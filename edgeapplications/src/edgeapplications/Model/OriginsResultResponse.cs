/*
 * Edge Application
 *
 * ## Welcome to the Azion API!  With the following APIs you can check, remove or update existing settings, besides creating new ones.  * * *  ## Overview  The Azion API is a RESTful API, based on HTTPS requests, that allows you to integrate your systems with our platform, simply, quickly, and securely.  Here you will find instructions on how our API works and what functionality is available.  This documentation is being constantly updated. Make sure you verify if there are any updates or changes before you perform any development in your application, even if you are familiar with our API.  * * *  Both HTTPS requests and responses must be in JavaScript Object Notation (JSON) format. All HTTPS requests and responses must follow these conventions.  **Base URL**  The base URL of the API, which must be used, is:  [**https://api.azionapi.net/_**](https://api.azionapi.net/)  **HTTP Methods**  Each HTTP method defines the type of operation that will be run.  | HTTP Method | CRUD | Whole Collection (e.g. /items) | Specific Item (e.g. /items/:item_id) | | - -- | - -- | - -- | - -- | | GET | Read | It retrieves the list of items in a Collection. | It retrieves a specific item in a Collection. | | POST | Create | It creates a new item in the Collection. | \\- | | PUT | Update/Replace | It replaces a whole Collection with a new one. | It replaces an item in a Collection with a new one. | | PATCH | Update/Modify | It partially updates a Collection. | It partially updates an item in a Collection | | DELETE | Delete | It deletes a whole Collection. | It deletes an item in a Collection. |  * * *  **Status Codes**  The HTTP return code defines the status – successful or not – after the requested operation is run.  | Status Code | Meaning | | - -- | - -- | | 200 OK | General Status for a successful operation. | | 201 CREATED | Successfully created a collection or item, by means of POST or PUT. | | 204 NO CONTENT | Successful operation, but without any content to be return to the Body. Generally used for DELETE or PUT operations. | | 207 MULTI-STATUS | A batch of operations were triggered by a single request, which resulted in different return codes when it was run, for some of the operations. The codes are displayed in the “status” field, in the body of the response, for each sub-batch of operations for whichever are applicable. | | 400 BAD REQUEST | Request error, such as invalid parameters, missing mandatory parameters or others. | | 401 UNAUTHORIZED | Error caused by a missing HTTP Authentication header. | | 403 FORBIDDEN | User does not have the permissions to run the requested operation. | | 404 NOT FOUND | The requested resource does not exist. | | 405 METHOD NOT ALLOWED | The requested method is not applicable with the URL. | | 406 NOT ACCEPTABLE | Accept header missing from the HTTP request or the header contains formatting or the version is not supported by the API. | | 409 CONFLICT | Conflict generated in running the request, such as a request to create an already existing record. | | 429 TOO MANY REQUESTS | The request was temporarily rejected, due to exceeding the limit on operations. Wait for the time defined in the X-Ratelimit-Reset header and try again. | | 500 INTERNAL SERVER ERROR | Unintentional error, due to an unidentified failure in the request process. | | \\- -- |  | | **HTTP Headers** |  |  All requests must be generated with the HTTP header specifying the desired code format for responses and the API version used. The current version of the API is 3 and the format is application/json.  ``` Accept: application/json; version=3  ```  * * *  **Rate Limit**  The limit of operations that can be run via the API is defined by 3 HTTP response headers:  *   **X-ratelimit-limit:** number of operations allowed in one time-frame; *   **X-ratelimit-remaining:** number of operations still available in one time-frame; *   **X-ratelimit-reset:** is the date and time, in IOS 8601 format, which represents the point in the future when the time-frame will be closed and when the limits will, therefore, be reset.       Example of HTTP response headers and a request:  ``` Date: Thu, 02 Nov 2017 12:30:28 GMT X-ratelimit-remaining: 199 X-ratelimit-limit: 200 X-ratelimit-reset: 2017-11-02T12:31:28.675446  ```  In the example provided, 200 operations are allowed within a 1-minute time frame. Of those, there are 199 still available, because one has already been run. The total limit will be reset after 1 minute.  When the X-ratelimit-limit is reached, or in other words, when the X-ratelimit-remaining reaches zero, the API will give the error, HTTP 429 TOO MANY REQUESTS. If your application receives this error, you will need to wait until the time defined in X-ratelimit-reset has passed, to make another request.  *   **X-ratelimit-limit by product**       The *X-ratelimit limit* variations by product are the following:  *   **Real-Time Metrics:** 20 requests per minute. *   **Real-Time Purge:** 200 requests per minute; except for the Wildcard, which is 2000 a day.       > The rate-limit values are based on the client_id.  * * *  **Optional Parameters**  In this version, it is possible to include some optional parameters as part of the GET method, which can help and modify the form in which your data will be returned.  You can combine these parameters to get the result you want.  They are:  | Parameter | Description | Accepted values: | | - -- | - -- | - -- | | order_by | Identifies which field the return should be sorted by. The default ordering is ascending. | Depends on the fields available from the endpoint structure | | sort | Defines which ordering to be used: ascending or descending. | asc  <br>  <br>desc | | page | Identifies which page should be returned, if the return is paginated. The default value is 1. | Page number. | | page_size | Identifies how many items should be returned per page. The default value is 10. | Desired number of items. |  * * *  **Request Exemple**  You can use one parameter, or a combination. See the example below, which uses all of them in the same request.  ``` GET /domains?order_by=name&page_size=20&sort=desc&page=3 Accept: application/json; version=3 Authorization: token 2909f3932069047f4736dc87e72baaddd19c9f75  ```  * * *  # Authentication  Authentication and authorization of operations via Azion API is done through Tokens.  The first step is to create the Token through authenticating a user registered in [Real-Time Manager](https://sso.azion.com/login).  * * *  ## Encoding Username and Password in Base64  Only token creation and cancelling operations are performed through Basic Authentication, that is, with a username and password. You can create and cancel the token through the API itself, but for that you need to encode your username and password in base64.  Base64 encoding can be done from the command line on a Unix terminal:  ``` $ echo 'user@domain:password'|base64 dXNlckBkb21haW46cGFzc3dvcmQK  ```  If you do not have a Unix terminal available, you can use the free online service at [https://www.base64encode.org/](https://www.base64encode.org/)
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
using OpenAPIDateConverter = edgeapplications.Client.OpenAPIDateConverter;

namespace edgeapplications.Model
{
    /// <summary>
    /// OriginsResultResponse
    /// </summary>
    [DataContract(Name = "OriginsResultResponse")]
    public partial class OriginsResultResponse : IEquatable<OriginsResultResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OriginsResultResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OriginsResultResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OriginsResultResponse" /> class.
        /// </summary>
        /// <param name="originId">originId (required).</param>
        /// <param name="originKey">originKey (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="originType">originType (required).</param>
        /// <param name="addresses">addresses (required).</param>
        /// <param name="originProtocolPolicy">originProtocolPolicy (required).</param>
        /// <param name="isOriginRedirectionEnabled">isOriginRedirectionEnabled (required).</param>
        /// <param name="hostHeader">hostHeader (required).</param>
        /// <param name="method">method (required).</param>
        /// <param name="originPath">originPath (required).</param>
        /// <param name="connectionTimeout">connectionTimeout (required).</param>
        /// <param name="timeoutBetweenBytes">timeoutBetweenBytes (required).</param>
        /// <param name="hmacAuthentication">hmacAuthentication (required).</param>
        /// <param name="hmacRegionName">hmacRegionName (required).</param>
        /// <param name="hmacAccessKey">hmacAccessKey (required).</param>
        /// <param name="hmacSecretKey">hmacSecretKey (required).</param>
        public OriginsResultResponse(long originId = default(long), string originKey = default(string), string name = default(string), string originType = default(string), List<OriginsResultResponseAddresses> addresses = default(List<OriginsResultResponseAddresses>), string originProtocolPolicy = default(string), bool isOriginRedirectionEnabled = default(bool), string hostHeader = default(string), string method = default(string), string originPath = default(string), long connectionTimeout = default(long), long timeoutBetweenBytes = default(long), bool hmacAuthentication = default(bool), string hmacRegionName = default(string), string hmacAccessKey = default(string), string hmacSecretKey = default(string))
        {
            this.OriginId = originId;
            // to ensure "originKey" is required (not null)
            if (originKey == null)
            {
                throw new ArgumentNullException("originKey is a required property for OriginsResultResponse and cannot be null");
            }
            this.OriginKey = originKey;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for OriginsResultResponse and cannot be null");
            }
            this.Name = name;
            // to ensure "originType" is required (not null)
            if (originType == null)
            {
                throw new ArgumentNullException("originType is a required property for OriginsResultResponse and cannot be null");
            }
            this.OriginType = originType;
            // to ensure "addresses" is required (not null)
            if (addresses == null)
            {
                throw new ArgumentNullException("addresses is a required property for OriginsResultResponse and cannot be null");
            }
            this.Addresses = addresses;
            // to ensure "originProtocolPolicy" is required (not null)
            if (originProtocolPolicy == null)
            {
                throw new ArgumentNullException("originProtocolPolicy is a required property for OriginsResultResponse and cannot be null");
            }
            this.OriginProtocolPolicy = originProtocolPolicy;
            this.IsOriginRedirectionEnabled = isOriginRedirectionEnabled;
            // to ensure "hostHeader" is required (not null)
            if (hostHeader == null)
            {
                throw new ArgumentNullException("hostHeader is a required property for OriginsResultResponse and cannot be null");
            }
            this.HostHeader = hostHeader;
            // to ensure "method" is required (not null)
            if (method == null)
            {
                throw new ArgumentNullException("method is a required property for OriginsResultResponse and cannot be null");
            }
            this.Method = method;
            // to ensure "originPath" is required (not null)
            if (originPath == null)
            {
                throw new ArgumentNullException("originPath is a required property for OriginsResultResponse and cannot be null");
            }
            this.OriginPath = originPath;
            this.ConnectionTimeout = connectionTimeout;
            this.TimeoutBetweenBytes = timeoutBetweenBytes;
            this.HmacAuthentication = hmacAuthentication;
            // to ensure "hmacRegionName" is required (not null)
            if (hmacRegionName == null)
            {
                throw new ArgumentNullException("hmacRegionName is a required property for OriginsResultResponse and cannot be null");
            }
            this.HmacRegionName = hmacRegionName;
            // to ensure "hmacAccessKey" is required (not null)
            if (hmacAccessKey == null)
            {
                throw new ArgumentNullException("hmacAccessKey is a required property for OriginsResultResponse and cannot be null");
            }
            this.HmacAccessKey = hmacAccessKey;
            // to ensure "hmacSecretKey" is required (not null)
            if (hmacSecretKey == null)
            {
                throw new ArgumentNullException("hmacSecretKey is a required property for OriginsResultResponse and cannot be null");
            }
            this.HmacSecretKey = hmacSecretKey;
        }

        /// <summary>
        /// Gets or Sets OriginId
        /// </summary>
        [DataMember(Name = "origin_id", IsRequired = true, EmitDefaultValue = true)]
        public long OriginId { get; set; }

        /// <summary>
        /// Gets or Sets OriginKey
        /// </summary>
        [DataMember(Name = "origin_key", IsRequired = true, EmitDefaultValue = true)]
        public string OriginKey { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OriginType
        /// </summary>
        [DataMember(Name = "origin_type", IsRequired = true, EmitDefaultValue = true)]
        public string OriginType { get; set; }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name = "addresses", IsRequired = true, EmitDefaultValue = true)]
        public List<OriginsResultResponseAddresses> Addresses { get; set; }

        /// <summary>
        /// Gets or Sets OriginProtocolPolicy
        /// </summary>
        [DataMember(Name = "origin_protocol_policy", IsRequired = true, EmitDefaultValue = true)]
        public string OriginProtocolPolicy { get; set; }

        /// <summary>
        /// Gets or Sets IsOriginRedirectionEnabled
        /// </summary>
        [DataMember(Name = "is_origin_redirection_enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool IsOriginRedirectionEnabled { get; set; }

        /// <summary>
        /// Gets or Sets HostHeader
        /// </summary>
        [DataMember(Name = "host_header", IsRequired = true, EmitDefaultValue = true)]
        public string HostHeader { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = true)]
        public string Method { get; set; }

        /// <summary>
        /// Gets or Sets OriginPath
        /// </summary>
        [DataMember(Name = "origin_path", IsRequired = true, EmitDefaultValue = true)]
        public string OriginPath { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionTimeout
        /// </summary>
        [DataMember(Name = "connection_timeout", IsRequired = true, EmitDefaultValue = true)]
        public long ConnectionTimeout { get; set; }

        /// <summary>
        /// Gets or Sets TimeoutBetweenBytes
        /// </summary>
        [DataMember(Name = "timeout_between_bytes", IsRequired = true, EmitDefaultValue = true)]
        public long TimeoutBetweenBytes { get; set; }

        /// <summary>
        /// Gets or Sets HmacAuthentication
        /// </summary>
        [DataMember(Name = "hmac_authentication", IsRequired = true, EmitDefaultValue = true)]
        public bool HmacAuthentication { get; set; }

        /// <summary>
        /// Gets or Sets HmacRegionName
        /// </summary>
        [DataMember(Name = "hmac_region_name", IsRequired = true, EmitDefaultValue = true)]
        public string HmacRegionName { get; set; }

        /// <summary>
        /// Gets or Sets HmacAccessKey
        /// </summary>
        [DataMember(Name = "hmac_access_key", IsRequired = true, EmitDefaultValue = true)]
        public string HmacAccessKey { get; set; }

        /// <summary>
        /// Gets or Sets HmacSecretKey
        /// </summary>
        [DataMember(Name = "hmac_secret_key", IsRequired = true, EmitDefaultValue = true)]
        public string HmacSecretKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OriginsResultResponse {\n");
            sb.Append("  OriginId: ").Append(OriginId).Append("\n");
            sb.Append("  OriginKey: ").Append(OriginKey).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OriginType: ").Append(OriginType).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  OriginProtocolPolicy: ").Append(OriginProtocolPolicy).Append("\n");
            sb.Append("  IsOriginRedirectionEnabled: ").Append(IsOriginRedirectionEnabled).Append("\n");
            sb.Append("  HostHeader: ").Append(HostHeader).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  OriginPath: ").Append(OriginPath).Append("\n");
            sb.Append("  ConnectionTimeout: ").Append(ConnectionTimeout).Append("\n");
            sb.Append("  TimeoutBetweenBytes: ").Append(TimeoutBetweenBytes).Append("\n");
            sb.Append("  HmacAuthentication: ").Append(HmacAuthentication).Append("\n");
            sb.Append("  HmacRegionName: ").Append(HmacRegionName).Append("\n");
            sb.Append("  HmacAccessKey: ").Append(HmacAccessKey).Append("\n");
            sb.Append("  HmacSecretKey: ").Append(HmacSecretKey).Append("\n");
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
            return this.Equals(input as OriginsResultResponse);
        }

        /// <summary>
        /// Returns true if OriginsResultResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OriginsResultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OriginsResultResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OriginId == input.OriginId ||
                    this.OriginId.Equals(input.OriginId)
                ) && 
                (
                    this.OriginKey == input.OriginKey ||
                    (this.OriginKey != null &&
                    this.OriginKey.Equals(input.OriginKey))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OriginType == input.OriginType ||
                    (this.OriginType != null &&
                    this.OriginType.Equals(input.OriginType))
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.OriginProtocolPolicy == input.OriginProtocolPolicy ||
                    (this.OriginProtocolPolicy != null &&
                    this.OriginProtocolPolicy.Equals(input.OriginProtocolPolicy))
                ) && 
                (
                    this.IsOriginRedirectionEnabled == input.IsOriginRedirectionEnabled ||
                    this.IsOriginRedirectionEnabled.Equals(input.IsOriginRedirectionEnabled)
                ) && 
                (
                    this.HostHeader == input.HostHeader ||
                    (this.HostHeader != null &&
                    this.HostHeader.Equals(input.HostHeader))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.OriginPath == input.OriginPath ||
                    (this.OriginPath != null &&
                    this.OriginPath.Equals(input.OriginPath))
                ) && 
                (
                    this.ConnectionTimeout == input.ConnectionTimeout ||
                    this.ConnectionTimeout.Equals(input.ConnectionTimeout)
                ) && 
                (
                    this.TimeoutBetweenBytes == input.TimeoutBetweenBytes ||
                    this.TimeoutBetweenBytes.Equals(input.TimeoutBetweenBytes)
                ) && 
                (
                    this.HmacAuthentication == input.HmacAuthentication ||
                    this.HmacAuthentication.Equals(input.HmacAuthentication)
                ) && 
                (
                    this.HmacRegionName == input.HmacRegionName ||
                    (this.HmacRegionName != null &&
                    this.HmacRegionName.Equals(input.HmacRegionName))
                ) && 
                (
                    this.HmacAccessKey == input.HmacAccessKey ||
                    (this.HmacAccessKey != null &&
                    this.HmacAccessKey.Equals(input.HmacAccessKey))
                ) && 
                (
                    this.HmacSecretKey == input.HmacSecretKey ||
                    (this.HmacSecretKey != null &&
                    this.HmacSecretKey.Equals(input.HmacSecretKey))
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
                hashCode = (hashCode * 59) + this.OriginId.GetHashCode();
                if (this.OriginKey != null)
                {
                    hashCode = (hashCode * 59) + this.OriginKey.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.OriginType != null)
                {
                    hashCode = (hashCode * 59) + this.OriginType.GetHashCode();
                }
                if (this.Addresses != null)
                {
                    hashCode = (hashCode * 59) + this.Addresses.GetHashCode();
                }
                if (this.OriginProtocolPolicy != null)
                {
                    hashCode = (hashCode * 59) + this.OriginProtocolPolicy.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsOriginRedirectionEnabled.GetHashCode();
                if (this.HostHeader != null)
                {
                    hashCode = (hashCode * 59) + this.HostHeader.GetHashCode();
                }
                if (this.Method != null)
                {
                    hashCode = (hashCode * 59) + this.Method.GetHashCode();
                }
                if (this.OriginPath != null)
                {
                    hashCode = (hashCode * 59) + this.OriginPath.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ConnectionTimeout.GetHashCode();
                hashCode = (hashCode * 59) + this.TimeoutBetweenBytes.GetHashCode();
                hashCode = (hashCode * 59) + this.HmacAuthentication.GetHashCode();
                if (this.HmacRegionName != null)
                {
                    hashCode = (hashCode * 59) + this.HmacRegionName.GetHashCode();
                }
                if (this.HmacAccessKey != null)
                {
                    hashCode = (hashCode * 59) + this.HmacAccessKey.GetHashCode();
                }
                if (this.HmacSecretKey != null)
                {
                    hashCode = (hashCode * 59) + this.HmacSecretKey.GetHashCode();
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
