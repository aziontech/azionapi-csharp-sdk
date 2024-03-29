/*
 * Data Streaming - OpenAPI
 *
 * The Data Streaming API allows you to manage your existing data streamings and templates. Data Streaming allows you to feed your stream processing, SIEM, and big data platforms with the event logs from your applications on Azion in real time. 
 *
 * The version of the OpenAPI document: 1.0.0
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
using OpenAPIDateConverter = data_streaming.Client.OpenAPIDateConverter;

namespace data_streaming.Model
{
    /// <summary>
    /// PostDataStreamingResponse
    /// </summary>
    [DataContract(Name = "PostDataStreamingResponse")]
    public partial class PostDataStreamingResponse : IEquatable<PostDataStreamingResponse>, IValidatableObject
    {
        /// <summary>
        /// Options:  * &#x60;2&#x60; - Edge Applications Event Collector  * &#x60;4&#x60; - WAF Event Collector  * &#x60;86&#x60; - Edge Functions Event Collector  * &#x60;184&#x60; - Edge Applications + WAF Event Collector  * &#x60;251&#x60; - Activity History Collector 
        /// </summary>
        /// <value>Options:  * &#x60;2&#x60; - Edge Applications Event Collector  * &#x60;4&#x60; - WAF Event Collector  * &#x60;86&#x60; - Edge Functions Event Collector  * &#x60;184&#x60; - Edge Applications + WAF Event Collector  * &#x60;251&#x60; - Activity History Collector </value>
        public enum TemplateIdEnum
        {
            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            NUMBER_4 = 4,

            /// <summary>
            /// Enum NUMBER_86 for value: 86
            /// </summary>
            NUMBER_86 = 86,

            /// <summary>
            /// Enum NUMBER_184 for value: 184
            /// </summary>
            NUMBER_184 = 184,

            /// <summary>
            /// Enum NUMBER_251 for value: 251
            /// </summary>
            NUMBER_251 = 251
        }


        /// <summary>
        /// Options:  * &#x60;2&#x60; - Edge Applications Event Collector  * &#x60;4&#x60; - WAF Event Collector  * &#x60;86&#x60; - Edge Functions Event Collector  * &#x60;184&#x60; - Edge Applications + WAF Event Collector  * &#x60;251&#x60; - Activity History Collector 
        /// </summary>
        /// <value>Options:  * &#x60;2&#x60; - Edge Applications Event Collector  * &#x60;4&#x60; - WAF Event Collector  * &#x60;86&#x60; - Edge Functions Event Collector  * &#x60;184&#x60; - Edge Applications + WAF Event Collector  * &#x60;251&#x60; - Activity History Collector </value>
        [DataMember(Name = "template_id", EmitDefaultValue = false)]
        public TemplateIdEnum? TemplateId { get; set; }
        /// <summary>
        /// Options:  * &#x60;http&#x60; - Edge Applications  * &#x60;waf&#x60; - WAF Events  * &#x60;cells_console&#x60; - Edge Functions  * &#x60;rtm_activity&#x60; - Activity History 
        /// </summary>
        /// <value>Options:  * &#x60;http&#x60; - Edge Applications  * &#x60;waf&#x60; - WAF Events  * &#x60;cells_console&#x60; - Edge Functions  * &#x60;rtm_activity&#x60; - Activity History </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DataSourceEnum
        {
            /// <summary>
            /// Enum Http for value: http
            /// </summary>
            [EnumMember(Value = "http")]
            Http = 1,

            /// <summary>
            /// Enum Waf for value: waf
            /// </summary>
            [EnumMember(Value = "waf")]
            Waf = 2,

            /// <summary>
            /// Enum CellsConsole for value: cells_console
            /// </summary>
            [EnumMember(Value = "cells_console")]
            CellsConsole = 3,

            /// <summary>
            /// Enum RtmActivity for value: rtm_activity
            /// </summary>
            [EnumMember(Value = "rtm_activity")]
            RtmActivity = 4
        }


        /// <summary>
        /// Options:  * &#x60;http&#x60; - Edge Applications  * &#x60;waf&#x60; - WAF Events  * &#x60;cells_console&#x60; - Edge Functions  * &#x60;rtm_activity&#x60; - Activity History 
        /// </summary>
        /// <value>Options:  * &#x60;http&#x60; - Edge Applications  * &#x60;waf&#x60; - WAF Events  * &#x60;cells_console&#x60; - Edge Functions  * &#x60;rtm_activity&#x60; - Activity History </value>
        [DataMember(Name = "data_source", EmitDefaultValue = false)]
        public DataSourceEnum? DataSource { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostDataStreamingResponse" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="templateId">Options:  * &#x60;2&#x60; - Edge Applications Event Collector  * &#x60;4&#x60; - WAF Event Collector  * &#x60;86&#x60; - Edge Functions Event Collector  * &#x60;184&#x60; - Edge Applications + WAF Event Collector  * &#x60;251&#x60; - Activity History Collector .</param>
        /// <param name="dataSource">Options:  * &#x60;http&#x60; - Edge Applications  * &#x60;waf&#x60; - WAF Events  * &#x60;cells_console&#x60; - Edge Functions  * &#x60;rtm_activity&#x60; - Activity History .</param>
        /// <param name="active">active.</param>
        /// <param name="endpoint">endpoint.</param>
        /// <param name="allDomains">Note:  * Field not used with the rtm_activity data source. .</param>
        public PostDataStreamingResponse(int id = default(int), string name = default(string), TemplateIdEnum? templateId = default(TemplateIdEnum?), DataSourceEnum? dataSource = default(DataSourceEnum?), bool active = default(bool), List<PostDataStreamingResponseEndpointInner> endpoint = default(List<PostDataStreamingResponseEndpointInner>), bool? allDomains = default(bool?))
        {
            this.Id = id;
            this.Name = name;
            this.TemplateId = templateId;
            this.DataSource = dataSource;
            this.Active = active;
            this.Endpoint = endpoint;
            this.AllDomains = allDomains;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets Endpoint
        /// </summary>
        [DataMember(Name = "endpoint", EmitDefaultValue = false)]
        public List<PostDataStreamingResponseEndpointInner> Endpoint { get; set; }

        /// <summary>
        /// Note:  * Field not used with the rtm_activity data source. 
        /// </summary>
        /// <value>Note:  * Field not used with the rtm_activity data source. </value>
        [DataMember(Name = "all_domains", EmitDefaultValue = true)]
        public bool? AllDomains { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostDataStreamingResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  DataSource: ").Append(DataSource).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  AllDomains: ").Append(AllDomains).Append("\n");
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
            return this.Equals(input as PostDataStreamingResponse);
        }

        /// <summary>
        /// Returns true if PostDataStreamingResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PostDataStreamingResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostDataStreamingResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    this.TemplateId.Equals(input.TemplateId)
                ) && 
                (
                    this.DataSource == input.DataSource ||
                    this.DataSource.Equals(input.DataSource)
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Endpoint == input.Endpoint ||
                    this.Endpoint != null &&
                    input.Endpoint != null &&
                    this.Endpoint.SequenceEqual(input.Endpoint)
                ) && 
                (
                    this.AllDomains == input.AllDomains ||
                    (this.AllDomains != null &&
                    this.AllDomains.Equals(input.AllDomains))
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                hashCode = (hashCode * 59) + this.DataSource.GetHashCode();
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.Endpoint != null)
                {
                    hashCode = (hashCode * 59) + this.Endpoint.GetHashCode();
                }
                if (this.AllDomains != null)
                {
                    hashCode = (hashCode * 59) + this.AllDomains.GetHashCode();
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
