// Probe for one generated RestSharp-flavour package (loaded from its build output).
//   Probe routes <package.dll>                         -> verb and route of every operation
//   Probe call <package.dll> <baseUrl> <ApiClass> <Operation> <json-args>
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;

static class Program
{
    static string Json(string s) => s == null ? "null" : "\"" + s.Replace("\\", "\\\\").Replace("\"", "\\\"") + "\"";

    static int Main(string[] args)
    {
        var dll = Path.GetFullPath(args[1]);
        var dir = Path.GetDirectoryName(dll)!;
        AppDomain.CurrentDomain.AssemblyResolve += (_, e) =>
        {
            var candidate = Path.Combine(dir, new AssemblyName(e.Name).Name + ".dll");
            return File.Exists(candidate) ? Assembly.LoadFrom(candidate) : null;
        };
        var asm = Assembly.LoadFrom(dll);
        var ns = Path.GetFileNameWithoutExtension(dll);
        return args[0] switch
        {
            "routes" => Routes(asm, ns),
            "call" => Call(asm, ns, args[2], args[3], args[4], args[5]),
            _ => 2,
        };
    }

    static object Configuration(Assembly asm, string ns, string basePath)
    {
        var type = asm.GetType(ns + ".Client.Configuration", true)!;
        var config = Activator.CreateInstance(type)!;
        type.GetProperty("BasePath")!.SetValue(config, basePath);
        ((IDictionary)type.GetProperty("ApiKey")!.GetValue(config)!)["Authorization"] = "test-token";
        ((IDictionary)type.GetProperty("ApiKeyPrefix")!.GetValue(config)!)["Authorization"] = "Token";
        return config;
    }

    static IEnumerable<Type> ApiTypes(Assembly asm, string ns) =>
        asm.GetTypes().Where(t => t.IsClass && t.IsPublic && t.Namespace == ns + ".Api" && t.Name.EndsWith("Api"));

    static object Placeholder(Type type, int index)
    {
        if (type == typeof(string)) return $"__P{index}__";
        if (type == typeof(Guid)) return Guid.Parse($"00000000-0000-0000-0000-{index:D12}");
        if (type == typeof(int)) return 900000 + index;
        if (type == typeof(long)) return 900000L + index;
        if (type == typeof(bool)) return false;
        if (Nullable.GetUnderlyingType(type) != null) return null;
        if (type.IsEnum) return Enum.GetValues(type).GetValue(0);
        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>)) return Activator.CreateInstance(type);
        if (type == typeof(Stream)) return new MemoryStream(new byte[] { 1 });
        if (type.IsClass && !type.IsAbstract && type != typeof(object))
        {
            try { return Activator.CreateInstance(type, nonPublic: true); }
            catch
            {
                try { return System.Runtime.CompilerServices.RuntimeHelpers.GetUninitializedObject(type); }
                catch { return null; }
            }
        }
        return null;
    }

    static int Routes(Assembly asm, string ns)
    {
        var port = FreePort();
        using var listener = new HttpListener();
        listener.Prefixes.Add($"http://127.0.0.1:{port}/");
        listener.Start();
        string last = null;
        var serve = Task.Run(() =>
        {
            while (listener.IsListening)
            {
                HttpListenerContext ctx;
                try { ctx = listener.GetContext(); } catch { break; }
                last = ctx.Request.HttpMethod + " " + ctx.Request.RawUrl!.Split('?')[0];
                var body = Encoding.UTF8.GetBytes("{}");
                ctx.Response.ContentType = "application/json";
                ctx.Response.OutputStream.Write(body);
                ctx.Response.Close();
            }
        });

        var defaultBase = (string)asm.GetType(ns + ".Client.Configuration", true)!.GetProperty("BasePath")!.GetValue(Activator.CreateInstance(asm.GetType(ns + ".Client.Configuration")!));
        var config = Configuration(asm, ns, $"http://127.0.0.1:{port}");
        var sb = new StringBuilder("{\"basePath\":" + Json(defaultBase) + ",\"routes\":[");
        var first = true;
        foreach (var api in ApiTypes(asm, ns))
        {
            var instance = Activator.CreateInstance(api, config);
            foreach (var m in api.GetMethods().Where(m => m.Name.EndsWith("WithHttpInfo") && m.DeclaringType == api))
            {
                var ps = m.GetParameters();
                var values = ps.Select((p, i) => p.HasDefaultValue ? p.DefaultValue : Placeholder(p.ParameterType, i)).ToArray();
                last = null;
                string error = null;
                try { m.Invoke(instance, values); }
                catch (TargetInvocationException e) { error = e.InnerException?.GetType().Name; }
                var op = m.Name.Substring(0, m.Name.Length - "WithHttpInfo".Length);
                var parts = last?.Split(' ', 2);
                sb.Append(first ? "" : ",").Append("{\"className\":").Append(Json(api.Name)).Append(",\"name\":").Append(Json(op))
                  .Append(",\"method\":").Append(Json(parts?[0])).Append(",\"path\":").Append(Json(parts?[1]))
                  .Append(",\"error\":").Append(Json(last == null ? error : null)).Append('}');
                first = false;
            }
        }
        listener.Stop();
        Console.Write(sb.Append("]}"));
        return 0;
    }

    static int Call(Assembly asm, string ns, string baseUrl, string apiName, string op, string argsJson)
    {
        var jsonConvert = Type.GetType("Newtonsoft.Json.JsonConvert, Newtonsoft.Json", true)!;
        var deserialize = jsonConvert.GetMethod("DeserializeObject", new[] { typeof(string), typeof(Type) })!;
        var serialize = jsonConvert.GetMethod("SerializeObject", new[] { typeof(object) })!;
        var api = asm.GetType($"{ns}.Api.{apiName}", true)!;
        var instance = Activator.CreateInstance(api, Configuration(asm, ns, baseUrl));
        var raw = (IList)deserialize.Invoke(null, new object[] { argsJson, typeof(List<object>) })!;
        var method = api.GetMethods().First(m => m.Name == op && m.GetParameters().Count(p => !p.HasDefaultValue) <= raw.Count && m.GetParameters().Length >= raw.Count);
        var ps = method.GetParameters();
        var values = ps.Select((p, i) => i < raw.Count
            ? (raw[i] == null ? null : deserialize.Invoke(null, new object[] { (string)serialize.Invoke(null, new[] { raw[i] })!, p.ParameterType }))
            : p.DefaultValue).ToArray();
        try
        {
            var data = method.Invoke(instance, values);
            Console.Write("{\"error\":null,\"dataType\":" + Json(data?.GetType().Name) + ",\"data\":" + (string)serialize.Invoke(null, new[] { data })! + "}");
        }
        catch (TargetInvocationException e) when (e.InnerException?.GetType().Name == "ApiException")
        {
            var code = e.InnerException.GetType().GetProperty("ErrorCode")!.GetValue(e.InnerException);
            Console.Write("{\"error\":{\"status\":" + code + "},\"dataType\":null,\"data\":null}");
        }
        return 0;
    }

    static int FreePort()
    {
        var l = new TcpListener(IPAddress.Loopback, 0);
        l.Start();
        var port = ((IPEndPoint)l.LocalEndpoint).Port;
        l.Stop();
        return port;
    }
}
