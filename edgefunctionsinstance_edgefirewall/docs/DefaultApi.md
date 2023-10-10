# edgefunctionsinstance_edgefirewall.Api.DefaultApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EdgeFirewallEdgeFirewallIdFunctionsInstancesGet**](DefaultApi.md#edgefirewalledgefirewallidfunctionsinstancesget) | **GET** /edge_firewall/:edge_firewall_id:/functions_instances | List all user Edge Functions Instances |
| [**EdgeFirewallEdgeFirewallIdFunctionsInstancesPost**](DefaultApi.md#edgefirewalledgefirewallidfunctionsinstancespost) | **POST** /edge_firewall/:edge_firewall_id:/functions_instances | Create an Edge Functions Instance |
| [**EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidDelete**](DefaultApi.md#edgefirewalledgefirewallidfunctionsinstancesuuiddelete) | **DELETE** /edge_firewall/:edge_firewall_id:/functions_instances/{uuid} | Delete an Edge Functions Instance by uuid |
| [**EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidGet**](DefaultApi.md#edgefirewalledgefirewallidfunctionsinstancesuuidget) | **GET** /edge_firewall/:edge_firewall_id:/functions_instances/{uuid} | Retrieve an Edge Functions Instance set by uuid |
| [**EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidPatch**](DefaultApi.md#edgefirewalledgefirewallidfunctionsinstancesuuidpatch) | **PATCH** /edge_firewall/:edge_firewall_id:/functions_instances/{uuid} | Update some Edge Functions Instance attributes |
| [**EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidPut**](DefaultApi.md#edgefirewalledgefirewallidfunctionsinstancesuuidput) | **PUT** /edge_firewall/:edge_firewall_id:/functions_instances/{uuid} | Overwrite some Edge Functions Instance attributes |

<a id="edgefirewalledgefirewallidfunctionsinstancesget"></a>
# **EdgeFirewallEdgeFirewallIdFunctionsInstancesGet**
> ListEdgeFunctionsInstancesResponse EdgeFirewallEdgeFirewallIdFunctionsInstancesGet (long? page = null, long? pageSize = null, string? sort = null, string? orderBy = null)

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
            var page = 789L;  // long? |  (optional) 
            var pageSize = 789L;  // long? |  (optional) 
            var sort = "sort_example";  // string? |  (optional) 
            var orderBy = "orderBy_example";  // string? |  (optional) 

            try
            {
                // List all user Edge Functions Instances
                ListEdgeFunctionsInstancesResponse result = apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesGet(page, pageSize, sort, orderBy);
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
    ApiResponse<ListEdgeFunctionsInstancesResponse> response = apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesGetWithHttpInfo(page, pageSize, sort, orderBy);
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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewalledgefirewallidfunctionsinstancespost"></a>
# **EdgeFirewallEdgeFirewallIdFunctionsInstancesPost**
> EdgeFunctionsInstanceResponse EdgeFirewallEdgeFirewallIdFunctionsInstancesPost (CreateEdgeFunctionsInstancesRequest createEdgeFunctionsInstancesRequest)

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
            var createEdgeFunctionsInstancesRequest = new CreateEdgeFunctionsInstancesRequest(); // CreateEdgeFunctionsInstancesRequest | 

            try
            {
                // Create an Edge Functions Instance
                EdgeFunctionsInstanceResponse result = apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesPost(createEdgeFunctionsInstancesRequest);
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
    ApiResponse<EdgeFunctionsInstanceResponse> response = apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesPostWithHttpInfo(createEdgeFunctionsInstancesRequest);
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
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewalledgefirewallidfunctionsinstancesuuiddelete"></a>
# **EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidDelete**
> void EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidDelete (string uuid)

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
    public class EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidDeleteExample
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
            var uuid = "uuid_example";  // string | 

            try
            {
                // Delete an Edge Functions Instance by uuid
                apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidDelete(uuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an Edge Functions Instance by uuid
    apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidDeleteWithHttpInfo(uuid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **string** |  |  |

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewalledgefirewallidfunctionsinstancesuuidget"></a>
# **EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidGet**
> EdgeFunctionsInstanceResponse EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidGet (string uuid)

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
    public class EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidGetExample
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
            var uuid = "uuid_example";  // string | 

            try
            {
                // Retrieve an Edge Functions Instance set by uuid
                EdgeFunctionsInstanceResponse result = apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidGet(uuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an Edge Functions Instance set by uuid
    ApiResponse<EdgeFunctionsInstanceResponse> response = apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidGetWithHttpInfo(uuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **string** |  |  |

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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewalledgefirewallidfunctionsinstancesuuidpatch"></a>
# **EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidPatch**
> EdgeFunctionsInstanceResponse EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidPatch (string uuid, CreateEdgeFunctionsInstancesRequest body)

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
    public class EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidPatchExample
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
            var uuid = "uuid_example";  // string | 
            var body = new CreateEdgeFunctionsInstancesRequest();  // CreateEdgeFunctionsInstancesRequest | 

            try
            {
                // Update some Edge Functions Instance attributes
                EdgeFunctionsInstanceResponse result = apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidPatch(uuid, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update some Edge Functions Instance attributes
    ApiResponse<EdgeFunctionsInstanceResponse> response = apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidPatchWithHttpInfo(uuid, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **string** |  |  |
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
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewalledgefirewallidfunctionsinstancesuuidput"></a>
# **EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidPut**
> EdgeFunctionsInstanceResponse EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidPut (string uuid, CreateEdgeFunctionsInstancesRequest body)

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
    public class EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidPutExample
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
            var uuid = "uuid_example";  // string | 
            var body = new CreateEdgeFunctionsInstancesRequest();  // CreateEdgeFunctionsInstancesRequest | 

            try
            {
                // Overwrite some Edge Functions Instance attributes
                EdgeFunctionsInstanceResponse result = apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidPut(uuid, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Overwrite some Edge Functions Instance attributes
    ApiResponse<EdgeFunctionsInstanceResponse> response = apiInstance.EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidPutWithHttpInfo(uuid, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdFunctionsInstancesUuidPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **string** |  |  |
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
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

