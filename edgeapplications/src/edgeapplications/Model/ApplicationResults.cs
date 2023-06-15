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
    /// ApplicationResults
    /// </summary>
    [DataContract(Name = "ApplicationResults")]
    public partial class ApplicationResults : IEquatable<ApplicationResults>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationResults" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationResults() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationResults" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="active">active (required).</param>
        /// <param name="debugRules">debugRules (required).</param>
        /// <param name="http3">http3 (required).</param>
        /// <param name="supportedCiphers">supportedCiphers (required).</param>
        /// <param name="deliveryProtocol">deliveryProtocol (required).</param>
        /// <param name="httpPort">httpPort (required).</param>
        /// <param name="httpsPort">httpsPort (required).</param>
        /// <param name="minimumTlsVersion">minimumTlsVersion (required).</param>
        /// <param name="applicationAcceleration">applicationAcceleration (required).</param>
        /// <param name="caching">caching (required).</param>
        /// <param name="deviceDetection">deviceDetection (required).</param>
        /// <param name="edgeFirewall">edgeFirewall (required).</param>
        /// <param name="edgeFunctions">edgeFunctions (required).</param>
        /// <param name="imageOptimization">imageOptimization (required).</param>
        /// <param name="l2Caching">l2Caching (required).</param>
        /// <param name="loadBalancer">loadBalancer (required).</param>
        /// <param name="rawLogs">rawLogs (required).</param>
        /// <param name="webApplicationFirewall">webApplicationFirewall (required).</param>
        public ApplicationResults(long id = default(long), string name = default(string), bool active = default(bool), bool debugRules = default(bool), bool http3 = default(bool), string supportedCiphers = default(string), string deliveryProtocol = default(string), Object httpPort = default(Object), Object httpsPort = default(Object), string minimumTlsVersion = default(string), bool applicationAcceleration = default(bool), bool caching = default(bool), bool deviceDetection = default(bool), bool edgeFirewall = default(bool), bool edgeFunctions = default(bool), bool imageOptimization = default(bool), bool l2Caching = default(bool), bool loadBalancer = default(bool), bool rawLogs = default(bool), bool webApplicationFirewall = default(bool))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ApplicationResults and cannot be null");
            }
            this.Name = name;
            this.Active = active;
            this.DebugRules = debugRules;
            this.Http3 = http3;
            // to ensure "supportedCiphers" is required (not null)
            if (supportedCiphers == null)
            {
                throw new ArgumentNullException("supportedCiphers is a required property for ApplicationResults and cannot be null");
            }
            this.SupportedCiphers = supportedCiphers;
            // to ensure "deliveryProtocol" is required (not null)
            if (deliveryProtocol == null)
            {
                throw new ArgumentNullException("deliveryProtocol is a required property for ApplicationResults and cannot be null");
            }
            this.DeliveryProtocol = deliveryProtocol;
            // to ensure "httpPort" is required (not null)
            if (httpPort == null)
            {
                throw new ArgumentNullException("httpPort is a required property for ApplicationResults and cannot be null");
            }
            this.HttpPort = httpPort;
            // to ensure "httpsPort" is required (not null)
            if (httpsPort == null)
            {
                throw new ArgumentNullException("httpsPort is a required property for ApplicationResults and cannot be null");
            }
            this.HttpsPort = httpsPort;
            // to ensure "minimumTlsVersion" is required (not null)
            if (minimumTlsVersion == null)
            {
                throw new ArgumentNullException("minimumTlsVersion is a required property for ApplicationResults and cannot be null");
            }
            this.MinimumTlsVersion = minimumTlsVersion;
            this.ApplicationAcceleration = applicationAcceleration;
            this.Caching = caching;
            this.DeviceDetection = deviceDetection;
            this.EdgeFirewall = edgeFirewall;
            this.EdgeFunctions = edgeFunctions;
            this.ImageOptimization = imageOptimization;
            this.L2Caching = l2Caching;
            this.LoadBalancer = loadBalancer;
            this.RawLogs = rawLogs;
            this.WebApplicationFirewall = webApplicationFirewall;
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
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", IsRequired = true, EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets DebugRules
        /// </summary>
        [DataMember(Name = "debug_rules", IsRequired = true, EmitDefaultValue = true)]
        public bool DebugRules { get; set; }

        /// <summary>
        /// Gets or Sets Http3
        /// </summary>
        [DataMember(Name = "http3", IsRequired = true, EmitDefaultValue = true)]
        public bool Http3 { get; set; }

        /// <summary>
        /// Gets or Sets SupportedCiphers
        /// </summary>
        [DataMember(Name = "supported_ciphers", IsRequired = true, EmitDefaultValue = true)]
        public string SupportedCiphers { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryProtocol
        /// </summary>
        [DataMember(Name = "delivery_protocol", IsRequired = true, EmitDefaultValue = true)]
        public string DeliveryProtocol { get; set; }

        /// <summary>
        /// Gets or Sets HttpPort
        /// </summary>
        [DataMember(Name = "http_port", IsRequired = true, EmitDefaultValue = true)]
        public Object HttpPort { get; set; }

        /// <summary>
        /// Gets or Sets HttpsPort
        /// </summary>
        [DataMember(Name = "https_port", IsRequired = true, EmitDefaultValue = true)]
        public Object HttpsPort { get; set; }

        /// <summary>
        /// Gets or Sets MinimumTlsVersion
        /// </summary>
        [DataMember(Name = "minimum_tls_version", IsRequired = true, EmitDefaultValue = true)]
        public string MinimumTlsVersion { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationAcceleration
        /// </summary>
        [DataMember(Name = "application_acceleration", IsRequired = true, EmitDefaultValue = true)]
        public bool ApplicationAcceleration { get; set; }

        /// <summary>
        /// Gets or Sets Caching
        /// </summary>
        [DataMember(Name = "caching", IsRequired = true, EmitDefaultValue = true)]
        public bool Caching { get; set; }

        /// <summary>
        /// Gets or Sets DeviceDetection
        /// </summary>
        [DataMember(Name = "device_detection", IsRequired = true, EmitDefaultValue = true)]
        public bool DeviceDetection { get; set; }

        /// <summary>
        /// Gets or Sets EdgeFirewall
        /// </summary>
        [DataMember(Name = "edge_firewall", IsRequired = true, EmitDefaultValue = true)]
        public bool EdgeFirewall { get; set; }

        /// <summary>
        /// Gets or Sets EdgeFunctions
        /// </summary>
        [DataMember(Name = "edge_functions", IsRequired = true, EmitDefaultValue = true)]
        public bool EdgeFunctions { get; set; }

        /// <summary>
        /// Gets or Sets ImageOptimization
        /// </summary>
        [DataMember(Name = "image_optimization", IsRequired = true, EmitDefaultValue = true)]
        public bool ImageOptimization { get; set; }

        /// <summary>
        /// Gets or Sets L2Caching
        /// </summary>
        [DataMember(Name = "l2_caching", IsRequired = true, EmitDefaultValue = true)]
        public bool L2Caching { get; set; }

        /// <summary>
        /// Gets or Sets LoadBalancer
        /// </summary>
        [DataMember(Name = "load_balancer", IsRequired = true, EmitDefaultValue = true)]
        public bool LoadBalancer { get; set; }

        /// <summary>
        /// Gets or Sets RawLogs
        /// </summary>
        [DataMember(Name = "raw_logs", IsRequired = true, EmitDefaultValue = true)]
        public bool RawLogs { get; set; }

        /// <summary>
        /// Gets or Sets WebApplicationFirewall
        /// </summary>
        [DataMember(Name = "web_application_firewall", IsRequired = true, EmitDefaultValue = true)]
        public bool WebApplicationFirewall { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationResults {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  DebugRules: ").Append(DebugRules).Append("\n");
            sb.Append("  Http3: ").Append(Http3).Append("\n");
            sb.Append("  SupportedCiphers: ").Append(SupportedCiphers).Append("\n");
            sb.Append("  DeliveryProtocol: ").Append(DeliveryProtocol).Append("\n");
            sb.Append("  HttpPort: ").Append(HttpPort).Append("\n");
            sb.Append("  HttpsPort: ").Append(HttpsPort).Append("\n");
            sb.Append("  MinimumTlsVersion: ").Append(MinimumTlsVersion).Append("\n");
            sb.Append("  ApplicationAcceleration: ").Append(ApplicationAcceleration).Append("\n");
            sb.Append("  Caching: ").Append(Caching).Append("\n");
            sb.Append("  DeviceDetection: ").Append(DeviceDetection).Append("\n");
            sb.Append("  EdgeFirewall: ").Append(EdgeFirewall).Append("\n");
            sb.Append("  EdgeFunctions: ").Append(EdgeFunctions).Append("\n");
            sb.Append("  ImageOptimization: ").Append(ImageOptimization).Append("\n");
            sb.Append("  L2Caching: ").Append(L2Caching).Append("\n");
            sb.Append("  LoadBalancer: ").Append(LoadBalancer).Append("\n");
            sb.Append("  RawLogs: ").Append(RawLogs).Append("\n");
            sb.Append("  WebApplicationFirewall: ").Append(WebApplicationFirewall).Append("\n");
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
            return this.Equals(input as ApplicationResults);
        }

        /// <summary>
        /// Returns true if ApplicationResults instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationResults input)
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
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.DebugRules == input.DebugRules ||
                    this.DebugRules.Equals(input.DebugRules)
                ) && 
                (
                    this.Http3 == input.Http3 ||
                    this.Http3.Equals(input.Http3)
                ) && 
                (
                    this.SupportedCiphers == input.SupportedCiphers ||
                    (this.SupportedCiphers != null &&
                    this.SupportedCiphers.Equals(input.SupportedCiphers))
                ) && 
                (
                    this.DeliveryProtocol == input.DeliveryProtocol ||
                    (this.DeliveryProtocol != null &&
                    this.DeliveryProtocol.Equals(input.DeliveryProtocol))
                ) && 
                (
                    this.HttpPort == input.HttpPort ||
                    (this.HttpPort != null &&
                    this.HttpPort.Equals(input.HttpPort))
                ) && 
                (
                    this.HttpsPort == input.HttpsPort ||
                    (this.HttpsPort != null &&
                    this.HttpsPort.Equals(input.HttpsPort))
                ) && 
                (
                    this.MinimumTlsVersion == input.MinimumTlsVersion ||
                    (this.MinimumTlsVersion != null &&
                    this.MinimumTlsVersion.Equals(input.MinimumTlsVersion))
                ) && 
                (
                    this.ApplicationAcceleration == input.ApplicationAcceleration ||
                    this.ApplicationAcceleration.Equals(input.ApplicationAcceleration)
                ) && 
                (
                    this.Caching == input.Caching ||
                    this.Caching.Equals(input.Caching)
                ) && 
                (
                    this.DeviceDetection == input.DeviceDetection ||
                    this.DeviceDetection.Equals(input.DeviceDetection)
                ) && 
                (
                    this.EdgeFirewall == input.EdgeFirewall ||
                    this.EdgeFirewall.Equals(input.EdgeFirewall)
                ) && 
                (
                    this.EdgeFunctions == input.EdgeFunctions ||
                    this.EdgeFunctions.Equals(input.EdgeFunctions)
                ) && 
                (
                    this.ImageOptimization == input.ImageOptimization ||
                    this.ImageOptimization.Equals(input.ImageOptimization)
                ) && 
                (
                    this.L2Caching == input.L2Caching ||
                    this.L2Caching.Equals(input.L2Caching)
                ) && 
                (
                    this.LoadBalancer == input.LoadBalancer ||
                    this.LoadBalancer.Equals(input.LoadBalancer)
                ) && 
                (
                    this.RawLogs == input.RawLogs ||
                    this.RawLogs.Equals(input.RawLogs)
                ) && 
                (
                    this.WebApplicationFirewall == input.WebApplicationFirewall ||
                    this.WebApplicationFirewall.Equals(input.WebApplicationFirewall)
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
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                hashCode = (hashCode * 59) + this.DebugRules.GetHashCode();
                hashCode = (hashCode * 59) + this.Http3.GetHashCode();
                if (this.SupportedCiphers != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedCiphers.GetHashCode();
                }
                if (this.DeliveryProtocol != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryProtocol.GetHashCode();
                }
                if (this.HttpPort != null)
                {
                    hashCode = (hashCode * 59) + this.HttpPort.GetHashCode();
                }
                if (this.HttpsPort != null)
                {
                    hashCode = (hashCode * 59) + this.HttpsPort.GetHashCode();
                }
                if (this.MinimumTlsVersion != null)
                {
                    hashCode = (hashCode * 59) + this.MinimumTlsVersion.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ApplicationAcceleration.GetHashCode();
                hashCode = (hashCode * 59) + this.Caching.GetHashCode();
                hashCode = (hashCode * 59) + this.DeviceDetection.GetHashCode();
                hashCode = (hashCode * 59) + this.EdgeFirewall.GetHashCode();
                hashCode = (hashCode * 59) + this.EdgeFunctions.GetHashCode();
                hashCode = (hashCode * 59) + this.ImageOptimization.GetHashCode();
                hashCode = (hashCode * 59) + this.L2Caching.GetHashCode();
                hashCode = (hashCode * 59) + this.LoadBalancer.GetHashCode();
                hashCode = (hashCode * 59) + this.RawLogs.GetHashCode();
                hashCode = (hashCode * 59) + this.WebApplicationFirewall.GetHashCode();
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
