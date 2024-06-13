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
    /// ApplicationCacheResults
    /// </summary>
    [DataContract(Name = "ApplicationCacheResults")]
    public partial class ApplicationCacheResults : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationCacheResults" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationCacheResults() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationCacheResults" /> class.
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
        /// <param name="isSliceConfigurationEnabled">isSliceConfigurationEnabled.</param>
        /// <param name="isSliceEdgeCachingEnabled">isSliceEdgeCachingEnabled.</param>
        /// <param name="isSliceL2CachingEnabled">isSliceL2CachingEnabled.</param>
        /// <param name="sliceConfigurationRange">sliceConfigurationRange.</param>
        /// <param name="enableCachingForOptions">enableCachingForOptions (required).</param>
        /// <param name="enableStaleCache">enableStaleCache (required).</param>
        /// <param name="l2Region">l2Region (required).</param>
        public ApplicationCacheResults(long id = default(long), string name = default(string), string browserCacheSettings = default(string), long browserCacheSettingsMaximumTtl = default(long), string cdnCacheSettings = default(string), long cdnCacheSettingsMaximumTtl = default(long), string cacheByQueryString = default(string), List<string> queryStringFields = default(List<string>), bool enableQueryStringSort = default(bool), string cacheByCookies = default(string), List<string> cookieNames = default(List<string>), string adaptiveDeliveryAction = default(string), List<int> deviceGroup = default(List<int>), bool enableCachingForPost = default(bool), bool l2CachingEnabled = default(bool), bool isSliceConfigurationEnabled = default(bool), bool isSliceEdgeCachingEnabled = default(bool), bool isSliceL2CachingEnabled = default(bool), long sliceConfigurationRange = default(long), bool enableCachingForOptions = default(bool), bool enableStaleCache = default(bool), string l2Region = default(string))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ApplicationCacheResults and cannot be null");
            }
            this.Name = name;
            // to ensure "browserCacheSettings" is required (not null)
            if (browserCacheSettings == null)
            {
                throw new ArgumentNullException("browserCacheSettings is a required property for ApplicationCacheResults and cannot be null");
            }
            this.BrowserCacheSettings = browserCacheSettings;
            this.BrowserCacheSettingsMaximumTtl = browserCacheSettingsMaximumTtl;
            // to ensure "cdnCacheSettings" is required (not null)
            if (cdnCacheSettings == null)
            {
                throw new ArgumentNullException("cdnCacheSettings is a required property for ApplicationCacheResults and cannot be null");
            }
            this.CdnCacheSettings = cdnCacheSettings;
            this.CdnCacheSettingsMaximumTtl = cdnCacheSettingsMaximumTtl;
            // to ensure "cacheByQueryString" is required (not null)
            if (cacheByQueryString == null)
            {
                throw new ArgumentNullException("cacheByQueryString is a required property for ApplicationCacheResults and cannot be null");
            }
            this.CacheByQueryString = cacheByQueryString;
            // to ensure "queryStringFields" is required (not null)
            if (queryStringFields == null)
            {
                throw new ArgumentNullException("queryStringFields is a required property for ApplicationCacheResults and cannot be null");
            }
            this.QueryStringFields = queryStringFields;
            this.EnableQueryStringSort = enableQueryStringSort;
            // to ensure "cacheByCookies" is required (not null)
            if (cacheByCookies == null)
            {
                throw new ArgumentNullException("cacheByCookies is a required property for ApplicationCacheResults and cannot be null");
            }
            this.CacheByCookies = cacheByCookies;
            // to ensure "cookieNames" is required (not null)
            if (cookieNames == null)
            {
                throw new ArgumentNullException("cookieNames is a required property for ApplicationCacheResults and cannot be null");
            }
            this.CookieNames = cookieNames;
            // to ensure "adaptiveDeliveryAction" is required (not null)
            if (adaptiveDeliveryAction == null)
            {
                throw new ArgumentNullException("adaptiveDeliveryAction is a required property for ApplicationCacheResults and cannot be null");
            }
            this.AdaptiveDeliveryAction = adaptiveDeliveryAction;
            // to ensure "deviceGroup" is required (not null)
            if (deviceGroup == null)
            {
                throw new ArgumentNullException("deviceGroup is a required property for ApplicationCacheResults and cannot be null");
            }
            this.DeviceGroup = deviceGroup;
            this.EnableCachingForPost = enableCachingForPost;
            this.L2CachingEnabled = l2CachingEnabled;
            this.EnableCachingForOptions = enableCachingForOptions;
            this.EnableStaleCache = enableStaleCache;
            // to ensure "l2Region" is required (not null)
            if (l2Region == null)
            {
                throw new ArgumentNullException("l2Region is a required property for ApplicationCacheResults and cannot be null");
            }
            this.L2Region = l2Region;
            this.IsSliceConfigurationEnabled = isSliceConfigurationEnabled;
            this.IsSliceEdgeCachingEnabled = isSliceEdgeCachingEnabled;
            this.IsSliceL2CachingEnabled = isSliceL2CachingEnabled;
            this.SliceConfigurationRange = sliceConfigurationRange;
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
        public List<int> DeviceGroup { get; set; }

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
        /// Gets or Sets IsSliceConfigurationEnabled
        /// </summary>
        [DataMember(Name = "is_slice_configuration_enabled", EmitDefaultValue = true)]
        public bool IsSliceConfigurationEnabled { get; set; }

        /// <summary>
        /// Gets or Sets IsSliceEdgeCachingEnabled
        /// </summary>
        [DataMember(Name = "is_slice_edge_caching_enabled", EmitDefaultValue = true)]
        public bool IsSliceEdgeCachingEnabled { get; set; }

        /// <summary>
        /// Gets or Sets IsSliceL2CachingEnabled
        /// </summary>
        [DataMember(Name = "is_slice_l2_caching_enabled", EmitDefaultValue = true)]
        public bool IsSliceL2CachingEnabled { get; set; }

        /// <summary>
        /// Gets or Sets SliceConfigurationRange
        /// </summary>
        [DataMember(Name = "slice_configuration_range", EmitDefaultValue = false)]
        public long SliceConfigurationRange { get; set; }

        /// <summary>
        /// Gets or Sets EnableCachingForOptions
        /// </summary>
        [DataMember(Name = "enable_caching_for_options", IsRequired = true, EmitDefaultValue = true)]
        public bool EnableCachingForOptions { get; set; }

        /// <summary>
        /// Gets or Sets EnableStaleCache
        /// </summary>
        [DataMember(Name = "enable_stale_cache", IsRequired = true, EmitDefaultValue = true)]
        public bool EnableStaleCache { get; set; }

        /// <summary>
        /// Gets or Sets L2Region
        /// </summary>
        [DataMember(Name = "l2_region", IsRequired = true, EmitDefaultValue = true)]
        public string L2Region { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationCacheResults {\n");
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
            sb.Append("  IsSliceConfigurationEnabled: ").Append(IsSliceConfigurationEnabled).Append("\n");
            sb.Append("  IsSliceEdgeCachingEnabled: ").Append(IsSliceEdgeCachingEnabled).Append("\n");
            sb.Append("  IsSliceL2CachingEnabled: ").Append(IsSliceL2CachingEnabled).Append("\n");
            sb.Append("  SliceConfigurationRange: ").Append(SliceConfigurationRange).Append("\n");
            sb.Append("  EnableCachingForOptions: ").Append(EnableCachingForOptions).Append("\n");
            sb.Append("  EnableStaleCache: ").Append(EnableStaleCache).Append("\n");
            sb.Append("  L2Region: ").Append(L2Region).Append("\n");
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
