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
using System.Reflection;

namespace edgeapplications.Model
{
    /// <summary>
    /// RulesEngineBehaviorTarget
    /// </summary>
    [JsonConverter(typeof(RulesEngineBehaviorTargetJsonConverter))]
    [DataContract(Name = "RulesEngineBehavior_target")]
    public partial class RulesEngineBehaviorTarget : AbstractOpenAPISchema, IEquatable<RulesEngineBehaviorTarget>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RulesEngineBehaviorTarget" /> class
        /// with the <see cref="string" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of string.</param>
        public RulesEngineBehaviorTarget(string actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RulesEngineBehaviorTarget" /> class
        /// with the <see cref="decimal" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of decimal.</param>
        public RulesEngineBehaviorTarget(decimal actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RulesEngineBehaviorTarget" /> class
        /// with the <see cref="RulesEngineBehaviorTargetOneOf" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of RulesEngineBehaviorTargetOneOf.</param>
        public RulesEngineBehaviorTarget(RulesEngineBehaviorTargetOneOf actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(RulesEngineBehaviorTargetOneOf))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(decimal))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(string))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: RulesEngineBehaviorTargetOneOf, decimal, string");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `string`. If the actual instance is not `string`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of string</returns>
        public string GetString()
        {
            return (string)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `decimal`. If the actual instance is not `decimal`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of decimal</returns>
        public decimal GetDecimal()
        {
            return (decimal)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `RulesEngineBehaviorTargetOneOf`. If the actual instance is not `RulesEngineBehaviorTargetOneOf`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of RulesEngineBehaviorTargetOneOf</returns>
        public RulesEngineBehaviorTargetOneOf GetRulesEngineBehaviorTargetOneOf()
        {
            return (RulesEngineBehaviorTargetOneOf)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RulesEngineBehaviorTarget {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, RulesEngineBehaviorTarget.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of RulesEngineBehaviorTarget
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of RulesEngineBehaviorTarget</returns>
        public static RulesEngineBehaviorTarget FromJson(string jsonString)
        {
            RulesEngineBehaviorTarget newRulesEngineBehaviorTarget = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newRulesEngineBehaviorTarget;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(RulesEngineBehaviorTargetOneOf).GetProperty("AdditionalProperties") == null)
                {
                    newRulesEngineBehaviorTarget = new RulesEngineBehaviorTarget(JsonConvert.DeserializeObject<RulesEngineBehaviorTargetOneOf>(jsonString, RulesEngineBehaviorTarget.SerializerSettings));
                }
                else
                {
                    newRulesEngineBehaviorTarget = new RulesEngineBehaviorTarget(JsonConvert.DeserializeObject<RulesEngineBehaviorTargetOneOf>(jsonString, RulesEngineBehaviorTarget.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("RulesEngineBehaviorTargetOneOf");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into RulesEngineBehaviorTargetOneOf: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(decimal).GetProperty("AdditionalProperties") == null)
                {
                    newRulesEngineBehaviorTarget = new RulesEngineBehaviorTarget(JsonConvert.DeserializeObject<decimal>(jsonString, RulesEngineBehaviorTarget.SerializerSettings));
                }
                else
                {
                    newRulesEngineBehaviorTarget = new RulesEngineBehaviorTarget(JsonConvert.DeserializeObject<decimal>(jsonString, RulesEngineBehaviorTarget.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("decimal");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into decimal: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(string).GetProperty("AdditionalProperties") == null)
                {
                    newRulesEngineBehaviorTarget = new RulesEngineBehaviorTarget(JsonConvert.DeserializeObject<string>(jsonString, RulesEngineBehaviorTarget.SerializerSettings));
                }
                else
                {
                    newRulesEngineBehaviorTarget = new RulesEngineBehaviorTarget(JsonConvert.DeserializeObject<string>(jsonString, RulesEngineBehaviorTarget.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("string");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into string: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newRulesEngineBehaviorTarget;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RulesEngineBehaviorTarget);
        }

        /// <summary>
        /// Returns true if RulesEngineBehaviorTarget instances are equal
        /// </summary>
        /// <param name="input">Instance of RulesEngineBehaviorTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RulesEngineBehaviorTarget input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for RulesEngineBehaviorTarget
    /// </summary>
    public class RulesEngineBehaviorTargetJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(RulesEngineBehaviorTarget).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return RulesEngineBehaviorTarget.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
