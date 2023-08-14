# edgeapplications.Api.EdgeApplicationsMainSettingsApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EdgeApplicationsGet**](EdgeApplicationsMainSettingsApi.md#edgeapplicationsget) | **GET** /edge_applications | /edge_applications |
| [**EdgeApplicationsIdDelete**](EdgeApplicationsMainSettingsApi.md#edgeapplicationsiddelete) | **DELETE** /edge_applications/{id} | /edge_applications/:id |
| [**EdgeApplicationsIdGet**](EdgeApplicationsMainSettingsApi.md#edgeapplicationsidget) | **GET** /edge_applications/{id} | /edge_applications/:id |
| [**EdgeApplicationsIdPatch**](EdgeApplicationsMainSettingsApi.md#edgeapplicationsidpatch) | **PATCH** /edge_applications/{id} | /edge_applications/:id |
| [**EdgeApplicationsIdPut**](EdgeApplicationsMainSettingsApi.md#edgeapplicationsidput) | **PUT** /edge_applications/{id} | /edge_applications/:id |
| [**EdgeApplicationsPost**](EdgeApplicationsMainSettingsApi.md#edgeapplicationspost) | **POST** /edge_applications | /edge_applications |

<a id="edgeapplicationsget"></a>
# **EdgeApplicationsGet**
> GetApplicationsResponse EdgeApplicationsGet (long? page = null, long? pageSize = null, string filter = null, string orderBy = null, string sort = null, string accept = null)

/edge_applications

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsMainSettingsApi(config);
            var page = 789L;  // long? |  (optional) 
            var pageSize = 789L;  // long? |  (optional) 
            var filter = "filter_example";  // string |  (optional) 
            var orderBy = "orderBy_example";  // string |  (optional) 
            var sort = "sort_example";  // string |  (optional) 
            var accept = application/json; version=3;  // string |  (optional) 

            try
            {
                // /edge_applications
                GetApplicationsResponse result = apiInstance.EdgeApplicationsGet(page, pageSize, filter, orderBy, sort, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsMainSettingsApi.EdgeApplicationsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications
    ApiResponse<GetApplicationsResponse> response = apiInstance.EdgeApplicationsGetWithHttpInfo(page, pageSize, filter, orderBy, sort, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsMainSettingsApi.EdgeApplicationsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **long?** |  | [optional]  |
| **pageSize** | **long?** |  | [optional]  |
| **filter** | **string** |  | [optional]  |
| **orderBy** | **string** |  | [optional]  |
| **sort** | **string** |  | [optional]  |
| **accept** | **string** |  | [optional]  |

### Return type

[**GetApplicationsResponse**](GetApplicationsResponse.md)

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

<a id="edgeapplicationsiddelete"></a>
# **EdgeApplicationsIdDelete**
> void EdgeApplicationsIdDelete (string id, string accept = null)

/edge_applications/:id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsMainSettingsApi(config);
            var id = "id_example";  // string | The id of the edge application that you plan to delete.
            var accept = application/json; version=3;  // string |  (optional) 

            try
            {
                // /edge_applications/:id
                apiInstance.EdgeApplicationsIdDelete(id, accept);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsMainSettingsApi.EdgeApplicationsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/:id
    apiInstance.EdgeApplicationsIdDeleteWithHttpInfo(id, accept);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsMainSettingsApi.EdgeApplicationsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the edge application that you plan to delete. |  |
| **accept** | **string** |  | [optional]  |

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

<a id="edgeapplicationsidget"></a>
# **EdgeApplicationsIdGet**
> GetApplicationResponse EdgeApplicationsIdGet (string id, string accept = null)

/edge_applications/:id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsMainSettingsApi(config);
            var id = "id_example";  // string | 
            var accept = application/json; version=3;  // string |  (optional) 

            try
            {
                // /edge_applications/:id
                GetApplicationResponse result = apiInstance.EdgeApplicationsIdGet(id, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsMainSettingsApi.EdgeApplicationsIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/:id
    ApiResponse<GetApplicationResponse> response = apiInstance.EdgeApplicationsIdGetWithHttpInfo(id, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsMainSettingsApi.EdgeApplicationsIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **accept** | **string** |  | [optional]  |

### Return type

[**GetApplicationResponse**](GetApplicationResponse.md)

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

<a id="edgeapplicationsidpatch"></a>
# **EdgeApplicationsIdPatch**
> ApplicationUpdateResponse EdgeApplicationsIdPatch (string id, string accept = null, string contentType = null, ApplicationUpdateRequest applicationUpdateRequest = null)

/edge_applications/:id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsMainSettingsApi(config);
            var id = "id_example";  // string | 
            var accept = application/json; version=3;  // string |  (optional) 
            var contentType = application/json;  // string | The type of coding used in the Body (application/json). <br>  Example: Content-Type: application/json (optional) 
            var applicationUpdateRequest = new ApplicationUpdateRequest(); // ApplicationUpdateRequest |  (optional) 

            try
            {
                // /edge_applications/:id
                ApplicationUpdateResponse result = apiInstance.EdgeApplicationsIdPatch(id, accept, contentType, applicationUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsMainSettingsApi.EdgeApplicationsIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/:id
    ApiResponse<ApplicationUpdateResponse> response = apiInstance.EdgeApplicationsIdPatchWithHttpInfo(id, accept, contentType, applicationUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsMainSettingsApi.EdgeApplicationsIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **accept** | **string** |  | [optional]  |
| **contentType** | **string** | The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json | [optional]  |
| **applicationUpdateRequest** | [**ApplicationUpdateRequest**](ApplicationUpdateRequest.md) |  | [optional]  |

### Return type

[**ApplicationUpdateResponse**](ApplicationUpdateResponse.md)

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
| **405** | Method Not Allowed |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgeapplicationsidput"></a>
# **EdgeApplicationsIdPut**
> ApplicationPutResult EdgeApplicationsIdPut (string id, string accept = null, string contentType = null, ApplicationPutRequest applicationPutRequest = null)

/edge_applications/:id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsMainSettingsApi(config);
            var id = "id_example";  // string | The Id of the edge application to be overwritten. 
            var accept = application/json; version=3;  // string |  (optional) 
            var contentType = application/json;  // string | The type of coding used in the Body (application/json). <br>  Example: Content-Type: application/json (optional) 
            var applicationPutRequest = new ApplicationPutRequest(); // ApplicationPutRequest |  (optional) 

            try
            {
                // /edge_applications/:id
                ApplicationPutResult result = apiInstance.EdgeApplicationsIdPut(id, accept, contentType, applicationPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsMainSettingsApi.EdgeApplicationsIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/:id
    ApiResponse<ApplicationPutResult> response = apiInstance.EdgeApplicationsIdPutWithHttpInfo(id, accept, contentType, applicationPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsMainSettingsApi.EdgeApplicationsIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The Id of the edge application to be overwritten.  |  |
| **accept** | **string** |  | [optional]  |
| **contentType** | **string** | The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json | [optional]  |
| **applicationPutRequest** | [**ApplicationPutRequest**](ApplicationPutRequest.md) |  | [optional]  |

### Return type

[**ApplicationPutResult**](ApplicationPutResult.md)

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
| **405** | Method Not Allowed |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgeapplicationspost"></a>
# **EdgeApplicationsPost**
> CreateApplicationResult EdgeApplicationsPost (string accept = null, string contentType = null, CreateApplicationRequest createApplicationRequest = null)

/edge_applications

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsMainSettingsApi(config);
            var accept = application/json; version=3;  // string |  (optional) 
            var contentType = application/json;  // string | The type of coding used in the Body (application/json). <br>  Example: Content-Type: application/json (optional) 
            var createApplicationRequest = new CreateApplicationRequest(); // CreateApplicationRequest |  (optional) 

            try
            {
                // /edge_applications
                CreateApplicationResult result = apiInstance.EdgeApplicationsPost(accept, contentType, createApplicationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsMainSettingsApi.EdgeApplicationsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications
    ApiResponse<CreateApplicationResult> response = apiInstance.EdgeApplicationsPostWithHttpInfo(accept, contentType, createApplicationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsMainSettingsApi.EdgeApplicationsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accept** | **string** |  | [optional]  |
| **contentType** | **string** | The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json | [optional]  |
| **createApplicationRequest** | [**CreateApplicationRequest**](CreateApplicationRequest.md) |  | [optional]  |

### Return type

[**CreateApplicationResult**](CreateApplicationResult.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json; version=3
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **201** | Successful response |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **415** | Unsupported Media Type |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

