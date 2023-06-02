# edgefunctions.Api.EdgeFunctionsApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EdgeFunctionsGet**](EdgeFunctionsApi.md#edgefunctionsget) | **GET** /edge_functions | edge_functions |
| [**EdgeFunctionsIdDelete**](EdgeFunctionsApi.md#edgefunctionsiddelete) | **DELETE** /edge_functions/{id} | edge_functions |
| [**EdgeFunctionsIdGet**](EdgeFunctionsApi.md#edgefunctionsidget) | **GET** /edge_functions/{id} | edge_functions |
| [**EdgeFunctionsIdPatch**](EdgeFunctionsApi.md#edgefunctionsidpatch) | **PATCH** /edge_functions/{id} | edge_functions |
| [**EdgeFunctionsIdPut**](EdgeFunctionsApi.md#edgefunctionsidput) | **PUT** /edge_functions/{id} | edge_functions |
| [**EdgeFunctionsPost**](EdgeFunctionsApi.md#edgefunctionspost) | **POST** /edge_functions | edge_functions |

<a id="edgefunctionsget"></a>
# **EdgeFunctionsGet**
> ListEdgeFunctionResponse EdgeFunctionsGet (long? page = null, long? pageSize = null, string sort = null, string orderBy = null)

edge_functions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefunctions.Api;
using edgefunctions.Client;
using edgefunctions.Model;

namespace Example
{
    public class EdgeFunctionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeFunctionsApi(config);
            var page = 789L;  // long? |  (optional) 
            var pageSize = 789L;  // long? |  (optional) 
            var sort = "sort_example";  // string |  (optional) 
            var orderBy = "orderBy_example";  // string |  (optional) 

            try
            {
                // edge_functions
                ListEdgeFunctionResponse result = apiInstance.EdgeFunctionsGet(page, pageSize, sort, orderBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeFunctionsApi.EdgeFunctionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFunctionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // edge_functions
    ApiResponse<ListEdgeFunctionResponse> response = apiInstance.EdgeFunctionsGetWithHttpInfo(page, pageSize, sort, orderBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeFunctionsApi.EdgeFunctionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **long?** |  | [optional]  |
| **pageSize** | **long?** |  | [optional]  |
| **sort** | **string** |  | [optional]  |
| **orderBy** | **string** |  | [optional]  |

### Return type

[**ListEdgeFunctionResponse**](ListEdgeFunctionResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefunctionsiddelete"></a>
# **EdgeFunctionsIdDelete**
> void EdgeFunctionsIdDelete (long id)

edge_functions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefunctions.Api;
using edgefunctions.Client;
using edgefunctions.Model;

namespace Example
{
    public class EdgeFunctionsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeFunctionsApi(config);
            var id = 789L;  // long | 

            try
            {
                // edge_functions
                apiInstance.EdgeFunctionsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeFunctionsApi.EdgeFunctionsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFunctionsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // edge_functions
    apiInstance.EdgeFunctionsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeFunctionsApi.EdgeFunctionsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefunctionsidget"></a>
# **EdgeFunctionsIdGet**
> EdgeFunctionResponse EdgeFunctionsIdGet (long id)

edge_functions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefunctions.Api;
using edgefunctions.Client;
using edgefunctions.Model;

namespace Example
{
    public class EdgeFunctionsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeFunctionsApi(config);
            var id = 789L;  // long | 

            try
            {
                // edge_functions
                EdgeFunctionResponse result = apiInstance.EdgeFunctionsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeFunctionsApi.EdgeFunctionsIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFunctionsIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // edge_functions
    ApiResponse<EdgeFunctionResponse> response = apiInstance.EdgeFunctionsIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeFunctionsApi.EdgeFunctionsIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |

### Return type

[**EdgeFunctionResponse**](EdgeFunctionResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefunctionsidpatch"></a>
# **EdgeFunctionsIdPatch**
> EdgeFunctionResponse EdgeFunctionsIdPatch (long id, PatchEdgeFunctionRequest patchEdgeFunctionRequest)

edge_functions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefunctions.Api;
using edgefunctions.Client;
using edgefunctions.Model;

namespace Example
{
    public class EdgeFunctionsIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeFunctionsApi(config);
            var id = 789L;  // long | 
            var patchEdgeFunctionRequest = new PatchEdgeFunctionRequest(); // PatchEdgeFunctionRequest | 

            try
            {
                // edge_functions
                EdgeFunctionResponse result = apiInstance.EdgeFunctionsIdPatch(id, patchEdgeFunctionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeFunctionsApi.EdgeFunctionsIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFunctionsIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // edge_functions
    ApiResponse<EdgeFunctionResponse> response = apiInstance.EdgeFunctionsIdPatchWithHttpInfo(id, patchEdgeFunctionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeFunctionsApi.EdgeFunctionsIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **patchEdgeFunctionRequest** | [**PatchEdgeFunctionRequest**](PatchEdgeFunctionRequest.md) |  |  |

### Return type

[**EdgeFunctionResponse**](EdgeFunctionResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json; version=3
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Invalid request |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefunctionsidput"></a>
# **EdgeFunctionsIdPut**
> EdgeFunctionResponse EdgeFunctionsIdPut (long id, PutEdgeFunctionRequest putEdgeFunctionRequest)

edge_functions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefunctions.Api;
using edgefunctions.Client;
using edgefunctions.Model;

namespace Example
{
    public class EdgeFunctionsIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeFunctionsApi(config);
            var id = 789L;  // long | 
            var putEdgeFunctionRequest = new PutEdgeFunctionRequest(); // PutEdgeFunctionRequest | 

            try
            {
                // edge_functions
                EdgeFunctionResponse result = apiInstance.EdgeFunctionsIdPut(id, putEdgeFunctionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeFunctionsApi.EdgeFunctionsIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFunctionsIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // edge_functions
    ApiResponse<EdgeFunctionResponse> response = apiInstance.EdgeFunctionsIdPutWithHttpInfo(id, putEdgeFunctionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeFunctionsApi.EdgeFunctionsIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **putEdgeFunctionRequest** | [**PutEdgeFunctionRequest**](PutEdgeFunctionRequest.md) |  |  |

### Return type

[**EdgeFunctionResponse**](EdgeFunctionResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json; version=3
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Invalid request |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefunctionspost"></a>
# **EdgeFunctionsPost**
> EdgeFunctionResponse EdgeFunctionsPost (CreateEdgeFunctionRequest createEdgeFunctionRequest)

edge_functions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefunctions.Api;
using edgefunctions.Client;
using edgefunctions.Model;

namespace Example
{
    public class EdgeFunctionsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeFunctionsApi(config);
            var createEdgeFunctionRequest = new CreateEdgeFunctionRequest(); // CreateEdgeFunctionRequest | 

            try
            {
                // edge_functions
                EdgeFunctionResponse result = apiInstance.EdgeFunctionsPost(createEdgeFunctionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeFunctionsApi.EdgeFunctionsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFunctionsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // edge_functions
    ApiResponse<EdgeFunctionResponse> response = apiInstance.EdgeFunctionsPostWithHttpInfo(createEdgeFunctionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeFunctionsApi.EdgeFunctionsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createEdgeFunctionRequest** | [**CreateEdgeFunctionRequest**](CreateEdgeFunctionRequest.md) |  |  |

### Return type

[**EdgeFunctionResponse**](EdgeFunctionResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |
| **400** | Invalid request |  -  |
| **0** | Unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

