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
    /// OriginsResponseLinks
    /// </summary>
    public partial class OriginsResponseLinks : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OriginsResponseLinks" /> class.
        /// </summary>
        /// <param name="previous">previous</param>
        /// <param name="next">next</param>
        [JsonConstructor]
        public OriginsResponseLinks(Option<string?> previous = default, Option<string?> next = default)
        {
            PreviousOption = previous;
            NextOption = next;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Previous
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PreviousOption { get; private set; }

        /// <summary>
        /// Gets or Sets Previous
        /// </summary>
        [JsonPropertyName("previous")]
        public string? Previous { get { return this.PreviousOption; } set { this.PreviousOption = new(value); } }

        /// <summary>
        /// Used to track the state of Next
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NextOption { get; private set; }

        /// <summary>
        /// Gets or Sets Next
        /// </summary>
        [JsonPropertyName("next")]
        public string? Next { get { return this.NextOption; } set { this.NextOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OriginsResponseLinks {\n");
            sb.Append("  Previous: ").Append(Previous).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
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
    /// A Json converter for type <see cref="OriginsResponseLinks" />
    /// </summary>
    public class OriginsResponseLinksJsonConverter : JsonConverter<OriginsResponseLinks>
    {
        /// <summary>
        /// Deserializes json to <see cref="OriginsResponseLinks" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override OriginsResponseLinks Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> previous = default;
            Option<string?> next = default;

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
                        case "previous":
                            previous = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "next":
                            next = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            return new OriginsResponseLinks(previous, next);
        }

        /// <summary>
        /// Serializes a <see cref="OriginsResponseLinks" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="originsResponseLinks"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, OriginsResponseLinks originsResponseLinks, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, originsResponseLinks, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="OriginsResponseLinks" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="originsResponseLinks"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, OriginsResponseLinks originsResponseLinks, JsonSerializerOptions jsonSerializerOptions)
        {
            if (originsResponseLinks.PreviousOption.IsSet)
                if (originsResponseLinks.PreviousOption.Value != null)
                    writer.WriteString("previous", originsResponseLinks.Previous);
                else
                    writer.WriteNull("previous");

            if (originsResponseLinks.NextOption.IsSet)
                if (originsResponseLinks.NextOption.Value != null)
                    writer.WriteString("next", originsResponseLinks.Next);
                else
                    writer.WriteNull("next");
        }
    }
}
