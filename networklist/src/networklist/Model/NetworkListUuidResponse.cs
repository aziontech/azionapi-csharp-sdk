/*
 * Network Lists API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
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
using OpenAPIDateConverter = networklist.Client.OpenAPIDateConverter;

namespace networklist.Model
{
    /// <summary>
    /// NetworkListUuidResponse
    /// </summary>
    [DataContract(Name = "NetworkListUuidResponse")]
    public partial class NetworkListUuidResponse : IEquatable<NetworkListUuidResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkListUuidResponse" /> class.
        /// </summary>
        /// <param name="results">results.</param>
        /// <param name="schemaVersion">schemaVersion.</param>
        public NetworkListUuidResponse(NetworkListUuidResponseEntry results = default(NetworkListUuidResponseEntry), long schemaVersion = default(long))
        {
            this.Results = results;
            this.SchemaVersion = schemaVersion;
        }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "results", EmitDefaultValue = false)]
        public NetworkListUuidResponseEntry Results { get; set; }

        /// <summary>
        /// Gets or Sets SchemaVersion
        /// </summary>
        /// <example>3</example>
        [DataMember(Name = "schema_version", EmitDefaultValue = false)]
        public long SchemaVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NetworkListUuidResponse {\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NetworkListUuidResponse);
        }

        /// <summary>
        /// Returns true if NetworkListUuidResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkListUuidResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkListUuidResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Results == input.Results ||
                    (this.Results != null &&
                    this.Results.Equals(input.Results))
                ) && 
                (
                    this.SchemaVersion == input.SchemaVersion ||
                    this.SchemaVersion.Equals(input.SchemaVersion)
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
                if (this.Results != null)
                {
                    hashCode = (hashCode * 59) + this.Results.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SchemaVersion.GetHashCode();
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