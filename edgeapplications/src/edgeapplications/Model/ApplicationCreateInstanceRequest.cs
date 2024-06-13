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
    /// ApplicationCreateInstanceRequest
    /// </summary>
    [DataContract(Name = "ApplicationCreateInstanceRequest")]
    public partial class ApplicationCreateInstanceRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationCreateInstanceRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationCreateInstanceRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationCreateInstanceRequest" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="edgeFunctionId">edgeFunctionId (required).</param>
        /// <param name="args">args (required).</param>
        public ApplicationCreateInstanceRequest(string name = default(string), long edgeFunctionId = default(long), Object args = default(Object))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ApplicationCreateInstanceRequest and cannot be null");
            }
            this.Name = name;
            this.EdgeFunctionId = edgeFunctionId;
            // to ensure "args" is required (not null)
            if (args == null)
            {
                throw new ArgumentNullException("args is a required property for ApplicationCreateInstanceRequest and cannot be null");
            }
            this.Args = args;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets EdgeFunctionId
        /// </summary>
        [DataMember(Name = "edge_function_id", IsRequired = true, EmitDefaultValue = true)]
        public long EdgeFunctionId { get; set; }

        /// <summary>
        /// Gets or Sets Args
        /// </summary>
        [DataMember(Name = "args", IsRequired = true, EmitDefaultValue = true)]
        public Object Args { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationCreateInstanceRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EdgeFunctionId: ").Append(EdgeFunctionId).Append("\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
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
