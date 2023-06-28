# storageapi.Api.DefaultApi

All URIs are relative to *https://storage-api.azion.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteVersion**](DefaultApi.md#deleteversion) | **DELETE** /storage/{version_id}/delete | /storage/:version_id/delete |
| [**StorageVersionIdPost**](DefaultApi.md#storageversionidpost) | **POST** /storage/{version_id} | /storage/:version_id |

<a id="deleteversion"></a>
# **DeleteVersion**
> void DeleteVersion (string versionId)

/storage/:version_id/delete

Delete a version. A version is just um path prefix/sub-namespace for a set of files.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using storageapi.Api;
using storageapi.Client;
using storageapi.Model;

namespace Example
{
    public class DeleteVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://storage-api.azion.com";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var versionId = "versionId_example";  // string | The version identifier

            try
            {
                // /storage/:version_id/delete
                apiInstance.DeleteVersion(versionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteVersion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteVersionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /storage/:version_id/delete
    apiInstance.DeleteVersionWithHttpInfo(versionId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteVersionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **versionId** | **string** | The version identifier |  |

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
| **204** | The resource was deleted successfully. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="storageversionidpost"></a>
# **StorageVersionIdPost**
> Object StorageVersionIdPost (string xAzionStaticPath, string versionId, string contentType = null, System.IO.Stream body = null)

/storage/:version_id

Upload file and transfer to remote storage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using storageapi.Api;
using storageapi.Client;
using storageapi.Model;

namespace Example
{
    public class StorageVersionIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://storage-api.azion.com";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var xAzionStaticPath = "xAzionStaticPath_example";  // string | Required in order to get the path and file name. i.e.: assets/css/main.css
            var versionId = "versionId_example";  // string | 
            var contentType = "\"b2/x-auto\"";  // string | The content type of the file (Example: text/plain). (optional)  (default to "b2/x-auto")
            var body = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                // /storage/:version_id
                Object result = apiInstance.StorageVersionIdPost(xAzionStaticPath, versionId, contentType, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.StorageVersionIdPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageVersionIdPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /storage/:version_id
    ApiResponse<Object> response = apiInstance.StorageVersionIdPostWithHttpInfo(xAzionStaticPath, versionId, contentType, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.StorageVersionIdPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xAzionStaticPath** | **string** | Required in order to get the path and file name. i.e.: assets/css/main.css |  |
| **versionId** | **string** |  |  |
| **contentType** | **string** | The content type of the file (Example: text/plain). | [optional] [default to &quot;b2/x-auto&quot;] |
| **body** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |

### Return type

**Object**

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

