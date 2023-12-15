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
    /// BucketObject
    /// </summary>
    [DataContract(Name = "BucketObject")]
    public partial class BucketObject : IEquatable<BucketObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BucketObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public BucketObject()
        {
        }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; private set; }

        /// <summary>
        /// Returns false as Key should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeKey()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets LastModified
        /// </summary>
        [DataMember(Name = "last_modified", IsRequired = true, EmitDefaultValue = true)]
        public DateTime LastModified { get; private set; }

        /// <summary>
        /// Returns false as LastModified should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastModified()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", IsRequired = true, EmitDefaultValue = true)]
        public int Size { get; private set; }

        /// <summary>
        /// Returns false as Size should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSize()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Etag
        /// </summary>
        [DataMember(Name = "etag", IsRequired = true, EmitDefaultValue = true)]
        public string Etag { get; private set; }

        /// <summary>
        /// Returns false as Etag should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEtag()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BucketObject {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
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
            return this.Equals(input as BucketObject);
        }

        /// <summary>
        /// Returns true if BucketObject instances are equal
        /// </summary>
        /// <param name="input">Instance of BucketObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BucketObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
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
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.LastModified != null)
                {
                    hashCode = (hashCode * 59) + this.LastModified.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Size.GetHashCode();
                if (this.Etag != null)
                {
                    hashCode = (hashCode * 59) + this.Etag.GetHashCode();
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
