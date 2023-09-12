# data_streaming.Api.DataStreamingDomainApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ListDataStreaming**](DataStreamingDomainApi.md#listdatastreaming) | **GET** /data_streaming/domains | List all domains used on data streaming |

<a id="listdatastreaming"></a>
# **ListDataStreaming**
> DataStreamingsDomainResponse ListDataStreaming (string? name = null, long? streamingId = null, bool? selected = null)

List all domains used on data streaming

Use the GET method to list all available domains that can be used on Data Streaming operations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using data_streaming.Api;
using data_streaming.Client;
using data_streaming.Model;

namespace Example
{
    public class ListDataStreamingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataStreamingDomainApi(config);
            var name = "name_example";  // string? | Domain's name in data streaming (optional) 
            var streamingId = 789L;  // long? |  (optional) 
            var selected = true;  // bool? |  (optional) 

            try
            {
                // List all domains used on data streaming
                DataStreamingsDomainResponse result = apiInstance.ListDataStreaming(name, streamingId, selected);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataStreamingDomainApi.ListDataStreaming: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListDataStreamingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all domains used on data streaming
    ApiResponse<DataStreamingsDomainResponse> response = apiInstance.ListDataStreamingWithHttpInfo(name, streamingId, selected);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataStreamingDomainApi.ListDataStreamingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string?** | Domain&#39;s name in data streaming | [optional]  |
| **streamingId** | **long?** |  | [optional]  |
| **selected** | **bool?** |  | [optional]  |

### Return type

[**DataStreamingsDomainResponse**](DataStreamingsDomainResponse.md)

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

