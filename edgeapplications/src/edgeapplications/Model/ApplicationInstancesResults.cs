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
    /// ApplicationInstancesResults
    /// </summary>
    public partial class ApplicationInstancesResults : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInstancesResults" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="edgeFunctionId">edgeFunctionId</param>
        /// <param name="name">name</param>
        /// <param name="args">args</param>
        [JsonConstructor]
        public ApplicationInstancesResults(long id, long edgeFunctionId, string name, Object? args = default)
        {
            Id = id;
            EdgeFunctionId = edgeFunctionId;
            Name = name;
            Args = args;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets EdgeFunctionId
        /// </summary>
        [JsonPropertyName("edge_function_id")]
        public long EdgeFunctionId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Args
        /// </summary>
        [JsonPropertyName("args")]
        public Object? Args { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationInstancesResults {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EdgeFunctionId: ").Append(EdgeFunctionId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
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
    /// A Json converter for type <see cref="ApplicationInstancesResults" />
    /// </summary>
    public class ApplicationInstancesResultsJsonConverter : JsonConverter<ApplicationInstancesResults>
    {
        /// <summary>
        /// Deserializes json to <see cref="ApplicationInstancesResults" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ApplicationInstancesResults Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> id = default;
            Option<long?> edgeFunctionId = default;
            Option<string?> name = default;
            Option<Object?> args = default;

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
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "edge_function_id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                edgeFunctionId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "args":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                args = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class ApplicationInstancesResults.", nameof(id));

            if (!edgeFunctionId.IsSet)
                throw new ArgumentException("Property is required for class ApplicationInstancesResults.", nameof(edgeFunctionId));

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class ApplicationInstancesResults.", nameof(name));

            if (!args.IsSet)
                throw new ArgumentException("Property is required for class ApplicationInstancesResults.", nameof(args));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class ApplicationInstancesResults.");

            if (edgeFunctionId.IsSet && edgeFunctionId.Value == null)
                throw new ArgumentNullException(nameof(edgeFunctionId), "Property is not nullable for class ApplicationInstancesResults.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class ApplicationInstancesResults.");

            return new ApplicationInstancesResults(id.Value!.Value!, edgeFunctionId.Value!.Value!, name.Value!, args.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="ApplicationInstancesResults" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="applicationInstancesResults"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ApplicationInstancesResults applicationInstancesResults, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, applicationInstancesResults, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ApplicationInstancesResults" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="applicationInstancesResults"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ApplicationInstancesResults applicationInstancesResults, JsonSerializerOptions jsonSerializerOptions)
        {
            if (applicationInstancesResults.Name == null)
                throw new ArgumentNullException(nameof(applicationInstancesResults.Name), "Property is required for class ApplicationInstancesResults.");

            writer.WriteNumber("id", applicationInstancesResults.Id);

            writer.WriteNumber("edge_function_id", applicationInstancesResults.EdgeFunctionId);

            writer.WriteString("name", applicationInstancesResults.Name);

            if (applicationInstancesResults.Args != null)
            {
                writer.WritePropertyName("args");
                JsonSerializer.Serialize(writer, applicationInstancesResults.Args, jsonSerializerOptions);
            }
            else
                writer.WriteNull("args");
        }
    }
}
