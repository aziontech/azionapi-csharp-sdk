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
    /// CreateDeviceGroupsRequest
    /// </summary>
    [DataContract(Name = "CreateDeviceGroupsRequest")]
    public partial class CreateDeviceGroupsRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeviceGroupsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateDeviceGroupsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeviceGroupsRequest" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="userAgent">userAgent (required).</param>
        /// <param name="addresses">addresses (required).</param>
        public CreateDeviceGroupsRequest(string name = default(string), string userAgent = default(string), string addresses = default(string))
        {
            // to ensure "userAgent" is required (not null)
            if (userAgent == null)
            {
                throw new ArgumentNullException("userAgent is a required property for CreateDeviceGroupsRequest and cannot be null");
            }
            this.UserAgent = userAgent;
            // to ensure "addresses" is required (not null)
            if (addresses == null)
            {
                throw new ArgumentNullException("addresses is a required property for CreateDeviceGroupsRequest and cannot be null");
            }
            this.Addresses = addresses;
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets UserAgent
        /// </summary>
        [DataMember(Name = "user_agent", IsRequired = true, EmitDefaultValue = true)]
        public string UserAgent { get; set; }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name = "addresses", IsRequired = true, EmitDefaultValue = true)]
        public string Addresses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateDeviceGroupsRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
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
