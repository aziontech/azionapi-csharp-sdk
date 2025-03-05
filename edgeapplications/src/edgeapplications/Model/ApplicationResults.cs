// <auto-generated>
/*
 * Edge Application API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using edgeapplications.Client;

namespace edgeapplications.Model
{
    /// <summary>
    /// ApplicationResults
    /// </summary>
    public partial class ApplicationResults : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationResults" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="name">name</param>
        /// <param name="active">active</param>
        /// <param name="debugRules">debugRules</param>
        /// <param name="http3">http3</param>
        /// <param name="supportedCiphers">supportedCiphers</param>
        /// <param name="deliveryProtocol">deliveryProtocol</param>
        /// <param name="minimumTlsVersion">minimumTlsVersion</param>
        /// <param name="applicationAcceleration">applicationAcceleration</param>
        /// <param name="caching">caching</param>
        /// <param name="deviceDetection">deviceDetection</param>
        /// <param name="edgeFirewall">edgeFirewall</param>
        /// <param name="edgeFunctions">edgeFunctions</param>
        /// <param name="imageOptimization">imageOptimization</param>
        /// <param name="l2Caching">l2Caching</param>
        /// <param name="loadBalancer">loadBalancer</param>
        /// <param name="rawLogs">rawLogs</param>
        /// <param name="webApplicationFirewall">webApplicationFirewall</param>
        /// <param name="httpPort">httpPort</param>
        /// <param name="httpsPort">httpsPort</param>
        /// <param name="websocket">websocket</param>
        [JsonConstructor]
        public ApplicationResults(long id, string name, bool active, bool debugRules, bool http3, string supportedCiphers, string deliveryProtocol, string minimumTlsVersion, bool applicationAcceleration, bool caching, bool deviceDetection, bool edgeFirewall, bool edgeFunctions, bool imageOptimization, bool l2Caching, bool loadBalancer, bool rawLogs, bool webApplicationFirewall, Object? httpPort = default, Object? httpsPort = default, Option<bool?> websocket = default)
        {
            Id = id;
            Name = name;
            Active = active;
            DebugRules = debugRules;
            Http3 = http3;
            SupportedCiphers = supportedCiphers;
            DeliveryProtocol = deliveryProtocol;
            MinimumTlsVersion = minimumTlsVersion;
            ApplicationAcceleration = applicationAcceleration;
            Caching = caching;
            DeviceDetection = deviceDetection;
            EdgeFirewall = edgeFirewall;
            EdgeFunctions = edgeFunctions;
            ImageOptimization = imageOptimization;
            L2Caching = l2Caching;
            LoadBalancer = loadBalancer;
            RawLogs = rawLogs;
            WebApplicationFirewall = webApplicationFirewall;
            HttpPort = httpPort;
            HttpsPort = httpsPort;
            WebsocketOption = websocket;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets DebugRules
        /// </summary>
        [JsonPropertyName("debug_rules")]
        public bool DebugRules { get; set; }

        /// <summary>
        /// Gets or Sets Http3
        /// </summary>
        [JsonPropertyName("http3")]
        public bool Http3 { get; set; }

        /// <summary>
        /// Gets or Sets SupportedCiphers
        /// </summary>
        [JsonPropertyName("supported_ciphers")]
        public string SupportedCiphers { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryProtocol
        /// </summary>
        [JsonPropertyName("delivery_protocol")]
        public string DeliveryProtocol { get; set; }

        /// <summary>
        /// Gets or Sets MinimumTlsVersion
        /// </summary>
        [JsonPropertyName("minimum_tls_version")]
        public string MinimumTlsVersion { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationAcceleration
        /// </summary>
        [JsonPropertyName("application_acceleration")]
        public bool ApplicationAcceleration { get; set; }

        /// <summary>
        /// Gets or Sets Caching
        /// </summary>
        [JsonPropertyName("caching")]
        public bool Caching { get; set; }

        /// <summary>
        /// Gets or Sets DeviceDetection
        /// </summary>
        [JsonPropertyName("device_detection")]
        public bool DeviceDetection { get; set; }

        /// <summary>
        /// Gets or Sets EdgeFirewall
        /// </summary>
        [JsonPropertyName("edge_firewall")]
        public bool EdgeFirewall { get; set; }

        /// <summary>
        /// Gets or Sets EdgeFunctions
        /// </summary>
        [JsonPropertyName("edge_functions")]
        public bool EdgeFunctions { get; set; }

        /// <summary>
        /// Gets or Sets ImageOptimization
        /// </summary>
        [JsonPropertyName("image_optimization")]
        public bool ImageOptimization { get; set; }

        /// <summary>
        /// Gets or Sets L2Caching
        /// </summary>
        [JsonPropertyName("l2_caching")]
        public bool L2Caching { get; set; }

        /// <summary>
        /// Gets or Sets LoadBalancer
        /// </summary>
        [JsonPropertyName("load_balancer")]
        public bool LoadBalancer { get; set; }

        /// <summary>
        /// Gets or Sets RawLogs
        /// </summary>
        [JsonPropertyName("raw_logs")]
        public bool RawLogs { get; set; }

        /// <summary>
        /// Gets or Sets WebApplicationFirewall
        /// </summary>
        [JsonPropertyName("web_application_firewall")]
        public bool WebApplicationFirewall { get; set; }

        /// <summary>
        /// Gets or Sets HttpPort
        /// </summary>
        [JsonPropertyName("http_port")]
        public Object? HttpPort { get; set; }

        /// <summary>
        /// Gets or Sets HttpsPort
        /// </summary>
        [JsonPropertyName("https_port")]
        public Object? HttpsPort { get; set; }

        /// <summary>
        /// Used to track the state of Websocket
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> WebsocketOption { get; private set; }

        /// <summary>
        /// Gets or Sets Websocket
        /// </summary>
        [JsonPropertyName("websocket")]
        public bool? Websocket { get { return this.WebsocketOption; } set { this.WebsocketOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationResults {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  DebugRules: ").Append(DebugRules).Append("\n");
            sb.Append("  Http3: ").Append(Http3).Append("\n");
            sb.Append("  SupportedCiphers: ").Append(SupportedCiphers).Append("\n");
            sb.Append("  DeliveryProtocol: ").Append(DeliveryProtocol).Append("\n");
            sb.Append("  MinimumTlsVersion: ").Append(MinimumTlsVersion).Append("\n");
            sb.Append("  ApplicationAcceleration: ").Append(ApplicationAcceleration).Append("\n");
            sb.Append("  Caching: ").Append(Caching).Append("\n");
            sb.Append("  DeviceDetection: ").Append(DeviceDetection).Append("\n");
            sb.Append("  EdgeFirewall: ").Append(EdgeFirewall).Append("\n");
            sb.Append("  EdgeFunctions: ").Append(EdgeFunctions).Append("\n");
            sb.Append("  ImageOptimization: ").Append(ImageOptimization).Append("\n");
            sb.Append("  L2Caching: ").Append(L2Caching).Append("\n");
            sb.Append("  LoadBalancer: ").Append(LoadBalancer).Append("\n");
            sb.Append("  RawLogs: ").Append(RawLogs).Append("\n");
            sb.Append("  WebApplicationFirewall: ").Append(WebApplicationFirewall).Append("\n");
            sb.Append("  HttpPort: ").Append(HttpPort).Append("\n");
            sb.Append("  HttpsPort: ").Append(HttpsPort).Append("\n");
            sb.Append("  Websocket: ").Append(Websocket).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ApplicationResults" />
    /// </summary>
    public class ApplicationResultsJsonConverter : JsonConverter<ApplicationResults>
    {
        /// <summary>
        /// Deserializes json to <see cref="ApplicationResults" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ApplicationResults Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> id = default;
            Option<string?> name = default;
            Option<bool?> active = default;
            Option<bool?> debugRules = default;
            Option<bool?> http3 = default;
            Option<string?> supportedCiphers = default;
            Option<string?> deliveryProtocol = default;
            Option<string?> minimumTlsVersion = default;
            Option<bool?> applicationAcceleration = default;
            Option<bool?> caching = default;
            Option<bool?> deviceDetection = default;
            Option<bool?> edgeFirewall = default;
            Option<bool?> edgeFunctions = default;
            Option<bool?> imageOptimization = default;
            Option<bool?> l2Caching = default;
            Option<bool?> loadBalancer = default;
            Option<bool?> rawLogs = default;
            Option<bool?> webApplicationFirewall = default;
            Option<Object?> httpPort = default;
            Option<Object?> httpsPort = default;
            Option<bool?> websocket = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "active":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                active = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "debug_rules":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                debugRules = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "http3":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                http3 = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "supported_ciphers":
                            supportedCiphers = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "delivery_protocol":
                            deliveryProtocol = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "minimum_tls_version":
                            minimumTlsVersion = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "application_acceleration":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                applicationAcceleration = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "caching":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                caching = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "device_detection":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                deviceDetection = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "edge_firewall":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                edgeFirewall = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "edge_functions":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                edgeFunctions = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "image_optimization":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                imageOptimization = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "l2_caching":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                l2Caching = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "load_balancer":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                loadBalancer = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "raw_logs":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                rawLogs = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "web_application_firewall":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                webApplicationFirewall = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "http_port":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                httpPort = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "https_port":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                httpsPort = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "websocket":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                websocket = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class ApplicationResults.", nameof(id));

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class ApplicationResults.", nameof(name));

            if (!active.IsSet)
                throw new ArgumentException("Property is required for class ApplicationResults.", nameof(active));

            if (!debugRules.IsSet)
                throw new ArgumentException("Property is required for class ApplicationResults.", nameof(debugRules));

            if (!http3.IsSet)
                throw new ArgumentException("Property is required for class ApplicationResults.", nameof(http3));

            if (!supportedCiphers.IsSet)
                throw new ArgumentException("Property is required for class ApplicationResults.", nameof(supportedCiphers));

            if (!deliveryProtocol.IsSet)
                throw new ArgumentException("Property is required for class ApplicationResults.", nameof(deliveryProtocol));

            if (!minimumTlsVersion.IsSet)
                throw new ArgumentException("Property is required for class ApplicationResults.", nameof(minimumTlsVersion));

            if (!applicationAcceleration.IsSet)
                throw new ArgumentException("Property is required for class ApplicationResults.", nameof(applicationAcceleration));

            if (!caching.IsSet)
                throw new ArgumentException("Property is required for class ApplicationResults.", nameof(caching));

            if (!deviceDetection.IsSet)
                throw new ArgumentException("Property is required for class ApplicationResults.", nameof(deviceDetection));

            if (!edgeFirewall.IsSet)
                throw new ArgumentException("Property is required for class ApplicationResults.", nameof(edgeFirewall));

            if (!edgeFunctions.IsSet)
                throw new ArgumentException("Property is required for class ApplicationResults.", nameof(edgeFunctions));

            if (!imageOptimization.IsSet)
                throw new ArgumentException("Property is required for class ApplicationResults.", nameof(imageOptimization));

            if (!l2Caching.IsSet)
                throw new ArgumentException("Property is required for class ApplicationResults.", nameof(l2Caching));

            if (!loadBalancer.IsSet)
                throw new ArgumentException("Property is required for class ApplicationResults.", nameof(loadBalancer));

            if (!rawLogs.IsSet)
                throw new ArgumentException("Property is required for class ApplicationResults.", nameof(rawLogs));

            if (!webApplicationFirewall.IsSet)
                throw new ArgumentException("Property is required for class ApplicationResults.", nameof(webApplicationFirewall));

            if (!httpPort.IsSet)
                throw new ArgumentException("Property is required for class ApplicationResults.", nameof(httpPort));

            if (!httpsPort.IsSet)
                throw new ArgumentException("Property is required for class ApplicationResults.", nameof(httpsPort));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class ApplicationResults.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class ApplicationResults.");

            if (active.IsSet && active.Value == null)
                throw new ArgumentNullException(nameof(active), "Property is not nullable for class ApplicationResults.");

            if (debugRules.IsSet && debugRules.Value == null)
                throw new ArgumentNullException(nameof(debugRules), "Property is not nullable for class ApplicationResults.");

            if (http3.IsSet && http3.Value == null)
                throw new ArgumentNullException(nameof(http3), "Property is not nullable for class ApplicationResults.");

            if (supportedCiphers.IsSet && supportedCiphers.Value == null)
                throw new ArgumentNullException(nameof(supportedCiphers), "Property is not nullable for class ApplicationResults.");

            if (deliveryProtocol.IsSet && deliveryProtocol.Value == null)
                throw new ArgumentNullException(nameof(deliveryProtocol), "Property is not nullable for class ApplicationResults.");

            if (minimumTlsVersion.IsSet && minimumTlsVersion.Value == null)
                throw new ArgumentNullException(nameof(minimumTlsVersion), "Property is not nullable for class ApplicationResults.");

            if (applicationAcceleration.IsSet && applicationAcceleration.Value == null)
                throw new ArgumentNullException(nameof(applicationAcceleration), "Property is not nullable for class ApplicationResults.");

            if (caching.IsSet && caching.Value == null)
                throw new ArgumentNullException(nameof(caching), "Property is not nullable for class ApplicationResults.");

            if (deviceDetection.IsSet && deviceDetection.Value == null)
                throw new ArgumentNullException(nameof(deviceDetection), "Property is not nullable for class ApplicationResults.");

            if (edgeFirewall.IsSet && edgeFirewall.Value == null)
                throw new ArgumentNullException(nameof(edgeFirewall), "Property is not nullable for class ApplicationResults.");

            if (edgeFunctions.IsSet && edgeFunctions.Value == null)
                throw new ArgumentNullException(nameof(edgeFunctions), "Property is not nullable for class ApplicationResults.");

            if (imageOptimization.IsSet && imageOptimization.Value == null)
                throw new ArgumentNullException(nameof(imageOptimization), "Property is not nullable for class ApplicationResults.");

            if (l2Caching.IsSet && l2Caching.Value == null)
                throw new ArgumentNullException(nameof(l2Caching), "Property is not nullable for class ApplicationResults.");

            if (loadBalancer.IsSet && loadBalancer.Value == null)
                throw new ArgumentNullException(nameof(loadBalancer), "Property is not nullable for class ApplicationResults.");

            if (rawLogs.IsSet && rawLogs.Value == null)
                throw new ArgumentNullException(nameof(rawLogs), "Property is not nullable for class ApplicationResults.");

            if (webApplicationFirewall.IsSet && webApplicationFirewall.Value == null)
                throw new ArgumentNullException(nameof(webApplicationFirewall), "Property is not nullable for class ApplicationResults.");

            if (websocket.IsSet && websocket.Value == null)
                throw new ArgumentNullException(nameof(websocket), "Property is not nullable for class ApplicationResults.");

            return new ApplicationResults(id.Value!.Value!, name.Value!, active.Value!.Value!, debugRules.Value!.Value!, http3.Value!.Value!, supportedCiphers.Value!, deliveryProtocol.Value!, minimumTlsVersion.Value!, applicationAcceleration.Value!.Value!, caching.Value!.Value!, deviceDetection.Value!.Value!, edgeFirewall.Value!.Value!, edgeFunctions.Value!.Value!, imageOptimization.Value!.Value!, l2Caching.Value!.Value!, loadBalancer.Value!.Value!, rawLogs.Value!.Value!, webApplicationFirewall.Value!.Value!, httpPort.Value!, httpsPort.Value!, websocket);
        }

        /// <summary>
        /// Serializes a <see cref="ApplicationResults" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="applicationResults"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ApplicationResults applicationResults, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, applicationResults, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ApplicationResults" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="applicationResults"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ApplicationResults applicationResults, JsonSerializerOptions jsonSerializerOptions)
        {
            if (applicationResults.Name == null)
                throw new ArgumentNullException(nameof(applicationResults.Name), "Property is required for class ApplicationResults.");

            if (applicationResults.SupportedCiphers == null)
                throw new ArgumentNullException(nameof(applicationResults.SupportedCiphers), "Property is required for class ApplicationResults.");

            if (applicationResults.DeliveryProtocol == null)
                throw new ArgumentNullException(nameof(applicationResults.DeliveryProtocol), "Property is required for class ApplicationResults.");

            if (applicationResults.MinimumTlsVersion == null)
                throw new ArgumentNullException(nameof(applicationResults.MinimumTlsVersion), "Property is required for class ApplicationResults.");

            writer.WriteNumber("id", applicationResults.Id);

            writer.WriteString("name", applicationResults.Name);

            writer.WriteBoolean("active", applicationResults.Active);

            writer.WriteBoolean("debug_rules", applicationResults.DebugRules);

            writer.WriteBoolean("http3", applicationResults.Http3);

            writer.WriteString("supported_ciphers", applicationResults.SupportedCiphers);

            writer.WriteString("delivery_protocol", applicationResults.DeliveryProtocol);

            writer.WriteString("minimum_tls_version", applicationResults.MinimumTlsVersion);

            writer.WriteBoolean("application_acceleration", applicationResults.ApplicationAcceleration);

            writer.WriteBoolean("caching", applicationResults.Caching);

            writer.WriteBoolean("device_detection", applicationResults.DeviceDetection);

            writer.WriteBoolean("edge_firewall", applicationResults.EdgeFirewall);

            writer.WriteBoolean("edge_functions", applicationResults.EdgeFunctions);

            writer.WriteBoolean("image_optimization", applicationResults.ImageOptimization);

            writer.WriteBoolean("l2_caching", applicationResults.L2Caching);

            writer.WriteBoolean("load_balancer", applicationResults.LoadBalancer);

            writer.WriteBoolean("raw_logs", applicationResults.RawLogs);

            writer.WriteBoolean("web_application_firewall", applicationResults.WebApplicationFirewall);

            if (applicationResults.HttpPort != null)
            {
                writer.WritePropertyName("http_port");
                JsonSerializer.Serialize(writer, applicationResults.HttpPort, jsonSerializerOptions);
            }
            else
                writer.WriteNull("http_port");
            if (applicationResults.HttpsPort != null)
            {
                writer.WritePropertyName("https_port");
                JsonSerializer.Serialize(writer, applicationResults.HttpsPort, jsonSerializerOptions);
            }
            else
                writer.WriteNull("https_port");
            if (applicationResults.WebsocketOption.IsSet)
                writer.WriteBoolean("websocket", applicationResults.WebsocketOption.Value!.Value);
        }
    }
}
