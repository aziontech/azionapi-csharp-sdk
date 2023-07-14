# personal_tokens.Api.PersonalTokenApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreatePersonalToken**](PersonalTokenApi.md#createpersonaltoken) | **POST** /iam/personal_tokens | Create a new personal token |
| [**DeletePersonalToken**](PersonalTokenApi.md#deletepersonaltoken) | **DELETE** /iam/personal_tokens/{personalTokenId} | Delete a personal token by id |
| [**GetPersonalToken**](PersonalTokenApi.md#getpersonaltoken) | **GET** /iam/personal_tokens/{personalTokenId} | Get a personal token info |
| [**ListPersonalToken**](PersonalTokenApi.md#listpersonaltoken) | **GET** /iam/personal_tokens | List all existing personal token |

<a id="createpersonaltoken"></a>
# **CreatePersonalToken**
> CreatePersonalTokenResponse CreatePersonalToken (CreatePersonalTokenRequest createPersonalTokenRequest)

Create a new personal token

Create a new personal token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using personal_tokens.Api;
using personal_tokens.Client;
using personal_tokens.Model;

namespace Example
{
    public class CreatePersonalTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PersonalTokenApi(config);
            var createPersonalTokenRequest = new CreatePersonalTokenRequest(); // CreatePersonalTokenRequest | 

            try
            {
                // Create a new personal token
                CreatePersonalTokenResponse result = apiInstance.CreatePersonalToken(createPersonalTokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalTokenApi.CreatePersonalToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePersonalTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new personal token
    ApiResponse<CreatePersonalTokenResponse> response = apiInstance.CreatePersonalTokenWithHttpInfo(createPersonalTokenRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonalTokenApi.CreatePersonalTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createPersonalTokenRequest** | [**CreatePersonalTokenRequest**](CreatePersonalTokenRequest.md) |  |  |

### Return type

[**CreatePersonalTokenResponse**](CreatePersonalTokenResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **429** | Rate Limit |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletepersonaltoken"></a>
# **DeletePersonalToken**
> void DeletePersonalToken (Guid personalTokenId)

Delete a personal token by id

Delete a personal token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using personal_tokens.Api;
using personal_tokens.Client;
using personal_tokens.Model;

namespace Example
{
    public class DeletePersonalTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PersonalTokenApi(config);
            var personalTokenId = "personalTokenId_example";  // Guid | 

            try
            {
                // Delete a personal token by id
                apiInstance.DeletePersonalToken(personalTokenId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalTokenApi.DeletePersonalToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePersonalTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a personal token by id
    apiInstance.DeletePersonalTokenWithHttpInfo(personalTokenId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonalTokenApi.DeletePersonalTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **personalTokenId** | **Guid** |  |  |

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
| **429** | Rate Limit |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpersonaltoken"></a>
# **GetPersonalToken**
> PersonalTokenResponseGet GetPersonalToken (Guid personalTokenId)

Get a personal token info

Get a personal token info

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using personal_tokens.Api;
using personal_tokens.Client;
using personal_tokens.Model;

namespace Example
{
    public class GetPersonalTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PersonalTokenApi(config);
            var personalTokenId = "personalTokenId_example";  // Guid | 

            try
            {
                // Get a personal token info
                PersonalTokenResponseGet result = apiInstance.GetPersonalToken(personalTokenId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalTokenApi.GetPersonalToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPersonalTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a personal token info
    ApiResponse<PersonalTokenResponseGet> response = apiInstance.GetPersonalTokenWithHttpInfo(personalTokenId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonalTokenApi.GetPersonalTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **personalTokenId** | **Guid** |  |  |

### Return type

[**PersonalTokenResponseGet**](PersonalTokenResponseGet.md)

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
| **429** | Rate Limit |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listpersonaltoken"></a>
# **ListPersonalToken**
> PersonalTokenResponseWithResults ListPersonalToken ()

List all existing personal token

List all existing personal token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using personal_tokens.Api;
using personal_tokens.Client;
using personal_tokens.Model;

namespace Example
{
    public class ListPersonalTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PersonalTokenApi(config);

            try
            {
                // List all existing personal token
                PersonalTokenResponseWithResults result = apiInstance.ListPersonalToken();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalTokenApi.ListPersonalToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPersonalTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all existing personal token
    ApiResponse<PersonalTokenResponseWithResults> response = apiInstance.ListPersonalTokenWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonalTokenApi.ListPersonalTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PersonalTokenResponseWithResults**](PersonalTokenResponseWithResults.md)

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
| **429** | Rate Limit |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

