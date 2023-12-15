/*
 * Object Storage
 *
 * REST API OpenAPI documentation for the Object Storage
 *
 * The version of the OpenAPI document: 1.0.0 (v1)
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
using OpenAPIDateConverter = storage.Client.OpenAPIDateConverter;

namespace storage.Model
{
    /// <summary>
    /// ObjectResponseData
    /// </summary>
    [DataContract(Name = "ObjectResponseData")]
    public partial class ObjectResponseData : IEquatable<ObjectResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectResponseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ObjectResponseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectResponseData" /> class.
        /// </summary>
        /// <param name="objectKey">objectKey (required).</param>
        public ObjectResponseData(string objectKey = default(string))
        {
            // to ensure "objectKey" is required (not null)
            if (objectKey == null)
            {
                throw new ArgumentNullException("objectKey is a required property for ObjectResponseData and cannot be null");
            }
            this.ObjectKey = objectKey;
        }

        /// <summary>
        /// Gets or Sets ObjectKey
        /// </summary>
        [DataMember(Name = "object_key", IsRequired = true, EmitDefaultValue = true)]
        public string ObjectKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ObjectResponseData {\n");
            sb.Append("  ObjectKey: ").Append(ObjectKey).Append("\n");
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
            return this.Equals(input as ObjectResponseData);
        }

        /// <summary>
        /// Returns true if ObjectResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectResponseData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ObjectKey == input.ObjectKey ||
                    (this.ObjectKey != null &&
                    this.ObjectKey.Equals(input.ObjectKey))
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
                if (this.ObjectKey != null)
                {
                    hashCode = (hashCode * 59) + this.ObjectKey.GetHashCode();
                }
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

}
