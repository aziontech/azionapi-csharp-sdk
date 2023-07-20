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
    /// ResultsInner
    /// </summary>
    [DataContract(Name = "results_inner")]
    public partial class ResultsInner : IEquatable<ResultsInner>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="ResultsInner" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="subjectName">subjectName.</param>
        /// <param name="validity">validity.</param>
        /// <param name="status">status.</param>
        /// <param name="certificateType">certificateType.</param>
        /// <param name="managed">managed.</param>
        public ResultsInner(int id = default(int), string name = default(string), List<string> subjectName = default(List<string>), string validity = default(string), string status = default(string), CertificateTypeEnum? certificateType = default(CertificateTypeEnum?), bool managed = default(bool))
        {
            this.Id = id;
            this.Name = name;
            this.SubjectName = subjectName;
            this.Validity = validity;
            this.Status = status;
            this.CertificateType = certificateType;
            this.Managed = managed;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SubjectName
        /// </summary>
        [DataMember(Name = "subject_name", EmitDefaultValue = false)]
        public List<string> SubjectName { get; set; }

        /// <summary>
        /// Gets or Sets Validity
        /// </summary>
        [DataMember(Name = "validity", EmitDefaultValue = false)]
        public string Validity { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

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
            sb.Append("class ResultsInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SubjectName: ").Append(SubjectName).Append("\n");
            sb.Append("  Validity: ").Append(Validity).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as ResultsInner);
        }

        /// <summary>
        /// Returns true if ResultsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ResultsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResultsInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SubjectName == input.SubjectName ||
                    this.SubjectName != null &&
                    input.SubjectName != null &&
                    this.SubjectName.SequenceEqual(input.SubjectName)
                ) && 
                (
                    this.Validity == input.Validity ||
                    (this.Validity != null &&
                    this.Validity.Equals(input.Validity))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.SubjectName != null)
                {
                    hashCode = (hashCode * 59) + this.SubjectName.GetHashCode();
                }
                if (this.Validity != null)
                {
                    hashCode = (hashCode * 59) + this.Validity.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
