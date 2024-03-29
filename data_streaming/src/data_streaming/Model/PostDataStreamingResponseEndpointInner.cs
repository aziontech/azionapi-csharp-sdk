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
using System.Reflection;

namespace data_streaming.Model
{
    /// <summary>
    /// PostDataStreamingResponseEndpointInner
    /// </summary>
    [JsonConverter(typeof(PostDataStreamingResponseEndpointInnerJsonConverter))]
    [DataContract(Name = "PostDataStreamingResponse_endpoint_inner")]
    public partial class PostDataStreamingResponseEndpointInner : AbstractOpenAPISchema, IEquatable<PostDataStreamingResponseEndpointInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostDataStreamingResponseEndpointInner" /> class
        /// with the <see cref="EndpointDefault" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of EndpointDefault.</param>
        public PostDataStreamingResponseEndpointInner(EndpointDefault actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDataStreamingResponseEndpointInner" /> class
        /// with the <see cref="EndpointKafka" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of EndpointKafka.</param>
        public PostDataStreamingResponseEndpointInner(EndpointKafka actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDataStreamingResponseEndpointInner" /> class
        /// with the <see cref="EndpoinrtS3" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of EndpoinrtS3.</param>
        public PostDataStreamingResponseEndpointInner(EndpoinrtS3 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDataStreamingResponseEndpointInner" /> class
        /// with the <see cref="EndpointGoogleBigQuery" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of EndpointGoogleBigQuery.</param>
        public PostDataStreamingResponseEndpointInner(EndpointGoogleBigQuery actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDataStreamingResponseEndpointInner" /> class
        /// with the <see cref="EndpointElasticsearch" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of EndpointElasticsearch.</param>
        public PostDataStreamingResponseEndpointInner(EndpointElasticsearch actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDataStreamingResponseEndpointInner" /> class
        /// with the <see cref="EndpointAWSKinesisFirehose" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of EndpointAWSKinesisFirehose.</param>
        public PostDataStreamingResponseEndpointInner(EndpointAWSKinesisFirehose actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDataStreamingResponseEndpointInner" /> class
        /// with the <see cref="EndpointDatadog" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of EndpointDatadog.</param>
        public PostDataStreamingResponseEndpointInner(EndpointDatadog actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDataStreamingResponseEndpointInner" /> class
        /// with the <see cref="EndpointIBMQRadar" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of EndpointIBMQRadar.</param>
        public PostDataStreamingResponseEndpointInner(EndpointIBMQRadar actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDataStreamingResponseEndpointInner" /> class
        /// with the <see cref="EndpointAzureMonitor" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of EndpointAzureMonitor.</param>
        public PostDataStreamingResponseEndpointInner(EndpointAzureMonitor actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDataStreamingResponseEndpointInner" /> class
        /// with the <see cref="EndpointAzureBlobStorage" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of EndpointAzureBlobStorage.</param>
        public PostDataStreamingResponseEndpointInner(EndpointAzureBlobStorage actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDataStreamingResponseEndpointInner" /> class
        /// with the <see cref="EndpointSplunk" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of EndpointSplunk.</param>
        public PostDataStreamingResponseEndpointInner(EndpointSplunk actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(EndpoinrtS3))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(EndpointAWSKinesisFirehose))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(EndpointAzureBlobStorage))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(EndpointAzureMonitor))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(EndpointDatadog))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(EndpointDefault))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(EndpointElasticsearch))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(EndpointGoogleBigQuery))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(EndpointIBMQRadar))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(EndpointKafka))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(EndpointSplunk))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: EndpoinrtS3, EndpointAWSKinesisFirehose, EndpointAzureBlobStorage, EndpointAzureMonitor, EndpointDatadog, EndpointDefault, EndpointElasticsearch, EndpointGoogleBigQuery, EndpointIBMQRadar, EndpointKafka, EndpointSplunk");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `EndpointDefault`. If the actual instance is not `EndpointDefault`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of EndpointDefault</returns>
        public EndpointDefault GetEndpointDefault()
        {
            return (EndpointDefault)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `EndpointKafka`. If the actual instance is not `EndpointKafka`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of EndpointKafka</returns>
        public EndpointKafka GetEndpointKafka()
        {
            return (EndpointKafka)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `EndpoinrtS3`. If the actual instance is not `EndpoinrtS3`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of EndpoinrtS3</returns>
        public EndpoinrtS3 GetEndpoinrtS3()
        {
            return (EndpoinrtS3)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `EndpointGoogleBigQuery`. If the actual instance is not `EndpointGoogleBigQuery`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of EndpointGoogleBigQuery</returns>
        public EndpointGoogleBigQuery GetEndpointGoogleBigQuery()
        {
            return (EndpointGoogleBigQuery)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `EndpointElasticsearch`. If the actual instance is not `EndpointElasticsearch`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of EndpointElasticsearch</returns>
        public EndpointElasticsearch GetEndpointElasticsearch()
        {
            return (EndpointElasticsearch)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `EndpointAWSKinesisFirehose`. If the actual instance is not `EndpointAWSKinesisFirehose`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of EndpointAWSKinesisFirehose</returns>
        public EndpointAWSKinesisFirehose GetEndpointAWSKinesisFirehose()
        {
            return (EndpointAWSKinesisFirehose)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `EndpointDatadog`. If the actual instance is not `EndpointDatadog`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of EndpointDatadog</returns>
        public EndpointDatadog GetEndpointDatadog()
        {
            return (EndpointDatadog)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `EndpointIBMQRadar`. If the actual instance is not `EndpointIBMQRadar`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of EndpointIBMQRadar</returns>
        public EndpointIBMQRadar GetEndpointIBMQRadar()
        {
            return (EndpointIBMQRadar)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `EndpointAzureMonitor`. If the actual instance is not `EndpointAzureMonitor`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of EndpointAzureMonitor</returns>
        public EndpointAzureMonitor GetEndpointAzureMonitor()
        {
            return (EndpointAzureMonitor)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `EndpointAzureBlobStorage`. If the actual instance is not `EndpointAzureBlobStorage`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of EndpointAzureBlobStorage</returns>
        public EndpointAzureBlobStorage GetEndpointAzureBlobStorage()
        {
            return (EndpointAzureBlobStorage)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `EndpointSplunk`. If the actual instance is not `EndpointSplunk`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of EndpointSplunk</returns>
        public EndpointSplunk GetEndpointSplunk()
        {
            return (EndpointSplunk)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostDataStreamingResponseEndpointInner {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, PostDataStreamingResponseEndpointInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of PostDataStreamingResponseEndpointInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of PostDataStreamingResponseEndpointInner</returns>
        public static PostDataStreamingResponseEndpointInner FromJson(string jsonString)
        {
            PostDataStreamingResponseEndpointInner newPostDataStreamingResponseEndpointInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newPostDataStreamingResponseEndpointInner;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(EndpoinrtS3).GetProperty("AdditionalProperties") == null)
                {
                    newPostDataStreamingResponseEndpointInner = new PostDataStreamingResponseEndpointInner(JsonConvert.DeserializeObject<EndpoinrtS3>(jsonString, PostDataStreamingResponseEndpointInner.SerializerSettings));
                }
                else
                {
                    newPostDataStreamingResponseEndpointInner = new PostDataStreamingResponseEndpointInner(JsonConvert.DeserializeObject<EndpoinrtS3>(jsonString, PostDataStreamingResponseEndpointInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("EndpoinrtS3");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into EndpoinrtS3: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(EndpointAWSKinesisFirehose).GetProperty("AdditionalProperties") == null)
                {
                    newPostDataStreamingResponseEndpointInner = new PostDataStreamingResponseEndpointInner(JsonConvert.DeserializeObject<EndpointAWSKinesisFirehose>(jsonString, PostDataStreamingResponseEndpointInner.SerializerSettings));
                }
                else
                {
                    newPostDataStreamingResponseEndpointInner = new PostDataStreamingResponseEndpointInner(JsonConvert.DeserializeObject<EndpointAWSKinesisFirehose>(jsonString, PostDataStreamingResponseEndpointInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("EndpointAWSKinesisFirehose");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into EndpointAWSKinesisFirehose: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(EndpointAzureBlobStorage).GetProperty("AdditionalProperties") == null)
                {
                    newPostDataStreamingResponseEndpointInner = new PostDataStreamingResponseEndpointInner(JsonConvert.DeserializeObject<EndpointAzureBlobStorage>(jsonString, PostDataStreamingResponseEndpointInner.SerializerSettings));
                }
                else
                {
                    newPostDataStreamingResponseEndpointInner = new PostDataStreamingResponseEndpointInner(JsonConvert.DeserializeObject<EndpointAzureBlobStorage>(jsonString, PostDataStreamingResponseEndpointInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("EndpointAzureBlobStorage");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into EndpointAzureBlobStorage: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(EndpointAzureMonitor).GetProperty("AdditionalProperties") == null)
                {
                    newPostDataStreamingResponseEndpointInner = new PostDataStreamingResponseEndpointInner(JsonConvert.DeserializeObject<EndpointAzureMonitor>(jsonString, PostDataStreamingResponseEndpointInner.SerializerSettings));
                }
                else
                {
                    newPostDataStreamingResponseEndpointInner = new PostDataStreamingResponseEndpointInner(JsonConvert.DeserializeObject<EndpointAzureMonitor>(jsonString, PostDataStreamingResponseEndpointInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("EndpointAzureMonitor");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into EndpointAzureMonitor: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(EndpointDatadog).GetProperty("AdditionalProperties") == null)
                {
                    newPostDataStreamingResponseEndpointInner = new PostDataStreamingResponseEndpointInner(JsonConvert.DeserializeObject<EndpointDatadog>(jsonString, PostDataStreamingResponseEndpointInner.SerializerSettings));
                }
                else
                {
                    newPostDataStreamingResponseEndpointInner = new PostDataStreamingResponseEndpointInner(JsonConvert.DeserializeObject<EndpointDatadog>(jsonString, PostDataStreamingResponseEndpointInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("EndpointDatadog");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into EndpointDatadog: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(EndpointDefault).GetProperty("AdditionalProperties") == null)
                {
                    newPostDataStreamingResponseEndpointInner = new PostDataStreamingResponseEndpointInner(JsonConvert.DeserializeObject<EndpointDefault>(jsonString, PostDataStreamingResponseEndpointInner.SerializerSettings));
                }
                else
                {
                    newPostDataStreamingResponseEndpointInner = new PostDataStreamingResponseEndpointInner(JsonConvert.DeserializeObject<EndpointDefault>(jsonString, PostDataStreamingResponseEndpointInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("EndpointDefault");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into EndpointDefault: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(EndpointElasticsearch).GetProperty("AdditionalProperties") == null)
                {
                    newPostDataStreamingResponseEndpointInner = new PostDataStreamingResponseEndpointInner(JsonConvert.DeserializeObject<EndpointElasticsearch>(jsonString, PostDataStreamingResponseEndpointInner.SerializerSettings));
                }
                else
                {
                    newPostDataStreamingResponseEndpointInner = new PostDataStreamingResponseEndpointInner(JsonConvert.DeserializeObject<EndpointElasticsearch>(jsonString, PostDataStreamingResponseEndpointInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("EndpointElasticsearch");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into EndpointElasticsearch: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(EndpointGoogleBigQuery).GetProperty("AdditionalProperties") == null)
                {
                    newPostDataStreamingResponseEndpointInner = new PostDataStreamingResponseEndpointInner(JsonConvert.DeserializeObject<EndpointGoogleBigQuery>(jsonString, PostDataStreamingResponseEndpointInner.SerializerSettings));
                }
                else
                {
                    newPostDataStreamingResponseEndpointInner = new PostDataStreamingResponseEndpointInner(JsonConvert.DeserializeObject<EndpointGoogleBigQuery>(jsonString, PostDataStreamingResponseEndpointInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("EndpointGoogleBigQuery");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into EndpointGoogleBigQuery: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(EndpointIBMQRadar).GetProperty("AdditionalProperties") == null)
                {
                    newPostDataStreamingResponseEndpointInner = new PostDataStreamingResponseEndpointInner(JsonConvert.DeserializeObject<EndpointIBMQRadar>(jsonString, PostDataStreamingResponseEndpointInner.SerializerSettings));
                }
                else
                {
                    newPostDataStreamingResponseEndpointInner = new PostDataStreamingResponseEndpointInner(JsonConvert.DeserializeObject<EndpointIBMQRadar>(jsonString, PostDataStreamingResponseEndpointInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("EndpointIBMQRadar");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into EndpointIBMQRadar: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(EndpointKafka).GetProperty("AdditionalProperties") == null)
                {
                    newPostDataStreamingResponseEndpointInner = new PostDataStreamingResponseEndpointInner(JsonConvert.DeserializeObject<EndpointKafka>(jsonString, PostDataStreamingResponseEndpointInner.SerializerSettings));
                }
                else
                {
                    newPostDataStreamingResponseEndpointInner = new PostDataStreamingResponseEndpointInner(JsonConvert.DeserializeObject<EndpointKafka>(jsonString, PostDataStreamingResponseEndpointInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("EndpointKafka");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into EndpointKafka: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(EndpointSplunk).GetProperty("AdditionalProperties") == null)
                {
                    newPostDataStreamingResponseEndpointInner = new PostDataStreamingResponseEndpointInner(JsonConvert.DeserializeObject<EndpointSplunk>(jsonString, PostDataStreamingResponseEndpointInner.SerializerSettings));
                }
                else
                {
                    newPostDataStreamingResponseEndpointInner = new PostDataStreamingResponseEndpointInner(JsonConvert.DeserializeObject<EndpointSplunk>(jsonString, PostDataStreamingResponseEndpointInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("EndpointSplunk");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into EndpointSplunk: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newPostDataStreamingResponseEndpointInner;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostDataStreamingResponseEndpointInner);
        }

        /// <summary>
        /// Returns true if PostDataStreamingResponseEndpointInner instances are equal
        /// </summary>
        /// <param name="input">Instance of PostDataStreamingResponseEndpointInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostDataStreamingResponseEndpointInner input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for PostDataStreamingResponseEndpointInner
    /// </summary>
    public class PostDataStreamingResponseEndpointInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(PostDataStreamingResponseEndpointInner).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return PostDataStreamingResponseEndpointInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
