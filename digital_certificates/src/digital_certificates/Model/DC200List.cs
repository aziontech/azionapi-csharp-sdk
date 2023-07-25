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
    /// DC200List
    /// </summary>
    [DataContract(Name = "DC200List")]
    public partial class DC200List : IEquatable<DC200List>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DC200List" /> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="totalPages">totalPages.</param>
        /// <param name="schemaVersion">schemaVersion.</param>
        /// <param name="links">links.</param>
        /// <param name="results">results.</param>
        public DC200List(int count = default(int), int totalPages = default(int), int schemaVersion = default(int), DC200ListLinks links = default(DC200ListLinks), List<ResultsInner> results = default(List<ResultsInner>))
        {
            this.Count = count;
            this.TotalPages = totalPages;
            this.SchemaVersion = schemaVersion;
            this.Links = links;
            this.Results = results;
        }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "total_pages", EmitDefaultValue = false)]
        public int TotalPages { get; set; }

        /// <summary>
        /// Gets or Sets SchemaVersion
        /// </summary>
        /// <example>3</example>
        [DataMember(Name = "schema_version", EmitDefaultValue = false)]
        public int SchemaVersion { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public DC200ListLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "results", EmitDefaultValue = false)]
        public List<ResultsInner> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DC200List {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  SchemaVersion: ").Append(SchemaVersion).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(input as DC200List);
        }

        /// <summary>
        /// Returns true if DC200List instances are equal
        /// </summary>
        /// <param name="input">Instance of DC200List to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DC200List input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.TotalPages == input.TotalPages ||
                    this.TotalPages.Equals(input.TotalPages)
                ) && 
                (
                    this.SchemaVersion == input.SchemaVersion ||
                    this.SchemaVersion.Equals(input.SchemaVersion)
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
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
                hashCode = (hashCode * 59) + this.Count.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalPages.GetHashCode();
                hashCode = (hashCode * 59) + this.SchemaVersion.GetHashCode();
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Results != null)
                {
                    hashCode = (hashCode * 59) + this.Results.GetHashCode();
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
