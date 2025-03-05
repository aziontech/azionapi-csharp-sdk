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
    /// RulesEngineIdResponse
    /// </summary>
    public partial class RulesEngineIdResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RulesEngineIdResponse" /> class.
        /// </summary>
        /// <param name="results">results</param>
        /// <param name="schemaVersion">schemaVersion</param>
        [JsonConstructor]
        public RulesEngineIdResponse(RulesEngineResultResponse results, long schemaVersion)
        {
            Results = results;
            SchemaVersion = schemaVersion;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [JsonPropertyName("results")]
        public RulesEngineResultResponse Results { get; set; }

        /// <summary>
        /// Gets or Sets SchemaVersion
        /// </summary>
        [JsonPropertyName("schema_version")]
        public long SchemaVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RulesEngineIdResponse {\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  SchemaVersion: ").Append(SchemaVersion).Append("\n");
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
    /// A Json converter for type <see cref="RulesEngineIdResponse" />
    /// </summary>
    public class RulesEngineIdResponseJsonConverter : JsonConverter<RulesEngineIdResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="RulesEngineIdResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override RulesEngineIdResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<RulesEngineResultResponse?> results = default;
            Option<long?> schemaVersion = default;

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
                        case "results":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                results = new Option<RulesEngineResultResponse?>(JsonSerializer.Deserialize<RulesEngineResultResponse>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "schema_version":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                schemaVersion = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!results.IsSet)
                throw new ArgumentException("Property is required for class RulesEngineIdResponse.", nameof(results));

            if (!schemaVersion.IsSet)
                throw new ArgumentException("Property is required for class RulesEngineIdResponse.", nameof(schemaVersion));

            if (results.IsSet && results.Value == null)
                throw new ArgumentNullException(nameof(results), "Property is not nullable for class RulesEngineIdResponse.");

            if (schemaVersion.IsSet && schemaVersion.Value == null)
                throw new ArgumentNullException(nameof(schemaVersion), "Property is not nullable for class RulesEngineIdResponse.");

            return new RulesEngineIdResponse(results.Value!, schemaVersion.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="RulesEngineIdResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="rulesEngineIdResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, RulesEngineIdResponse rulesEngineIdResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, rulesEngineIdResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="RulesEngineIdResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="rulesEngineIdResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, RulesEngineIdResponse rulesEngineIdResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (rulesEngineIdResponse.Results == null)
                throw new ArgumentNullException(nameof(rulesEngineIdResponse.Results), "Property is required for class RulesEngineIdResponse.");

            writer.WritePropertyName("results");
            JsonSerializer.Serialize(writer, rulesEngineIdResponse.Results, jsonSerializerOptions);
            writer.WriteNumber("schema_version", rulesEngineIdResponse.SchemaVersion);
        }
    }
}
