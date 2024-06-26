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
    /// S3Credential
    /// </summary>
    [DataContract(Name = "S3Credential")]
    public partial class S3Credential : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="S3Credential" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="accessKey">accessKey.</param>
        /// <param name="secretKey">secretKey.</param>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="bucket">bucket.</param>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="createdAt">createdAt.</param>
        public S3Credential(string name = default(string), string accessKey = default(string), string secretKey = default(string), List<string> capabilities = default(List<string>), string bucket = default(string), DateTime expirationDate = default(DateTime), DateTime createdAt = default(DateTime))
        {
            this.Name = name;
            this.AccessKey = accessKey;
            this.SecretKey = secretKey;
            this.Capabilities = capabilities;
            this.Bucket = bucket;
            this.ExpirationDate = expirationDate;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>my-s3-credential-all-permissions</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AccessKey
        /// </summary>
        /// <example>s3_credential_access_key</example>
        [DataMember(Name = "access_key", EmitDefaultValue = false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// Gets or Sets SecretKey
        /// </summary>
        /// <example>s3_credential_secret_key</example>
        [DataMember(Name = "secret_key", EmitDefaultValue = false)]
        public string SecretKey { get; set; }

        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        /// <example>[&quot;listAllBucketNames&quot;,&quot;listBuckets&quot;,&quot;listFiles&quot;,&quot;readFiles&quot;,&quot;writeFiles&quot;,&quot;deleteFiles&quot;]</example>
        [DataMember(Name = "capabilities", EmitDefaultValue = false)]
        public List<string> Capabilities { get; set; }

        /// <summary>
        /// Gets or Sets Bucket
        /// </summary>
        /// <example>s3-credentials-bucket</example>
        [DataMember(Name = "bucket", EmitDefaultValue = false)]
        public string Bucket { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        /// <example>2025-01-31T10:57Z</example>
        [DataMember(Name = "expiration_date", EmitDefaultValue = false)]
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /// <example>2024-03-04T16:54:14.782211Z</example>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class S3Credential {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AccessKey: ").Append(AccessKey).Append("\n");
            sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  Bucket: ").Append(Bucket).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 200.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            if (this.Name != null) {
                // Name (string) pattern
                Regex regexName = new Regex(@".*", RegexOptions.CultureInvariant);
                if (!regexName.Match(this.Name).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
                }
            }

            // AccessKey (string) maxLength
            if (this.AccessKey != null && this.AccessKey.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccessKey, length must be less than 200.", new [] { "AccessKey" });
            }

            // AccessKey (string) minLength
            if (this.AccessKey != null && this.AccessKey.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccessKey, length must be greater than 1.", new [] { "AccessKey" });
            }

            if (this.AccessKey != null) {
                // AccessKey (string) pattern
                Regex regexAccessKey = new Regex(@".*", RegexOptions.CultureInvariant);
                if (!regexAccessKey.Match(this.AccessKey).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccessKey, must match a pattern of " + regexAccessKey, new [] { "AccessKey" });
                }
            }

            // SecretKey (string) maxLength
            if (this.SecretKey != null && this.SecretKey.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecretKey, length must be less than 200.", new [] { "SecretKey" });
            }

            // SecretKey (string) minLength
            if (this.SecretKey != null && this.SecretKey.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecretKey, length must be greater than 1.", new [] { "SecretKey" });
            }

            if (this.SecretKey != null) {
                // SecretKey (string) pattern
                Regex regexSecretKey = new Regex(@".*", RegexOptions.CultureInvariant);
                if (!regexSecretKey.Match(this.SecretKey).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecretKey, must match a pattern of " + regexSecretKey, new [] { "SecretKey" });
                }
            }

            // Bucket (string) maxLength
            if (this.Bucket != null && this.Bucket.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Bucket, length must be less than 200.", new [] { "Bucket" });
            }

            // Bucket (string) minLength
            if (this.Bucket != null && this.Bucket.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Bucket, length must be greater than 1.", new [] { "Bucket" });
            }

            if (this.Bucket != null) {
                // Bucket (string) pattern
                Regex regexBucket = new Regex(@".*", RegexOptions.CultureInvariant);
                if (!regexBucket.Match(this.Bucket).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Bucket, must match a pattern of " + regexBucket, new [] { "Bucket" });
                }
            }

            // ExpirationDate (DateTime) maxLength
            if (this.ExpirationDate != null && this.ExpirationDate.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpirationDate, length must be less than 30.", new [] { "ExpirationDate" });
            }

            // ExpirationDate (DateTime) minLength
            if (this.ExpirationDate != null && this.ExpirationDate.Length < 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpirationDate, length must be greater than 10.", new [] { "ExpirationDate" });
            }

            if (this.ExpirationDate != null) {
                // ExpirationDate (DateTime) pattern
                Regex regexExpirationDate = new Regex(@".*", RegexOptions.CultureInvariant);
                if (!regexExpirationDate.Match(this.ExpirationDate).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpirationDate, must match a pattern of " + regexExpirationDate, new [] { "ExpirationDate" });
                }
            }

            // CreatedAt (DateTime) maxLength
            if (this.CreatedAt != null && this.CreatedAt.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreatedAt, length must be less than 30.", new [] { "CreatedAt" });
            }

            // CreatedAt (DateTime) minLength
            if (this.CreatedAt != null && this.CreatedAt.Length < 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreatedAt, length must be greater than 10.", new [] { "CreatedAt" });
            }

            if (this.CreatedAt != null) {
                // CreatedAt (DateTime) pattern
                Regex regexCreatedAt = new Regex(@".*", RegexOptions.CultureInvariant);
                if (!regexCreatedAt.Match(this.CreatedAt).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreatedAt, must match a pattern of " + regexCreatedAt, new [] { "CreatedAt" });
                }
            }

            yield break;
        }
    }

}
