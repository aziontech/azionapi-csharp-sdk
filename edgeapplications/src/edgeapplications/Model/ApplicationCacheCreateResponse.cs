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
    /// ApplicationCacheCreateResponse
    /// </summary>
    [DataContract(Name = "ApplicationCacheCreateResponse")]
    public partial class ApplicationCacheCreateResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationCacheCreateResponse" /> class.
        /// </summary>
        /// <param name="results">results.</param>
        /// <param name="schemaVersion">schemaVersion.</param>
        public ApplicationCacheCreateResponse(ApplicationCacheCreateResults results = default(ApplicationCacheCreateResults), long schemaVersion = default(long))
        {
            this.Results = results;
            this.SchemaVersion = schemaVersion;
        }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "results", EmitDefaultValue = false)]
        public ApplicationCacheCreateResults Results { get; set; }

        /// <summary>
        /// Gets or Sets SchemaVersion
        /// </summary>
        [DataMember(Name = "schema_version", EmitDefaultValue = false)]
        public long SchemaVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationCacheCreateResponse {\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  SchemaVersion: ").Append(SchemaVersion).Append("\n");
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
