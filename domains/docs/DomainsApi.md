# domains.Api.DomainsApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateDomain**](DomainsApi.md#createdomain) | **POST** /domains | /domains |
| [**DelDomain**](DomainsApi.md#deldomain) | **DELETE** /domains/{id} | /domains/:id |
| [**GetDomain**](DomainsApi.md#getdomain) | **GET** /domains/{id} | /domains/:id |
| [**GetDomains**](DomainsApi.md#getdomains) | **GET** /domains | /domains |
| [**PutDomain**](DomainsApi.md#putdomain) | **PUT** /domains/{id} | /domains:/:id |
| [**UpdateDomain**](DomainsApi.md#updatedomain) | **PATCH** /domains/{id} | /domains/:id |

<a id="createdomain"></a>
# **CreateDomain**
> DomainResponseWithResult CreateDomain (string accept = null, string contentType = null, CreateDomainRequest createDomainRequest = null)

/domains

It enables you to include a new domain into an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using domains.Api;
using domains.Client;
using domains.Model;

namespace Example
{
    public class CreateDomainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DomainsApi(config);
            var accept = application/json; version=3;  // string |  (optional) 
            var contentType = application/json;  // string |  (optional) 
            var createDomainRequest = new CreateDomainRequest(); // CreateDomainRequest |  (optional) 

            try
            {
                // /domains
                DomainResponseWithResult result = apiInstance.CreateDomain(accept, contentType, createDomainRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.CreateDomain: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDomainWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /domains
    ApiResponse<DomainResponseWithResult> response = apiInstance.CreateDomainWithHttpInfo(accept, contentType, createDomainRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainsApi.CreateDomainWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accept** | **string** |  | [optional]  |
| **contentType** | **string** |  | [optional]  |
| **createDomainRequest** | [**CreateDomainRequest**](CreateDomainRequest.md) |  | [optional]  |

### Return type

[**DomainResponseWithResult**](DomainResponseWithResult.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json; version=3
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deldomain"></a>
# **DelDomain**
> void DelDomain (string id, string accept = null)

/domains/:id

It enables you to delete a domain.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using domains.Api;
using domains.Client;
using domains.Model;

namespace Example
{
    public class DelDomainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DomainsApi(config);
            var id = "id_example";  // string | The id of the domain to be deleted. 
            var accept = application/json; version=3;  // string |  (optional) 

            try
            {
                // /domains/:id
                apiInstance.DelDomain(id, accept);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.DelDomain: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DelDomainWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /domains/:id
    apiInstance.DelDomainWithHttpInfo(id, accept);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainsApi.DelDomainWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the domain to be deleted.  |  |
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

<a id="getdomain"></a>
# **GetDomain**
> DomainResponseWithResult GetDomain (string id, string accept = null)

/domains/:id

It returns details of a domain.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using domains.Api;
using domains.Client;
using domains.Model;

namespace Example
{
    public class GetDomainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DomainsApi(config);
            var id = "id_example";  // string | The id of the domain to be consulted. 
            var accept = application/json; version=3;  // string |  (optional) 

            try
            {
                // /domains/:id
                DomainResponseWithResult result = apiInstance.GetDomain(id, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.GetDomain: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDomainWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /domains/:id
    ApiResponse<DomainResponseWithResult> response = apiInstance.GetDomainWithHttpInfo(id, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainsApi.GetDomainWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the domain to be consulted.  |  |
| **accept** | **string** |  | [optional]  |

### Return type

[**DomainResponseWithResult**](DomainResponseWithResult.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdomains"></a>
# **GetDomains**
> DomainResponseWithResults GetDomains (string accept = null)

/domains

It returns the list of domains of an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using domains.Api;
using domains.Client;
using domains.Model;

namespace Example
{
    public class GetDomainsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DomainsApi(config);
            var accept = application/json; version=3;  // string |  (optional) 

            try
            {
                // /domains
                DomainResponseWithResults result = apiInstance.GetDomains(accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.GetDomains: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDomainsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /domains
    ApiResponse<DomainResponseWithResults> response = apiInstance.GetDomainsWithHttpInfo(accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainsApi.GetDomainsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accept** | **string** |  | [optional]  |

### Return type

[**DomainResponseWithResults**](DomainResponseWithResults.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putdomain"></a>
# **PutDomain**
> DomainResponseWithResult PutDomain (string id, string accept = null, string contentType = null, PutDomainRequest putDomainRequest = null)

/domains:/:id

It overwrites all fields of a domain, while preserving the id. Optional fields not filled in will be replaced by the default values.  To update only some fields in a domain, consider using the PATCH method instead of PUT.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using domains.Api;
using domains.Client;
using domains.Model;

namespace Example
{
    public class PutDomainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DomainsApi(config);
            var id = "id_example";  // string | 
            var accept = application/json; version=3;  // string |  (optional) 
            var contentType = application/json;  // string |  (optional) 
            var putDomainRequest = new PutDomainRequest(); // PutDomainRequest |  (optional) 

            try
            {
                // /domains:/:id
                DomainResponseWithResult result = apiInstance.PutDomain(id, accept, contentType, putDomainRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.PutDomain: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutDomainWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /domains:/:id
    ApiResponse<DomainResponseWithResult> response = apiInstance.PutDomainWithHttpInfo(id, accept, contentType, putDomainRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainsApi.PutDomainWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **accept** | **string** |  | [optional]  |
| **contentType** | **string** |  | [optional]  |
| **putDomainRequest** | [**PutDomainRequest**](PutDomainRequest.md) |  | [optional]  |

### Return type

[**DomainResponseWithResult**](DomainResponseWithResult.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json; version=3
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatedomain"></a>
# **UpdateDomain**
> DomainResponseWithResult UpdateDomain (string id, string accept = null, string contentType = null, UpdateDomainRequest updateDomainRequest = null)

/domains/:id

It updates one or more fields in a Domain, preserving the value of the fields not informed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using domains.Api;
using domains.Client;
using domains.Model;

namespace Example
{
    public class UpdateDomainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DomainsApi(config);
            var id = "id_example";  // string | 
            var accept = application/json; version=3;  // string |  (optional) 
            var contentType = application/json;  // string |  (optional) 
            var updateDomainRequest = new UpdateDomainRequest(); // UpdateDomainRequest |  (optional) 

            try
            {
                // /domains/:id
                DomainResponseWithResult result = apiInstance.UpdateDomain(id, accept, contentType, updateDomainRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainsApi.UpdateDomain: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDomainWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /domains/:id
    ApiResponse<DomainResponseWithResult> response = apiInstance.UpdateDomainWithHttpInfo(id, accept, contentType, updateDomainRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainsApi.UpdateDomainWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **accept** | **string** |  | [optional]  |
| **contentType** | **string** |  | [optional]  |
| **updateDomainRequest** | [**UpdateDomainRequest**](UpdateDomainRequest.md) |  | [optional]  |

### Return type

[**DomainResponseWithResult**](DomainResponseWithResult.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json; version=3
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

