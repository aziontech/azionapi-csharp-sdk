# credentials.Api.DefaultApi

All URIs are relative to *http://localhost:3007*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCredential**](DefaultApi.md#createcredential) | **POST** /credentials | Create credential |
| [**DeleteCredential**](DefaultApi.md#deletecredential) | **DELETE** /credentials/{credentialId} | Delete the Credential |
| [**FindAll**](DefaultApi.md#findall) | **GET** /credentials | Return all credentials |
| [**LoadCredential**](DefaultApi.md#loadcredential) | **GET** /credentials/{credentialId} | Load the Credential |
| [**UpdateCredential**](DefaultApi.md#updatecredential) | **PATCH** /credentials/{credentialId} | Update the Credential |

<a id="createcredential"></a>
# **CreateCredential**
> AuthToken CreateCredential (CreateCredentialRequest createCredentialRequest)

Create credential

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using credentials.Api;
using credentials.Client;
using credentials.Model;

namespace Example
{
    public class CreateCredentialExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3007";
            // Configure API key authorization: bearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var createCredentialRequest = new CreateCredentialRequest(); // CreateCredentialRequest | 

            try
            {
                // Create credential
                AuthToken result = apiInstance.CreateCredential(createCredentialRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateCredential: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCredentialWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create credential
    ApiResponse<AuthToken> response = apiInstance.CreateCredentialWithHttpInfo(createCredentialRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateCredentialWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createCredentialRequest** | [**CreateCredentialRequest**](CreateCredentialRequest.md) |  |  |

### Return type

[**AuthToken**](AuthToken.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json; version=3
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecredential"></a>
# **DeleteCredential**
> void DeleteCredential (long credentialId)

Delete the Credential

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using credentials.Api;
using credentials.Client;
using credentials.Model;

namespace Example
{
    public class DeleteCredentialExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3007";
            // Configure API key authorization: bearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var credentialId = 789L;  // long | 

            try
            {
                // Delete the Credential
                apiInstance.DeleteCredential(credentialId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteCredential: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCredentialWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete the Credential
    apiInstance.DeleteCredentialWithHttpInfo(credentialId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteCredentialWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **credentialId** | **long** |  |  |

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="findall"></a>
# **FindAll**
> ResponseWithTotal FindAll (string filter = null, long? page = null, long? pageSize = null, string sort = null, string orderBy = null)

Return all credentials

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using credentials.Api;
using credentials.Client;
using credentials.Model;

namespace Example
{
    public class FindAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3007";
            // Configure API key authorization: bearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var filter = "filter_example";  // string |  (optional) 
            var page = 789L;  // long? |  (optional) 
            var pageSize = 789L;  // long? |  (optional) 
            var sort = "sort_example";  // string |  (optional) 
            var orderBy = "orderBy_example";  // string |  (optional) 

            try
            {
                // Return all credentials
                ResponseWithTotal result = apiInstance.FindAll(filter, page, pageSize, sort, orderBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.FindAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return all credentials
    ApiResponse<ResponseWithTotal> response = apiInstance.FindAllWithHttpInfo(filter, page, pageSize, sort, orderBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.FindAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filter** | **string** |  | [optional]  |
| **page** | **long?** |  | [optional]  |
| **pageSize** | **long?** |  | [optional]  |
| **sort** | **string** |  | [optional]  |
| **orderBy** | **string** |  | [optional]  |

### Return type

[**ResponseWithTotal**](ResponseWithTotal.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="loadcredential"></a>
# **LoadCredential**
> Response LoadCredential (long credentialId)

Load the Credential

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using credentials.Api;
using credentials.Client;
using credentials.Model;

namespace Example
{
    public class LoadCredentialExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3007";
            // Configure API key authorization: bearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var credentialId = 789L;  // long | 

            try
            {
                // Load the Credential
                Response result = apiInstance.LoadCredential(credentialId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.LoadCredential: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoadCredentialWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Load the Credential
    ApiResponse<Response> response = apiInstance.LoadCredentialWithHttpInfo(credentialId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.LoadCredentialWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **credentialId** | **long** |  |  |

### Return type

[**Response**](Response.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecredential"></a>
# **UpdateCredential**
> Response UpdateCredential (long credentialId, UpdateCredentialRequest updateCredentialRequest)

Update the Credential

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using credentials.Api;
using credentials.Client;
using credentials.Model;

namespace Example
{
    public class UpdateCredentialExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3007";
            // Configure API key authorization: bearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var credentialId = 789L;  // long | 
            var updateCredentialRequest = new UpdateCredentialRequest(); // UpdateCredentialRequest | 

            try
            {
                // Update the Credential
                Response result = apiInstance.UpdateCredential(credentialId, updateCredentialRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateCredential: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCredentialWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the Credential
    ApiResponse<Response> response = apiInstance.UpdateCredentialWithHttpInfo(credentialId, updateCredentialRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateCredentialWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **credentialId** | **long** |  |  |
| **updateCredentialRequest** | [**UpdateCredentialRequest**](UpdateCredentialRequest.md) |  |  |

### Return type

[**Response**](Response.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json; version=3
 - **Accept**: application/json; version=3


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

