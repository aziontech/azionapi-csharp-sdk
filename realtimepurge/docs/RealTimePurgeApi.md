# realtimepurge.Api.RealTimePurgeApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PurgeCacheKey**](RealTimePurgeApi.md#purgecachekey) | **POST** /purge/cachekey | /purge/cachekey |
| [**PurgeUrl**](RealTimePurgeApi.md#purgeurl) | **POST** /purge/url | /purge/url |
| [**PurgeWildcard**](RealTimePurgeApi.md#purgewildcard) | **POST** /purge/wildcard | /purge/wildcard |

<a id="purgecachekey"></a>
# **PurgeCacheKey**
> void PurgeCacheKey (string accept = null, string contentType = null, PurgeCacheKeyRequest purgeCacheKeyRequest = null)

/purge/cachekey

List of Cache Keys you want to remove from the Azion Edge Servers cache. urls (array): list of up to 50 Cache Keys to be expired from the cache, per request. method (choice): purge method, use the “delete” value for removal. Layer (choice): layer where the purge will be done. Use the value “edge_caching” (default value if not informed) to purge on the Edge Caching layer and the value “l2_caching” to purge on L2 Caching.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using realtimepurge.Api;
using realtimepurge.Client;
using realtimepurge.Model;

namespace Example
{
    public class PurgeCacheKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RealTimePurgeApi(config);
            var accept = application/json; version=3;  // string |  (optional) 
            var contentType = application/json;  // string |  (optional) 
            var purgeCacheKeyRequest = new PurgeCacheKeyRequest(); // PurgeCacheKeyRequest |  (optional) 

            try
            {
                // /purge/cachekey
                apiInstance.PurgeCacheKey(accept, contentType, purgeCacheKeyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RealTimePurgeApi.PurgeCacheKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurgeCacheKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /purge/cachekey
    apiInstance.PurgeCacheKeyWithHttpInfo(accept, contentType, purgeCacheKeyRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RealTimePurgeApi.PurgeCacheKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accept** | **string** |  | [optional]  |
| **contentType** | **string** |  | [optional]  |
| **purgeCacheKeyRequest** | [**PurgeCacheKeyRequest**](PurgeCacheKeyRequest.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **201** | Created |  -  |
| **204** | No Content |  -  |
| **207** | Multi Status |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **406** | Not Acceptable |  -  |
| **409** | Conflict |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="purgeurl"></a>
# **PurgeUrl**
> void PurgeUrl (string accept = null, string contentType = null, PurgeUrlRequest purgeUrlRequest = null)

/purge/url

List of URLs you want to remove from the Azion Edge Servers cache. urls (array): list of up to 50 URLs to be expired from the cache, per request. method (choice): purge method, use the “delete” value for removal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using realtimepurge.Api;
using realtimepurge.Client;
using realtimepurge.Model;

namespace Example
{
    public class PurgeUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RealTimePurgeApi(config);
            var accept = application/json; version=3;  // string |  (optional) 
            var contentType = application/json;  // string |  (optional) 
            var purgeUrlRequest = new PurgeUrlRequest(); // PurgeUrlRequest |  (optional) 

            try
            {
                // /purge/url
                apiInstance.PurgeUrl(accept, contentType, purgeUrlRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RealTimePurgeApi.PurgeUrl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurgeUrlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /purge/url
    apiInstance.PurgeUrlWithHttpInfo(accept, contentType, purgeUrlRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RealTimePurgeApi.PurgeUrlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accept** | **string** |  | [optional]  |
| **contentType** | **string** |  | [optional]  |
| **purgeUrlRequest** | [**PurgeUrlRequest**](PurgeUrlRequest.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json; version=3
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **201** | Created |  -  |
| **204** | No Content |  -  |
| **207** | Multi Status |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **406** | Not Acceptable |  -  |
| **409** | Conflict |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="purgewildcard"></a>
# **PurgeWildcard**
> void PurgeWildcard (string accept = null, string contentType = null, PurgeWildcardRequest purgeWildcardRequest = null)

/purge/wildcard

The Wildcard expression that represents the list of objects that you want to remove from the Azion Edge Servers cache. urls (array):the Wildcard URL or Wildcard Cache Key that represents the list of objects you want to expire. You can only use one Wildcard expression per request. method (choice): purge method, use the “delete” value for removal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using realtimepurge.Api;
using realtimepurge.Client;
using realtimepurge.Model;

namespace Example
{
    public class PurgeWildcardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RealTimePurgeApi(config);
            var accept = application/json; version=3;  // string |  (optional) 
            var contentType = application/json;  // string |  (optional) 
            var purgeWildcardRequest = new PurgeWildcardRequest(); // PurgeWildcardRequest |  (optional) 

            try
            {
                // /purge/wildcard
                apiInstance.PurgeWildcard(accept, contentType, purgeWildcardRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RealTimePurgeApi.PurgeWildcard: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurgeWildcardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /purge/wildcard
    apiInstance.PurgeWildcardWithHttpInfo(accept, contentType, purgeWildcardRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RealTimePurgeApi.PurgeWildcardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accept** | **string** |  | [optional]  |
| **contentType** | **string** |  | [optional]  |
| **purgeWildcardRequest** | [**PurgeWildcardRequest**](PurgeWildcardRequest.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **201** | Created |  -  |
| **204** | No Content |  -  |
| **207** | Multi Status |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **406** | Not Acceptable |  -  |
| **409** | Conflict |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

