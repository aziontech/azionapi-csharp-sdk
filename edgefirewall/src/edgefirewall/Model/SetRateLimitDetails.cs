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
    /// SetRateLimitDetails
    /// </summary>
    [DataContract(Name = "SetRateLimitDetails")]
    public partial class SetRateLimitDetails : IEquatable<SetRateLimitDetails>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Second for value: second
            /// </summary>
            [EnumMember(Value = "second")]
            Second = 1,

            /// <summary>
            /// Enum Minute for value: minute
            /// </summary>
            [EnumMember(Value = "minute")]
            Minute = 2
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Defines LimitBy
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LimitByEnum
        {
            /// <summary>
            /// Enum ClientIp for value: client_ip
            /// </summary>
            [EnumMember(Value = "client_ip")]
            ClientIp = 1,

            /// <summary>
            /// Enum Global for value: global
            /// </summary>
            [EnumMember(Value = "global")]
            Global = 2
        }


        /// <summary>
        /// Gets or Sets LimitBy
        /// </summary>
        [DataMember(Name = "limit_by", EmitDefaultValue = false)]
        public LimitByEnum? LimitBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetRateLimitDetails" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="limitBy">limitBy.</param>
        /// <param name="averageRateLimit">averageRateLimit.</param>
        /// <param name="maximumBurstSize">maximumBurstSize.</param>
        public SetRateLimitDetails(TypeEnum? type = default(TypeEnum?), LimitByEnum? limitBy = default(LimitByEnum?), int averageRateLimit = default(int), int maximumBurstSize = default(int))
        {
            this.Type = type;
            this.LimitBy = limitBy;
            this.AverageRateLimit = averageRateLimit;
            this.MaximumBurstSize = maximumBurstSize;
        }

        /// <summary>
        /// Gets or Sets AverageRateLimit
        /// </summary>
        [DataMember(Name = "average_rate_limit", EmitDefaultValue = false)]
        public int AverageRateLimit { get; set; }

        /// <summary>
        /// Gets or Sets MaximumBurstSize
        /// </summary>
        [DataMember(Name = "maximum_burst_size", EmitDefaultValue = false)]
        public int MaximumBurstSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SetRateLimitDetails {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  LimitBy: ").Append(LimitBy).Append("\n");
            sb.Append("  AverageRateLimit: ").Append(AverageRateLimit).Append("\n");
            sb.Append("  MaximumBurstSize: ").Append(MaximumBurstSize).Append("\n");
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
            return this.Equals(input as SetRateLimitDetails);
        }

        /// <summary>
        /// Returns true if SetRateLimitDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of SetRateLimitDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetRateLimitDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.LimitBy == input.LimitBy ||
                    this.LimitBy.Equals(input.LimitBy)
                ) && 
                (
                    this.AverageRateLimit == input.AverageRateLimit ||
                    this.AverageRateLimit.Equals(input.AverageRateLimit)
                ) && 
                (
                    this.MaximumBurstSize == input.MaximumBurstSize ||
                    this.MaximumBurstSize.Equals(input.MaximumBurstSize)
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.LimitBy.GetHashCode();
                hashCode = (hashCode * 59) + this.AverageRateLimit.GetHashCode();
                hashCode = (hashCode * 59) + this.MaximumBurstSize.GetHashCode();
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
            // AverageRateLimit (int) minimum
            if (this.AverageRateLimit < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AverageRateLimit, must be a value greater than or equal to 1.", new [] { "AverageRateLimit" });
            }

            // MaximumBurstSize (int) minimum
            if (this.MaximumBurstSize < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaximumBurstSize, must be a value greater than or equal to 1.", new [] { "MaximumBurstSize" });
            }

            yield break;
        }
    }

}
