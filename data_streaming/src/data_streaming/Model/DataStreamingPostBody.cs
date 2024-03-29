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
    /// DataStreamingPostBody
    /// </summary>
    [DataContract(Name = "DataStreamingPostBody")]
    public partial class DataStreamingPostBody : IEquatable<DataStreamingPostBody>, IValidatableObject
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
        /// Options:  * &#x60;http&#x60; - Edge Applications (default)  * &#x60;waf&#x60; - WAF Events  * &#x60;cells_console&#x60; - Edge Functions  * &#x60;rtm_activity&#x60; - Activity History 
        /// </summary>
        /// <value>Options:  * &#x60;http&#x60; - Edge Applications (default)  * &#x60;waf&#x60; - WAF Events  * &#x60;cells_console&#x60; - Edge Functions  * &#x60;rtm_activity&#x60; - Activity History </value>
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
        /// Options:  * &#x60;http&#x60; - Edge Applications (default)  * &#x60;waf&#x60; - WAF Events  * &#x60;cells_console&#x60; - Edge Functions  * &#x60;rtm_activity&#x60; - Activity History 
        /// </summary>
        /// <value>Options:  * &#x60;http&#x60; - Edge Applications (default)  * &#x60;waf&#x60; - WAF Events  * &#x60;cells_console&#x60; - Edge Functions  * &#x60;rtm_activity&#x60; - Activity History </value>
        [DataMember(Name = "data_source", EmitDefaultValue = true)]
        public DataSourceEnum? DataSource { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataStreamingPostBody" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="templateId">Options:  * &#x60;2&#x60; - Edge Applications Event Collector  * &#x60;4&#x60; - WAF Event Collector  * &#x60;86&#x60; - Edge Functions Event Collector  * &#x60;184&#x60; - Edge Applications + WAF Event Collector  * &#x60;251&#x60; - Activity History Collector .</param>
        /// <param name="dataSource">Options:  * &#x60;http&#x60; - Edge Applications (default)  * &#x60;waf&#x60; - WAF Events  * &#x60;cells_console&#x60; - Edge Functions  * &#x60;rtm_activity&#x60; - Activity History .</param>
        /// <param name="active">active (default to true).</param>
        /// <param name="endpoint">Options&#39; examples:  - &#x60;Standard HTTP/HTTPS POST&#x60; - { \&quot;endpoint_type\&quot;: \&quot;standard\&quot;, \&quot;url\&quot;: \&quot;http://example.com\&quot;, \&quot;log_line_separator\&quot;: \&quot;\\n\&quot;, \&quot;payload_format\&quot;: \&quot;$dataset\&quot;, \&quot;max_size\&quot;: 1000024 }  - &#x60;Apache Kafka&#x60; - { \&quot;endpoint_type\&quot;: \&quot;kafka\&quot;, \&quot;kafka_topic\&quot;: \&quot;example_topic\&quot;, \&quot;bootstrap_servers\&quot;: \&quot;kafka-server.com:9092,kafka-server-2.com:9092\&quot;, \&quot;use_tls\&quot;:true }  - &#x60;Simple Storage Service (S3)&#x60; - { \&quot;endpoint_type\&quot;: \&quot;s3\&quot;, \&quot;access_key\&quot;: \&quot;MYACCESSKEY\&quot;, \&quot;region\&quot;: \&quot;us-east-1\&quot;, \&quot;object_key_prefix\&quot;: \&quot;my_prefix_\&quot;, \&quot;bucket_name\&quot;: \&quot;bucket_example\&quot;, \&quot;content_type\&quot;: \&quot;plain/text\&quot;, \&quot;host_url\&quot;: \&quot;http://aws-host.com\&quot;, \&quot;secret_key\&quot;: \&quot;MYSECRETKEY\&quot; }  - &#x60;Google BigQuery&#x60; - { \&quot;endpoint_type\&quot;: \&quot;big_query\&quot;, \&quot;dataset_id\&quot;: \&quot;my_dataset\&quot;, \&quot;project_id\&quot;: \&quot;my_project\&quot;, \&quot;table_id\&quot;: \&quot;my_table\&quot;, \&quot;service_account_key\&quot;: \&quot;{ \&quot;service_account_key\&quot;: \&quot;key_content\&quot; }\&quot; }  - &#x60;Elasticsearch&#x60; - { “endpoint_type”: \&quot;elasticsearch\&quot;, “url”: “http://elasticsearch.com”, “api_key”: “XYZ_API_KEY” }  - &#x60;AWS Kinesis Data Firehose&#x60; -  { \&quot;endpoint_type\&quot;: \&quot;aws_kinesis_firehose\&quot;, \&quot;access_key\&quot;: \&quot;MYACCESSKEY\&quot;, \&quot;stream_name\&quot;: \&quot;my_stream_name\&quot;, \&quot;region\&quot;: \&quot;us-east-1\&quot;, \&quot;secret_key\&quot;: \&quot;MYSECRETKEY\&quot; }  - &#x60;Datadog&#x60; - { \&quot;endpoint_type\&quot;: \&quot;datadog\&quot;, \&quot;url\&quot;: \&quot;https://http-intake.logs.datadoghq.com/v1/input\&quot;, \&quot;api_key\&quot;: \&quot;MYAPIKEY\&quot; }  - &#x60;IBM QRadar&#x60; - { \&quot;endpoint_type\&quot;: \&quot;qradar\&quot;, \&quot;url\&quot;: \&quot;http://137.15.824.10:14440” }  - &#x60;Azure Monitor&#x60; - { \&quot;endpoint_type\&quot;: \&quot;azure_monitor\&quot;, \&quot;log_type\&quot;: \&quot;myLogType\&quot;, \&quot;shared_key\&quot;: \&quot;mysharedkey\&quot;, \&quot;time_generated_field\&quot;: \&quot;timeGeneratedField\&quot;, \&quot;workspace_id\&quot;: \&quot;anfhw-123sd-466gcs\&quot;}  - &#x60;Azure Blob Storage&#x60; - { \&quot;endpoint_type\&quot;: \&quot;azure_blob_storage\&quot;, \&quot;storage_account\&quot;: \&quot;mystorageaccount\&quot;, \&quot;container_name\&quot;: \&quot;log_container\&quot;, \&quot;blob_sas_token\&quot;: \&quot;fd56e23e1f12efe\&quot; }  - &#x60;Splunk&#x60; - { \&quot;endpoint_type\&quot;: \&quot;splunk\&quot;, \&quot;url\&quot;: \&quot;https://inputs.splunk-client.splunkcloud.com:1337/services/collector\&quot;, \&quot;api_key\&quot;: \&quot;MYAPIKEY\&quot; } .</param>
        /// <param name="domainsIds">Note:  * Field not used with the rtm_activity data source. .</param>
        /// <param name="allDomains">Note:  * Field not used with the rtm_activity data source.  (default to false).</param>
        /// <param name="samplingPercentage">Note:  * &#x60;Range&#x60; - From 0 to 100.  * &#x60;To use:&#x60; [Contact the sales team](https://www.azion.com/en/contact-sales/) to activate this feature in your account. .</param>
        public DataStreamingPostBody(string name = default(string), TemplateIdEnum? templateId = default(TemplateIdEnum?), DataSourceEnum? dataSource = default(DataSourceEnum?), bool? active = true, string endpoint = default(string), List<int> domainsIds = default(List<int>), bool? allDomains = false, int? samplingPercentage = default(int?))
        {
            this.Name = name;
            this.TemplateId = templateId;
            this.DataSource = dataSource;
            // use default value if no "active" provided
            this.Active = active ?? true;
            this.Endpoint = endpoint;
            this.DomainsIds = domainsIds;
            // use default value if no "allDomains" provided
            this.AllDomains = allDomains ?? false;
            this.SamplingPercentage = samplingPercentage;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool? Active { get; set; }

        /// <summary>
        /// Options&#39; examples:  - &#x60;Standard HTTP/HTTPS POST&#x60; - { \&quot;endpoint_type\&quot;: \&quot;standard\&quot;, \&quot;url\&quot;: \&quot;http://example.com\&quot;, \&quot;log_line_separator\&quot;: \&quot;\\n\&quot;, \&quot;payload_format\&quot;: \&quot;$dataset\&quot;, \&quot;max_size\&quot;: 1000024 }  - &#x60;Apache Kafka&#x60; - { \&quot;endpoint_type\&quot;: \&quot;kafka\&quot;, \&quot;kafka_topic\&quot;: \&quot;example_topic\&quot;, \&quot;bootstrap_servers\&quot;: \&quot;kafka-server.com:9092,kafka-server-2.com:9092\&quot;, \&quot;use_tls\&quot;:true }  - &#x60;Simple Storage Service (S3)&#x60; - { \&quot;endpoint_type\&quot;: \&quot;s3\&quot;, \&quot;access_key\&quot;: \&quot;MYACCESSKEY\&quot;, \&quot;region\&quot;: \&quot;us-east-1\&quot;, \&quot;object_key_prefix\&quot;: \&quot;my_prefix_\&quot;, \&quot;bucket_name\&quot;: \&quot;bucket_example\&quot;, \&quot;content_type\&quot;: \&quot;plain/text\&quot;, \&quot;host_url\&quot;: \&quot;http://aws-host.com\&quot;, \&quot;secret_key\&quot;: \&quot;MYSECRETKEY\&quot; }  - &#x60;Google BigQuery&#x60; - { \&quot;endpoint_type\&quot;: \&quot;big_query\&quot;, \&quot;dataset_id\&quot;: \&quot;my_dataset\&quot;, \&quot;project_id\&quot;: \&quot;my_project\&quot;, \&quot;table_id\&quot;: \&quot;my_table\&quot;, \&quot;service_account_key\&quot;: \&quot;{ \&quot;service_account_key\&quot;: \&quot;key_content\&quot; }\&quot; }  - &#x60;Elasticsearch&#x60; - { “endpoint_type”: \&quot;elasticsearch\&quot;, “url”: “http://elasticsearch.com”, “api_key”: “XYZ_API_KEY” }  - &#x60;AWS Kinesis Data Firehose&#x60; -  { \&quot;endpoint_type\&quot;: \&quot;aws_kinesis_firehose\&quot;, \&quot;access_key\&quot;: \&quot;MYACCESSKEY\&quot;, \&quot;stream_name\&quot;: \&quot;my_stream_name\&quot;, \&quot;region\&quot;: \&quot;us-east-1\&quot;, \&quot;secret_key\&quot;: \&quot;MYSECRETKEY\&quot; }  - &#x60;Datadog&#x60; - { \&quot;endpoint_type\&quot;: \&quot;datadog\&quot;, \&quot;url\&quot;: \&quot;https://http-intake.logs.datadoghq.com/v1/input\&quot;, \&quot;api_key\&quot;: \&quot;MYAPIKEY\&quot; }  - &#x60;IBM QRadar&#x60; - { \&quot;endpoint_type\&quot;: \&quot;qradar\&quot;, \&quot;url\&quot;: \&quot;http://137.15.824.10:14440” }  - &#x60;Azure Monitor&#x60; - { \&quot;endpoint_type\&quot;: \&quot;azure_monitor\&quot;, \&quot;log_type\&quot;: \&quot;myLogType\&quot;, \&quot;shared_key\&quot;: \&quot;mysharedkey\&quot;, \&quot;time_generated_field\&quot;: \&quot;timeGeneratedField\&quot;, \&quot;workspace_id\&quot;: \&quot;anfhw-123sd-466gcs\&quot;}  - &#x60;Azure Blob Storage&#x60; - { \&quot;endpoint_type\&quot;: \&quot;azure_blob_storage\&quot;, \&quot;storage_account\&quot;: \&quot;mystorageaccount\&quot;, \&quot;container_name\&quot;: \&quot;log_container\&quot;, \&quot;blob_sas_token\&quot;: \&quot;fd56e23e1f12efe\&quot; }  - &#x60;Splunk&#x60; - { \&quot;endpoint_type\&quot;: \&quot;splunk\&quot;, \&quot;url\&quot;: \&quot;https://inputs.splunk-client.splunkcloud.com:1337/services/collector\&quot;, \&quot;api_key\&quot;: \&quot;MYAPIKEY\&quot; } 
        /// </summary>
        /// <value>Options&#39; examples:  - &#x60;Standard HTTP/HTTPS POST&#x60; - { \&quot;endpoint_type\&quot;: \&quot;standard\&quot;, \&quot;url\&quot;: \&quot;http://example.com\&quot;, \&quot;log_line_separator\&quot;: \&quot;\\n\&quot;, \&quot;payload_format\&quot;: \&quot;$dataset\&quot;, \&quot;max_size\&quot;: 1000024 }  - &#x60;Apache Kafka&#x60; - { \&quot;endpoint_type\&quot;: \&quot;kafka\&quot;, \&quot;kafka_topic\&quot;: \&quot;example_topic\&quot;, \&quot;bootstrap_servers\&quot;: \&quot;kafka-server.com:9092,kafka-server-2.com:9092\&quot;, \&quot;use_tls\&quot;:true }  - &#x60;Simple Storage Service (S3)&#x60; - { \&quot;endpoint_type\&quot;: \&quot;s3\&quot;, \&quot;access_key\&quot;: \&quot;MYACCESSKEY\&quot;, \&quot;region\&quot;: \&quot;us-east-1\&quot;, \&quot;object_key_prefix\&quot;: \&quot;my_prefix_\&quot;, \&quot;bucket_name\&quot;: \&quot;bucket_example\&quot;, \&quot;content_type\&quot;: \&quot;plain/text\&quot;, \&quot;host_url\&quot;: \&quot;http://aws-host.com\&quot;, \&quot;secret_key\&quot;: \&quot;MYSECRETKEY\&quot; }  - &#x60;Google BigQuery&#x60; - { \&quot;endpoint_type\&quot;: \&quot;big_query\&quot;, \&quot;dataset_id\&quot;: \&quot;my_dataset\&quot;, \&quot;project_id\&quot;: \&quot;my_project\&quot;, \&quot;table_id\&quot;: \&quot;my_table\&quot;, \&quot;service_account_key\&quot;: \&quot;{ \&quot;service_account_key\&quot;: \&quot;key_content\&quot; }\&quot; }  - &#x60;Elasticsearch&#x60; - { “endpoint_type”: \&quot;elasticsearch\&quot;, “url”: “http://elasticsearch.com”, “api_key”: “XYZ_API_KEY” }  - &#x60;AWS Kinesis Data Firehose&#x60; -  { \&quot;endpoint_type\&quot;: \&quot;aws_kinesis_firehose\&quot;, \&quot;access_key\&quot;: \&quot;MYACCESSKEY\&quot;, \&quot;stream_name\&quot;: \&quot;my_stream_name\&quot;, \&quot;region\&quot;: \&quot;us-east-1\&quot;, \&quot;secret_key\&quot;: \&quot;MYSECRETKEY\&quot; }  - &#x60;Datadog&#x60; - { \&quot;endpoint_type\&quot;: \&quot;datadog\&quot;, \&quot;url\&quot;: \&quot;https://http-intake.logs.datadoghq.com/v1/input\&quot;, \&quot;api_key\&quot;: \&quot;MYAPIKEY\&quot; }  - &#x60;IBM QRadar&#x60; - { \&quot;endpoint_type\&quot;: \&quot;qradar\&quot;, \&quot;url\&quot;: \&quot;http://137.15.824.10:14440” }  - &#x60;Azure Monitor&#x60; - { \&quot;endpoint_type\&quot;: \&quot;azure_monitor\&quot;, \&quot;log_type\&quot;: \&quot;myLogType\&quot;, \&quot;shared_key\&quot;: \&quot;mysharedkey\&quot;, \&quot;time_generated_field\&quot;: \&quot;timeGeneratedField\&quot;, \&quot;workspace_id\&quot;: \&quot;anfhw-123sd-466gcs\&quot;}  - &#x60;Azure Blob Storage&#x60; - { \&quot;endpoint_type\&quot;: \&quot;azure_blob_storage\&quot;, \&quot;storage_account\&quot;: \&quot;mystorageaccount\&quot;, \&quot;container_name\&quot;: \&quot;log_container\&quot;, \&quot;blob_sas_token\&quot;: \&quot;fd56e23e1f12efe\&quot; }  - &#x60;Splunk&#x60; - { \&quot;endpoint_type\&quot;: \&quot;splunk\&quot;, \&quot;url\&quot;: \&quot;https://inputs.splunk-client.splunkcloud.com:1337/services/collector\&quot;, \&quot;api_key\&quot;: \&quot;MYAPIKEY\&quot; } </value>
        [DataMember(Name = "endpoint", EmitDefaultValue = false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Note:  * Field not used with the rtm_activity data source. 
        /// </summary>
        /// <value>Note:  * Field not used with the rtm_activity data source. </value>
        [DataMember(Name = "domains_ids", EmitDefaultValue = false)]
        public List<int> DomainsIds { get; set; }

        /// <summary>
        /// Note:  * Field not used with the rtm_activity data source. 
        /// </summary>
        /// <value>Note:  * Field not used with the rtm_activity data source. </value>
        [DataMember(Name = "all_domains", EmitDefaultValue = true)]
        public bool? AllDomains { get; set; }

        /// <summary>
        /// Note:  * &#x60;Range&#x60; - From 0 to 100.  * &#x60;To use:&#x60; [Contact the sales team](https://www.azion.com/en/contact-sales/) to activate this feature in your account. 
        /// </summary>
        /// <value>Note:  * &#x60;Range&#x60; - From 0 to 100.  * &#x60;To use:&#x60; [Contact the sales team](https://www.azion.com/en/contact-sales/) to activate this feature in your account. </value>
        [DataMember(Name = "sampling_percentage", EmitDefaultValue = true)]
        public int? SamplingPercentage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataStreamingPostBody {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  DataSource: ").Append(DataSource).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  DomainsIds: ").Append(DomainsIds).Append("\n");
            sb.Append("  AllDomains: ").Append(AllDomains).Append("\n");
            sb.Append("  SamplingPercentage: ").Append(SamplingPercentage).Append("\n");
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
            return this.Equals(input as DataStreamingPostBody);
        }

        /// <summary>
        /// Returns true if DataStreamingPostBody instances are equal
        /// </summary>
        /// <param name="input">Instance of DataStreamingPostBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataStreamingPostBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
                ) && 
                (
                    this.DomainsIds == input.DomainsIds ||
                    this.DomainsIds != null &&
                    input.DomainsIds != null &&
                    this.DomainsIds.SequenceEqual(input.DomainsIds)
                ) && 
                (
                    this.AllDomains == input.AllDomains ||
                    (this.AllDomains != null &&
                    this.AllDomains.Equals(input.AllDomains))
                ) && 
                (
                    this.SamplingPercentage == input.SamplingPercentage ||
                    (this.SamplingPercentage != null &&
                    this.SamplingPercentage.Equals(input.SamplingPercentage))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                hashCode = (hashCode * 59) + this.DataSource.GetHashCode();
                if (this.Active != null)
                {
                    hashCode = (hashCode * 59) + this.Active.GetHashCode();
                }
                if (this.Endpoint != null)
                {
                    hashCode = (hashCode * 59) + this.Endpoint.GetHashCode();
                }
                if (this.DomainsIds != null)
                {
                    hashCode = (hashCode * 59) + this.DomainsIds.GetHashCode();
                }
                if (this.AllDomains != null)
                {
                    hashCode = (hashCode * 59) + this.AllDomains.GetHashCode();
                }
                if (this.SamplingPercentage != null)
                {
                    hashCode = (hashCode * 59) + this.SamplingPercentage.GetHashCode();
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
            // SamplingPercentage (int?) maximum
            if (this.SamplingPercentage > (int?)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SamplingPercentage, must be a value less than or equal to 100.", new [] { "SamplingPercentage" });
            }

            // SamplingPercentage (int?) minimum
            if (this.SamplingPercentage < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SamplingPercentage, must be a value greater than or equal to 0.", new [] { "SamplingPercentage" });
            }

            yield break;
        }
    }

}
