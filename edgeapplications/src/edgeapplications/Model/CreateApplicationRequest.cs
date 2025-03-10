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
    /// CreateApplicationRequest
    /// </summary>
    public partial class CreateApplicationRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApplicationRequest" /> class.
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="applicationAcceleration">applicationAcceleration</param>
        /// <param name="deliveryProtocol">deliveryProtocol</param>
        /// <param name="originType">originType</param>
        /// <param name="address">address</param>
        /// <param name="minimumTlsVersion">minimumTlsVersion</param>
        /// <param name="originProtocolPolicy">originProtocolPolicy</param>
        /// <param name="hostHeader">hostHeader</param>
        /// <param name="browserCacheSettings">browserCacheSettings</param>
        /// <param name="cdnCacheSettings">cdnCacheSettings</param>
        /// <param name="browserCacheSettingsMaximumTtl">browserCacheSettingsMaximumTtl</param>
        /// <param name="cdnCacheSettingsMaximumTtl">cdnCacheSettingsMaximumTtl</param>
        /// <param name="debugRules">debugRules</param>
        /// <param name="supportedCiphers">supportedCiphers</param>
        /// <param name="httpPort">httpPort</param>
        /// <param name="httpsPort">httpsPort</param>
        /// <param name="l2Caching">l2Caching</param>
        /// <param name="http3">http3</param>
        /// <param name="websocket">websocket</param>
        [JsonConstructor]
        public CreateApplicationRequest(string name, Option<bool?> applicationAcceleration = default, Option<string?> deliveryProtocol = default, Option<string?> originType = default, Option<string?> address = default, Option<string?> minimumTlsVersion = default, Option<string?> originProtocolPolicy = default, Option<string?> hostHeader = default, Option<string?> browserCacheSettings = default, Option<string?> cdnCacheSettings = default, Option<long?> browserCacheSettingsMaximumTtl = default, Option<long?> cdnCacheSettingsMaximumTtl = default, Option<bool?> debugRules = default, Option<string?> supportedCiphers = default, Option<Object?> httpPort = default, Option<Object?> httpsPort = default, Option<bool?> l2Caching = default, Option<bool?> http3 = default, Option<bool?> websocket = default)
        {
            Name = name;
            ApplicationAccelerationOption = applicationAcceleration;
            DeliveryProtocolOption = deliveryProtocol;
            OriginTypeOption = originType;
            AddressOption = address;
            MinimumTlsVersionOption = minimumTlsVersion;
            OriginProtocolPolicyOption = originProtocolPolicy;
            HostHeaderOption = hostHeader;
            BrowserCacheSettingsOption = browserCacheSettings;
            CdnCacheSettingsOption = cdnCacheSettings;
            BrowserCacheSettingsMaximumTtlOption = browserCacheSettingsMaximumTtl;
            CdnCacheSettingsMaximumTtlOption = cdnCacheSettingsMaximumTtl;
            DebugRulesOption = debugRules;
            SupportedCiphersOption = supportedCiphers;
            HttpPortOption = httpPort;
            HttpsPortOption = httpsPort;
            L2CachingOption = l2Caching;
            Http3Option = http3;
            WebsocketOption = websocket;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

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
        /// Used to track the state of OriginType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> OriginTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets OriginType
        /// </summary>
        [JsonPropertyName("origin_type")]
        public string? OriginType { get { return this.OriginTypeOption; } set { this.OriginTypeOption = new(value); } }

        /// <summary>
        /// Used to track the state of Address
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> AddressOption { get; private set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [JsonPropertyName("address")]
        public string? Address { get { return this.AddressOption; } set { this.AddressOption = new(value); } }

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
        /// Used to track the state of OriginProtocolPolicy
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> OriginProtocolPolicyOption { get; private set; }

        /// <summary>
        /// Gets or Sets OriginProtocolPolicy
        /// </summary>
        [JsonPropertyName("origin_protocol_policy")]
        public string? OriginProtocolPolicy { get { return this.OriginProtocolPolicyOption; } set { this.OriginProtocolPolicyOption = new(value); } }

        /// <summary>
        /// Used to track the state of HostHeader
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> HostHeaderOption { get; private set; }

        /// <summary>
        /// Gets or Sets HostHeader
        /// </summary>
        [JsonPropertyName("host_header")]
        public string? HostHeader { get { return this.HostHeaderOption; } set { this.HostHeaderOption = new(value); } }

        /// <summary>
        /// Used to track the state of BrowserCacheSettings
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> BrowserCacheSettingsOption { get; private set; }

        /// <summary>
        /// Gets or Sets BrowserCacheSettings
        /// </summary>
        [JsonPropertyName("browser_cache_settings")]
        public string? BrowserCacheSettings { get { return this.BrowserCacheSettingsOption; } set { this.BrowserCacheSettingsOption = new(value); } }

        /// <summary>
        /// Used to track the state of CdnCacheSettings
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CdnCacheSettingsOption { get; private set; }

        /// <summary>
        /// Gets or Sets CdnCacheSettings
        /// </summary>
        [JsonPropertyName("cdn_cache_settings")]
        public string? CdnCacheSettings { get { return this.CdnCacheSettingsOption; } set { this.CdnCacheSettingsOption = new(value); } }

        /// <summary>
        /// Used to track the state of BrowserCacheSettingsMaximumTtl
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> BrowserCacheSettingsMaximumTtlOption { get; private set; }

        /// <summary>
        /// Gets or Sets BrowserCacheSettingsMaximumTtl
        /// </summary>
        [JsonPropertyName("browser_cache_settings_maximum_ttl")]
        public long? BrowserCacheSettingsMaximumTtl { get { return this.BrowserCacheSettingsMaximumTtlOption; } set { this.BrowserCacheSettingsMaximumTtlOption = new(value); } }

        /// <summary>
        /// Used to track the state of CdnCacheSettingsMaximumTtl
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> CdnCacheSettingsMaximumTtlOption { get; private set; }

        /// <summary>
        /// Gets or Sets CdnCacheSettingsMaximumTtl
        /// </summary>
        [JsonPropertyName("cdn_cache_settings_maximum_ttl")]
        public long? CdnCacheSettingsMaximumTtl { get { return this.CdnCacheSettingsMaximumTtlOption; } set { this.CdnCacheSettingsMaximumTtlOption = new(value); } }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateApplicationRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ApplicationAcceleration: ").Append(ApplicationAcceleration).Append("\n");
            sb.Append("  DeliveryProtocol: ").Append(DeliveryProtocol).Append("\n");
            sb.Append("  OriginType: ").Append(OriginType).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  MinimumTlsVersion: ").Append(MinimumTlsVersion).Append("\n");
            sb.Append("  OriginProtocolPolicy: ").Append(OriginProtocolPolicy).Append("\n");
            sb.Append("  HostHeader: ").Append(HostHeader).Append("\n");
            sb.Append("  BrowserCacheSettings: ").Append(BrowserCacheSettings).Append("\n");
            sb.Append("  CdnCacheSettings: ").Append(CdnCacheSettings).Append("\n");
            sb.Append("  BrowserCacheSettingsMaximumTtl: ").Append(BrowserCacheSettingsMaximumTtl).Append("\n");
            sb.Append("  CdnCacheSettingsMaximumTtl: ").Append(CdnCacheSettingsMaximumTtl).Append("\n");
            sb.Append("  DebugRules: ").Append(DebugRules).Append("\n");
            sb.Append("  SupportedCiphers: ").Append(SupportedCiphers).Append("\n");
            sb.Append("  HttpPort: ").Append(HttpPort).Append("\n");
            sb.Append("  HttpsPort: ").Append(HttpsPort).Append("\n");
            sb.Append("  L2Caching: ").Append(L2Caching).Append("\n");
            sb.Append("  Http3: ").Append(Http3).Append("\n");
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
    /// A Json converter for type <see cref="CreateApplicationRequest" />
    /// </summary>
    public class CreateApplicationRequestJsonConverter : JsonConverter<CreateApplicationRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="CreateApplicationRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CreateApplicationRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> name = default;
            Option<bool?> applicationAcceleration = default;
            Option<string?> deliveryProtocol = default;
            Option<string?> originType = default;
            Option<string?> address = default;
            Option<string?> minimumTlsVersion = default;
            Option<string?> originProtocolPolicy = default;
            Option<string?> hostHeader = default;
            Option<string?> browserCacheSettings = default;
            Option<string?> cdnCacheSettings = default;
            Option<long?> browserCacheSettingsMaximumTtl = default;
            Option<long?> cdnCacheSettingsMaximumTtl = default;
            Option<bool?> debugRules = default;
            Option<string?> supportedCiphers = default;
            Option<Object?> httpPort = default;
            Option<Object?> httpsPort = default;
            Option<bool?> l2Caching = default;
            Option<bool?> http3 = default;
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
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "application_acceleration":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                applicationAcceleration = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "delivery_protocol":
                            deliveryProtocol = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "origin_type":
                            originType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "address":
                            address = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "minimum_tls_version":
                            minimumTlsVersion = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "origin_protocol_policy":
                            originProtocolPolicy = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "host_header":
                            hostHeader = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "browser_cache_settings":
                            browserCacheSettings = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "cdn_cache_settings":
                            cdnCacheSettings = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "browser_cache_settings_maximum_ttl":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                browserCacheSettingsMaximumTtl = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "cdn_cache_settings_maximum_ttl":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                cdnCacheSettingsMaximumTtl = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "debug_rules":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                debugRules = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "supported_ciphers":
                            supportedCiphers = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "http_port":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                httpPort = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "https_port":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                httpsPort = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "l2_caching":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                l2Caching = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "http3":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                http3 = new Option<bool?>(utf8JsonReader.GetBoolean());
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

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class CreateApplicationRequest.", nameof(name));

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class CreateApplicationRequest.");

            if (applicationAcceleration.IsSet && applicationAcceleration.Value == null)
                throw new ArgumentNullException(nameof(applicationAcceleration), "Property is not nullable for class CreateApplicationRequest.");

            if (deliveryProtocol.IsSet && deliveryProtocol.Value == null)
                throw new ArgumentNullException(nameof(deliveryProtocol), "Property is not nullable for class CreateApplicationRequest.");

            if (originType.IsSet && originType.Value == null)
                throw new ArgumentNullException(nameof(originType), "Property is not nullable for class CreateApplicationRequest.");

            if (address.IsSet && address.Value == null)
                throw new ArgumentNullException(nameof(address), "Property is not nullable for class CreateApplicationRequest.");

            if (minimumTlsVersion.IsSet && minimumTlsVersion.Value == null)
                throw new ArgumentNullException(nameof(minimumTlsVersion), "Property is not nullable for class CreateApplicationRequest.");

            if (originProtocolPolicy.IsSet && originProtocolPolicy.Value == null)
                throw new ArgumentNullException(nameof(originProtocolPolicy), "Property is not nullable for class CreateApplicationRequest.");

            if (hostHeader.IsSet && hostHeader.Value == null)
                throw new ArgumentNullException(nameof(hostHeader), "Property is not nullable for class CreateApplicationRequest.");

            if (browserCacheSettings.IsSet && browserCacheSettings.Value == null)
                throw new ArgumentNullException(nameof(browserCacheSettings), "Property is not nullable for class CreateApplicationRequest.");

            if (cdnCacheSettings.IsSet && cdnCacheSettings.Value == null)
                throw new ArgumentNullException(nameof(cdnCacheSettings), "Property is not nullable for class CreateApplicationRequest.");

            if (browserCacheSettingsMaximumTtl.IsSet && browserCacheSettingsMaximumTtl.Value == null)
                throw new ArgumentNullException(nameof(browserCacheSettingsMaximumTtl), "Property is not nullable for class CreateApplicationRequest.");

            if (cdnCacheSettingsMaximumTtl.IsSet && cdnCacheSettingsMaximumTtl.Value == null)
                throw new ArgumentNullException(nameof(cdnCacheSettingsMaximumTtl), "Property is not nullable for class CreateApplicationRequest.");

            if (debugRules.IsSet && debugRules.Value == null)
                throw new ArgumentNullException(nameof(debugRules), "Property is not nullable for class CreateApplicationRequest.");

            if (supportedCiphers.IsSet && supportedCiphers.Value == null)
                throw new ArgumentNullException(nameof(supportedCiphers), "Property is not nullable for class CreateApplicationRequest.");

            if (l2Caching.IsSet && l2Caching.Value == null)
                throw new ArgumentNullException(nameof(l2Caching), "Property is not nullable for class CreateApplicationRequest.");

            if (http3.IsSet && http3.Value == null)
                throw new ArgumentNullException(nameof(http3), "Property is not nullable for class CreateApplicationRequest.");

            if (websocket.IsSet && websocket.Value == null)
                throw new ArgumentNullException(nameof(websocket), "Property is not nullable for class CreateApplicationRequest.");

            return new CreateApplicationRequest(name.Value!, applicationAcceleration, deliveryProtocol, originType, address, minimumTlsVersion, originProtocolPolicy, hostHeader, browserCacheSettings, cdnCacheSettings, browserCacheSettingsMaximumTtl, cdnCacheSettingsMaximumTtl, debugRules, supportedCiphers, httpPort, httpsPort, l2Caching, http3, websocket);
        }

        /// <summary>
        /// Serializes a <see cref="CreateApplicationRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createApplicationRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CreateApplicationRequest createApplicationRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, createApplicationRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CreateApplicationRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createApplicationRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, CreateApplicationRequest createApplicationRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (createApplicationRequest.Name == null)
                throw new ArgumentNullException(nameof(createApplicationRequest.Name), "Property is required for class CreateApplicationRequest.");

            if (createApplicationRequest.DeliveryProtocolOption.IsSet && createApplicationRequest.DeliveryProtocol == null)
                throw new ArgumentNullException(nameof(createApplicationRequest.DeliveryProtocol), "Property is required for class CreateApplicationRequest.");

            if (createApplicationRequest.OriginTypeOption.IsSet && createApplicationRequest.OriginType == null)
                throw new ArgumentNullException(nameof(createApplicationRequest.OriginType), "Property is required for class CreateApplicationRequest.");

            if (createApplicationRequest.AddressOption.IsSet && createApplicationRequest.Address == null)
                throw new ArgumentNullException(nameof(createApplicationRequest.Address), "Property is required for class CreateApplicationRequest.");

            if (createApplicationRequest.MinimumTlsVersionOption.IsSet && createApplicationRequest.MinimumTlsVersion == null)
                throw new ArgumentNullException(nameof(createApplicationRequest.MinimumTlsVersion), "Property is required for class CreateApplicationRequest.");

            if (createApplicationRequest.OriginProtocolPolicyOption.IsSet && createApplicationRequest.OriginProtocolPolicy == null)
                throw new ArgumentNullException(nameof(createApplicationRequest.OriginProtocolPolicy), "Property is required for class CreateApplicationRequest.");

            if (createApplicationRequest.HostHeaderOption.IsSet && createApplicationRequest.HostHeader == null)
                throw new ArgumentNullException(nameof(createApplicationRequest.HostHeader), "Property is required for class CreateApplicationRequest.");

            if (createApplicationRequest.BrowserCacheSettingsOption.IsSet && createApplicationRequest.BrowserCacheSettings == null)
                throw new ArgumentNullException(nameof(createApplicationRequest.BrowserCacheSettings), "Property is required for class CreateApplicationRequest.");

            if (createApplicationRequest.CdnCacheSettingsOption.IsSet && createApplicationRequest.CdnCacheSettings == null)
                throw new ArgumentNullException(nameof(createApplicationRequest.CdnCacheSettings), "Property is required for class CreateApplicationRequest.");

            if (createApplicationRequest.SupportedCiphersOption.IsSet && createApplicationRequest.SupportedCiphers == null)
                throw new ArgumentNullException(nameof(createApplicationRequest.SupportedCiphers), "Property is required for class CreateApplicationRequest.");

            writer.WriteString("name", createApplicationRequest.Name);

            if (createApplicationRequest.ApplicationAccelerationOption.IsSet)
                writer.WriteBoolean("application_acceleration", createApplicationRequest.ApplicationAccelerationOption.Value!.Value);

            if (createApplicationRequest.DeliveryProtocolOption.IsSet)
                writer.WriteString("delivery_protocol", createApplicationRequest.DeliveryProtocol);

            if (createApplicationRequest.OriginTypeOption.IsSet)
                writer.WriteString("origin_type", createApplicationRequest.OriginType);

            if (createApplicationRequest.AddressOption.IsSet)
                writer.WriteString("address", createApplicationRequest.Address);

            if (createApplicationRequest.MinimumTlsVersionOption.IsSet)
                writer.WriteString("minimum_tls_version", createApplicationRequest.MinimumTlsVersion);

            if (createApplicationRequest.OriginProtocolPolicyOption.IsSet)
                writer.WriteString("origin_protocol_policy", createApplicationRequest.OriginProtocolPolicy);

            if (createApplicationRequest.HostHeaderOption.IsSet)
                writer.WriteString("host_header", createApplicationRequest.HostHeader);

            if (createApplicationRequest.BrowserCacheSettingsOption.IsSet)
                writer.WriteString("browser_cache_settings", createApplicationRequest.BrowserCacheSettings);

            if (createApplicationRequest.CdnCacheSettingsOption.IsSet)
                writer.WriteString("cdn_cache_settings", createApplicationRequest.CdnCacheSettings);

            if (createApplicationRequest.BrowserCacheSettingsMaximumTtlOption.IsSet)
                writer.WriteNumber("browser_cache_settings_maximum_ttl", createApplicationRequest.BrowserCacheSettingsMaximumTtlOption.Value!.Value);

            if (createApplicationRequest.CdnCacheSettingsMaximumTtlOption.IsSet)
                writer.WriteNumber("cdn_cache_settings_maximum_ttl", createApplicationRequest.CdnCacheSettingsMaximumTtlOption.Value!.Value);

            if (createApplicationRequest.DebugRulesOption.IsSet)
                writer.WriteBoolean("debug_rules", createApplicationRequest.DebugRulesOption.Value!.Value);

            if (createApplicationRequest.SupportedCiphersOption.IsSet)
                writer.WriteString("supported_ciphers", createApplicationRequest.SupportedCiphers);

            if (createApplicationRequest.HttpPortOption.IsSet)
                if (createApplicationRequest.HttpPortOption.Value != null)
                {
                    writer.WritePropertyName("http_port");
                    JsonSerializer.Serialize(writer, createApplicationRequest.HttpPort, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("http_port");
            if (createApplicationRequest.HttpsPortOption.IsSet)
                if (createApplicationRequest.HttpsPortOption.Value != null)
                {
                    writer.WritePropertyName("https_port");
                    JsonSerializer.Serialize(writer, createApplicationRequest.HttpsPort, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("https_port");
            if (createApplicationRequest.L2CachingOption.IsSet)
                writer.WriteBoolean("l2_caching", createApplicationRequest.L2CachingOption.Value!.Value);

            if (createApplicationRequest.Http3Option.IsSet)
                writer.WriteBoolean("http3", createApplicationRequest.Http3Option.Value!.Value);

            if (createApplicationRequest.WebsocketOption.IsSet)
                writer.WriteBoolean("websocket", createApplicationRequest.WebsocketOption.Value!.Value);
        }
    }
}
