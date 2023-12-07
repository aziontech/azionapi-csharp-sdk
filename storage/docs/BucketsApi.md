# storage.Api.BucketsApi

All URIs are relative to *https://api.azion.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV1StorageBucketsCreate**](BucketsApi.md#apiv1storagebucketscreate) | **POST** /v4/storage/buckets | /v4/storage/buckets |
| [**ApiV1StorageBucketsDestroy**](BucketsApi.md#apiv1storagebucketsdestroy) | **DELETE** /v4/storage/buckets/{name} | /v4/storage/buckets/:name |
| [**ApiV1StorageBucketsList**](BucketsApi.md#apiv1storagebucketslist) | **GET** /v4/storage/buckets | /v4/storage/buckets |
| [**ApiV1StorageBucketsPartialUpdate**](BucketsApi.md#apiv1storagebucketspartialupdate) | **PATCH** /v4/storage/buckets/{name} | /v4/storage/buckets/:name |

<a id="apiv1storagebucketscreate"></a>
# **ApiV1StorageBucketsCreate**
> ResponseBucket ApiV1StorageBucketsCreate (BucketCreate bucketCreate)

/v4/storage/buckets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using storage.Api;
using storage.Client;
using storage.Model;

namespace Example
{
    public class ApiV1StorageBucketsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azion.com";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BucketsApi(config);
            var bucketCreate = new BucketCreate(); // BucketCreate | 

            try
            {
                // /v4/storage/buckets
                ResponseBucket result = apiInstance.ApiV1StorageBucketsCreate(bucketCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BucketsApi.ApiV1StorageBucketsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1StorageBucketsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /v4/storage/buckets
    ApiResponse<ResponseBucket> response = apiInstance.ApiV1StorageBucketsCreateWithHttpInfo(bucketCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BucketsApi.ApiV1StorageBucketsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bucketCreate** | [**BucketCreate**](BucketCreate.md) |  |  |

### Return type

[**ResponseBucket**](ResponseBucket.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **406** | Not Acceptable |  -  |
| **429** | Too Many Requests |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **202** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1storagebucketsdestroy"></a>
# **ApiV1StorageBucketsDestroy**
> ResponseDeleteBucket ApiV1StorageBucketsDestroy (string name)

/v4/storage/buckets/:name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using storage.Api;
using storage.Client;
using storage.Model;

namespace Example
{
    public class ApiV1StorageBucketsDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azion.com";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BucketsApi(config);
            var name = "name_example";  // string | 

            try
            {
                // /v4/storage/buckets/:name
                ResponseDeleteBucket result = apiInstance.ApiV1StorageBucketsDestroy(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BucketsApi.ApiV1StorageBucketsDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1StorageBucketsDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /v4/storage/buckets/:name
    ApiResponse<ResponseDeleteBucket> response = apiInstance.ApiV1StorageBucketsDestroyWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BucketsApi.ApiV1StorageBucketsDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |

### Return type

[**ResponseDeleteBucket**](ResponseDeleteBucket.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **406** | Not Acceptable |  -  |
| **429** | Too Many Requests |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **202** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1storagebucketslist"></a>
# **ApiV1StorageBucketsList**
> PaginatedBucketList ApiV1StorageBucketsList (int? page = null, int? pageSize = null)

/v4/storage/buckets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using storage.Api;
using storage.Client;
using storage.Model;

namespace Example
{
    public class ApiV1StorageBucketsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azion.com";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BucketsApi(config);
            var page = 56;  // int? | A page number within the paginated result set. (optional) 
            var pageSize = 56;  // int? | Number of results to return per page. (optional) 

            try
            {
                // /v4/storage/buckets
                PaginatedBucketList result = apiInstance.ApiV1StorageBucketsList(page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BucketsApi.ApiV1StorageBucketsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1StorageBucketsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /v4/storage/buckets
    ApiResponse<PaginatedBucketList> response = apiInstance.ApiV1StorageBucketsListWithHttpInfo(page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BucketsApi.ApiV1StorageBucketsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | A page number within the paginated result set. | [optional]  |
| **pageSize** | **int?** | Number of results to return per page. | [optional]  |

### Return type

[**PaginatedBucketList**](PaginatedBucketList.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **406** | Not Acceptable |  -  |
| **429** | Too Many Requests |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1storagebucketspartialupdate"></a>
# **ApiV1StorageBucketsPartialUpdate**
> ResponseBucket ApiV1StorageBucketsPartialUpdate (string name, PatchedBucket? patchedBucket = null)

/v4/storage/buckets/:name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using storage.Api;
using storage.Client;
using storage.Model;

namespace Example
{
    public class ApiV1StorageBucketsPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azion.com";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BucketsApi(config);
            var name = "name_example";  // string | 
            var patchedBucket = new PatchedBucket?(); // PatchedBucket? |  (optional) 

            try
            {
                // /v4/storage/buckets/:name
                ResponseBucket result = apiInstance.ApiV1StorageBucketsPartialUpdate(name, patchedBucket);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BucketsApi.ApiV1StorageBucketsPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1StorageBucketsPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /v4/storage/buckets/:name
    ApiResponse<ResponseBucket> response = apiInstance.ApiV1StorageBucketsPartialUpdateWithHttpInfo(name, patchedBucket);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BucketsApi.ApiV1StorageBucketsPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |
| **patchedBucket** | [**PatchedBucket?**](PatchedBucket?.md) |  | [optional]  |

### Return type

[**ResponseBucket**](ResponseBucket.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **406** | Not Acceptable |  -  |
| **429** | Too Many Requests |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **202** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

