/*
 * Edge Application API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = edgeapplications.Client.OpenAPIDateConverter;

namespace edgeapplications.Model
{
    /// <summary>
    /// ApplicationPutRequest
    /// </summary>
    [DataContract(Name = "ApplicationPutRequest")]
    public partial class ApplicationPutRequest : IEquatable<ApplicationPutRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationPutRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationPutRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationPutRequest" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="deliveryProtocol">deliveryProtocol.</param>
        /// <param name="httpPort">httpPort.</param>
        /// <param name="httpsPort">httpsPort.</param>
        /// <param name="minimumTlsVersion">minimumTlsVersion.</param>
        /// <param name="active">active.</param>
        /// <param name="applicationAcceleration">applicationAcceleration.</param>
        /// <param name="deviceDetection">deviceDetection.</param>
        /// <param name="edgeFirewall">edgeFirewall.</param>
        /// <param name="edgeFunctions">edgeFunctions.</param>
        /// <param name="imageOptimization">imageOptimization.</param>
        /// <param name="l2Caching">l2Caching.</param>
        /// <param name="loadBalancer">loadBalancer.</param>
        /// <param name="rawLogs">rawLogs.</param>
        /// <param name="webApplicationFirewall">webApplicationFirewall.</param>
        /// <param name="debugRules">debugRules.</param>
        /// <param name="http3">http3.</param>
        /// <param name="websocket">websocket.</param>
        /// <param name="supportedCiphers">supportedCiphers.</param>
        public ApplicationPutRequest(string name = default(string), string deliveryProtocol = default(string), Object httpPort = default(Object), Object httpsPort = default(Object), string minimumTlsVersion = default(string), bool active = default(bool), bool applicationAcceleration = default(bool), bool deviceDetection = default(bool), bool edgeFirewall = default(bool), bool edgeFunctions = default(bool), bool imageOptimization = default(bool), bool l2Caching = default(bool), bool loadBalancer = default(bool), bool rawLogs = default(bool), bool webApplicationFirewall = default(bool), bool debugRules = default(bool), bool http3 = default(bool), bool websocket = default(bool), string supportedCiphers = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ApplicationPutRequest and cannot be null");
            }
            this.Name = name;
            this.DeliveryProtocol = deliveryProtocol;
            this.HttpPort = httpPort;
            this.HttpsPort = httpsPort;
            this.MinimumTlsVersion = minimumTlsVersion;
            this.Active = active;
            this.ApplicationAcceleration = applicationAcceleration;
            this.DeviceDetection = deviceDetection;
            this.EdgeFirewall = edgeFirewall;
            this.EdgeFunctions = edgeFunctions;
            this.ImageOptimization = imageOptimization;
            this.L2Caching = l2Caching;
            this.LoadBalancer = loadBalancer;
            this.RawLogs = rawLogs;
            this.WebApplicationFirewall = webApplicationFirewall;
            this.DebugRules = debugRules;
            this.Http3 = http3;
            this.Websocket = websocket;
            this.SupportedCiphers = supportedCiphers;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryProtocol
        /// </summary>
        [DataMember(Name = "delivery_protocol", EmitDefaultValue = false)]
        public string DeliveryProtocol { get; set; }

        /// <summary>
        /// Gets or Sets HttpPort
        /// </summary>
        [DataMember(Name = "http_port", EmitDefaultValue = true)]
        public Object HttpPort { get; set; }

        /// <summary>
        /// Gets or Sets HttpsPort
        /// </summary>
        [DataMember(Name = "https_port", EmitDefaultValue = true)]
        public Object HttpsPort { get; set; }

        /// <summary>
        /// Gets or Sets MinimumTlsVersion
        /// </summary>
        [DataMember(Name = "minimum_tls_version", EmitDefaultValue = false)]
        public string MinimumTlsVersion { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationAcceleration
        /// </summary>
        [DataMember(Name = "application_acceleration", EmitDefaultValue = true)]
        public bool ApplicationAcceleration { get; set; }

        /// <summary>
        /// Gets or Sets DeviceDetection
        /// </summary>
        [DataMember(Name = "device_detection", EmitDefaultValue = true)]
        public bool DeviceDetection { get; set; }

        /// <summary>
        /// Gets or Sets EdgeFirewall
        /// </summary>
        [DataMember(Name = "edge_firewall", EmitDefaultValue = true)]
        public bool EdgeFirewall { get; set; }

        /// <summary>
        /// Gets or Sets EdgeFunctions
        /// </summary>
        [DataMember(Name = "edge_functions", EmitDefaultValue = true)]
        public bool EdgeFunctions { get; set; }

        /// <summary>
        /// Gets or Sets ImageOptimization
        /// </summary>
        [DataMember(Name = "image_optimization", EmitDefaultValue = true)]
        public bool ImageOptimization { get; set; }

        /// <summary>
        /// Gets or Sets L2Caching
        /// </summary>
        [DataMember(Name = "l2_caching", EmitDefaultValue = true)]
        public bool L2Caching { get; set; }

        /// <summary>
        /// Gets or Sets LoadBalancer
        /// </summary>
        [DataMember(Name = "load_balancer", EmitDefaultValue = true)]
        public bool LoadBalancer { get; set; }

        /// <summary>
        /// Gets or Sets RawLogs
        /// </summary>
        [DataMember(Name = "raw_logs", EmitDefaultValue = true)]
        public bool RawLogs { get; set; }

        /// <summary>
        /// Gets or Sets WebApplicationFirewall
        /// </summary>
        [DataMember(Name = "web_application_firewall", EmitDefaultValue = true)]
        public bool WebApplicationFirewall { get; set; }

        /// <summary>
        /// Gets or Sets DebugRules
        /// </summary>
        [DataMember(Name = "debug_rules", EmitDefaultValue = true)]
        public bool DebugRules { get; set; }

        /// <summary>
        /// Gets or Sets Http3
        /// </summary>
        [DataMember(Name = "http3", EmitDefaultValue = true)]
        public bool Http3 { get; set; }

        /// <summary>
        /// Gets or Sets Websocket
        /// </summary>
        [DataMember(Name = "websocket", EmitDefaultValue = true)]
        public bool Websocket { get; set; }

        /// <summary>
        /// Gets or Sets SupportedCiphers
        /// </summary>
        [DataMember(Name = "supported_ciphers", EmitDefaultValue = false)]
        public string SupportedCiphers { get; set; }

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
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplicationPutRequest);
        }

        /// <summary>
        /// Returns true if ApplicationPutRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationPutRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationPutRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DeliveryProtocol == input.DeliveryProtocol ||
                    (this.DeliveryProtocol != null &&
                    this.DeliveryProtocol.Equals(input.DeliveryProtocol))
                ) && 
                (
                    this.HttpPort == input.HttpPort ||
                    (this.HttpPort != null &&
                    this.HttpPort.Equals(input.HttpPort))
                ) && 
                (
                    this.HttpsPort == input.HttpsPort ||
                    (this.HttpsPort != null &&
                    this.HttpsPort.Equals(input.HttpsPort))
                ) && 
                (
                    this.MinimumTlsVersion == input.MinimumTlsVersion ||
                    (this.MinimumTlsVersion != null &&
                    this.MinimumTlsVersion.Equals(input.MinimumTlsVersion))
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.ApplicationAcceleration == input.ApplicationAcceleration ||
                    this.ApplicationAcceleration.Equals(input.ApplicationAcceleration)
                ) && 
                (
                    this.DeviceDetection == input.DeviceDetection ||
                    this.DeviceDetection.Equals(input.DeviceDetection)
                ) && 
                (
                    this.EdgeFirewall == input.EdgeFirewall ||
                    this.EdgeFirewall.Equals(input.EdgeFirewall)
                ) && 
                (
                    this.EdgeFunctions == input.EdgeFunctions ||
                    this.EdgeFunctions.Equals(input.EdgeFunctions)
                ) && 
                (
                    this.ImageOptimization == input.ImageOptimization ||
                    this.ImageOptimization.Equals(input.ImageOptimization)
                ) && 
                (
                    this.L2Caching == input.L2Caching ||
                    this.L2Caching.Equals(input.L2Caching)
                ) && 
                (
                    this.LoadBalancer == input.LoadBalancer ||
                    this.LoadBalancer.Equals(input.LoadBalancer)
                ) && 
                (
                    this.RawLogs == input.RawLogs ||
                    this.RawLogs.Equals(input.RawLogs)
                ) && 
                (
                    this.WebApplicationFirewall == input.WebApplicationFirewall ||
                    this.WebApplicationFirewall.Equals(input.WebApplicationFirewall)
                ) && 
                (
                    this.DebugRules == input.DebugRules ||
                    this.DebugRules.Equals(input.DebugRules)
                ) && 
                (
                    this.Http3 == input.Http3 ||
                    this.Http3.Equals(input.Http3)
                ) && 
                (
                    this.Websocket == input.Websocket ||
                    this.Websocket.Equals(input.Websocket)
                ) && 
                (
                    this.SupportedCiphers == input.SupportedCiphers ||
                    (this.SupportedCiphers != null &&
                    this.SupportedCiphers.Equals(input.SupportedCiphers))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.DeliveryProtocol != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryProtocol.GetHashCode();
                }
                if (this.HttpPort != null)
                {
                    hashCode = (hashCode * 59) + this.HttpPort.GetHashCode();
                }
                if (this.HttpsPort != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsPort.GetHashCode();
                }
                if (this.MinimumTlsVersion != null)
                {
                    hashCode = (hashCode * 59) + this.MinimumTlsVersion.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                hashCode = (hashCode * 59) + this.ApplicationAcceleration.GetHashCode();
                hashCode = (hashCode * 59) + this.DeviceDetection.GetHashCode();
                hashCode = (hashCode * 59) + this.EdgeFirewall.GetHashCode();
                hashCode = (hashCode * 59) + this.EdgeFunctions.GetHashCode();
                hashCode = (hashCode * 59) + this.ImageOptimization.GetHashCode();
                hashCode = (hashCode * 59) + this.L2Caching.GetHashCode();
                hashCode = (hashCode * 59) + this.LoadBalancer.GetHashCode();
                hashCode = (hashCode * 59) + this.RawLogs.GetHashCode();
                hashCode = (hashCode * 59) + this.WebApplicationFirewall.GetHashCode();
                hashCode = (hashCode * 59) + this.DebugRules.GetHashCode();
                hashCode = (hashCode * 59) + this.Http3.GetHashCode();
                hashCode = (hashCode * 59) + this.Websocket.GetHashCode();
                if (this.SupportedCiphers != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedCiphers.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
