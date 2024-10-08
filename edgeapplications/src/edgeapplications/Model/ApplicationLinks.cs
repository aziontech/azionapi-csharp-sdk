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
    /// ApplicationLinks
    /// </summary>
    [DataContract(Name = "ApplicationLinks")]
    public partial class ApplicationLinks : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationLinks" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationLinks() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationLinks" /> class.
        /// </summary>
        /// <param name="previous">previous (required).</param>
        /// <param name="next">next (required).</param>
        public ApplicationLinks(string previous = default(string), string next = default(string))
        {
            // to ensure "previous" is required (not null)
            if (previous == null)
            {
                throw new ArgumentNullException("previous is a required property for ApplicationLinks and cannot be null");
            }
            this.Previous = previous;
            // to ensure "next" is required (not null)
            if (next == null)
            {
                throw new ArgumentNullException("next is a required property for ApplicationLinks and cannot be null");
            }
            this.Next = next;
        }

        /// <summary>
        /// Gets or Sets Previous
        /// </summary>
        [DataMember(Name = "previous", IsRequired = true, EmitDefaultValue = true)]
        public string Previous { get; set; }

        /// <summary>
        /// Gets or Sets Next
        /// </summary>
        [DataMember(Name = "next", IsRequired = true, EmitDefaultValue = true)]
        public string Next { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationLinks {\n");
            sb.Append("  Previous: ").Append(Previous).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
