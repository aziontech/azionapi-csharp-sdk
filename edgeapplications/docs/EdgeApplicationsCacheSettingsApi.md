# edgeapplications.Api.EdgeApplicationsCacheSettingsApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsDelete**](EdgeApplicationsCacheSettingsApi.md#edgeapplicationsedgeapplicationidcachesettingscachesettingsdelete) | **DELETE** /edge_applications/{edge_application_id}/cache_settings/{cache_settings} | /edge_applications/:edge_application_id:/cache_settings/:cache_settings: |
| [**EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsIdGet**](EdgeApplicationsCacheSettingsApi.md#edgeapplicationsedgeapplicationidcachesettingscachesettingsidget) | **GET** /edge_applications/{edge_application_id}/cache_settings/{cache_settings_id} | /edge_applications/:edge_application_id:/cache_settings/:cache_settings_id: |
| [**EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsIdPut**](EdgeApplicationsCacheSettingsApi.md#edgeapplicationsedgeapplicationidcachesettingscachesettingsidput) | **PUT** /edge_applications/{edge_application_id}/cache_settings/{cache_settings_id} | /edge_applications/:edge_application_id:/cache_settings/ca |
| [**EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsPatch**](EdgeApplicationsCacheSettingsApi.md#edgeapplicationsedgeapplicationidcachesettingscachesettingspatch) | **PATCH** /edge_applications/{edge_application_id}/cache_settings/{cache_settings} | /edge_applications/:edge_application_id:/cache_settings/:cache_settings_id: |
| [**EdgeApplicationsEdgeApplicationIdCacheSettingsGet**](EdgeApplicationsCacheSettingsApi.md#edgeapplicationsedgeapplicationidcachesettingsget) | **GET** /edge_applications/{edge_application_id}/cache_settings | /edge_applications/{edge_application_id}/cache_settings |
| [**EdgeApplicationsEdgeApplicationIdCacheSettingsPost**](EdgeApplicationsCacheSettingsApi.md#edgeapplicationsedgeapplicationidcachesettingspost) | **POST** /edge_applications/{edge_application_id}/cache_settings | /edge_applications/:edge_application_id:/cache_settings |

<a id="edgeapplicationsedgeapplicationidcachesettingscachesettingsdelete"></a>
# **EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsDelete**
> void EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsDelete (long edgeApplicationId, long cacheSettings, string accept = null, string contentType = null)

/edge_applications/:edge_application_id:/cache_settings/:cache_settings:

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsCacheSettingsApi(config);
            var edgeApplicationId = 789L;  // long | 
            var cacheSettings = 789L;  // long | 
            var accept = application/json; version=3;  // string |  (optional) 
            var contentType = application/json;  // string | The type of coding used in the Body (application/json). <br>  Example: Content-Type: application/json (optional) 

            try
            {
                // /edge_applications/:edge_application_id:/cache_settings/:cache_settings:
                apiInstance.EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsDelete(edgeApplicationId, cacheSettings, accept, contentType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsCacheSettingsApi.EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/:edge_application_id:/cache_settings/:cache_settings:
    apiInstance.EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsDeleteWithHttpInfo(edgeApplicationId, cacheSettings, accept, contentType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsCacheSettingsApi.EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** |  |  |
| **cacheSettings** | **long** |  |  |
| **accept** | **string** |  | [optional]  |
| **contentType** | **string** | The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json | [optional]  |

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No response |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgeapplicationsedgeapplicationidcachesettingscachesettingsidget"></a>
# **EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsIdGet**
> ApplicationCacheGetOneResponse EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsIdGet (long edgeApplicationId, long cacheSettingsId, string accept = null)

/edge_applications/:edge_application_id:/cache_settings/:cache_settings_id:

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsCacheSettingsApi(config);
            var edgeApplicationId = 789L;  // long | 
            var cacheSettingsId = 789L;  // long | 
            var accept = application/json; version=3;  // string |  (optional) 

            try
            {
                // /edge_applications/:edge_application_id:/cache_settings/:cache_settings_id:
                ApplicationCacheGetOneResponse result = apiInstance.EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsIdGet(edgeApplicationId, cacheSettingsId, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsCacheSettingsApi.EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/:edge_application_id:/cache_settings/:cache_settings_id:
    ApiResponse<ApplicationCacheGetOneResponse> response = apiInstance.EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsIdGetWithHttpInfo(edgeApplicationId, cacheSettingsId, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsCacheSettingsApi.EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** |  |  |
| **cacheSettingsId** | **long** |  |  |
| **accept** | **string** |  | [optional]  |

### Return type

[**ApplicationCacheGetOneResponse**](ApplicationCacheGetOneResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgeapplicationsedgeapplicationidcachesettingscachesettingsidput"></a>
# **EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsIdPut**
> ApplicationCachePutResponse EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsIdPut (long edgeApplicationId, long cacheSettingsId, string accept = null, string contentType = null, ApplicationCachePutRequest applicationCachePutRequest = null)

/edge_applications/:edge_application_id:/cache_settings/ca

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsCacheSettingsApi(config);
            var edgeApplicationId = 789L;  // long | 
            var cacheSettingsId = 789L;  // long | 
            var accept = application/json; version=3;  // string |  (optional) 
            var contentType = application/json;  // string | The type of coding used in the Body (application/json). <br>  Example: Content-Type: application/json (optional) 
            var applicationCachePutRequest = new ApplicationCachePutRequest(); // ApplicationCachePutRequest |  (optional) 

            try
            {
                // /edge_applications/:edge_application_id:/cache_settings/ca
                ApplicationCachePutResponse result = apiInstance.EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsIdPut(edgeApplicationId, cacheSettingsId, accept, contentType, applicationCachePutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsCacheSettingsApi.EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/:edge_application_id:/cache_settings/ca
    ApiResponse<ApplicationCachePutResponse> response = apiInstance.EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsIdPutWithHttpInfo(edgeApplicationId, cacheSettingsId, accept, contentType, applicationCachePutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsCacheSettingsApi.EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** |  |  |
| **cacheSettingsId** | **long** |  |  |
| **accept** | **string** |  | [optional]  |
| **contentType** | **string** | The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json | [optional]  |
| **applicationCachePutRequest** | [**ApplicationCachePutRequest**](ApplicationCachePutRequest.md) |  | [optional]  |

### Return type

[**ApplicationCachePutResponse**](ApplicationCachePutResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json; version=3
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgeapplicationsedgeapplicationidcachesettingscachesettingspatch"></a>
# **EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsPatch**
> ApplicationCachePatchResponse EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsPatch (long edgeApplicationId, long cacheSettings, string accept = null, ApplicationCachePatchRequest applicationCachePatchRequest = null)

/edge_applications/:edge_application_id:/cache_settings/:cache_settings_id:

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsCacheSettingsApi(config);
            var edgeApplicationId = 789L;  // long | 
            var cacheSettings = 789L;  // long | 
            var accept = application/json; version=3;  // string |  (optional) 
            var applicationCachePatchRequest = new ApplicationCachePatchRequest(); // ApplicationCachePatchRequest |  (optional) 

            try
            {
                // /edge_applications/:edge_application_id:/cache_settings/:cache_settings_id:
                ApplicationCachePatchResponse result = apiInstance.EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsPatch(edgeApplicationId, cacheSettings, accept, applicationCachePatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsCacheSettingsApi.EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/:edge_application_id:/cache_settings/:cache_settings_id:
    ApiResponse<ApplicationCachePatchResponse> response = apiInstance.EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsPatchWithHttpInfo(edgeApplicationId, cacheSettings, accept, applicationCachePatchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsCacheSettingsApi.EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** |  |  |
| **cacheSettings** | **long** |  |  |
| **accept** | **string** |  | [optional]  |
| **applicationCachePatchRequest** | [**ApplicationCachePatchRequest**](ApplicationCachePatchRequest.md) |  | [optional]  |

### Return type

[**ApplicationCachePatchResponse**](ApplicationCachePatchResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json; version=3
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgeapplicationsedgeapplicationidcachesettingsget"></a>
# **EdgeApplicationsEdgeApplicationIdCacheSettingsGet**
> ApplicationCacheGetResponse EdgeApplicationsEdgeApplicationIdCacheSettingsGet (long edgeApplicationId, long? page = null, long? pageSize = null, string filter = null, string orderBy = null, string sort = null, string accept = null)

/edge_applications/{edge_application_id}/cache_settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdCacheSettingsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsCacheSettingsApi(config);
            var edgeApplicationId = 789L;  // long | 
            var page = 789L;  // long? |  (optional) 
            var pageSize = 789L;  // long? |  (optional) 
            var filter = "filter_example";  // string |  (optional) 
            var orderBy = "orderBy_example";  // string |  (optional) 
            var sort = "sort_example";  // string |  (optional) 
            var accept = application/json; version=3;  // string |  (optional) 

            try
            {
                // /edge_applications/{edge_application_id}/cache_settings
                ApplicationCacheGetResponse result = apiInstance.EdgeApplicationsEdgeApplicationIdCacheSettingsGet(edgeApplicationId, page, pageSize, filter, orderBy, sort, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsCacheSettingsApi.EdgeApplicationsEdgeApplicationIdCacheSettingsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdCacheSettingsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/{edge_application_id}/cache_settings
    ApiResponse<ApplicationCacheGetResponse> response = apiInstance.EdgeApplicationsEdgeApplicationIdCacheSettingsGetWithHttpInfo(edgeApplicationId, page, pageSize, filter, orderBy, sort, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsCacheSettingsApi.EdgeApplicationsEdgeApplicationIdCacheSettingsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** |  |  |
| **page** | **long?** |  | [optional]  |
| **pageSize** | **long?** |  | [optional]  |
| **filter** | **string** |  | [optional]  |
| **orderBy** | **string** |  | [optional]  |
| **sort** | **string** |  | [optional]  |
| **accept** | **string** |  | [optional]  |

### Return type

[**ApplicationCacheGetResponse**](ApplicationCacheGetResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgeapplicationsedgeapplicationidcachesettingspost"></a>
# **EdgeApplicationsEdgeApplicationIdCacheSettingsPost**
> ApplicationCacheCreateResponse EdgeApplicationsEdgeApplicationIdCacheSettingsPost (long edgeApplicationId, string accept = null, string contentType = null, ApplicationCacheCreateRequest applicationCacheCreateRequest = null)

/edge_applications/:edge_application_id:/cache_settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdCacheSettingsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsCacheSettingsApi(config);
            var edgeApplicationId = 789L;  // long | 
            var accept = application/json; version=3;  // string |  (optional) 
            var contentType = application/json;  // string | The type of coding used in the Body (application/json). <br>  Example: Content-Type: application/json (optional) 
            var applicationCacheCreateRequest = new ApplicationCacheCreateRequest(); // ApplicationCacheCreateRequest |  (optional) 

            try
            {
                // /edge_applications/:edge_application_id:/cache_settings
                ApplicationCacheCreateResponse result = apiInstance.EdgeApplicationsEdgeApplicationIdCacheSettingsPost(edgeApplicationId, accept, contentType, applicationCacheCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsCacheSettingsApi.EdgeApplicationsEdgeApplicationIdCacheSettingsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdCacheSettingsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/:edge_application_id:/cache_settings
    ApiResponse<ApplicationCacheCreateResponse> response = apiInstance.EdgeApplicationsEdgeApplicationIdCacheSettingsPostWithHttpInfo(edgeApplicationId, accept, contentType, applicationCacheCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsCacheSettingsApi.EdgeApplicationsEdgeApplicationIdCacheSettingsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** |  |  |
| **accept** | **string** |  | [optional]  |
| **contentType** | **string** | The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json | [optional]  |
| **applicationCacheCreateRequest** | [**ApplicationCacheCreateRequest**](ApplicationCacheCreateRequest.md) |  | [optional]  |

### Return type

[**ApplicationCacheCreateResponse**](ApplicationCacheCreateResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json; version=3
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

