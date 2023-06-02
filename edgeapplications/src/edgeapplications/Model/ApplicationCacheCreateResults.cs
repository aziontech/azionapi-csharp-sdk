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
    /// ApplicationCacheCreateResults
    /// </summary>
    [DataContract(Name = "ApplicationCacheCreateResults")]
    public partial class ApplicationCacheCreateResults : IEquatable<ApplicationCacheCreateResults>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationCacheCreateResults" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationCacheCreateResults() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationCacheCreateResults" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="browserCacheSettings">browserCacheSettings (required).</param>
        /// <param name="browserCacheSettingsMaximumTtl">browserCacheSettingsMaximumTtl (required).</param>
        /// <param name="cdnCacheSettings">cdnCacheSettings (required).</param>
        /// <param name="cdnCacheSettingsMaximumTtl">cdnCacheSettingsMaximumTtl (required).</param>
        /// <param name="cacheByQueryString">cacheByQueryString (required).</param>
        /// <param name="queryStringFields">queryStringFields (required).</param>
        /// <param name="enableQueryStringSort">enableQueryStringSort (required).</param>
        /// <param name="cacheByCookies">cacheByCookies (required).</param>
        /// <param name="cookieNames">cookieNames (required).</param>
        /// <param name="adaptiveDeliveryAction">adaptiveDeliveryAction (required).</param>
        /// <param name="deviceGroup">deviceGroup (required).</param>
        /// <param name="enableCachingForPost">enableCachingForPost (required).</param>
        /// <param name="l2CachingEnabled">l2CachingEnabled (required).</param>
        public ApplicationCacheCreateResults(long id = default(long), string name = default(string), string browserCacheSettings = default(string), long browserCacheSettingsMaximumTtl = default(long), string cdnCacheSettings = default(string), long cdnCacheSettingsMaximumTtl = default(long), string cacheByQueryString = default(string), List<string> queryStringFields = default(List<string>), bool enableQueryStringSort = default(bool), string cacheByCookies = default(string), List<string> cookieNames = default(List<string>), string adaptiveDeliveryAction = default(string), List<string> deviceGroup = default(List<string>), bool enableCachingForPost = default(bool), bool l2CachingEnabled = default(bool))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ApplicationCacheCreateResults and cannot be null");
            }
            this.Name = name;
            // to ensure "browserCacheSettings" is required (not null)
            if (browserCacheSettings == null)
            {
                throw new ArgumentNullException("browserCacheSettings is a required property for ApplicationCacheCreateResults and cannot be null");
            }
            this.BrowserCacheSettings = browserCacheSettings;
            this.BrowserCacheSettingsMaximumTtl = browserCacheSettingsMaximumTtl;
            // to ensure "cdnCacheSettings" is required (not null)
            if (cdnCacheSettings == null)
            {
                throw new ArgumentNullException("cdnCacheSettings is a required property for ApplicationCacheCreateResults and cannot be null");
            }
            this.CdnCacheSettings = cdnCacheSettings;
            this.CdnCacheSettingsMaximumTtl = cdnCacheSettingsMaximumTtl;
            // to ensure "cacheByQueryString" is required (not null)
            if (cacheByQueryString == null)
            {
                throw new ArgumentNullException("cacheByQueryString is a required property for ApplicationCacheCreateResults and cannot be null");
            }
            this.CacheByQueryString = cacheByQueryString;
            // to ensure "queryStringFields" is required (not null)
            if (queryStringFields == null)
            {
                throw new ArgumentNullException("queryStringFields is a required property for ApplicationCacheCreateResults and cannot be null");
            }
            this.QueryStringFields = queryStringFields;
            this.EnableQueryStringSort = enableQueryStringSort;
            // to ensure "cacheByCookies" is required (not null)
            if (cacheByCookies == null)
            {
                throw new ArgumentNullException("cacheByCookies is a required property for ApplicationCacheCreateResults and cannot be null");
            }
            this.CacheByCookies = cacheByCookies;
            // to ensure "cookieNames" is required (not null)
            if (cookieNames == null)
            {
                throw new ArgumentNullException("cookieNames is a required property for ApplicationCacheCreateResults and cannot be null");
            }
            this.CookieNames = cookieNames;
            // to ensure "adaptiveDeliveryAction" is required (not null)
            if (adaptiveDeliveryAction == null)
            {
                throw new ArgumentNullException("adaptiveDeliveryAction is a required property for ApplicationCacheCreateResults and cannot be null");
            }
            this.AdaptiveDeliveryAction = adaptiveDeliveryAction;
            // to ensure "deviceGroup" is required (not null)
            if (deviceGroup == null)
            {
                throw new ArgumentNullException("deviceGroup is a required property for ApplicationCacheCreateResults and cannot be null");
            }
            this.DeviceGroup = deviceGroup;
            this.EnableCachingForPost = enableCachingForPost;
            this.L2CachingEnabled = l2CachingEnabled;
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
        /// Gets or Sets BrowserCacheSettings
        /// </summary>
        [DataMember(Name = "browser_cache_settings", IsRequired = true, EmitDefaultValue = true)]
        public string BrowserCacheSettings { get; set; }

        /// <summary>
        /// Gets or Sets BrowserCacheSettingsMaximumTtl
        /// </summary>
        [DataMember(Name = "browser_cache_settings_maximum_ttl", IsRequired = true, EmitDefaultValue = true)]
        public long BrowserCacheSettingsMaximumTtl { get; set; }

        /// <summary>
        /// Gets or Sets CdnCacheSettings
        /// </summary>
        [DataMember(Name = "cdn_cache_settings", IsRequired = true, EmitDefaultValue = true)]
        public string CdnCacheSettings { get; set; }

        /// <summary>
        /// Gets or Sets CdnCacheSettingsMaximumTtl
        /// </summary>
        [DataMember(Name = "cdn_cache_settings_maximum_ttl", IsRequired = true, EmitDefaultValue = true)]
        public long CdnCacheSettingsMaximumTtl { get; set; }

        /// <summary>
        /// Gets or Sets CacheByQueryString
        /// </summary>
        [DataMember(Name = "cache_by_query_string", IsRequired = true, EmitDefaultValue = true)]
        public string CacheByQueryString { get; set; }

        /// <summary>
        /// Gets or Sets QueryStringFields
        /// </summary>
        [DataMember(Name = "query_string_fields", IsRequired = true, EmitDefaultValue = true)]
        public List<string> QueryStringFields { get; set; }

        /// <summary>
        /// Gets or Sets EnableQueryStringSort
        /// </summary>
        [DataMember(Name = "enable_query_string_sort", IsRequired = true, EmitDefaultValue = true)]
        public bool EnableQueryStringSort { get; set; }

        /// <summary>
        /// Gets or Sets CacheByCookies
        /// </summary>
        [DataMember(Name = "cache_by_cookies", IsRequired = true, EmitDefaultValue = true)]
        public string CacheByCookies { get; set; }

        /// <summary>
        /// Gets or Sets CookieNames
        /// </summary>
        [DataMember(Name = "cookie_names", IsRequired = true, EmitDefaultValue = true)]
        public List<string> CookieNames { get; set; }

        /// <summary>
        /// Gets or Sets AdaptiveDeliveryAction
        /// </summary>
        [DataMember(Name = "adaptive_delivery_action", IsRequired = true, EmitDefaultValue = true)]
        public string AdaptiveDeliveryAction { get; set; }

        /// <summary>
        /// Gets or Sets DeviceGroup
        /// </summary>
        [DataMember(Name = "device_group", IsRequired = true, EmitDefaultValue = true)]
        public List<string> DeviceGroup { get; set; }

        /// <summary>
        /// Gets or Sets EnableCachingForPost
        /// </summary>
        [DataMember(Name = "enable_caching_for_post", IsRequired = true, EmitDefaultValue = true)]
        public bool EnableCachingForPost { get; set; }

        /// <summary>
        /// Gets or Sets L2CachingEnabled
        /// </summary>
        [DataMember(Name = "l2_caching_enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool L2CachingEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationCacheCreateResults {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BrowserCacheSettings: ").Append(BrowserCacheSettings).Append("\n");
            sb.Append("  BrowserCacheSettingsMaximumTtl: ").Append(BrowserCacheSettingsMaximumTtl).Append("\n");
            sb.Append("  CdnCacheSettings: ").Append(CdnCacheSettings).Append("\n");
            sb.Append("  CdnCacheSettingsMaximumTtl: ").Append(CdnCacheSettingsMaximumTtl).Append("\n");
            sb.Append("  CacheByQueryString: ").Append(CacheByQueryString).Append("\n");
            sb.Append("  QueryStringFields: ").Append(QueryStringFields).Append("\n");
            sb.Append("  EnableQueryStringSort: ").Append(EnableQueryStringSort).Append("\n");
            sb.Append("  CacheByCookies: ").Append(CacheByCookies).Append("\n");
            sb.Append("  CookieNames: ").Append(CookieNames).Append("\n");
            sb.Append("  AdaptiveDeliveryAction: ").Append(AdaptiveDeliveryAction).Append("\n");
            sb.Append("  DeviceGroup: ").Append(DeviceGroup).Append("\n");
            sb.Append("  EnableCachingForPost: ").Append(EnableCachingForPost).Append("\n");
            sb.Append("  L2CachingEnabled: ").Append(L2CachingEnabled).Append("\n");
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
            return this.Equals(input as ApplicationCacheCreateResults);
        }

        /// <summary>
        /// Returns true if ApplicationCacheCreateResults instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationCacheCreateResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationCacheCreateResults input)
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
                    this.BrowserCacheSettings == input.BrowserCacheSettings ||
                    (this.BrowserCacheSettings != null &&
                    this.BrowserCacheSettings.Equals(input.BrowserCacheSettings))
                ) && 
                (
                    this.BrowserCacheSettingsMaximumTtl == input.BrowserCacheSettingsMaximumTtl ||
                    this.BrowserCacheSettingsMaximumTtl.Equals(input.BrowserCacheSettingsMaximumTtl)
                ) && 
                (
                    this.CdnCacheSettings == input.CdnCacheSettings ||
                    (this.CdnCacheSettings != null &&
                    this.CdnCacheSettings.Equals(input.CdnCacheSettings))
                ) && 
                (
                    this.CdnCacheSettingsMaximumTtl == input.CdnCacheSettingsMaximumTtl ||
                    this.CdnCacheSettingsMaximumTtl.Equals(input.CdnCacheSettingsMaximumTtl)
                ) && 
                (
                    this.CacheByQueryString == input.CacheByQueryString ||
                    (this.CacheByQueryString != null &&
                    this.CacheByQueryString.Equals(input.CacheByQueryString))
                ) && 
                (
                    this.QueryStringFields == input.QueryStringFields ||
                    this.QueryStringFields != null &&
                    input.QueryStringFields != null &&
                    this.QueryStringFields.SequenceEqual(input.QueryStringFields)
                ) && 
                (
                    this.EnableQueryStringSort == input.EnableQueryStringSort ||
                    this.EnableQueryStringSort.Equals(input.EnableQueryStringSort)
                ) && 
                (
                    this.CacheByCookies == input.CacheByCookies ||
                    (this.CacheByCookies != null &&
                    this.CacheByCookies.Equals(input.CacheByCookies))
                ) && 
                (
                    this.CookieNames == input.CookieNames ||
                    this.CookieNames != null &&
                    input.CookieNames != null &&
                    this.CookieNames.SequenceEqual(input.CookieNames)
                ) && 
                (
                    this.AdaptiveDeliveryAction == input.AdaptiveDeliveryAction ||
                    (this.AdaptiveDeliveryAction != null &&
                    this.AdaptiveDeliveryAction.Equals(input.AdaptiveDeliveryAction))
                ) && 
                (
                    this.DeviceGroup == input.DeviceGroup ||
                    this.DeviceGroup != null &&
                    input.DeviceGroup != null &&
                    this.DeviceGroup.SequenceEqual(input.DeviceGroup)
                ) && 
                (
                    this.EnableCachingForPost == input.EnableCachingForPost ||
                    this.EnableCachingForPost.Equals(input.EnableCachingForPost)
                ) && 
                (
                    this.L2CachingEnabled == input.L2CachingEnabled ||
                    this.L2CachingEnabled.Equals(input.L2CachingEnabled)
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
                if (this.BrowserCacheSettings != null)
                {
                    hashCode = (hashCode * 59) + this.BrowserCacheSettings.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BrowserCacheSettingsMaximumTtl.GetHashCode();
                if (this.CdnCacheSettings != null)
                {
                    hashCode = (hashCode * 59) + this.CdnCacheSettings.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CdnCacheSettingsMaximumTtl.GetHashCode();
                if (this.CacheByQueryString != null)
                {
                    hashCode = (hashCode * 59) + this.CacheByQueryString.GetHashCode();
                }
                if (this.QueryStringFields != null)
                {
                    hashCode = (hashCode * 59) + this.QueryStringFields.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EnableQueryStringSort.GetHashCode();
                if (this.CacheByCookies != null)
                {
                    hashCode = (hashCode * 59) + this.CacheByCookies.GetHashCode();
                }
                if (this.CookieNames != null)
                {
                    hashCode = (hashCode * 59) + this.CookieNames.GetHashCode();
                }
                if (this.AdaptiveDeliveryAction != null)
                {
                    hashCode = (hashCode * 59) + this.AdaptiveDeliveryAction.GetHashCode();
                }
                if (this.DeviceGroup != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceGroup.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EnableCachingForPost.GetHashCode();
                hashCode = (hashCode * 59) + this.L2CachingEnabled.GetHashCode();
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
