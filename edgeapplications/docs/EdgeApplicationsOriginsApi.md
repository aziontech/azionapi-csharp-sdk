# edgeapplications.Api.EdgeApplicationsOriginsApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EdgeApplicationsEdgeApplicationIdOriginsGet**](EdgeApplicationsOriginsApi.md#edgeapplicationsedgeapplicationidoriginsget) | **GET** /edge_applications/{edge_application_id}/origins | /edge_applications/{edge_application_id}/origins |
| [**EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDelete**](EdgeApplicationsOriginsApi.md#edgeapplicationsedgeapplicationidoriginsoriginkeydelete) | **DELETE** /edge_applications/{edge_application_id}/origins/{origin_key} | /edge_applications/{edge_application_id}/origins/{origin_id} |
| [**EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGet**](EdgeApplicationsOriginsApi.md#edgeapplicationsedgeapplicationidoriginsoriginkeyget) | **GET** /edge_applications/{edge_application_id}/origins/{origin_key} | /edge_applications/{edge_application_id}/origins/{origin_key} |
| [**EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatch**](EdgeApplicationsOriginsApi.md#edgeapplicationsedgeapplicationidoriginsoriginkeypatch) | **PATCH** /edge_applications/{edge_application_id}/origins/{origin_key} | /edge_applications/:edge_application_id:/origins/:origin_id: |
| [**EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPut**](EdgeApplicationsOriginsApi.md#edgeapplicationsedgeapplicationidoriginsoriginkeyput) | **PUT** /edge_applications/{edge_application_id}/origins/{origin_key} | /edge_applications/{edge_application_id}/origins/{origin_id} |
| [**EdgeApplicationsEdgeApplicationIdOriginsPost**](EdgeApplicationsOriginsApi.md#edgeapplicationsedgeapplicationidoriginspost) | **POST** /edge_applications/{edge_application_id}/origins | /edge_applications/{edge_application_id}/origins |

<a id="edgeapplicationsedgeapplicationidoriginsget"></a>
# **EdgeApplicationsEdgeApplicationIdOriginsGet**
> OriginsResponse EdgeApplicationsEdgeApplicationIdOriginsGet (long edgeApplicationId, long? page = null, long? pageSize = null, string? filter = null, string? orderBy = null, string? sort = null, string? accept = null)

/edge_applications/{edge_application_id}/origins

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdOriginsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsOriginsApi(config);
            var edgeApplicationId = 789L;  // long | 
            var page = 789L;  // long? |  (optional) 
            var pageSize = 789L;  // long? |  (optional) 
            var filter = "filter_example";  // string? |  (optional) 
            var orderBy = "orderBy_example";  // string? |  (optional) 
            var sort = "sort_example";  // string? |  (optional) 
            var accept = application/json; version=3;  // string? |  (optional) 

            try
            {
                // /edge_applications/{edge_application_id}/origins
                OriginsResponse result = apiInstance.EdgeApplicationsEdgeApplicationIdOriginsGet(edgeApplicationId, page, pageSize, filter, orderBy, sort, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdOriginsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/{edge_application_id}/origins
    ApiResponse<OriginsResponse> response = apiInstance.EdgeApplicationsEdgeApplicationIdOriginsGetWithHttpInfo(edgeApplicationId, page, pageSize, filter, orderBy, sort, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsGetWithHttpInfo: " + e.Message);
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
| **filter** | **string?** |  | [optional]  |
| **orderBy** | **string?** |  | [optional]  |
| **sort** | **string?** |  | [optional]  |
| **accept** | **string?** |  | [optional]  |

### Return type

[**OriginsResponse**](OriginsResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

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

<a id="edgeapplicationsedgeapplicationidoriginsoriginkeydelete"></a>
# **EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDelete**
> void EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDelete (long edgeApplicationId, string originKey, string? accept = null)

/edge_applications/{edge_application_id}/origins/{origin_id}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsOriginsApi(config);
            var edgeApplicationId = 789L;  // long | 
            var originKey = "originKey_example";  // string | 
            var accept = application/json; version=3;  // string? | The id of the Origin that you plan to delete. (optional) 

            try
            {
                // /edge_applications/{edge_application_id}/origins/{origin_id}
                apiInstance.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDelete(edgeApplicationId, originKey, accept);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/{edge_application_id}/origins/{origin_id}
    apiInstance.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDeleteWithHttpInfo(edgeApplicationId, originKey, accept);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** |  |  |
| **originKey** | **string** |  |  |
| **accept** | **string?** | The id of the Origin that you plan to delete. | [optional]  |

### Return type

void (empty response body)

### Authorization

[tokenAuth](../README.md#tokenAuth)

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

<a id="edgeapplicationsedgeapplicationidoriginsoriginkeyget"></a>
# **EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGet**
> OriginsIdResponse EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGet (long edgeApplicationId, string originKey, string? accept = null)

/edge_applications/{edge_application_id}/origins/{origin_key}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsOriginsApi(config);
            var edgeApplicationId = 789L;  // long | 
            var originKey = "originKey_example";  // string | 
            var accept = application/json; version=3;  // string? | The id of the Origin that you plan to query. (optional) 

            try
            {
                // /edge_applications/{edge_application_id}/origins/{origin_key}
                OriginsIdResponse result = apiInstance.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGet(edgeApplicationId, originKey, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/{edge_application_id}/origins/{origin_key}
    ApiResponse<OriginsIdResponse> response = apiInstance.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGetWithHttpInfo(edgeApplicationId, originKey, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** |  |  |
| **originKey** | **string** |  |  |
| **accept** | **string?** | The id of the Origin that you plan to query. | [optional]  |

### Return type

[**OriginsIdResponse**](OriginsIdResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

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

<a id="edgeapplicationsedgeapplicationidoriginsoriginkeypatch"></a>
# **EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatch**
> OriginsIdResponse EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatch (long edgeApplicationId, string originKey, string? accept = null, string? contentType = null, PatchOriginsRequest? patchOriginsRequest = null)

/edge_applications/:edge_application_id:/origins/:origin_id:

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsOriginsApi(config);
            var edgeApplicationId = 789L;  // long | 
            var originKey = "originKey_example";  // string | 
            var accept = application/json; version=3;  // string? |  (optional) 
            var contentType = application/json;  // string? | The type of coding used in the Body (application/json). <br>  Example: Content-Type: application/json (optional) 
            var patchOriginsRequest = new PatchOriginsRequest?(); // PatchOriginsRequest? |  (optional) 

            try
            {
                // /edge_applications/:edge_application_id:/origins/:origin_id:
                OriginsIdResponse result = apiInstance.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatch(edgeApplicationId, originKey, accept, contentType, patchOriginsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/:edge_application_id:/origins/:origin_id:
    ApiResponse<OriginsIdResponse> response = apiInstance.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatchWithHttpInfo(edgeApplicationId, originKey, accept, contentType, patchOriginsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** |  |  |
| **originKey** | **string** |  |  |
| **accept** | **string?** |  | [optional]  |
| **contentType** | **string?** | The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json | [optional]  |
| **patchOriginsRequest** | [**PatchOriginsRequest?**](PatchOriginsRequest?.md) |  | [optional]  |

### Return type

[**OriginsIdResponse**](OriginsIdResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

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

<a id="edgeapplicationsedgeapplicationidoriginsoriginkeyput"></a>
# **EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPut**
> OriginsIdResponse EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPut (long edgeApplicationId, string originKey, string? accept = null, string? contentType = null, UpdateOriginsRequest? updateOriginsRequest = null)

/edge_applications/{edge_application_id}/origins/{origin_id}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsOriginsApi(config);
            var edgeApplicationId = 789L;  // long | 
            var originKey = "originKey_example";  // string | 
            var accept = application/json; version=3;  // string? |  (optional) 
            var contentType = application/json;  // string? | The type of coding used in the Body (application/json). <br>  Example: Content-Type: application/json (optional) 
            var updateOriginsRequest = new UpdateOriginsRequest?(); // UpdateOriginsRequest? |  (optional) 

            try
            {
                // /edge_applications/{edge_application_id}/origins/{origin_id}
                OriginsIdResponse result = apiInstance.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPut(edgeApplicationId, originKey, accept, contentType, updateOriginsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/{edge_application_id}/origins/{origin_id}
    ApiResponse<OriginsIdResponse> response = apiInstance.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPutWithHttpInfo(edgeApplicationId, originKey, accept, contentType, updateOriginsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** |  |  |
| **originKey** | **string** |  |  |
| **accept** | **string?** |  | [optional]  |
| **contentType** | **string?** | The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json | [optional]  |
| **updateOriginsRequest** | [**UpdateOriginsRequest?**](UpdateOriginsRequest?.md) |  | [optional]  |

### Return type

[**OriginsIdResponse**](OriginsIdResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

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

<a id="edgeapplicationsedgeapplicationidoriginspost"></a>
# **EdgeApplicationsEdgeApplicationIdOriginsPost**
> OriginsIdResponse EdgeApplicationsEdgeApplicationIdOriginsPost (long edgeApplicationId, string? accept = null, string? contentType = null, CreateOriginsRequest? createOriginsRequest = null)

/edge_applications/{edge_application_id}/origins

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdOriginsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsOriginsApi(config);
            var edgeApplicationId = 789L;  // long | 
            var accept = application/json; version=3;  // string? |  (optional) 
            var contentType = application/json;  // string? | The type of coding used in the Body (application/json). <br>  Example: Content-Type: application/json (optional) 
            var createOriginsRequest = new CreateOriginsRequest?(); // CreateOriginsRequest? |  (optional) 

            try
            {
                // /edge_applications/{edge_application_id}/origins
                OriginsIdResponse result = apiInstance.EdgeApplicationsEdgeApplicationIdOriginsPost(edgeApplicationId, accept, contentType, createOriginsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdOriginsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/{edge_application_id}/origins
    ApiResponse<OriginsIdResponse> response = apiInstance.EdgeApplicationsEdgeApplicationIdOriginsPostWithHttpInfo(edgeApplicationId, accept, contentType, createOriginsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** |  |  |
| **accept** | **string?** |  | [optional]  |
| **contentType** | **string?** | The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json | [optional]  |
| **createOriginsRequest** | [**CreateOriginsRequest?**](CreateOriginsRequest?.md) |  | [optional]  |

### Return type

[**OriginsIdResponse**](OriginsIdResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

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

