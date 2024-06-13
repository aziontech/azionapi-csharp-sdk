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
    /// ApplicationsResults
    /// </summary>
    [DataContract(Name = "ApplicationsResults")]
    public partial class ApplicationsResults : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationsResults" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationsResults() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationsResults" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="debugRules">debugRules (required).</param>
        /// <param name="lastEditor">lastEditor (required).</param>
        /// <param name="lastModified">lastModified (required).</param>
        /// <param name="active">active (required).</param>
        /// <param name="origins">origins (required).</param>
        public ApplicationsResults(long id = default(long), string name = default(string), bool debugRules = default(bool), string lastEditor = default(string), string lastModified = default(string), bool active = default(bool), List<ApplicationOrigins> origins = default(List<ApplicationOrigins>))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ApplicationsResults and cannot be null");
            }
            this.Name = name;
            this.DebugRules = debugRules;
            // to ensure "lastEditor" is required (not null)
            if (lastEditor == null)
            {
                throw new ArgumentNullException("lastEditor is a required property for ApplicationsResults and cannot be null");
            }
            this.LastEditor = lastEditor;
            // to ensure "lastModified" is required (not null)
            if (lastModified == null)
            {
                throw new ArgumentNullException("lastModified is a required property for ApplicationsResults and cannot be null");
            }
            this.LastModified = lastModified;
            this.Active = active;
            // to ensure "origins" is required (not null)
            if (origins == null)
            {
                throw new ArgumentNullException("origins is a required property for ApplicationsResults and cannot be null");
            }
            this.Origins = origins;
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
        /// Gets or Sets DebugRules
        /// </summary>
        [DataMember(Name = "debug_rules", IsRequired = true, EmitDefaultValue = true)]
        public bool DebugRules { get; set; }

        /// <summary>
        /// Gets or Sets LastEditor
        /// </summary>
        [DataMember(Name = "last_editor", IsRequired = true, EmitDefaultValue = true)]
        public string LastEditor { get; set; }

        /// <summary>
        /// Gets or Sets LastModified
        /// </summary>
        [DataMember(Name = "last_modified", IsRequired = true, EmitDefaultValue = true)]
        public string LastModified { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", IsRequired = true, EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets Origins
        /// </summary>
        [DataMember(Name = "origins", IsRequired = true, EmitDefaultValue = true)]
        public List<ApplicationOrigins> Origins { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationsResults {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DebugRules: ").Append(DebugRules).Append("\n");
            sb.Append("  LastEditor: ").Append(LastEditor).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Origins: ").Append(Origins).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
