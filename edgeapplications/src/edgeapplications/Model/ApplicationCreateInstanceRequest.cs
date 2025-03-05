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
    /// ApplicationCreateInstanceRequest
    /// </summary>
    public partial class ApplicationCreateInstanceRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationCreateInstanceRequest" /> class.
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="edgeFunctionId">edgeFunctionId</param>
        /// <param name="args">args</param>
        [JsonConstructor]
        public ApplicationCreateInstanceRequest(string name, long edgeFunctionId, ApplicationCreateInstanceRequestArgs args)
        {
            Name = name;
            EdgeFunctionId = edgeFunctionId;
            Args = args;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets EdgeFunctionId
        /// </summary>
        [JsonPropertyName("edge_function_id")]
        public long EdgeFunctionId { get; set; }

        /// <summary>
        /// Gets or Sets Args
        /// </summary>
        [JsonPropertyName("args")]
        public ApplicationCreateInstanceRequestArgs Args { get; set; }

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
    /// A Json converter for type <see cref="ApplicationCreateInstanceRequest" />
    /// </summary>
    public class ApplicationCreateInstanceRequestJsonConverter : JsonConverter<ApplicationCreateInstanceRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="ApplicationCreateInstanceRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ApplicationCreateInstanceRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> name = default;
            Option<long?> edgeFunctionId = default;
            Option<ApplicationCreateInstanceRequestArgs?> args = default;

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
                        case "edge_function_id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                edgeFunctionId = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "args":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                args = new Option<ApplicationCreateInstanceRequestArgs?>(JsonSerializer.Deserialize<ApplicationCreateInstanceRequestArgs>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class ApplicationCreateInstanceRequest.", nameof(name));

            if (!edgeFunctionId.IsSet)
                throw new ArgumentException("Property is required for class ApplicationCreateInstanceRequest.", nameof(edgeFunctionId));

            if (!args.IsSet)
                throw new ArgumentException("Property is required for class ApplicationCreateInstanceRequest.", nameof(args));

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class ApplicationCreateInstanceRequest.");

            if (edgeFunctionId.IsSet && edgeFunctionId.Value == null)
                throw new ArgumentNullException(nameof(edgeFunctionId), "Property is not nullable for class ApplicationCreateInstanceRequest.");

            if (args.IsSet && args.Value == null)
                throw new ArgumentNullException(nameof(args), "Property is not nullable for class ApplicationCreateInstanceRequest.");

            return new ApplicationCreateInstanceRequest(name.Value!, edgeFunctionId.Value!.Value!, args.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="ApplicationCreateInstanceRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="applicationCreateInstanceRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ApplicationCreateInstanceRequest applicationCreateInstanceRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, applicationCreateInstanceRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ApplicationCreateInstanceRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="applicationCreateInstanceRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ApplicationCreateInstanceRequest applicationCreateInstanceRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (applicationCreateInstanceRequest.Name == null)
                throw new ArgumentNullException(nameof(applicationCreateInstanceRequest.Name), "Property is required for class ApplicationCreateInstanceRequest.");

            if (applicationCreateInstanceRequest.Args == null)
                throw new ArgumentNullException(nameof(applicationCreateInstanceRequest.Args), "Property is required for class ApplicationCreateInstanceRequest.");

            writer.WriteString("name", applicationCreateInstanceRequest.Name);

            writer.WriteNumber("edge_function_id", applicationCreateInstanceRequest.EdgeFunctionId);

            writer.WritePropertyName("args");
            JsonSerializer.Serialize(writer, applicationCreateInstanceRequest.Args, jsonSerializerOptions);
        }
    }
}
