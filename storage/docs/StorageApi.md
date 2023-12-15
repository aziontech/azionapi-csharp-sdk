# storage.Api.StorageApi

All URIs are relative to *https://api.azion.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**StorageApiBucketsCreate**](StorageApi.md#storageapibucketscreate) | **POST** /v4/storage/buckets | Create a new bucket |
| [**StorageApiBucketsDestroy**](StorageApi.md#storageapibucketsdestroy) | **DELETE** /v4/storage/buckets/{name} | Delete a bucket |
| [**StorageApiBucketsList**](StorageApi.md#storageapibucketslist) | **GET** /v4/storage/buckets | List buckets |
| [**StorageApiBucketsObjectsCreate**](StorageApi.md#storageapibucketsobjectscreate) | **POST** /v4/storage/buckets/{bucket_name}/objects/{object_key} | Create new object key |
| [**StorageApiBucketsObjectsDestroy**](StorageApi.md#storageapibucketsobjectsdestroy) | **DELETE** /v4/storage/buckets/{bucket_name}/objects/{object_key} | Delete object key |
| [**StorageApiBucketsObjectsList**](StorageApi.md#storageapibucketsobjectslist) | **GET** /v4/storage/buckets/{bucket_name}/objects | List buckets objects |
| [**StorageApiBucketsObjectsRetrieve**](StorageApi.md#storageapibucketsobjectsretrieve) | **GET** /v4/storage/buckets/{bucket_name}/objects/{object_key} | Download object |
| [**StorageApiBucketsObjectsUpdate**](StorageApi.md#storageapibucketsobjectsupdate) | **PUT** /v4/storage/buckets/{bucket_name}/objects/{object_key} | Update the object key |
| [**StorageApiBucketsPartialUpdate**](StorageApi.md#storageapibucketspartialupdate) | **PATCH** /v4/storage/buckets/{name} | Update bucket info |

<a id="storageapibucketscreate"></a>
# **StorageApiBucketsCreate**
> ResponseBucket StorageApiBucketsCreate (BucketCreate bucketCreate)

Create a new bucket

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using storage.Api;
using storage.Client;
using storage.Model;

namespace Example
{
    public class StorageApiBucketsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azion.com";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var bucketCreate = new BucketCreate(); // BucketCreate | 

            try
            {
                // Create a new bucket
                ResponseBucket result = apiInstance.StorageApiBucketsCreate(bucketCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageApiBucketsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageApiBucketsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new bucket
    ApiResponse<ResponseBucket> response = apiInstance.StorageApiBucketsCreateWithHttpInfo(bucketCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageApiBucketsCreateWithHttpInfo: " + e.Message);
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

<a id="storageapibucketsdestroy"></a>
# **StorageApiBucketsDestroy**
> SuccessBucketOperation StorageApiBucketsDestroy (string name)

Delete a bucket

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using storage.Api;
using storage.Client;
using storage.Model;

namespace Example
{
    public class StorageApiBucketsDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azion.com";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var name = "name_example";  // string | 

            try
            {
                // Delete a bucket
                SuccessBucketOperation result = apiInstance.StorageApiBucketsDestroy(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageApiBucketsDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageApiBucketsDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a bucket
    ApiResponse<SuccessBucketOperation> response = apiInstance.StorageApiBucketsDestroyWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageApiBucketsDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |

### Return type

[**SuccessBucketOperation**](SuccessBucketOperation.md)

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

<a id="storageapibucketslist"></a>
# **StorageApiBucketsList**
> PaginatedBucketList StorageApiBucketsList (int? page = null, int? pageSize = null)

List buckets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using storage.Api;
using storage.Client;
using storage.Model;

namespace Example
{
    public class StorageApiBucketsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azion.com";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var page = 56;  // int? | A page number within the paginated result set. (optional) 
            var pageSize = 56;  // int? | Number of results to return per page. (optional) 

            try
            {
                // List buckets
                PaginatedBucketList result = apiInstance.StorageApiBucketsList(page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageApiBucketsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageApiBucketsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List buckets
    ApiResponse<PaginatedBucketList> response = apiInstance.StorageApiBucketsListWithHttpInfo(page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageApiBucketsListWithHttpInfo: " + e.Message);
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

<a id="storageapibucketsobjectscreate"></a>
# **StorageApiBucketsObjectsCreate**
> SuccessObjectOperation StorageApiBucketsObjectsCreate (string bucketName, string objectKey, Dictionary<string, Object>? requestBody = null)

Create new object key

Create a new object key in the bucket.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using storage.Api;
using storage.Client;
using storage.Model;

namespace Example
{
    public class StorageApiBucketsObjectsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azion.com";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var bucketName = "bucketName_example";  // string | 
            var objectKey = "objectKey_example";  // string | 
            var requestBody = new Dictionary<string, Object>?(); // Dictionary<string, Object>? |  (optional) 

            try
            {
                // Create new object key
                SuccessObjectOperation result = apiInstance.StorageApiBucketsObjectsCreate(bucketName, objectKey, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageApiBucketsObjectsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageApiBucketsObjectsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create new object key
    ApiResponse<SuccessObjectOperation> response = apiInstance.StorageApiBucketsObjectsCreateWithHttpInfo(bucketName, objectKey, requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageApiBucketsObjectsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bucketName** | **string** |  |  |
| **objectKey** | **string** |  |  |
| **requestBody** | [**Dictionary&lt;string, Object&gt;?**](Object.md) |  | [optional]  |

### Return type

[**SuccessObjectOperation**](SuccessObjectOperation.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/octet-stream
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

<a id="storageapibucketsobjectsdestroy"></a>
# **StorageApiBucketsObjectsDestroy**
> SuccessObjectOperation StorageApiBucketsObjectsDestroy (string bucketName, string objectKey)

Delete object key

Delete an object key from bucket

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using storage.Api;
using storage.Client;
using storage.Model;

namespace Example
{
    public class StorageApiBucketsObjectsDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azion.com";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var bucketName = "bucketName_example";  // string | 
            var objectKey = "objectKey_example";  // string | 

            try
            {
                // Delete object key
                SuccessObjectOperation result = apiInstance.StorageApiBucketsObjectsDestroy(bucketName, objectKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageApiBucketsObjectsDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageApiBucketsObjectsDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete object key
    ApiResponse<SuccessObjectOperation> response = apiInstance.StorageApiBucketsObjectsDestroyWithHttpInfo(bucketName, objectKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageApiBucketsObjectsDestroyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bucketName** | **string** |  |  |
| **objectKey** | **string** |  |  |

### Return type

[**SuccessObjectOperation**](SuccessObjectOperation.md)

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

<a id="storageapibucketsobjectslist"></a>
# **StorageApiBucketsObjectsList**
> PaginatedBucketObjectList StorageApiBucketsObjectsList (string bucketName, int? page = null, int? pageSize = null)

List buckets objects

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using storage.Api;
using storage.Client;
using storage.Model;

namespace Example
{
    public class StorageApiBucketsObjectsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azion.com";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var bucketName = "bucketName_example";  // string | 
            var page = 56;  // int? | A page number within the paginated result set. (optional) 
            var pageSize = 56;  // int? | Number of results to return per page. (optional) 

            try
            {
                // List buckets objects
                PaginatedBucketObjectList result = apiInstance.StorageApiBucketsObjectsList(bucketName, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageApiBucketsObjectsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageApiBucketsObjectsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List buckets objects
    ApiResponse<PaginatedBucketObjectList> response = apiInstance.StorageApiBucketsObjectsListWithHttpInfo(bucketName, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageApiBucketsObjectsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bucketName** | **string** |  |  |
| **page** | **int?** | A page number within the paginated result set. | [optional]  |
| **pageSize** | **int?** | Number of results to return per page. | [optional]  |

### Return type

[**PaginatedBucketObjectList**](PaginatedBucketObjectList.md)

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

<a id="storageapibucketsobjectsretrieve"></a>
# **StorageApiBucketsObjectsRetrieve**
> System.IO.Stream StorageApiBucketsObjectsRetrieve (string bucketName, string objectKey)

Download object

Download the object key from bucket.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using storage.Api;
using storage.Client;
using storage.Model;

namespace Example
{
    public class StorageApiBucketsObjectsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azion.com";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var bucketName = "bucketName_example";  // string | 
            var objectKey = "objectKey_example";  // string | 

            try
            {
                // Download object
                System.IO.Stream result = apiInstance.StorageApiBucketsObjectsRetrieve(bucketName, objectKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageApiBucketsObjectsRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageApiBucketsObjectsRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download object
    ApiResponse<System.IO.Stream> response = apiInstance.StorageApiBucketsObjectsRetrieveWithHttpInfo(bucketName, objectKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageApiBucketsObjectsRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bucketName** | **string** |  |  |
| **objectKey** | **string** |  |  |

### Return type

**System.IO.Stream**

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


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

<a id="storageapibucketsobjectsupdate"></a>
# **StorageApiBucketsObjectsUpdate**
> SuccessObjectOperation StorageApiBucketsObjectsUpdate (string bucketName, string objectKey, Dictionary<string, Object>? requestBody = null)

Update the object key

Update the object key from bucket.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using storage.Api;
using storage.Client;
using storage.Model;

namespace Example
{
    public class StorageApiBucketsObjectsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azion.com";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var bucketName = "bucketName_example";  // string | 
            var objectKey = "objectKey_example";  // string | 
            var requestBody = new Dictionary<string, Object>?(); // Dictionary<string, Object>? |  (optional) 

            try
            {
                // Update the object key
                SuccessObjectOperation result = apiInstance.StorageApiBucketsObjectsUpdate(bucketName, objectKey, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageApiBucketsObjectsUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageApiBucketsObjectsUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the object key
    ApiResponse<SuccessObjectOperation> response = apiInstance.StorageApiBucketsObjectsUpdateWithHttpInfo(bucketName, objectKey, requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageApiBucketsObjectsUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bucketName** | **string** |  |  |
| **objectKey** | **string** |  |  |
| **requestBody** | [**Dictionary&lt;string, Object&gt;?**](Object.md) |  | [optional]  |

### Return type

[**SuccessObjectOperation**](SuccessObjectOperation.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/octet-stream
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

<a id="storageapibucketspartialupdate"></a>
# **StorageApiBucketsPartialUpdate**
> ResponseBucket StorageApiBucketsPartialUpdate (string name)

Update bucket info

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using storage.Api;
using storage.Client;
using storage.Model;

namespace Example
{
    public class StorageApiBucketsPartialUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azion.com";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi(config);
            var name = "name_example";  // string | 

            try
            {
                // Update bucket info
                ResponseBucket result = apiInstance.StorageApiBucketsPartialUpdate(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageApiBucketsPartialUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageApiBucketsPartialUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update bucket info
    ApiResponse<ResponseBucket> response = apiInstance.StorageApiBucketsPartialUpdateWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageApiBucketsPartialUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |

### Return type

[**ResponseBucket**](ResponseBucket.md)

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

