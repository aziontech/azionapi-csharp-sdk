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
    /// ApplicationPutRequest
    /// </summary>
    public partial class ApplicationPutRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationPutRequest" /> class.
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="deliveryProtocol">deliveryProtocol</param>
        /// <param name="httpPort">httpPort</param>
        /// <param name="httpsPort">httpsPort</param>
        /// <param name="minimumTlsVersion">minimumTlsVersion</param>
        /// <param name="active">active</param>
        /// <param name="applicationAcceleration">applicationAcceleration</param>
        /// <param name="deviceDetection">deviceDetection</param>
        /// <param name="edgeFirewall">edgeFirewall</param>
        /// <param name="edgeFunctions">edgeFunctions</param>
        /// <param name="imageOptimization">imageOptimization</param>
        /// <param name="l2Caching">l2Caching</param>
        /// <param name="loadBalancer">loadBalancer</param>
        /// <param name="rawLogs">rawLogs</param>
        /// <param name="webApplicationFirewall">webApplicationFirewall</param>
        /// <param name="debugRules">debugRules</param>
        /// <param name="http3">http3</param>
        /// <param name="websocket">websocket</param>
        /// <param name="supportedCiphers">supportedCiphers</param>
        [JsonConstructor]
        public ApplicationPutRequest(string name, Option<string?> deliveryProtocol = default, Option<Object?> httpPort = default, Option<Object?> httpsPort = default, Option<string?> minimumTlsVersion = default, Option<bool?> active = default, Option<bool?> applicationAcceleration = default, Option<bool?> deviceDetection = default, Option<bool?> edgeFirewall = default, Option<bool?> edgeFunctions = default, Option<bool?> imageOptimization = default, Option<bool?> l2Caching = default, Option<bool?> loadBalancer = default, Option<bool?> rawLogs = default, Option<bool?> webApplicationFirewall = default, Option<bool?> debugRules = default, Option<bool?> http3 = default, Option<bool?> websocket = default, Option<string?> supportedCiphers = default)
        {
            Name = name;
            DeliveryProtocolOption = deliveryProtocol;
            HttpPortOption = httpPort;
            HttpsPortOption = httpsPort;
            MinimumTlsVersionOption = minimumTlsVersion;
            ActiveOption = active;
            ApplicationAccelerationOption = applicationAcceleration;
            DeviceDetectionOption = deviceDetection;
            EdgeFirewallOption = edgeFirewall;
            EdgeFunctionsOption = edgeFunctions;
            ImageOptimizationOption = imageOptimization;
            L2CachingOption = l2Caching;
            LoadBalancerOption = loadBalancer;
            RawLogsOption = rawLogs;
            WebApplicationFirewallOption = webApplicationFirewall;
            DebugRulesOption = debugRules;
            Http3Option = http3;
            WebsocketOption = websocket;
            SupportedCiphersOption = supportedCiphers;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Used to track the state of DeliveryProtocol
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DeliveryProtocolOption { get; private set; }

        /// <summary>
        /// Gets or Sets DeliveryProtocol
        /// </summary>
        [JsonPropertyName("delivery_protocol")]
        public string? DeliveryProtocol { get { return this.DeliveryProtocolOption; } set { this.DeliveryProtocolOption = new(value); } }

        /// <summary>
        /// Used to track the state of HttpPort
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> HttpPortOption { get; private set; }

        /// <summary>
        /// Gets or Sets HttpPort
        /// </summary>
        [JsonPropertyName("http_port")]
        public Object? HttpPort { get { return this.HttpPortOption; } set { this.HttpPortOption = new(value); } }

        /// <summary>
        /// Used to track the state of HttpsPort
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> HttpsPortOption { get; private set; }

        /// <summary>
        /// Gets or Sets HttpsPort
        /// </summary>
        [JsonPropertyName("https_port")]
        public Object? HttpsPort { get { return this.HttpsPortOption; } set { this.HttpsPortOption = new(value); } }

        /// <summary>
        /// Used to track the state of MinimumTlsVersion
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> MinimumTlsVersionOption { get; private set; }

        /// <summary>
        /// Gets or Sets MinimumTlsVersion
        /// </summary>
        [JsonPropertyName("minimum_tls_version")]
        public string? MinimumTlsVersion { get { return this.MinimumTlsVersionOption; } set { this.MinimumTlsVersionOption = new(value); } }

        /// <summary>
        /// Used to track the state of Active
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> ActiveOption { get; private set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [JsonPropertyName("active")]
        public bool? Active { get { return this.ActiveOption; } set { this.ActiveOption = new(value); } }

        /// <summary>
        /// Used to track the state of ApplicationAcceleration
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> ApplicationAccelerationOption { get; private set; }

        /// <summary>
        /// Gets or Sets ApplicationAcceleration
        /// </summary>
        [JsonPropertyName("application_acceleration")]
        public bool? ApplicationAcceleration { get { return this.ApplicationAccelerationOption; } set { this.ApplicationAccelerationOption = new(value); } }

        /// <summary>
        /// Used to track the state of DeviceDetection
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> DeviceDetectionOption { get; private set; }

        /// <summary>
        /// Gets or Sets DeviceDetection
        /// </summary>
        [JsonPropertyName("device_detection")]
        public bool? DeviceDetection { get { return this.DeviceDetectionOption; } set { this.DeviceDetectionOption = new(value); } }

        /// <summary>
        /// Used to track the state of EdgeFirewall
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> EdgeFirewallOption { get; private set; }

        /// <summary>
        /// Gets or Sets EdgeFirewall
        /// </summary>
        [JsonPropertyName("edge_firewall")]
        public bool? EdgeFirewall { get { return this.EdgeFirewallOption; } set { this.EdgeFirewallOption = new(value); } }

        /// <summary>
        /// Used to track the state of EdgeFunctions
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> EdgeFunctionsOption { get; private set; }

        /// <summary>
        /// Gets or Sets EdgeFunctions
        /// </summary>
        [JsonPropertyName("edge_functions")]
        public bool? EdgeFunctions { get { return this.EdgeFunctionsOption; } set { this.EdgeFunctionsOption = new(value); } }

        /// <summary>
        /// Used to track the state of ImageOptimization
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> ImageOptimizationOption { get; private set; }

        /// <summary>
        /// Gets or Sets ImageOptimization
        /// </summary>
        [JsonPropertyName("image_optimization")]
        public bool? ImageOptimization { get { return this.ImageOptimizationOption; } set { this.ImageOptimizationOption = new(value); } }

        /// <summary>
        /// Used to track the state of L2Caching
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> L2CachingOption { get; private set; }

        /// <summary>
        /// Gets or Sets L2Caching
        /// </summary>
        [JsonPropertyName("l2_caching")]
        public bool? L2Caching { get { return this.L2CachingOption; } set { this.L2CachingOption = new(value); } }

        /// <summary>
        /// Used to track the state of LoadBalancer
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> LoadBalancerOption { get; private set; }

        /// <summary>
        /// Gets or Sets LoadBalancer
        /// </summary>
        [JsonPropertyName("load_balancer")]
        public bool? LoadBalancer { get { return this.LoadBalancerOption; } set { this.LoadBalancerOption = new(value); } }

        /// <summary>
        /// Used to track the state of RawLogs
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> RawLogsOption { get; private set; }

        /// <summary>
        /// Gets or Sets RawLogs
        /// </summary>
        [JsonPropertyName("raw_logs")]
        public bool? RawLogs { get { return this.RawLogsOption; } set { this.RawLogsOption = new(value); } }

        /// <summary>
        /// Used to track the state of WebApplicationFirewall
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> WebApplicationFirewallOption { get; private set; }

        /// <summary>
        /// Gets or Sets WebApplicationFirewall
        /// </summary>
        [JsonPropertyName("web_application_firewall")]
        public bool? WebApplicationFirewall { get { return this.WebApplicationFirewallOption; } set { this.WebApplicationFirewallOption = new(value); } }

        /// <summary>
        /// Used to track the state of DebugRules
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> DebugRulesOption { get; private set; }

        /// <summary>
        /// Gets or Sets DebugRules
        /// </summary>
        [JsonPropertyName("debug_rules")]
        public bool? DebugRules { get { return this.DebugRulesOption; } set { this.DebugRulesOption = new(value); } }

        /// <summary>
        /// Used to track the state of Http3
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> Http3Option { get; private set; }

        /// <summary>
        /// Gets or Sets Http3
        /// </summary>
        [JsonPropertyName("http3")]
        public bool? Http3 { get { return this.Http3Option; } set { this.Http3Option = new(value); } }

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
        /// Used to track the state of SupportedCiphers
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> SupportedCiphersOption { get; private set; }

        /// <summary>
        /// Gets or Sets SupportedCiphers
        /// </summary>
        [JsonPropertyName("supported_ciphers")]
        public string? SupportedCiphers { get { return this.SupportedCiphersOption; } set { this.SupportedCiphersOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationPutRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DeliveryProtocol: ").Append(DeliveryProtocol).Append("\n");
            sb.Append("  HttpPort: ").Append(HttpPort).Append("\n");
            sb.Append("  HttpsPort: ").Append(HttpsPort).Append("\n");
            sb.Append("  MinimumTlsVersion: ").Append(MinimumTlsVersion).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  ApplicationAcceleration: ").Append(ApplicationAcceleration).Append("\n");
            sb.Append("  DeviceDetection: ").Append(DeviceDetection).Append("\n");
            sb.Append("  EdgeFirewall: ").Append(EdgeFirewall).Append("\n");
            sb.Append("  EdgeFunctions: ").Append(EdgeFunctions).Append("\n");
            sb.Append("  ImageOptimization: ").Append(ImageOptimization).Append("\n");
            sb.Append("  L2Caching: ").Append(L2Caching).Append("\n");
            sb.Append("  LoadBalancer: ").Append(LoadBalancer).Append("\n");
            sb.Append("  RawLogs: ").Append(RawLogs).Append("\n");
            sb.Append("  WebApplicationFirewall: ").Append(WebApplicationFirewall).Append("\n");
            sb.Append("  DebugRules: ").Append(DebugRules).Append("\n");
            sb.Append("  Http3: ").Append(Http3).Append("\n");
            sb.Append("  Websocket: ").Append(Websocket).Append("\n");
            sb.Append("  SupportedCiphers: ").Append(SupportedCiphers).Append("\n");
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
    /// A Json converter for type <see cref="ApplicationPutRequest" />
    /// </summary>
    public class ApplicationPutRequestJsonConverter : JsonConverter<ApplicationPutRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="ApplicationPutRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ApplicationPutRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> name = default;
            Option<string?> deliveryProtocol = default;
            Option<Object?> httpPort = default;
            Option<Object?> httpsPort = default;
            Option<string?> minimumTlsVersion = default;
            Option<bool?> active = default;
            Option<bool?> applicationAcceleration = default;
            Option<bool?> deviceDetection = default;
            Option<bool?> edgeFirewall = default;
            Option<bool?> edgeFunctions = default;
            Option<bool?> imageOptimization = default;
            Option<bool?> l2Caching = default;
            Option<bool?> loadBalancer = default;
            Option<bool?> rawLogs = default;
            Option<bool?> webApplicationFirewall = default;
            Option<bool?> debugRules = default;
            Option<bool?> http3 = default;
            Option<bool?> websocket = default;
            Option<string?> supportedCiphers = default;

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
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "delivery_protocol":
                            deliveryProtocol = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "http_port":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                httpPort = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "https_port":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                httpsPort = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "minimum_tls_version":
                            minimumTlsVersion = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "active":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                active = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "application_acceleration":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                applicationAcceleration = new Option<bool?>(utf8JsonReader.GetBoolean());
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
                        case "debug_rules":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                debugRules = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "http3":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                http3 = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "websocket":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                websocket = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "supported_ciphers":
                            supportedCiphers = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class ApplicationPutRequest.", nameof(name));

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class ApplicationPutRequest.");

            if (deliveryProtocol.IsSet && deliveryProtocol.Value == null)
                throw new ArgumentNullException(nameof(deliveryProtocol), "Property is not nullable for class ApplicationPutRequest.");

            if (minimumTlsVersion.IsSet && minimumTlsVersion.Value == null)
                throw new ArgumentNullException(nameof(minimumTlsVersion), "Property is not nullable for class ApplicationPutRequest.");

            if (active.IsSet && active.Value == null)
                throw new ArgumentNullException(nameof(active), "Property is not nullable for class ApplicationPutRequest.");

            if (applicationAcceleration.IsSet && applicationAcceleration.Value == null)
                throw new ArgumentNullException(nameof(applicationAcceleration), "Property is not nullable for class ApplicationPutRequest.");

            if (deviceDetection.IsSet && deviceDetection.Value == null)
                throw new ArgumentNullException(nameof(deviceDetection), "Property is not nullable for class ApplicationPutRequest.");

            if (edgeFirewall.IsSet && edgeFirewall.Value == null)
                throw new ArgumentNullException(nameof(edgeFirewall), "Property is not nullable for class ApplicationPutRequest.");

            if (edgeFunctions.IsSet && edgeFunctions.Value == null)
                throw new ArgumentNullException(nameof(edgeFunctions), "Property is not nullable for class ApplicationPutRequest.");

            if (imageOptimization.IsSet && imageOptimization.Value == null)
                throw new ArgumentNullException(nameof(imageOptimization), "Property is not nullable for class ApplicationPutRequest.");

            if (l2Caching.IsSet && l2Caching.Value == null)
                throw new ArgumentNullException(nameof(l2Caching), "Property is not nullable for class ApplicationPutRequest.");

            if (loadBalancer.IsSet && loadBalancer.Value == null)
                throw new ArgumentNullException(nameof(loadBalancer), "Property is not nullable for class ApplicationPutRequest.");

            if (rawLogs.IsSet && rawLogs.Value == null)
                throw new ArgumentNullException(nameof(rawLogs), "Property is not nullable for class ApplicationPutRequest.");

            if (webApplicationFirewall.IsSet && webApplicationFirewall.Value == null)
                throw new ArgumentNullException(nameof(webApplicationFirewall), "Property is not nullable for class ApplicationPutRequest.");

            if (debugRules.IsSet && debugRules.Value == null)
                throw new ArgumentNullException(nameof(debugRules), "Property is not nullable for class ApplicationPutRequest.");

            if (http3.IsSet && http3.Value == null)
                throw new ArgumentNullException(nameof(http3), "Property is not nullable for class ApplicationPutRequest.");

            if (websocket.IsSet && websocket.Value == null)
                throw new ArgumentNullException(nameof(websocket), "Property is not nullable for class ApplicationPutRequest.");

            if (supportedCiphers.IsSet && supportedCiphers.Value == null)
                throw new ArgumentNullException(nameof(supportedCiphers), "Property is not nullable for class ApplicationPutRequest.");

            return new ApplicationPutRequest(name.Value!, deliveryProtocol, httpPort, httpsPort, minimumTlsVersion, active, applicationAcceleration, deviceDetection, edgeFirewall, edgeFunctions, imageOptimization, l2Caching, loadBalancer, rawLogs, webApplicationFirewall, debugRules, http3, websocket, supportedCiphers);
        }

        /// <summary>
        /// Serializes a <see cref="ApplicationPutRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="applicationPutRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ApplicationPutRequest applicationPutRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, applicationPutRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ApplicationPutRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="applicationPutRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ApplicationPutRequest applicationPutRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (applicationPutRequest.Name == null)
                throw new ArgumentNullException(nameof(applicationPutRequest.Name), "Property is required for class ApplicationPutRequest.");

            if (applicationPutRequest.DeliveryProtocolOption.IsSet && applicationPutRequest.DeliveryProtocol == null)
                throw new ArgumentNullException(nameof(applicationPutRequest.DeliveryProtocol), "Property is required for class ApplicationPutRequest.");

            if (applicationPutRequest.MinimumTlsVersionOption.IsSet && applicationPutRequest.MinimumTlsVersion == null)
                throw new ArgumentNullException(nameof(applicationPutRequest.MinimumTlsVersion), "Property is required for class ApplicationPutRequest.");

            if (applicationPutRequest.SupportedCiphersOption.IsSet && applicationPutRequest.SupportedCiphers == null)
                throw new ArgumentNullException(nameof(applicationPutRequest.SupportedCiphers), "Property is required for class ApplicationPutRequest.");

            writer.WriteString("name", applicationPutRequest.Name);

            if (applicationPutRequest.DeliveryProtocolOption.IsSet)
                writer.WriteString("delivery_protocol", applicationPutRequest.DeliveryProtocol);

            if (applicationPutRequest.HttpPortOption.IsSet)
                if (applicationPutRequest.HttpPortOption.Value != null)
                {
                    writer.WritePropertyName("http_port");
                    JsonSerializer.Serialize(writer, applicationPutRequest.HttpPort, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("http_port");
            if (applicationPutRequest.HttpsPortOption.IsSet)
                if (applicationPutRequest.HttpsPortOption.Value != null)
                {
                    writer.WritePropertyName("https_port");
                    JsonSerializer.Serialize(writer, applicationPutRequest.HttpsPort, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("https_port");
            if (applicationPutRequest.MinimumTlsVersionOption.IsSet)
                writer.WriteString("minimum_tls_version", applicationPutRequest.MinimumTlsVersion);

            if (applicationPutRequest.ActiveOption.IsSet)
                writer.WriteBoolean("active", applicationPutRequest.ActiveOption.Value!.Value);

            if (applicationPutRequest.ApplicationAccelerationOption.IsSet)
                writer.WriteBoolean("application_acceleration", applicationPutRequest.ApplicationAccelerationOption.Value!.Value);

            if (applicationPutRequest.DeviceDetectionOption.IsSet)
                writer.WriteBoolean("device_detection", applicationPutRequest.DeviceDetectionOption.Value!.Value);

            if (applicationPutRequest.EdgeFirewallOption.IsSet)
                writer.WriteBoolean("edge_firewall", applicationPutRequest.EdgeFirewallOption.Value!.Value);

            if (applicationPutRequest.EdgeFunctionsOption.IsSet)
                writer.WriteBoolean("edge_functions", applicationPutRequest.EdgeFunctionsOption.Value!.Value);

            if (applicationPutRequest.ImageOptimizationOption.IsSet)
                writer.WriteBoolean("image_optimization", applicationPutRequest.ImageOptimizationOption.Value!.Value);

            if (applicationPutRequest.L2CachingOption.IsSet)
                writer.WriteBoolean("l2_caching", applicationPutRequest.L2CachingOption.Value!.Value);

            if (applicationPutRequest.LoadBalancerOption.IsSet)
                writer.WriteBoolean("load_balancer", applicationPutRequest.LoadBalancerOption.Value!.Value);

            if (applicationPutRequest.RawLogsOption.IsSet)
                writer.WriteBoolean("raw_logs", applicationPutRequest.RawLogsOption.Value!.Value);

            if (applicationPutRequest.WebApplicationFirewallOption.IsSet)
                writer.WriteBoolean("web_application_firewall", applicationPutRequest.WebApplicationFirewallOption.Value!.Value);

            if (applicationPutRequest.DebugRulesOption.IsSet)
                writer.WriteBoolean("debug_rules", applicationPutRequest.DebugRulesOption.Value!.Value);

            if (applicationPutRequest.Http3Option.IsSet)
                writer.WriteBoolean("http3", applicationPutRequest.Http3Option.Value!.Value);

            if (applicationPutRequest.WebsocketOption.IsSet)
                writer.WriteBoolean("websocket", applicationPutRequest.WebsocketOption.Value!.Value);

            if (applicationPutRequest.SupportedCiphersOption.IsSet)
                writer.WriteString("supported_ciphers", applicationPutRequest.SupportedCiphers);
        }
    }
}
