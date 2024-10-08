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
    /// RulesEngineResultResponse
    /// </summary>
    [DataContract(Name = "RulesEngineResultResponse")]
    public partial class RulesEngineResultResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RulesEngineResultResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RulesEngineResultResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RulesEngineResultResponse" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description.</param>
        /// <param name="phase">phase (required).</param>
        /// <param name="behaviors">behaviors.</param>
        /// <param name="criteria">criteria (required).</param>
        /// <param name="isActive">isActive (required).</param>
        /// <param name="order">order (required).</param>
        public RulesEngineResultResponse(long id = default(long), string name = default(string), string description = default(string), string phase = default(string), List<RulesEngineBehaviorEntry> behaviors = default(List<RulesEngineBehaviorEntry>), List<List<RulesEngineCriteria>> criteria = default(List<List<RulesEngineCriteria>>), bool isActive = default(bool), long order = default(long))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for RulesEngineResultResponse and cannot be null");
            }
            this.Name = name;
            // to ensure "phase" is required (not null)
            if (phase == null)
            {
                throw new ArgumentNullException("phase is a required property for RulesEngineResultResponse and cannot be null");
            }
            this.Phase = phase;
            // to ensure "criteria" is required (not null)
            if (criteria == null)
            {
                throw new ArgumentNullException("criteria is a required property for RulesEngineResultResponse and cannot be null");
            }
            this.Criteria = criteria;
            this.IsActive = isActive;
            this.Order = order;
            this.Description = description;
            this.Behaviors = behaviors;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Phase
        /// </summary>
        [DataMember(Name = "phase", IsRequired = true, EmitDefaultValue = true)]
        public string Phase { get; set; }

        /// <summary>
        /// Gets or Sets Behaviors
        /// </summary>
        [DataMember(Name = "behaviors", EmitDefaultValue = false)]
        public List<RulesEngineBehaviorEntry> Behaviors { get; set; }

        /// <summary>
        /// Gets or Sets Criteria
        /// </summary>
        [DataMember(Name = "criteria", IsRequired = true, EmitDefaultValue = true)]
        public List<List<RulesEngineCriteria>> Criteria { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "is_active", IsRequired = true, EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", IsRequired = true, EmitDefaultValue = true)]
        public long Order { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RulesEngineResultResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Phase: ").Append(Phase).Append("\n");
            sb.Append("  Behaviors: ").Append(Behaviors).Append("\n");
            sb.Append("  Criteria: ").Append(Criteria).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
