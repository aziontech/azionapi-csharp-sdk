# data_streaming.Api.DataStreamingTemplatesApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetDataStramingTemplateById**](DataStreamingTemplatesApi.md#getdatastramingtemplatebyid) | **GET** /data_streaming/templates/{template_id} | Get an global Template info by template ID |
| [**ListDataStreamingTemplates**](DataStreamingTemplatesApi.md#listdatastreamingtemplates) | **GET** /data_streaming/templates | List all global Templates that can be used on Data Streaming operations |

<a id="getdatastramingtemplatebyid"></a>
# **GetDataStramingTemplateById**
> TemplateResultById GetDataStramingTemplateById (int templateId)

Get an global Template info by template ID

Use the GET method and add the data streaming's ID to the URI of the request to get more data on a specific data streaming global template.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using data_streaming.Api;
using data_streaming.Client;
using data_streaming.Model;

namespace Example
{
    public class GetDataStramingTemplateByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataStreamingTemplatesApi(config);
            var templateId = 56;  // int | 

            try
            {
                // Get an global Template info by template ID
                TemplateResultById result = apiInstance.GetDataStramingTemplateById(templateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataStreamingTemplatesApi.GetDataStramingTemplateById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataStramingTemplateByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an global Template info by template ID
    ApiResponse<TemplateResultById> response = apiInstance.GetDataStramingTemplateByIdWithHttpInfo(templateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataStreamingTemplatesApi.GetDataStramingTemplateByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **int** |  |  |

### Return type

[**TemplateResultById**](TemplateResultById.md)

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
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listdatastreamingtemplates"></a>
# **ListDataStreamingTemplates**
> TemplateResults ListDataStreamingTemplates ()

List all global Templates that can be used on Data Streaming operations

Use the GET method to list all global templates that can be used on Data Streaming operations.  **Note:** Customized templates won't be listed. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using data_streaming.Api;
using data_streaming.Client;
using data_streaming.Model;

namespace Example
{
    public class ListDataStreamingTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DataStreamingTemplatesApi(config);

            try
            {
                // List all global Templates that can be used on Data Streaming operations
                TemplateResults result = apiInstance.ListDataStreamingTemplates();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataStreamingTemplatesApi.ListDataStreamingTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListDataStreamingTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all global Templates that can be used on Data Streaming operations
    ApiResponse<TemplateResults> response = apiInstance.ListDataStreamingTemplatesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataStreamingTemplatesApi.ListDataStreamingTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**TemplateResults**](TemplateResults.md)

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

