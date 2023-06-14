/*
 * Purge API
 *
 * Azion Real-Time Purge
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
using OpenAPIDateConverter = realtimepurge.Client.OpenAPIDateConverter;

namespace realtimepurge.Model
{
    /// <summary>
    /// PurgeWildcardRequest
    /// </summary>
    [DataContract(Name = "PurgeWildcardRequest")]
    public partial class PurgeWildcardRequest : IEquatable<PurgeWildcardRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurgeWildcardRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PurgeWildcardRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PurgeWildcardRequest" /> class.
        /// </summary>
        /// <param name="urls">urls (required).</param>
        /// <param name="method">method (required).</param>
        public PurgeWildcardRequest(List<string> urls = default(List<string>), string method = default(string))
        {
            // to ensure "urls" is required (not null)
            if (urls == null)
            {
                throw new ArgumentNullException("urls is a required property for PurgeWildcardRequest and cannot be null");
            }
            this.Urls = urls;
            // to ensure "method" is required (not null)
            if (method == null)
            {
                throw new ArgumentNullException("method is a required property for PurgeWildcardRequest and cannot be null");
            }
            this.Method = method;
        }

        /// <summary>
        /// Gets or Sets Urls
        /// </summary>
        [DataMember(Name = "urls", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Urls { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = true)]
        public string Method { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PurgeWildcardRequest {\n");
            sb.Append("  Urls: ").Append(Urls).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
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
            return this.Equals(input as PurgeWildcardRequest);
        }

        /// <summary>
        /// Returns true if PurgeWildcardRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PurgeWildcardRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurgeWildcardRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Urls == input.Urls ||
                    this.Urls != null &&
                    input.Urls != null &&
                    this.Urls.SequenceEqual(input.Urls)
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
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
                if (this.Urls != null)
                {
                    hashCode = (hashCode * 59) + this.Urls.GetHashCode();
                }
                if (this.Method != null)
                {
                    hashCode = (hashCode * 59) + this.Method.GetHashCode();
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