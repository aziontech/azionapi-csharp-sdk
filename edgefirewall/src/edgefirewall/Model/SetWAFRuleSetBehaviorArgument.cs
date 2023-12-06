/*
 * Edge Firewall API
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
using OpenAPIDateConverter = edgefirewall.Client.OpenAPIDateConverter;

namespace edgefirewall.Model
{
    /// <summary>
    /// SetWAFRuleSetBehaviorArgument
    /// </summary>
    [DataContract(Name = "SetWAFRuleSetBehavior_argument")]
    public partial class SetWAFRuleSetBehaviorArgument : IEquatable<SetWAFRuleSetBehaviorArgument>, IValidatableObject
    {
        /// <summary>
        /// Defines Mode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Enum Learning for value: learning
            /// </summary>
            [EnumMember(Value = "learning")]
            Learning = 1,

            /// <summary>
            /// Enum Blocking for value: blocking
            /// </summary>
            [EnumMember(Value = "blocking")]
            Blocking = 2
        }


        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name = "mode", EmitDefaultValue = false)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetWAFRuleSetBehaviorArgument" /> class.
        /// </summary>
        /// <param name="wafId">wafId.</param>
        /// <param name="mode">mode.</param>
        public SetWAFRuleSetBehaviorArgument(int wafId = default(int), ModeEnum? mode = default(ModeEnum?))
        {
            this.WafId = wafId;
            this.Mode = mode;
        }

        /// <summary>
        /// Gets or Sets WafId
        /// </summary>
        [DataMember(Name = "waf_id", EmitDefaultValue = false)]
        public int WafId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SetWAFRuleSetBehaviorArgument {\n");
            sb.Append("  WafId: ").Append(WafId).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
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
            return this.Equals(input as SetWAFRuleSetBehaviorArgument);
        }

        /// <summary>
        /// Returns true if SetWAFRuleSetBehaviorArgument instances are equal
        /// </summary>
        /// <param name="input">Instance of SetWAFRuleSetBehaviorArgument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetWAFRuleSetBehaviorArgument input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.WafId == input.WafId ||
                    this.WafId.Equals(input.WafId)
                ) && 
                (
                    this.Mode == input.Mode ||
                    this.Mode.Equals(input.Mode)
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
                hashCode = (hashCode * 59) + this.WafId.GetHashCode();
                hashCode = (hashCode * 59) + this.Mode.GetHashCode();
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
            // WafId (int) minimum
            if (this.WafId < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WafId, must be a value greater than or equal to 1.", new [] { "WafId" });
            }

            yield break;
        }
    }

}