# edgenode.Api.DefaultApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuthorizeEdgeNode**](DefaultApi.md#authorizeedgenode) | **PATCH** /edge_nodes/authorize | Authorize edge-node |
| [**CreateEdgeNodeSvcs**](DefaultApi.md#createedgenodesvcs) | **POST** /edge_nodes/{edgenodeId}/services | Create an edge-node Service association |
| [**DelEdgeNode**](DefaultApi.md#deledgenode) | **DELETE** /edge_nodes/{edgenodeId} | Delete edge-node by ID |
| [**DelEdgeNodeSvc**](DefaultApi.md#deledgenodesvc) | **DELETE** /edge_nodes/{edgenodeId}/services/{bindId} | Delete an edge-node Service association |
| [**GetEdgeNode**](DefaultApi.md#getedgenode) | **GET** /edge_nodes/{edgenodeId} | Return edge-node by ID |
| [**GetEdgeNodeGroups**](DefaultApi.md#getedgenodegroups) | **GET** /edge_nodes/groups | Return edge-node groups |
| [**GetEdgeNodeSvcDetail**](DefaultApi.md#getedgenodesvcdetail) | **GET** /edge_nodes/{edgenodeId}/services/{bindId} | Return edge-node Service association by ID |
| [**GetEdgeNodeSvcs**](DefaultApi.md#getedgenodesvcs) | **GET** /edge_nodes/{edgenodeId}/services | Return edge-node Services association |
| [**GetEdgeNodes**](DefaultApi.md#getedgenodes) | **GET** /edge_nodes | Return edge-nodes |
| [**UpdateEdgeNode**](DefaultApi.md#updateedgenode) | **PATCH** /edge_nodes/{edgenodeId} | Update edge-node |
| [**UpdateEdgeNodeSvcDetail**](DefaultApi.md#updateedgenodesvcdetail) | **PATCH** /edge_nodes/{edgenodeId}/services/{bindId} | Update edge-node Service association by ID |

<a id="authorizeedgenode"></a>
# **AuthorizeEdgeNode**
> AuthorizeEdgeNodesResponse AuthorizeEdgeNode (AuthorizeEdgeNodesRequest authorizeEdgeNodesRequest)

Authorize edge-node

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgenode.Api;
using edgenode.Client;
using edgenode.Model;

namespace Example
{
    public class AuthorizeEdgeNodeExample
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
            var authorizeEdgeNodesRequest = new AuthorizeEdgeNodesRequest(); // AuthorizeEdgeNodesRequest | 

            try
            {
                // Authorize edge-node
                AuthorizeEdgeNodesResponse result = apiInstance.AuthorizeEdgeNode(authorizeEdgeNodesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AuthorizeEdgeNode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthorizeEdgeNodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Authorize edge-node
    ApiResponse<AuthorizeEdgeNodesResponse> response = apiInstance.AuthorizeEdgeNodeWithHttpInfo(authorizeEdgeNodesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.AuthorizeEdgeNodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorizeEdgeNodesRequest** | [**AuthorizeEdgeNodesRequest**](AuthorizeEdgeNodesRequest.md) |  |  |

### Return type

[**AuthorizeEdgeNodesResponse**](AuthorizeEdgeNodesResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json; version=3
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **422** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createedgenodesvcs"></a>
# **CreateEdgeNodeSvcs**
> ServiceBindDetailResponse CreateEdgeNodeSvcs (long edgenodeId, ServiceBindRequest serviceBindRequest)

Create an edge-node Service association

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgenode.Api;
using edgenode.Client;
using edgenode.Model;

namespace Example
{
    public class CreateEdgeNodeSvcsExample
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
            var edgenodeId = 789L;  // long | 
            var serviceBindRequest = new ServiceBindRequest(); // ServiceBindRequest | 

            try
            {
                // Create an edge-node Service association
                ServiceBindDetailResponse result = apiInstance.CreateEdgeNodeSvcs(edgenodeId, serviceBindRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateEdgeNodeSvcs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateEdgeNodeSvcsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an edge-node Service association
    ApiResponse<ServiceBindDetailResponse> response = apiInstance.CreateEdgeNodeSvcsWithHttpInfo(edgenodeId, serviceBindRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateEdgeNodeSvcsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgenodeId** | **long** |  |  |
| **serviceBindRequest** | [**ServiceBindRequest**](ServiceBindRequest.md) |  |  |

### Return type

[**ServiceBindDetailResponse**](ServiceBindDetailResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json; version=3
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deledgenode"></a>
# **DelEdgeNode**
> void DelEdgeNode (long edgenodeId)

Delete edge-node by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgenode.Api;
using edgenode.Client;
using edgenode.Model;

namespace Example
{
    public class DelEdgeNodeExample
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
            var edgenodeId = 789L;  // long | 

            try
            {
                // Delete edge-node by ID
                apiInstance.DelEdgeNode(edgenodeId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DelEdgeNode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DelEdgeNodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete edge-node by ID
    apiInstance.DelEdgeNodeWithHttpInfo(edgenodeId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DelEdgeNodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgenodeId** | **long** |  |  |

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
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deledgenodesvc"></a>
# **DelEdgeNodeSvc**
> void DelEdgeNodeSvc (long edgenodeId, long bindId)

Delete an edge-node Service association

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgenode.Api;
using edgenode.Client;
using edgenode.Model;

namespace Example
{
    public class DelEdgeNodeSvcExample
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
            var edgenodeId = 789L;  // long | 
            var bindId = 789L;  // long | 

            try
            {
                // Delete an edge-node Service association
                apiInstance.DelEdgeNodeSvc(edgenodeId, bindId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DelEdgeNodeSvc: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DelEdgeNodeSvcWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an edge-node Service association
    apiInstance.DelEdgeNodeSvcWithHttpInfo(edgenodeId, bindId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DelEdgeNodeSvcWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgenodeId** | **long** |  |  |
| **bindId** | **long** |  |  |

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
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getedgenode"></a>
# **GetEdgeNode**
> EdgeNodeDetailResponse GetEdgeNode (long edgenodeId)

Return edge-node by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgenode.Api;
using edgenode.Client;
using edgenode.Model;

namespace Example
{
    public class GetEdgeNodeExample
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
            var edgenodeId = 789L;  // long | 

            try
            {
                // Return edge-node by ID
                EdgeNodeDetailResponse result = apiInstance.GetEdgeNode(edgenodeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetEdgeNode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEdgeNodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return edge-node by ID
    ApiResponse<EdgeNodeDetailResponse> response = apiInstance.GetEdgeNodeWithHttpInfo(edgenodeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetEdgeNodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgenodeId** | **long** |  |  |

### Return type

[**EdgeNodeDetailResponse**](EdgeNodeDetailResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getedgenodegroups"></a>
# **GetEdgeNodeGroups**
> List&lt;NodeGroupResponse&gt; GetEdgeNodeGroups ()

Return edge-node groups

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgenode.Api;
using edgenode.Client;
using edgenode.Model;

namespace Example
{
    public class GetEdgeNodeGroupsExample
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

            try
            {
                // Return edge-node groups
                List<NodeGroupResponse> result = apiInstance.GetEdgeNodeGroups();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetEdgeNodeGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEdgeNodeGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return edge-node groups
    ApiResponse<List<NodeGroupResponse>> response = apiInstance.GetEdgeNodeGroupsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetEdgeNodeGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;NodeGroupResponse&gt;**](NodeGroupResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getedgenodesvcdetail"></a>
# **GetEdgeNodeSvcDetail**
> ServiceBindDetailResponse GetEdgeNodeSvcDetail (long edgenodeId, long bindId)

Return edge-node Service association by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgenode.Api;
using edgenode.Client;
using edgenode.Model;

namespace Example
{
    public class GetEdgeNodeSvcDetailExample
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
            var edgenodeId = 789L;  // long | 
            var bindId = 789L;  // long | 

            try
            {
                // Return edge-node Service association by ID
                ServiceBindDetailResponse result = apiInstance.GetEdgeNodeSvcDetail(edgenodeId, bindId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetEdgeNodeSvcDetail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEdgeNodeSvcDetailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return edge-node Service association by ID
    ApiResponse<ServiceBindDetailResponse> response = apiInstance.GetEdgeNodeSvcDetailWithHttpInfo(edgenodeId, bindId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetEdgeNodeSvcDetailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgenodeId** | **long** |  |  |
| **bindId** | **long** |  |  |

### Return type

[**ServiceBindDetailResponse**](ServiceBindDetailResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getedgenodesvcs"></a>
# **GetEdgeNodeSvcs**
> ServiceResponseWithTotal GetEdgeNodeSvcs (long edgenodeId, bool? isBound = null, string filter = null, string orderBy = null, string sort = null, long? page = null, long? pageSize = null)

Return edge-node Services association

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgenode.Api;
using edgenode.Client;
using edgenode.Model;

namespace Example
{
    public class GetEdgeNodeSvcsExample
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
            var edgenodeId = 789L;  // long | 
            var isBound = true;  // bool? |  (optional) 
            var filter = "filter_example";  // string |  (optional) 
            var orderBy = "orderBy_example";  // string |  (optional) 
            var sort = "sort_example";  // string |  (optional) 
            var page = 789L;  // long? |  (optional) 
            var pageSize = 789L;  // long? |  (optional) 

            try
            {
                // Return edge-node Services association
                ServiceResponseWithTotal result = apiInstance.GetEdgeNodeSvcs(edgenodeId, isBound, filter, orderBy, sort, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetEdgeNodeSvcs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEdgeNodeSvcsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return edge-node Services association
    ApiResponse<ServiceResponseWithTotal> response = apiInstance.GetEdgeNodeSvcsWithHttpInfo(edgenodeId, isBound, filter, orderBy, sort, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetEdgeNodeSvcsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgenodeId** | **long** |  |  |
| **isBound** | **bool?** |  | [optional]  |
| **filter** | **string** |  | [optional]  |
| **orderBy** | **string** |  | [optional]  |
| **sort** | **string** |  | [optional]  |
| **page** | **long?** |  | [optional]  |
| **pageSize** | **long?** |  | [optional]  |

### Return type

[**ServiceResponseWithTotal**](ServiceResponseWithTotal.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getedgenodes"></a>
# **GetEdgeNodes**
> EdgeNodeResponseWithTotal GetEdgeNodes (string filter = null, string orderBy = null, string sort = null, bool? onlyIds = null, long? pageSize = null)

Return edge-nodes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgenode.Api;
using edgenode.Client;
using edgenode.Model;

namespace Example
{
    public class GetEdgeNodesExample
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
            var filter = "filter_example";  // string |  (optional) 
            var orderBy = "orderBy_example";  // string |  (optional) 
            var sort = "sort_example";  // string |  (optional) 
            var onlyIds = true;  // bool? |  (optional) 
            var pageSize = 789L;  // long? |  (optional) 

            try
            {
                // Return edge-nodes
                EdgeNodeResponseWithTotal result = apiInstance.GetEdgeNodes(filter, orderBy, sort, onlyIds, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetEdgeNodes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEdgeNodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return edge-nodes
    ApiResponse<EdgeNodeResponseWithTotal> response = apiInstance.GetEdgeNodesWithHttpInfo(filter, orderBy, sort, onlyIds, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetEdgeNodesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filter** | **string** |  | [optional]  |
| **orderBy** | **string** |  | [optional]  |
| **sort** | **string** |  | [optional]  |
| **onlyIds** | **bool?** |  | [optional]  |
| **pageSize** | **long?** |  | [optional]  |

### Return type

[**EdgeNodeResponseWithTotal**](EdgeNodeResponseWithTotal.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateedgenode"></a>
# **UpdateEdgeNode**
> UpdateEdgeNodeResponse UpdateEdgeNode (long edgenodeId)

Update edge-node

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgenode.Api;
using edgenode.Client;
using edgenode.Model;

namespace Example
{
    public class UpdateEdgeNodeExample
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
            var edgenodeId = 789L;  // long | 

            try
            {
                // Update edge-node
                UpdateEdgeNodeResponse result = apiInstance.UpdateEdgeNode(edgenodeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateEdgeNode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateEdgeNodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update edge-node
    ApiResponse<UpdateEdgeNodeResponse> response = apiInstance.UpdateEdgeNodeWithHttpInfo(edgenodeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateEdgeNodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgenodeId** | **long** |  |  |

### Return type

[**UpdateEdgeNodeResponse**](UpdateEdgeNodeResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateedgenodesvcdetail"></a>
# **UpdateEdgeNodeSvcDetail**
> ServiceBindDetailResponse UpdateEdgeNodeSvcDetail (long edgenodeId, long bindId, UpdateServiceBindRequest updateServiceBindRequest)

Update edge-node Service association by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgenode.Api;
using edgenode.Client;
using edgenode.Model;

namespace Example
{
    public class UpdateEdgeNodeSvcDetailExample
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
            var edgenodeId = 789L;  // long | 
            var bindId = 789L;  // long | 
            var updateServiceBindRequest = new UpdateServiceBindRequest(); // UpdateServiceBindRequest | 

            try
            {
                // Update edge-node Service association by ID
                ServiceBindDetailResponse result = apiInstance.UpdateEdgeNodeSvcDetail(edgenodeId, bindId, updateServiceBindRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateEdgeNodeSvcDetail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateEdgeNodeSvcDetailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update edge-node Service association by ID
    ApiResponse<ServiceBindDetailResponse> response = apiInstance.UpdateEdgeNodeSvcDetailWithHttpInfo(edgenodeId, bindId, updateServiceBindRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateEdgeNodeSvcDetailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgenodeId** | **long** |  |  |
| **bindId** | **long** |  |  |
| **updateServiceBindRequest** | [**UpdateServiceBindRequest**](UpdateServiceBindRequest.md) |  |  |

### Return type

[**ServiceBindDetailResponse**](ServiceBindDetailResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json; version=3
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

