# digital_certificates.Api.CreateCSRApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCSR**](CreateCSRApi.md#createcsr) | **POST** /digital_certificates/csr | Create an encrypted Certificate Request with Azion, which can then be sent for signing to a CA |

<a id="createcsr"></a>
# **CreateCSR**
> DC201 CreateCSR (CreateCSRRequest createCSRRequest)

Create an encrypted Certificate Request with Azion, which can then be sent for signing to a CA

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using digital_certificates.Api;
using digital_certificates.Client;
using digital_certificates.Model;

namespace Example
{
    public class CreateCSRExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CreateCSRApi(config);
            var createCSRRequest = new CreateCSRRequest(); // CreateCSRRequest | 

            try
            {
                // Create an encrypted Certificate Request with Azion, which can then be sent for signing to a CA
                DC201 result = apiInstance.CreateCSR(createCSRRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateCSRApi.CreateCSR: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCSRWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an encrypted Certificate Request with Azion, which can then be sent for signing to a CA
    ApiResponse<DC201> response = apiInstance.CreateCSRWithHttpInfo(createCSRRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreateCSRApi.CreateCSRWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createCSRRequest** | [**CreateCSRRequest**](CreateCSRRequest.md) |  |  |

### Return type

[**DC201**](DC201.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Successful operation |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

