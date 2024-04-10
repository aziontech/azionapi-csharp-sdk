/*
 * Domain API
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
using OpenAPIDateConverter = domains.Client.OpenAPIDateConverter;

namespace domains.Model
{
    /// <summary>
    /// DomainResponseWithResults
    /// </summary>
    [DataContract(Name = "DomainResponseWithResults")]
    public partial class DomainResponseWithResults : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainResponseWithResults" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DomainResponseWithResults() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainResponseWithResults" /> class.
        /// </summary>
        /// <param name="count">count (required).</param>
        /// <param name="totalPages">totalPages (required).</param>
        /// <param name="schemaVersion">schemaVersion (required).</param>
        /// <param name="links">links (required).</param>
        /// <param name="results">results (required).</param>
        public DomainResponseWithResults(long count = default(long), long totalPages = default(long), long schemaVersion = default(long), DomainLinks links = default(DomainLinks), List<DomainEntity> results = default(List<DomainEntity>))
        {
            this.Count = count;
            this.TotalPages = totalPages;
            this.SchemaVersion = schemaVersion;
            // to ensure "links" is required (not null)
            if (links == null)
            {
                throw new ArgumentNullException("links is a required property for DomainResponseWithResults and cannot be null");
            }
            this.Links = links;
            // to ensure "results" is required (not null)
            if (results == null)
            {
                throw new ArgumentNullException("results is a required property for DomainResponseWithResults and cannot be null");
            }
            this.Results = results;
        }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", IsRequired = true, EmitDefaultValue = true)]
        public long Count { get; set; }

        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        [DataMember(Name = "total_pages", IsRequired = true, EmitDefaultValue = true)]
        public long TotalPages { get; set; }

        /// <summary>
        /// Gets or Sets SchemaVersion
        /// </summary>
        [DataMember(Name = "schema_version", IsRequired = true, EmitDefaultValue = true)]
        public long SchemaVersion { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", IsRequired = true, EmitDefaultValue = true)]
        public DomainLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "results", IsRequired = true, EmitDefaultValue = true)]
        public List<DomainEntity> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DomainResponseWithResults {\n");
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
