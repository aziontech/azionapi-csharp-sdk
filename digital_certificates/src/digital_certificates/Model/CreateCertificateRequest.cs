/*
 * Digital Certificates API
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
using OpenAPIDateConverter = digital_certificates.Client.OpenAPIDateConverter;

namespace digital_certificates.Model
{
    /// <summary>
    /// CreateCertificateRequest
    /// </summary>
    [DataContract(Name = "createCertificate_request")]
    public partial class CreateCertificateRequest : IEquatable<CreateCertificateRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines CertificateType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CertificateTypeEnum
        {
            /// <summary>
            /// Enum EdgeCertificate for value: edge_certificate
            /// </summary>
            [EnumMember(Value = "edge_certificate")]
            EdgeCertificate = 1,

            /// <summary>
            /// Enum TrustedCaCertificate for value: trusted_ca_certificate
            /// </summary>
            [EnumMember(Value = "trusted_ca_certificate")]
            TrustedCaCertificate = 2

        }


        /// <summary>
        /// Gets or Sets CertificateType
        /// </summary>
        [DataMember(Name = "certificate_type", EmitDefaultValue = false)]
        public CertificateTypeEnum? CertificateType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCertificateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCertificateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCertificateRequest" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="certificate">certificate (required).</param>
        /// <param name="privateKey">privateKey (required).</param>
        /// <param name="certificateType">certificateType.</param>
        /// <param name="managed">managed.</param>
        public CreateCertificateRequest(string name = default(string), string certificate = default(string), string privateKey = default(string), CertificateTypeEnum? certificateType = default(CertificateTypeEnum?), bool managed = default(bool))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateCertificateRequest and cannot be null");
            }
            this.Name = name;
            // to ensure "certificate" is required (not null)
            if (certificate == null)
            {
                throw new ArgumentNullException("certificate is a required property for CreateCertificateRequest and cannot be null");
            }
            this.Certificate = certificate;
            // to ensure "privateKey" is required (not null)
            if (privateKey == null)
            {
                throw new ArgumentNullException("privateKey is a required property for CreateCertificateRequest and cannot be null");
            }
            this.PrivateKey = privateKey;
            this.CertificateType = certificateType;
            this.Managed = managed;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Certificate
        /// </summary>
        [DataMember(Name = "certificate", IsRequired = true, EmitDefaultValue = true)]
        public string Certificate { get; set; }

        /// <summary>
        /// Gets or Sets PrivateKey
        /// </summary>
        [DataMember(Name = "private_key", IsRequired = true, EmitDefaultValue = true)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// Gets or Sets Managed
        /// </summary>
        [DataMember(Name = "managed", EmitDefaultValue = true)]
        public bool Managed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateCertificateRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  CertificateType: ").Append(CertificateType).Append("\n");
            sb.Append("  Managed: ").Append(Managed).Append("\n");
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
            return this.Equals(input as CreateCertificateRequest);
        }

        /// <summary>
        /// Returns true if CreateCertificateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCertificateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCertificateRequest input)
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
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
                ) && 
                (
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))
                ) && 
                (
                    this.CertificateType == input.CertificateType ||
                    this.CertificateType.Equals(input.CertificateType)
                ) && 
                (
                    this.Managed == input.Managed ||
                    this.Managed.Equals(input.Managed)
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
                if (this.Certificate != null)
                {
                    hashCode = (hashCode * 59) + this.Certificate.GetHashCode();
                }
                if (this.PrivateKey != null)
                {
                    hashCode = (hashCode * 59) + this.PrivateKey.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CertificateType.GetHashCode();
                hashCode = (hashCode * 59) + this.Managed.GetHashCode();
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
