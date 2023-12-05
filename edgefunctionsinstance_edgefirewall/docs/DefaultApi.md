# edgefunctionsinstance_edgefirewall.Api.DefaultApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdDelete**](DefaultApi.md#edgefirewalledgefirewallidfunctionsinstancesedgefunctioninstanceiddelete) | **DELETE** /edge_firewall/{edge_firewall_id}/functions_instances/{edge_function_instance_id} | Delete an Edge Functions Instance by uuid |
| [**EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdGet**](DefaultApi.md#edgefirewalledgefirewallidfunctionsinstancesedgefunctioninstanceidget) | **GET** /edge_firewall/{edge_firewall_id}/functions_instances/{edge_function_instance_id} | Retrieve an Edge Functions Instance set by uuid |
| [**EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdPatch**](DefaultApi.md#edgefirewalledgefirewallidfunctionsinstancesedgefunctioninstanceidpatch) | **PATCH** /edge_firewall/{edge_firewall_id}/functions_instances/{edge_function_instance_id} | Update some Edge Functions Instance attributes |
| [**EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdPut**](DefaultApi.md#edgefirewalledgefirewallidfunctionsinstancesedgefunctioninstanceidput) | **PUT** /edge_firewall/{edge_firewall_id}/functions_instances/{edge_function_instance_id} | Overwrite some Edge Functions Instance attributes |
| [**EdgeFirewallEdgeFirewallIdFunctionsInstancesGet**](DefaultApi.md#edgefirewalledgefirewallidfunctionsinstancesget) | **GET** /edge_firewall/{edge_firewall_id}/functions_instances | List all user Edge Functions Instances |
| [**EdgeFirewallEdgeFirewallIdFunctionsInstancesPost**](DefaultApi.md#edgefirewalledgefirewallidfunctionsinstancespost) | **POST** /edge_firewall/{edge_firewall_id}/functions_instances | Create an Edge Functions Instance |

<a id="edgefirewalledgefirewallidfunctionsinstancesedgefunctioninstanceiddelete"></a>
# **EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdDelete**
> void EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdDelete (long edgeFirewallId, long edgeFunctionInstanceId)

Delete an Edge Functions Instance by uuid

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefunctionsinstance_edgefirewall.Api;
using edgefunctionsinstance_edgefirewall.Client;
using edgefunctionsinstance_edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var edgeFirewallId = 789L;  // long | 
            var edgeFunctionInstanceId = 789L;  // long | 

            try
            {
                // Delete an Edge Functions Instance by uuid
                apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdDelete(edgeFirewallId, edgeFunctionInstanceId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an Edge Functions Instance by uuid
    apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdDeleteWithHttpInfo(edgeFirewallId, edgeFunctionInstanceId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeFirewallId** | **long** |  |  |
| **edgeFunctionInstanceId** | **long** |  |  |

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
| **204** | Successfully deleted |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewalledgefirewallidfunctionsinstancesedgefunctioninstanceidget"></a>
# **EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdGet**
> EdgeFunctionsInstanceResponse EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdGet (long edgeFirewallId, long edgeFunctionInstanceId)

Retrieve an Edge Functions Instance set by uuid

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefunctionsinstance_edgefirewall.Api;
using edgefunctionsinstance_edgefirewall.Client;
using edgefunctionsinstance_edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var edgeFirewallId = 789L;  // long | 
            var edgeFunctionInstanceId = 789L;  // long | 

            try
            {
                // Retrieve an Edge Functions Instance set by uuid
                EdgeFunctionsInstanceResponse result = apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdGet(edgeFirewallId, edgeFunctionInstanceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an Edge Functions Instance set by uuid
    ApiResponse<EdgeFunctionsInstanceResponse> response = apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdGetWithHttpInfo(edgeFirewallId, edgeFunctionInstanceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeFirewallId** | **long** |  |  |
| **edgeFunctionInstanceId** | **long** |  |  |

### Return type

[**EdgeFunctionsInstanceResponse**](EdgeFunctionsInstanceResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An Edge Functions Instance object |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewalledgefirewallidfunctionsinstancesedgefunctioninstanceidpatch"></a>
# **EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdPatch**
> EdgeFunctionsInstanceResponse EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdPatch (long edgeFirewallId, long edgeFunctionInstanceId, CreateEdgeFunctionsInstancesRequest body)

Update some Edge Functions Instance attributes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefunctionsinstance_edgefirewall.Api;
using edgefunctionsinstance_edgefirewall.Client;
using edgefunctionsinstance_edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var edgeFirewallId = 789L;  // long | 
            var edgeFunctionInstanceId = 789L;  // long | 
            var body = new CreateEdgeFunctionsInstancesRequest();  // CreateEdgeFunctionsInstancesRequest | 

            try
            {
                // Update some Edge Functions Instance attributes
                EdgeFunctionsInstanceResponse result = apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdPatch(edgeFirewallId, edgeFunctionInstanceId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update some Edge Functions Instance attributes
    ApiResponse<EdgeFunctionsInstanceResponse> response = apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdPatchWithHttpInfo(edgeFirewallId, edgeFunctionInstanceId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeFirewallId** | **long** |  |  |
| **edgeFunctionInstanceId** | **long** |  |  |
| **body** | **CreateEdgeFunctionsInstancesRequest** |  |  |

### Return type

[**EdgeFunctionsInstanceResponse**](EdgeFunctionsInstanceResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully updated |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewalledgefirewallidfunctionsinstancesedgefunctioninstanceidput"></a>
# **EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdPut**
> EdgeFunctionsInstanceResponse EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdPut (long edgeFirewallId, long edgeFunctionInstanceId, CreateEdgeFunctionsInstancesRequest body)

Overwrite some Edge Functions Instance attributes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefunctionsinstance_edgefirewall.Api;
using edgefunctionsinstance_edgefirewall.Client;
using edgefunctionsinstance_edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var edgeFirewallId = 789L;  // long | 
            var edgeFunctionInstanceId = 789L;  // long | 
            var body = new CreateEdgeFunctionsInstancesRequest();  // CreateEdgeFunctionsInstancesRequest | 

            try
            {
                // Overwrite some Edge Functions Instance attributes
                EdgeFunctionsInstanceResponse result = apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdPut(edgeFirewallId, edgeFunctionInstanceId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Overwrite some Edge Functions Instance attributes
    ApiResponse<EdgeFunctionsInstanceResponse> response = apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdPutWithHttpInfo(edgeFirewallId, edgeFunctionInstanceId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdFunctionsInstancesEdgeFunctionInstanceIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeFirewallId** | **long** |  |  |
| **edgeFunctionInstanceId** | **long** |  |  |
| **body** | **CreateEdgeFunctionsInstancesRequest** |  |  |

### Return type

[**EdgeFunctionsInstanceResponse**](EdgeFunctionsInstanceResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully updated |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewalledgefirewallidfunctionsinstancesget"></a>
# **EdgeFirewallEdgeFirewallIdFunctionsInstancesGet**
> ListEdgeFunctionsInstancesResponse EdgeFirewallEdgeFirewallIdFunctionsInstancesGet (long edgeFirewallId, long? page = null, long? pageSize = null, string? sort = null, string? orderBy = null)

List all user Edge Functions Instances

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefunctionsinstance_edgefirewall.Api;
using edgefunctionsinstance_edgefirewall.Client;
using edgefunctionsinstance_edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallEdgeFirewallIdFunctionsInstancesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var edgeFirewallId = 789L;  // long | 
            var page = 789L;  // long? |  (optional) 
            var pageSize = 789L;  // long? |  (optional) 
            var sort = "sort_example";  // string? |  (optional) 
            var orderBy = "orderBy_example";  // string? |  (optional) 

            try
            {
                // List all user Edge Functions Instances
                ListEdgeFunctionsInstancesResponse result = apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesGet(edgeFirewallId, page, pageSize, sort, orderBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdFunctionsInstancesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallEdgeFirewallIdFunctionsInstancesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all user Edge Functions Instances
    ApiResponse<ListEdgeFunctionsInstancesResponse> response = apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesGetWithHttpInfo(edgeFirewallId, page, pageSize, sort, orderBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdFunctionsInstancesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeFirewallId** | **long** |  |  |
| **page** | **long?** |  | [optional]  |
| **pageSize** | **long?** |  | [optional]  |
| **sort** | **string?** |  | [optional]  |
| **orderBy** | **string?** |  | [optional]  |

### Return type

[**ListEdgeFunctionsInstancesResponse**](ListEdgeFunctionsInstancesResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of Edge Functions Instances |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewalledgefirewallidfunctionsinstancespost"></a>
# **EdgeFirewallEdgeFirewallIdFunctionsInstancesPost**
> EdgeFunctionsInstanceResponse EdgeFirewallEdgeFirewallIdFunctionsInstancesPost (long edgeFirewallId, CreateEdgeFunctionsInstancesRequest createEdgeFunctionsInstancesRequest)

Create an Edge Functions Instance

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefunctionsinstance_edgefirewall.Api;
using edgefunctionsinstance_edgefirewall.Client;
using edgefunctionsinstance_edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallEdgeFirewallIdFunctionsInstancesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var edgeFirewallId = 789L;  // long | 
            var createEdgeFunctionsInstancesRequest = new CreateEdgeFunctionsInstancesRequest(); // CreateEdgeFunctionsInstancesRequest | 

            try
            {
                // Create an Edge Functions Instance
                EdgeFunctionsInstanceResponse result = apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesPost(edgeFirewallId, createEdgeFunctionsInstancesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdFunctionsInstancesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallEdgeFirewallIdFunctionsInstancesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an Edge Functions Instance
    ApiResponse<EdgeFunctionsInstanceResponse> response = apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesPostWithHttpInfo(edgeFirewallId, createEdgeFunctionsInstancesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdFunctionsInstancesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeFirewallId** | **long** |  |  |
| **createEdgeFunctionsInstancesRequest** | [**CreateEdgeFunctionsInstancesRequest**](CreateEdgeFunctionsInstancesRequest.md) |  |  |

### Return type

[**EdgeFunctionsInstanceResponse**](EdgeFunctionsInstanceResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Edge Functions Instance created |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

