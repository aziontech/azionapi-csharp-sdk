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
    /// RulesEngineCriteria
    /// </summary>
    [DataContract(Name = "RulesEngineCriteria")]
    public partial class RulesEngineCriteria : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RulesEngineCriteria" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RulesEngineCriteria() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RulesEngineCriteria" /> class.
        /// </summary>
        /// <param name="conditional">conditional (required).</param>
        /// <param name="variable">variable (required).</param>
        /// <param name="varOperator">varOperator (required).</param>
        /// <param name="inputValue">inputValue.</param>
        public RulesEngineCriteria(string conditional = default(string), string variable = default(string), string varOperator = default(string), string inputValue = default(string))
        {
            // to ensure "conditional" is required (not null)
            if (conditional == null)
            {
                throw new ArgumentNullException("conditional is a required property for RulesEngineCriteria and cannot be null");
            }
            this.Conditional = conditional;
            // to ensure "variable" is required (not null)
            if (variable == null)
            {
                throw new ArgumentNullException("variable is a required property for RulesEngineCriteria and cannot be null");
            }
            this.Variable = variable;
            // to ensure "varOperator" is required (not null)
            if (varOperator == null)
            {
                throw new ArgumentNullException("varOperator is a required property for RulesEngineCriteria and cannot be null");
            }
            this.Operator = varOperator;
            this.InputValue = inputValue;
        }

        /// <summary>
        /// Gets or Sets Conditional
        /// </summary>
        [DataMember(Name = "conditional", IsRequired = true, EmitDefaultValue = true)]
        public string Conditional { get; set; }

        /// <summary>
        /// Gets or Sets Variable
        /// </summary>
        [DataMember(Name = "variable", IsRequired = true, EmitDefaultValue = true)]
        public string Variable { get; set; }

        /// <summary>
        /// Gets or Sets Operator
        /// </summary>
        [DataMember(Name = "operator", IsRequired = true, EmitDefaultValue = true)]
        public string Operator { get; set; }

        /// <summary>
        /// Gets or Sets InputValue
        /// </summary>
        [DataMember(Name = "input_value", EmitDefaultValue = false)]
        public string InputValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RulesEngineCriteria {\n");
            sb.Append("  Conditional: ").Append(Conditional).Append("\n");
            sb.Append("  Variable: ").Append(Variable).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  InputValue: ").Append(InputValue).Append("\n");
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
