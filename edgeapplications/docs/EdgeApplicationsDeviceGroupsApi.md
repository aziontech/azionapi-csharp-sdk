# edgeapplications.Api.EdgeApplicationsDeviceGroupsApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdDelete**](EdgeApplicationsDeviceGroupsApi.md#edgeapplicationsedgeapplicationiddevicegroupsdevicegroupiddelete) | **DELETE** /edge_applications/{edge_application_id}/device_groups/{device_group_id} | /edge_applications/{edge_application_id}/device_groups/{device_group_id} |
| [**EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdGet**](EdgeApplicationsDeviceGroupsApi.md#edgeapplicationsedgeapplicationiddevicegroupsdevicegroupidget) | **GET** /edge_applications/{edge_application_id}/device_groups/{device_group_id} | /edge_applications/{edge_application_id}/device_groups/{device_group_id} |
| [**EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdPatch**](EdgeApplicationsDeviceGroupsApi.md#edgeapplicationsedgeapplicationiddevicegroupsdevicegroupidpatch) | **PATCH** /edge_applications/{edge_application_id}/device_groups/{device_group_id} | /edge_applications/{edge_application_id}/device_groups/{device_group_id} |
| [**EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdPut**](EdgeApplicationsDeviceGroupsApi.md#edgeapplicationsedgeapplicationiddevicegroupsdevicegroupidput) | **PUT** /edge_applications/{edge_application_id}/device_groups/{device_group_id} | /edge_applications/{edge_application_id}/device_groups/{device_group_id} |
| [**EdgeApplicationsEdgeApplicationIdDeviceGroupsGet**](EdgeApplicationsDeviceGroupsApi.md#edgeapplicationsedgeapplicationiddevicegroupsget) | **GET** /edge_applications/{edge_application_id}/device_groups | /edge_applications/{edge_application_id}/device_groups |
| [**EdgeApplicationsEdgeApplicationIdDeviceGroupsPost**](EdgeApplicationsDeviceGroupsApi.md#edgeapplicationsedgeapplicationiddevicegroupspost) | **POST** /edge_applications/{edge_application_id}/device_groups | /edge_applications/{edge_application_id}/device_groups |

<a id="edgeapplicationsedgeapplicationiddevicegroupsdevicegroupiddelete"></a>
# **EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdDelete**
> void EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdDelete (long edgeApplicationId, long deviceGroupId, string? accept = null)

/edge_applications/{edge_application_id}/device_groups/{device_group_id}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsDeviceGroupsApi(config);
            var edgeApplicationId = 789L;  // long | 
            var deviceGroupId = 789L;  // long | 
            var accept = application/json; version=3;  // string? | The id of the Device Groups that you plan to delete. (optional) 

            try
            {
                // /edge_applications/{edge_application_id}/device_groups/{device_group_id}
                apiInstance.EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdDelete(edgeApplicationId, deviceGroupId, accept);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsDeviceGroupsApi.EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/{edge_application_id}/device_groups/{device_group_id}
    apiInstance.EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdDeleteWithHttpInfo(edgeApplicationId, deviceGroupId, accept);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsDeviceGroupsApi.EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** |  |  |
| **deviceGroupId** | **long** |  |  |
| **accept** | **string?** | The id of the Device Groups that you plan to delete. | [optional]  |

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

<a id="edgeapplicationsedgeapplicationiddevicegroupsdevicegroupidget"></a>
# **EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdGet**
> DeviceGroupsIdResponse EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdGet (long edgeApplicationId, long deviceGroupId, string? accept = null)

/edge_applications/{edge_application_id}/device_groups/{device_group_id}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsDeviceGroupsApi(config);
            var edgeApplicationId = 789L;  // long | 
            var deviceGroupId = 789L;  // long | 
            var accept = application/json; version=3;  // string? | The id of the Device Groups that you plan to query. (optional) 

            try
            {
                // /edge_applications/{edge_application_id}/device_groups/{device_group_id}
                DeviceGroupsIdResponse result = apiInstance.EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdGet(edgeApplicationId, deviceGroupId, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsDeviceGroupsApi.EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/{edge_application_id}/device_groups/{device_group_id}
    ApiResponse<DeviceGroupsIdResponse> response = apiInstance.EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdGetWithHttpInfo(edgeApplicationId, deviceGroupId, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsDeviceGroupsApi.EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** |  |  |
| **deviceGroupId** | **long** |  |  |
| **accept** | **string?** | The id of the Device Groups that you plan to query. | [optional]  |

### Return type

[**DeviceGroupsIdResponse**](DeviceGroupsIdResponse.md)

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

<a id="edgeapplicationsedgeapplicationiddevicegroupsdevicegroupidpatch"></a>
# **EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdPatch**
> DeviceGroupsIdResponse EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdPatch (long edgeApplicationId, long deviceGroupId, string? accept = null, string? contentType = null, PatchDeviceGroupsRequest? patchDeviceGroupsRequest = null)

/edge_applications/{edge_application_id}/device_groups/{device_group_id}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsDeviceGroupsApi(config);
            var edgeApplicationId = 789L;  // long | 
            var deviceGroupId = 789L;  // long | 
            var accept = application/json; version=3;  // string? |  (optional) 
            var contentType = application/json;  // string? | The type of coding used in the Body (application/json). <br>  Example: Content-Type: application/json (optional) 
            var patchDeviceGroupsRequest = new PatchDeviceGroupsRequest?(); // PatchDeviceGroupsRequest? |  (optional) 

            try
            {
                // /edge_applications/{edge_application_id}/device_groups/{device_group_id}
                DeviceGroupsIdResponse result = apiInstance.EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdPatch(edgeApplicationId, deviceGroupId, accept, contentType, patchDeviceGroupsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsDeviceGroupsApi.EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/{edge_application_id}/device_groups/{device_group_id}
    ApiResponse<DeviceGroupsIdResponse> response = apiInstance.EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdPatchWithHttpInfo(edgeApplicationId, deviceGroupId, accept, contentType, patchDeviceGroupsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsDeviceGroupsApi.EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** |  |  |
| **deviceGroupId** | **long** |  |  |
| **accept** | **string?** |  | [optional]  |
| **contentType** | **string?** | The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json | [optional]  |
| **patchDeviceGroupsRequest** | [**PatchDeviceGroupsRequest?**](PatchDeviceGroupsRequest?.md) |  | [optional]  |

### Return type

[**DeviceGroupsIdResponse**](DeviceGroupsIdResponse.md)

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

<a id="edgeapplicationsedgeapplicationiddevicegroupsdevicegroupidput"></a>
# **EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdPut**
> DeviceGroupsIdResponse EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdPut (long edgeApplicationId, long deviceGroupId, string? accept = null, string? contentType = null, UpdateDeviceGroupsRequest? updateDeviceGroupsRequest = null)

/edge_applications/{edge_application_id}/device_groups/{device_group_id}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsDeviceGroupsApi(config);
            var edgeApplicationId = 789L;  // long | 
            var deviceGroupId = 789L;  // long | 
            var accept = application/json; version=3;  // string? |  (optional) 
            var contentType = application/json;  // string? | The type of coding used in the Body (application/json). <br>  Example: Content-Type: application/json (optional) 
            var updateDeviceGroupsRequest = new UpdateDeviceGroupsRequest?(); // UpdateDeviceGroupsRequest? |  (optional) 

            try
            {
                // /edge_applications/{edge_application_id}/device_groups/{device_group_id}
                DeviceGroupsIdResponse result = apiInstance.EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdPut(edgeApplicationId, deviceGroupId, accept, contentType, updateDeviceGroupsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsDeviceGroupsApi.EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/{edge_application_id}/device_groups/{device_group_id}
    ApiResponse<DeviceGroupsIdResponse> response = apiInstance.EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdPutWithHttpInfo(edgeApplicationId, deviceGroupId, accept, contentType, updateDeviceGroupsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsDeviceGroupsApi.EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** |  |  |
| **deviceGroupId** | **long** |  |  |
| **accept** | **string?** |  | [optional]  |
| **contentType** | **string?** | The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json | [optional]  |
| **updateDeviceGroupsRequest** | [**UpdateDeviceGroupsRequest?**](UpdateDeviceGroupsRequest?.md) |  | [optional]  |

### Return type

[**DeviceGroupsIdResponse**](DeviceGroupsIdResponse.md)

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

<a id="edgeapplicationsedgeapplicationiddevicegroupsget"></a>
# **EdgeApplicationsEdgeApplicationIdDeviceGroupsGet**
> DeviceGroupsResponse EdgeApplicationsEdgeApplicationIdDeviceGroupsGet (long edgeApplicationId, long? page = null, long? pageSize = null, string? filter = null, string? orderBy = null, string? sort = null, string? accept = null)

/edge_applications/{edge_application_id}/device_groups

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdDeviceGroupsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsDeviceGroupsApi(config);
            var edgeApplicationId = 789L;  // long | 
            var page = 789L;  // long? |  (optional) 
            var pageSize = 789L;  // long? |  (optional) 
            var filter = "filter_example";  // string? |  (optional) 
            var orderBy = "orderBy_example";  // string? |  (optional) 
            var sort = "sort_example";  // string? |  (optional) 
            var accept = application/json; version=3;  // string? |  (optional) 

            try
            {
                // /edge_applications/{edge_application_id}/device_groups
                DeviceGroupsResponse result = apiInstance.EdgeApplicationsEdgeApplicationIdDeviceGroupsGet(edgeApplicationId, page, pageSize, filter, orderBy, sort, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsDeviceGroupsApi.EdgeApplicationsEdgeApplicationIdDeviceGroupsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdDeviceGroupsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/{edge_application_id}/device_groups
    ApiResponse<DeviceGroupsResponse> response = apiInstance.EdgeApplicationsEdgeApplicationIdDeviceGroupsGetWithHttpInfo(edgeApplicationId, page, pageSize, filter, orderBy, sort, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsDeviceGroupsApi.EdgeApplicationsEdgeApplicationIdDeviceGroupsGetWithHttpInfo: " + e.Message);
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

[**DeviceGroupsResponse**](DeviceGroupsResponse.md)

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

<a id="edgeapplicationsedgeapplicationiddevicegroupspost"></a>
# **EdgeApplicationsEdgeApplicationIdDeviceGroupsPost**
> DeviceGroupsIdResponse EdgeApplicationsEdgeApplicationIdDeviceGroupsPost (long edgeApplicationId, string? accept = null, string? contentType = null, CreateDeviceGroupsRequest? createDeviceGroupsRequest = null)

/edge_applications/{edge_application_id}/device_groups

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdDeviceGroupsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsDeviceGroupsApi(config);
            var edgeApplicationId = 789L;  // long | 
            var accept = application/json; version=3;  // string? |  (optional) 
            var contentType = application/json;  // string? | The type of coding used in the Body (application/json). <br>  Example: Content-Type: application/json (optional) 
            var createDeviceGroupsRequest = new CreateDeviceGroupsRequest?(); // CreateDeviceGroupsRequest? |  (optional) 

            try
            {
                // /edge_applications/{edge_application_id}/device_groups
                DeviceGroupsIdResponse result = apiInstance.EdgeApplicationsEdgeApplicationIdDeviceGroupsPost(edgeApplicationId, accept, contentType, createDeviceGroupsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsDeviceGroupsApi.EdgeApplicationsEdgeApplicationIdDeviceGroupsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdDeviceGroupsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/{edge_application_id}/device_groups
    ApiResponse<DeviceGroupsIdResponse> response = apiInstance.EdgeApplicationsEdgeApplicationIdDeviceGroupsPostWithHttpInfo(edgeApplicationId, accept, contentType, createDeviceGroupsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsDeviceGroupsApi.EdgeApplicationsEdgeApplicationIdDeviceGroupsPostWithHttpInfo: " + e.Message);
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
| **createDeviceGroupsRequest** | [**CreateDeviceGroupsRequest?**](CreateDeviceGroupsRequest?.md) |  | [optional]  |

### Return type

[**DeviceGroupsIdResponse**](DeviceGroupsIdResponse.md)

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
| **415** | Unsupported Media Type |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

