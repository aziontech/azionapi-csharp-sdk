// <auto-generated>
/*
 * Edge Application API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using edgeapplications.Client;

namespace edgeapplications.Model
{
    /// <summary>
    /// RulesEngineBehaviorObject
    /// </summary>
    public partial class RulesEngineBehaviorObject : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RulesEngineBehaviorObject" /> class.
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="target">target</param>
        [JsonConstructor]
        public RulesEngineBehaviorObject(string name, RulesEngineBehaviorObjectTarget target)
        {
            Name = name;
            Target = target;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [JsonPropertyName("target")]
        public RulesEngineBehaviorObjectTarget Target { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RulesEngineBehaviorObject {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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

    /// <summary>
    /// A Json converter for type <see cref="RulesEngineBehaviorObject" />
    /// </summary>
    public class RulesEngineBehaviorObjectJsonConverter : JsonConverter<RulesEngineBehaviorObject>
    {
        /// <summary>
        /// Deserializes json to <see cref="RulesEngineBehaviorObject" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override RulesEngineBehaviorObject Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> name = default;
            Option<RulesEngineBehaviorObjectTarget?> target = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "target":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                target = new Option<RulesEngineBehaviorObjectTarget?>(JsonSerializer.Deserialize<RulesEngineBehaviorObjectTarget>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class RulesEngineBehaviorObject.", nameof(name));

            if (!target.IsSet)
                throw new ArgumentException("Property is required for class RulesEngineBehaviorObject.", nameof(target));

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class RulesEngineBehaviorObject.");

            if (target.IsSet && target.Value == null)
                throw new ArgumentNullException(nameof(target), "Property is not nullable for class RulesEngineBehaviorObject.");

            return new RulesEngineBehaviorObject(name.Value!, target.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="RulesEngineBehaviorObject" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="rulesEngineBehaviorObject"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, RulesEngineBehaviorObject rulesEngineBehaviorObject, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, rulesEngineBehaviorObject, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="RulesEngineBehaviorObject" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="rulesEngineBehaviorObject"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, RulesEngineBehaviorObject rulesEngineBehaviorObject, JsonSerializerOptions jsonSerializerOptions)
        {
            if (rulesEngineBehaviorObject.Name == null)
                throw new ArgumentNullException(nameof(rulesEngineBehaviorObject.Name), "Property is required for class RulesEngineBehaviorObject.");

            if (rulesEngineBehaviorObject.Target == null)
                throw new ArgumentNullException(nameof(rulesEngineBehaviorObject.Target), "Property is required for class RulesEngineBehaviorObject.");

            writer.WriteString("name", rulesEngineBehaviorObject.Name);

            writer.WritePropertyName("target");
            JsonSerializer.Serialize(writer, rulesEngineBehaviorObject.Target, jsonSerializerOptions);
        }
    }
}
