# services.Api.DefaultApi

All URIs are relative to *http://bff.azion.net:3002*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteResource**](DefaultApi.md#deleteresource) | **DELETE** /edge_services/{serviceId}/resources/{resourceId} | Delete Service Resource by ID |
| [**DeleteService**](DefaultApi.md#deleteservice) | **DELETE** /edge_services/{id} | Delete Service by ID |
| [**GetResource**](DefaultApi.md#getresource) | **GET** /edge_services/{serviceId}/resources/{resourceId} | Return Service Resource by ID |
| [**GetResources**](DefaultApi.md#getresources) | **GET** /edge_services/{serviceId}/resources | Return Service Resources by page |
| [**GetService**](DefaultApi.md#getservice) | **GET** /edge_services/{id} | Return Service by ID |
| [**GetServices**](DefaultApi.md#getservices) | **GET** /edge_services | Return Services by page |
| [**NewService**](DefaultApi.md#newservice) | **POST** /edge_services | Create Service |
| [**PatchService**](DefaultApi.md#patchservice) | **PATCH** /edge_services/{id} | Update Service by ID |
| [**PatchServiceResource**](DefaultApi.md#patchserviceresource) | **PATCH** /edge_services/{serviceId}/resources/{resourceId} | Update Service Resource by ID |
| [**PostResource**](DefaultApi.md#postresource) | **POST** /edge_services/{serviceId}/resources | Create Service Resource |

<a id="deleteresource"></a>
# **DeleteResource**
> void DeleteResource (long serviceId, long resourceId)

Delete Service Resource by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using services.Api;
using services.Client;
using services.Model;

namespace Example
{
    public class DeleteResourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://bff.azion.net:3002";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var serviceId = 789L;  // long | 
            var resourceId = 789L;  // long | 

            try
            {
                // Delete Service Resource by ID
                apiInstance.DeleteResource(serviceId, resourceId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteResource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteResourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Service Resource by ID
    apiInstance.DeleteResourceWithHttpInfo(serviceId, resourceId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteResourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serviceId** | **long** |  |  |
| **resourceId** | **long** |  |  |

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

<a id="deleteservice"></a>
# **DeleteService**
> void DeleteService (long id)

Delete Service by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using services.Api;
using services.Client;
using services.Model;

namespace Example
{
    public class DeleteServiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://bff.azion.net:3002";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var id = 789L;  // long | 

            try
            {
                // Delete Service by ID
                apiInstance.DeleteService(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteService: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteServiceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Service by ID
    apiInstance.DeleteServiceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteServiceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |

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

<a id="getresource"></a>
# **GetResource**
> ResourceDetail GetResource (long serviceId, long resourceId)

Return Service Resource by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using services.Api;
using services.Client;
using services.Model;

namespace Example
{
    public class GetResourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://bff.azion.net:3002";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var serviceId = 789L;  // long | 
            var resourceId = 789L;  // long | 

            try
            {
                // Return Service Resource by ID
                ResourceDetail result = apiInstance.GetResource(serviceId, resourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetResource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetResourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return Service Resource by ID
    ApiResponse<ResourceDetail> response = apiInstance.GetResourceWithHttpInfo(serviceId, resourceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetResourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serviceId** | **long** |  |  |
| **resourceId** | **long** |  |  |

### Return type

[**ResourceDetail**](ResourceDetail.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getresources"></a>
# **GetResources**
> Object GetResources (long serviceId, long? page = null, long? pageSize = null, string filter = null, string orderBy = null, string sort = null)

Return Service Resources by page

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using services.Api;
using services.Client;
using services.Model;

namespace Example
{
    public class GetResourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://bff.azion.net:3002";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var serviceId = 789L;  // long | 
            var page = 789L;  // long? |  (optional) 
            var pageSize = 789L;  // long? |  (optional) 
            var filter = "filter_example";  // string |  (optional) 
            var orderBy = "orderBy_example";  // string |  (optional) 
            var sort = "sort_example";  // string |  (optional) 

            try
            {
                // Return Service Resources by page
                Object result = apiInstance.GetResources(serviceId, page, pageSize, filter, orderBy, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetResources: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetResourcesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return Service Resources by page
    ApiResponse<Object> response = apiInstance.GetResourcesWithHttpInfo(serviceId, page, pageSize, filter, orderBy, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetResourcesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serviceId** | **long** |  |  |
| **page** | **long?** |  | [optional]  |
| **pageSize** | **long?** |  | [optional]  |
| **filter** | **string** |  | [optional]  |
| **orderBy** | **string** |  | [optional]  |
| **sort** | **string** |  | [optional]  |

### Return type

**Object**

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getservice"></a>
# **GetService**
> ServiceResponse GetService (long id, bool? withVars = null)

Return Service by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using services.Api;
using services.Client;
using services.Model;

namespace Example
{
    public class GetServiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://bff.azion.net:3002";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var id = 789L;  // long | 
            var withVars = true;  // bool? |  (optional) 

            try
            {
                // Return Service by ID
                ServiceResponse result = apiInstance.GetService(id, withVars);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetService: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetServiceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return Service by ID
    ApiResponse<ServiceResponse> response = apiInstance.GetServiceWithHttpInfo(id, withVars);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetServiceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **withVars** | **bool?** |  | [optional]  |

### Return type

[**ServiceResponse**](ServiceResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getservices"></a>
# **GetServices**
> ServiceResponseWithTotals GetServices (long? page = null, long? pageSize = null, string filter = null, string orderBy = null, string sort = null)

Return Services by page

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using services.Api;
using services.Client;
using services.Model;

namespace Example
{
    public class GetServicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://bff.azion.net:3002";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var page = 789L;  // long? |  (optional) 
            var pageSize = 789L;  // long? |  (optional) 
            var filter = "filter_example";  // string |  (optional) 
            var orderBy = "orderBy_example";  // string |  (optional) 
            var sort = "sort_example";  // string |  (optional) 

            try
            {
                // Return Services by page
                ServiceResponseWithTotals result = apiInstance.GetServices(page, pageSize, filter, orderBy, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetServices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetServicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return Services by page
    ApiResponse<ServiceResponseWithTotals> response = apiInstance.GetServicesWithHttpInfo(page, pageSize, filter, orderBy, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetServicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **long?** |  | [optional]  |
| **pageSize** | **long?** |  | [optional]  |
| **filter** | **string** |  | [optional]  |
| **orderBy** | **string** |  | [optional]  |
| **sort** | **string** |  | [optional]  |

### Return type

[**ServiceResponseWithTotals**](ServiceResponseWithTotals.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="newservice"></a>
# **NewService**
> ServiceResponse NewService (CreateServiceRequest createServiceRequest)

Create Service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using services.Api;
using services.Client;
using services.Model;

namespace Example
{
    public class NewServiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://bff.azion.net:3002";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var createServiceRequest = new CreateServiceRequest(); // CreateServiceRequest | 

            try
            {
                // Create Service
                ServiceResponse result = apiInstance.NewService(createServiceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.NewService: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewServiceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Service
    ApiResponse<ServiceResponse> response = apiInstance.NewServiceWithHttpInfo(createServiceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.NewServiceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createServiceRequest** | [**CreateServiceRequest**](CreateServiceRequest.md) |  |  |

### Return type

[**ServiceResponse**](ServiceResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="patchservice"></a>
# **PatchService**
> ServiceResponse PatchService (long id, UpdateServiceRequest updateServiceRequest)

Update Service by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using services.Api;
using services.Client;
using services.Model;

namespace Example
{
    public class PatchServiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://bff.azion.net:3002";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var id = 789L;  // long | 
            var updateServiceRequest = new UpdateServiceRequest(); // UpdateServiceRequest | 

            try
            {
                // Update Service by ID
                ServiceResponse result = apiInstance.PatchService(id, updateServiceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.PatchService: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchServiceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Service by ID
    ApiResponse<ServiceResponse> response = apiInstance.PatchServiceWithHttpInfo(id, updateServiceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.PatchServiceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **updateServiceRequest** | [**UpdateServiceRequest**](UpdateServiceRequest.md) |  |  |

### Return type

[**ServiceResponse**](ServiceResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


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

<a id="patchserviceresource"></a>
# **PatchServiceResource**
> ResourceDetail PatchServiceResource (long serviceId, long resourceId, UpdateResourceRequest updateResourceRequest)

Update Service Resource by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using services.Api;
using services.Client;
using services.Model;

namespace Example
{
    public class PatchServiceResourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://bff.azion.net:3002";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var serviceId = 789L;  // long | 
            var resourceId = 789L;  // long | 
            var updateResourceRequest = new UpdateResourceRequest(); // UpdateResourceRequest | 

            try
            {
                // Update Service Resource by ID
                ResourceDetail result = apiInstance.PatchServiceResource(serviceId, resourceId, updateResourceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.PatchServiceResource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchServiceResourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Service Resource by ID
    ApiResponse<ResourceDetail> response = apiInstance.PatchServiceResourceWithHttpInfo(serviceId, resourceId, updateResourceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.PatchServiceResourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serviceId** | **long** |  |  |
| **resourceId** | **long** |  |  |
| **updateResourceRequest** | [**UpdateResourceRequest**](UpdateResourceRequest.md) |  |  |

### Return type

[**ResourceDetail**](ResourceDetail.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


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

<a id="postresource"></a>
# **PostResource**
> ResourceDetail PostResource (long serviceId, CreateResourceRequest createResourceRequest)

Create Service Resource

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using services.Api;
using services.Client;
using services.Model;

namespace Example
{
    public class PostResourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://bff.azion.net:3002";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var serviceId = 789L;  // long | 
            var createResourceRequest = new CreateResourceRequest(); // CreateResourceRequest | 

            try
            {
                // Create Service Resource
                ResourceDetail result = apiInstance.PostResource(serviceId, createResourceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.PostResource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostResourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Service Resource
    ApiResponse<ResourceDetail> response = apiInstance.PostResourceWithHttpInfo(serviceId, createResourceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.PostResourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serviceId** | **long** |  |  |
| **createResourceRequest** | [**CreateResourceRequest**](CreateResourceRequest.md) |  |  |

### Return type

[**ResourceDetail**](ResourceDetail.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


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

