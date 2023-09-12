# data_streaming.Api.DataStreamingApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNewDataStreaming**](DataStreamingApi.md#createnewdatastreaming) | **POST** /data_streaming/streamings | Create a new data streaming |
| [**DeleteDataStreamingById**](DataStreamingApi.md#deletedatastreamingbyid) | **DELETE** /data_streaming/streamings/{data_streaming_id} | Delete data streaming |
| [**EditDataStreamingById**](DataStreamingApi.md#editdatastreamingbyid) | **PATCH** /data_streaming/streamings/{data_streaming_id} | Edit data streaming |
| [**ListDataStreamingById**](DataStreamingApi.md#listdatastreamingbyid) | **GET** /data_streaming/streamings/{data_streaming_id} | Get expecific data streaming by Data Streaming ID |
| [**ListDataStreamings**](DataStreamingApi.md#listdatastreamings) | **GET** /data_streaming/streamings | List all exist data streamings |
| [**OverwriteDataStreamingById**](DataStreamingApi.md#overwritedatastreamingbyid) | **PUT** /data_streaming/streamings/{data_streaming_id} | Overwrite data streaming |

<a id="createnewdatastreaming"></a>
# **CreateNewDataStreaming**
> CreateNewDataStreaming201Response CreateNewDataStreaming (CreateNewDataStreamingRequest createNewDataStreamingRequest)

Create a new data streaming

Create a new data streaming.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using data_streaming.Api;
using data_streaming.Client;
using data_streaming.Model;

namespace Example
{
    public class CreateNewDataStreamingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataStreamingApi(config);
            var createNewDataStreamingRequest = new CreateNewDataStreamingRequest(); // CreateNewDataStreamingRequest | 

            try
            {
                // Create a new data streaming
                CreateNewDataStreaming201Response result = apiInstance.CreateNewDataStreaming(createNewDataStreamingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataStreamingApi.CreateNewDataStreaming: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateNewDataStreamingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new data streaming
    ApiResponse<CreateNewDataStreaming201Response> response = apiInstance.CreateNewDataStreamingWithHttpInfo(createNewDataStreamingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataStreamingApi.CreateNewDataStreamingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createNewDataStreamingRequest** | [**CreateNewDataStreamingRequest**](CreateNewDataStreamingRequest.md) |  |  |

### Return type

[**CreateNewDataStreaming201Response**](CreateNewDataStreaming201Response.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created successfully |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **406** | Not Acceptable |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletedatastreamingbyid"></a>
# **DeleteDataStreamingById**
> void DeleteDataStreamingById (int dataStreamingId)

Delete data streaming

Use the DELETE method to remove a data streaming from your account. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using data_streaming.Api;
using data_streaming.Client;
using data_streaming.Model;

namespace Example
{
    public class DeleteDataStreamingByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataStreamingApi(config);
            var dataStreamingId = 56;  // int | 

            try
            {
                // Delete data streaming
                apiInstance.DeleteDataStreamingById(dataStreamingId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataStreamingApi.DeleteDataStreamingById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDataStreamingByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete data streaming
    apiInstance.DeleteDataStreamingByIdWithHttpInfo(dataStreamingId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataStreamingApi.DeleteDataStreamingByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dataStreamingId** | **int** |  |  |

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
| **204** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **406** | Not Acceptable |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="editdatastreamingbyid"></a>
# **EditDataStreamingById**
> CreateNewDataStreaming201Response EditDataStreamingById (int dataStreamingId, CreateNewDataStreamingRequest createNewDataStreamingRequest)

Edit data streaming

Use the PATCH method to change only select settings of your data streaming. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using data_streaming.Api;
using data_streaming.Client;
using data_streaming.Model;

namespace Example
{
    public class EditDataStreamingByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataStreamingApi(config);
            var dataStreamingId = 56;  // int | 
            var createNewDataStreamingRequest = new CreateNewDataStreamingRequest(); // CreateNewDataStreamingRequest | 

            try
            {
                // Edit data streaming
                CreateNewDataStreaming201Response result = apiInstance.EditDataStreamingById(dataStreamingId, createNewDataStreamingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataStreamingApi.EditDataStreamingById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EditDataStreamingByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit data streaming
    ApiResponse<CreateNewDataStreaming201Response> response = apiInstance.EditDataStreamingByIdWithHttpInfo(dataStreamingId, createNewDataStreamingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataStreamingApi.EditDataStreamingByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dataStreamingId** | **int** |  |  |
| **createNewDataStreamingRequest** | [**CreateNewDataStreamingRequest**](CreateNewDataStreamingRequest.md) |  |  |

### Return type

[**CreateNewDataStreaming201Response**](CreateNewDataStreaming201Response.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **406** | Not Acceptable |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listdatastreamingbyid"></a>
# **ListDataStreamingById**
> DataStreamingsById ListDataStreamingById (int dataStreamingId)

Get expecific data streaming by Data Streaming ID

Use the GET method and add the data streaming's ID to the URI of the request to get more data on a specific data streaming.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using data_streaming.Api;
using data_streaming.Client;
using data_streaming.Model;

namespace Example
{
    public class ListDataStreamingByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataStreamingApi(config);
            var dataStreamingId = 56;  // int | 

            try
            {
                // Get expecific data streaming by Data Streaming ID
                DataStreamingsById result = apiInstance.ListDataStreamingById(dataStreamingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataStreamingApi.ListDataStreamingById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListDataStreamingByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get expecific data streaming by Data Streaming ID
    ApiResponse<DataStreamingsById> response = apiInstance.ListDataStreamingByIdWithHttpInfo(dataStreamingId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataStreamingApi.ListDataStreamingByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dataStreamingId** | **int** |  |  |

### Return type

[**DataStreamingsById**](DataStreamingsById.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **406** | Not Acceptable |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listdatastreamings"></a>
# **ListDataStreamings**
> DataStreamingResponseWithResults ListDataStreamings ()

List all exist data streamings

Use the GET method to list all data streamings, both active and inactive, and its properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using data_streaming.Api;
using data_streaming.Client;
using data_streaming.Model;

namespace Example
{
    public class ListDataStreamingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataStreamingApi(config);

            try
            {
                // List all exist data streamings
                DataStreamingResponseWithResults result = apiInstance.ListDataStreamings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataStreamingApi.ListDataStreamings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListDataStreamingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all exist data streamings
    ApiResponse<DataStreamingResponseWithResults> response = apiInstance.ListDataStreamingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataStreamingApi.ListDataStreamingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DataStreamingResponseWithResults**](DataStreamingResponseWithResults.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **406** | Not Acceptable |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="overwritedatastreamingbyid"></a>
# **OverwriteDataStreamingById**
> CreateNewDataStreaming201Response OverwriteDataStreamingById (int dataStreamingId, CreateNewDataStreamingRequest createNewDataStreamingRequest)

Overwrite data streaming

Use the PUT method to overwrite the data streaming. Although  you can change a single property using the PUT method, you must pass all fields for the request to be completed. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using data_streaming.Api;
using data_streaming.Client;
using data_streaming.Model;

namespace Example
{
    public class OverwriteDataStreamingByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataStreamingApi(config);
            var dataStreamingId = 56;  // int | 
            var createNewDataStreamingRequest = new CreateNewDataStreamingRequest(); // CreateNewDataStreamingRequest | 

            try
            {
                // Overwrite data streaming
                CreateNewDataStreaming201Response result = apiInstance.OverwriteDataStreamingById(dataStreamingId, createNewDataStreamingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataStreamingApi.OverwriteDataStreamingById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OverwriteDataStreamingByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Overwrite data streaming
    ApiResponse<CreateNewDataStreaming201Response> response = apiInstance.OverwriteDataStreamingByIdWithHttpInfo(dataStreamingId, createNewDataStreamingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataStreamingApi.OverwriteDataStreamingByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dataStreamingId** | **int** |  |  |
| **createNewDataStreamingRequest** | [**CreateNewDataStreamingRequest**](CreateNewDataStreamingRequest.md) |  |  |

### Return type

[**CreateNewDataStreaming201Response**](CreateNewDataStreaming201Response.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **406** | Not Acceptable |  -  |
| **409** | Conflict |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

