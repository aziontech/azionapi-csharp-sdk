# networklist.Api.DefaultApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**NetworkListsGet**](DefaultApi.md#networklistsget) | **GET** /network_lists | List all user Network Lists |
| [**NetworkListsPost**](DefaultApi.md#networklistspost) | **POST** /network_lists | Create a Network Lists |
| [**NetworkListsUuidGet**](DefaultApi.md#networklistsuuidget) | **GET** /network_lists/{uuid} | Retrieve a Network Lists set by uuid |
| [**NetworkListsUuidPut**](DefaultApi.md#networklistsuuidput) | **PUT** /network_lists/{uuid} | Overwrite some Network Lists attributes |

<a id="networklistsget"></a>
# **NetworkListsGet**
> ListNetworkListsResponse NetworkListsGet (int? page = null)

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

            try
            {
                // List all user Network Lists
                ListNetworkListsResponse result = apiInstance.NetworkListsGet(page);
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
    ApiResponse<ListNetworkListsResponse> response = apiInstance.NetworkListsGetWithHttpInfo(page);
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

### Return type

[**ListNetworkListsResponse**](ListNetworkListsResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of Network Lists |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="networklistspost"></a>
# **NetworkListsPost**
> void NetworkListsPost (CreateNetworkListsRequest createNetworkListsRequest)

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
                apiInstance.NetworkListsPost(createNetworkListsRequest);
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
    apiInstance.NetworkListsPostWithHttpInfo(createNetworkListsRequest);
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

void (empty response body)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Network Lists created |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="networklistsuuidget"></a>
# **NetworkListsUuidGet**
> NetworkListsResponse NetworkListsUuidGet (string uuid)

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
                NetworkListsResponse result = apiInstance.NetworkListsUuidGet(uuid);
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
    ApiResponse<NetworkListsResponse> response = apiInstance.NetworkListsUuidGetWithHttpInfo(uuid);
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

[**NetworkListsResponse**](NetworkListsResponse.md)

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
> ListNetworkListsResponse NetworkListsUuidPut (string uuid, UpdateNetworkListsRequest updateNetworkListsRequest)

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
            var updateNetworkListsRequest = new UpdateNetworkListsRequest(); // UpdateNetworkListsRequest | 

            try
            {
                // Overwrite some Network Lists attributes
                ListNetworkListsResponse result = apiInstance.NetworkListsUuidPut(uuid, updateNetworkListsRequest);
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
    ApiResponse<ListNetworkListsResponse> response = apiInstance.NetworkListsUuidPutWithHttpInfo(uuid, updateNetworkListsRequest);
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
| **updateNetworkListsRequest** | [**UpdateNetworkListsRequest**](UpdateNetworkListsRequest.md) |  |  |

### Return type

[**ListNetworkListsResponse**](ListNetworkListsResponse.md)

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

