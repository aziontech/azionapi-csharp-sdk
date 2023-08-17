# networklist.Api.DefaultApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**NetworkListsGet**](DefaultApi.md#networklistsget) | **GET** /network_lists | List all user Network Lists |
| [**NetworkListsPost**](DefaultApi.md#networklistspost) | **POST** /network_lists | Create a Network Lists |
| [**NetworkListsUuidDelete**](DefaultApi.md#networklistsuuiddelete) | **DELETE** /network_lists/{uuid} | Delete a Network Lists set by uuid |
| [**NetworkListsUuidGet**](DefaultApi.md#networklistsuuidget) | **GET** /network_lists/{uuid} | Retrieve a Network Lists set by uuid |
| [**NetworkListsUuidPut**](DefaultApi.md#networklistsuuidput) | **PUT** /network_lists/{uuid} | Overwrite some Network Lists attributes |

<a id="networklistsget"></a>
# **NetworkListsGet**
> ListNetworkListsResponse NetworkListsGet (int? page = null, int? pageSize = null, string sort = null, string orderBy = null)

List all user Network Lists

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using networklist.Api;
using networklist.Client;
using networklist.Model;

namespace Example
{
    public class NetworkListsGetExample
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
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var sort = "sort_example";  // string |  (optional) 
            var orderBy = "orderBy_example";  // string |  (optional) 

            try
            {
                // List all user Network Lists
                ListNetworkListsResponse result = apiInstance.NetworkListsGet(page, pageSize, sort, orderBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.NetworkListsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NetworkListsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all user Network Lists
    ApiResponse<ListNetworkListsResponse> response = apiInstance.NetworkListsGetWithHttpInfo(page, pageSize, sort, orderBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.NetworkListsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **sort** | **string** |  | [optional]  |
| **orderBy** | **string** |  | [optional]  |

### Return type

[**ListNetworkListsResponse**](ListNetworkListsResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of Network Lists |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="networklistspost"></a>
# **NetworkListsPost**
> NetworkListsResponse NetworkListsPost (CreateNetworkListsRequest createNetworkListsRequest)

Create a Network Lists

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using networklist.Api;
using networklist.Client;
using networklist.Model;

namespace Example
{
    public class NetworkListsPostExample
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
            var createNetworkListsRequest = new CreateNetworkListsRequest(); // CreateNetworkListsRequest | 

            try
            {
                // Create a Network Lists
                NetworkListsResponse result = apiInstance.NetworkListsPost(createNetworkListsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.NetworkListsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NetworkListsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Network Lists
    ApiResponse<NetworkListsResponse> response = apiInstance.NetworkListsPostWithHttpInfo(createNetworkListsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.NetworkListsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createNetworkListsRequest** | [**CreateNetworkListsRequest**](CreateNetworkListsRequest.md) |  |  |

### Return type

[**NetworkListsResponse**](NetworkListsResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A Network Lists object |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="networklistsuuiddelete"></a>
# **NetworkListsUuidDelete**
> void NetworkListsUuidDelete (string uuid, string accept = null)

Delete a Network Lists set by uuid

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using networklist.Api;
using networklist.Client;
using networklist.Model;

namespace Example
{
    public class NetworkListsUuidDeleteExample
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
            var uuid = "uuid_example";  // string | The id of the networkList to be deleted. 
            var accept = application/json; version=3;  // string |  (optional) 

            try
            {
                // Delete a Network Lists set by uuid
                apiInstance.NetworkListsUuidDelete(uuid, accept);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.NetworkListsUuidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NetworkListsUuidDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Network Lists set by uuid
    apiInstance.NetworkListsUuidDeleteWithHttpInfo(uuid, accept);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.NetworkListsUuidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **string** | The id of the networkList to be deleted.  |  |
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
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="networklistsuuidget"></a>
# **NetworkListsUuidGet**
> NetworkListUuidResponse NetworkListsUuidGet (string uuid)

Retrieve a Network Lists set by uuid

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using networklist.Api;
using networklist.Client;
using networklist.Model;

namespace Example
{
    public class NetworkListsUuidGetExample
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
                // Retrieve a Network Lists set by uuid
                NetworkListUuidResponse result = apiInstance.NetworkListsUuidGet(uuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.NetworkListsUuidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NetworkListsUuidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Network Lists set by uuid
    ApiResponse<NetworkListUuidResponse> response = apiInstance.NetworkListsUuidGetWithHttpInfo(uuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.NetworkListsUuidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **string** |  |  |

### Return type

[**NetworkListUuidResponse**](NetworkListUuidResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A Network Lists object |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="networklistsuuidput"></a>
# **NetworkListsUuidPut**
> NetworkListsResponse NetworkListsUuidPut (string uuid, CreateNetworkListsRequest createNetworkListsRequest)

Overwrite some Network Lists attributes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using networklist.Api;
using networklist.Client;
using networklist.Model;

namespace Example
{
    public class NetworkListsUuidPutExample
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
            var createNetworkListsRequest = new CreateNetworkListsRequest(); // CreateNetworkListsRequest | 

            try
            {
                // Overwrite some Network Lists attributes
                NetworkListsResponse result = apiInstance.NetworkListsUuidPut(uuid, createNetworkListsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.NetworkListsUuidPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NetworkListsUuidPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Overwrite some Network Lists attributes
    ApiResponse<NetworkListsResponse> response = apiInstance.NetworkListsUuidPutWithHttpInfo(uuid, createNetworkListsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.NetworkListsUuidPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **string** |  |  |
| **createNetworkListsRequest** | [**CreateNetworkListsRequest**](CreateNetworkListsRequest.md) |  |  |

### Return type

[**NetworkListsResponse**](NetworkListsResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully updated |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

