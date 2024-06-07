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
| [**StorageApiS3CredentialsByAccessKey**](StorageApi.md#storageapis3credentialsbyaccesskey) | **GET** /v4/storage/s3-credentials/{s3_credential_access_key} | get by s3 credentials by access key |
| [**StorageApiS3CredentialsCreate**](StorageApi.md#storageapis3credentialscreate) | **POST** /v4/storage/s3-credentials | create s3 credentials |
| [**StorageApiS3CredentialsDelete**](StorageApi.md#storageapis3credentialsdelete) | **DELETE** /v4/storage/s3-credentials/{s3_credential_access_key} | delete by s3 credentials |
| [**StorageApiS3CredentialsList**](StorageApi.md#storageapis3credentialslist) | **GET** /v4/storage/s3-credentials | List s3 credentials |

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
> SuccessObjectOperation StorageApiBucketsObjectsCreate (string bucketName, string objectKey, string? contentType = null, System.IO.Stream? body = null)

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
            var contentType = "contentType_example";  // string? | The content type of the file (Example: text/plain). (optional) 
            var body = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream? |  (optional) 

            try
            {
                // Create new object key
                SuccessObjectOperation result = apiInstance.StorageApiBucketsObjectsCreate(bucketName, objectKey, contentType, body);
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
    ApiResponse<SuccessObjectOperation> response = apiInstance.StorageApiBucketsObjectsCreateWithHttpInfo(bucketName, objectKey, contentType, body);
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
| **contentType** | **string?** | The content type of the file (Example: text/plain). | [optional]  |
| **body** | **System.IO.Stream?****System.IO.Stream?** |  | [optional]  |

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
| **201** | Created |  -  |
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
> PaginatedBucketObjectList StorageApiBucketsObjectsList (string bucketName, string? continuationToken = null, int? maxObjectCount = null)

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
            var continuationToken = "continuationToken_example";  // string? | Token for next page. (optional) 
            var maxObjectCount = 56;  // int? | Number of results to return per page. (optional) 

            try
            {
                // List buckets objects
                PaginatedBucketObjectList result = apiInstance.StorageApiBucketsObjectsList(bucketName, continuationToken, maxObjectCount);
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
    ApiResponse<PaginatedBucketObjectList> response = apiInstance.StorageApiBucketsObjectsListWithHttpInfo(bucketName, continuationToken, maxObjectCount);
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
| **continuationToken** | **string?** | Token for next page. | [optional]  |
| **maxObjectCount** | **int?** | Number of results to return per page. | [optional]  |

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
> void StorageApiBucketsObjectsRetrieve (string bucketName, string objectKey)

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
                apiInstance.StorageApiBucketsObjectsRetrieve(bucketName, objectKey);
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
    apiInstance.StorageApiBucketsObjectsRetrieveWithHttpInfo(bucketName, objectKey);
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

void (empty response body)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/html, application/json, application/xml, text/plain, image/jpeg, image/png, image/gif, video/mp4, audio/mpeg, application/pdf, application/javascript, text/css, application/octet-stream, multipart/form-data, application/x-www-form-urlencoded


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
> SuccessObjectOperation StorageApiBucketsObjectsUpdate (string bucketName, string objectKey, string? contentType = null, System.IO.Stream? body = null)

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
            var contentType = "contentType_example";  // string? | The content type of the file (Example: text/plain). (optional) 
            var body = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream? |  (optional) 

            try
            {
                // Update the object key
                SuccessObjectOperation result = apiInstance.StorageApiBucketsObjectsUpdate(bucketName, objectKey, contentType, body);
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
    ApiResponse<SuccessObjectOperation> response = apiInstance.StorageApiBucketsObjectsUpdateWithHttpInfo(bucketName, objectKey, contentType, body);
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
| **contentType** | **string?** | The content type of the file (Example: text/plain). | [optional]  |
| **body** | **System.IO.Stream?****System.IO.Stream?** |  | [optional]  |

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
> ResponseBucket StorageApiBucketsPartialUpdate (string name, BucketUpdate? bucketUpdate = null)

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
            var bucketUpdate = new BucketUpdate?(); // BucketUpdate? |  (optional) 

            try
            {
                // Update bucket info
                ResponseBucket result = apiInstance.StorageApiBucketsPartialUpdate(name, bucketUpdate);
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
    ApiResponse<ResponseBucket> response = apiInstance.StorageApiBucketsPartialUpdateWithHttpInfo(name, bucketUpdate);
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
| **bucketUpdate** | [**BucketUpdate?**](BucketUpdate?.md) |  | [optional]  |

### Return type

[**ResponseBucket**](ResponseBucket.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
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

<a id="storageapis3credentialsbyaccesskey"></a>
# **StorageApiS3CredentialsByAccessKey**
> ResponseS3Credential StorageApiS3CredentialsByAccessKey (string s3CredentialAccessKey)

get by s3 credentials by access key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using storage.Api;
using storage.Client;
using storage.Model;

namespace Example
{
    public class StorageApiS3CredentialsByAccessKeyExample
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
            var s3CredentialAccessKey = "s3CredentialAccessKey_example";  // string | 

            try
            {
                // get by s3 credentials by access key
                ResponseS3Credential result = apiInstance.StorageApiS3CredentialsByAccessKey(s3CredentialAccessKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageApiS3CredentialsByAccessKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageApiS3CredentialsByAccessKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get by s3 credentials by access key
    ApiResponse<ResponseS3Credential> response = apiInstance.StorageApiS3CredentialsByAccessKeyWithHttpInfo(s3CredentialAccessKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageApiS3CredentialsByAccessKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **s3CredentialAccessKey** | **string** |  |  |

### Return type

[**ResponseS3Credential**](ResponseS3Credential.md)

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

<a id="storageapis3credentialscreate"></a>
# **StorageApiS3CredentialsCreate**
> ResponseS3Credential StorageApiS3CredentialsCreate (S3CredentialCreate s3CredentialCreate)

create s3 credentials

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using storage.Api;
using storage.Client;
using storage.Model;

namespace Example
{
    public class StorageApiS3CredentialsCreateExample
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
            var s3CredentialCreate = new S3CredentialCreate(); // S3CredentialCreate | 

            try
            {
                // create s3 credentials
                ResponseS3Credential result = apiInstance.StorageApiS3CredentialsCreate(s3CredentialCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageApiS3CredentialsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageApiS3CredentialsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // create s3 credentials
    ApiResponse<ResponseS3Credential> response = apiInstance.StorageApiS3CredentialsCreateWithHttpInfo(s3CredentialCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageApiS3CredentialsCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **s3CredentialCreate** | [**S3CredentialCreate**](S3CredentialCreate.md) |  |  |

### Return type

[**ResponseS3Credential**](ResponseS3Credential.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="storageapis3credentialsdelete"></a>
# **StorageApiS3CredentialsDelete**
> ResponseS3Credential StorageApiS3CredentialsDelete (string s3CredentialAccessKey)

delete by s3 credentials

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using storage.Api;
using storage.Client;
using storage.Model;

namespace Example
{
    public class StorageApiS3CredentialsDeleteExample
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
            var s3CredentialAccessKey = "s3CredentialAccessKey_example";  // string | 

            try
            {
                // delete by s3 credentials
                ResponseS3Credential result = apiInstance.StorageApiS3CredentialsDelete(s3CredentialAccessKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageApiS3CredentialsDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageApiS3CredentialsDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // delete by s3 credentials
    ApiResponse<ResponseS3Credential> response = apiInstance.StorageApiS3CredentialsDeleteWithHttpInfo(s3CredentialAccessKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageApiS3CredentialsDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **s3CredentialAccessKey** | **string** |  |  |

### Return type

[**ResponseS3Credential**](ResponseS3Credential.md)

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

<a id="storageapis3credentialslist"></a>
# **StorageApiS3CredentialsList**
> PaginatedS3CredentialList StorageApiS3CredentialsList (string? key = null, string? lastModified = null, int? size = null, string? continuationToken = null)

List s3 credentials

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using storage.Api;
using storage.Client;
using storage.Model;

namespace Example
{
    public class StorageApiS3CredentialsListExample
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
            var key = "key_example";  // string? | Object key. Used to identify the object for requests. Sent in POST requests as a path variable. (optional) 
            var lastModified = "lastModified_example";  // string? | Timestamp of the last modification to the object. (optional) 
            var size = 56;  // int? | Size of file in bytes. (optional) 
            var continuationToken = "continuationToken_example";  // string? | Hash that can be added to the continuation_token query to skip list to the next page. (optional) 

            try
            {
                // List s3 credentials
                PaginatedS3CredentialList result = apiInstance.StorageApiS3CredentialsList(key, lastModified, size, continuationToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageApiS3CredentialsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageApiS3CredentialsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List s3 credentials
    ApiResponse<PaginatedS3CredentialList> response = apiInstance.StorageApiS3CredentialsListWithHttpInfo(key, lastModified, size, continuationToken);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageApiS3CredentialsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **key** | **string?** | Object key. Used to identify the object for requests. Sent in POST requests as a path variable. | [optional]  |
| **lastModified** | **string?** | Timestamp of the last modification to the object. | [optional]  |
| **size** | **int?** | Size of file in bytes. | [optional]  |
| **continuationToken** | **string?** | Hash that can be added to the continuation_token query to skip list to the next page. | [optional]  |

### Return type

[**PaginatedS3CredentialList**](PaginatedS3CredentialList.md)

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

