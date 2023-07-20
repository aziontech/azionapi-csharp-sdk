# digital_certificates.Api.CreateDigitalCertificateApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCertificate**](CreateDigitalCertificateApi.md#createcertificate) | **POST** /digital_certificates | Create a new digital certificate |

<a id="createcertificate"></a>
# **CreateCertificate**
> DC201 CreateCertificate (CreateCertificateRequest createCertificateRequest)

Create a new digital certificate

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using digital_certificates.Api;
using digital_certificates.Client;
using digital_certificates.Model;

namespace Example
{
    public class CreateCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CreateDigitalCertificateApi(config);
            var createCertificateRequest = new CreateCertificateRequest(); // CreateCertificateRequest | 

            try
            {
                // Create a new digital certificate
                DC201 result = apiInstance.CreateCertificate(createCertificateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateDigitalCertificateApi.CreateCertificate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCertificateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new digital certificate
    ApiResponse<DC201> response = apiInstance.CreateCertificateWithHttpInfo(createCertificateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreateDigitalCertificateApi.CreateCertificateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createCertificateRequest** | [**CreateCertificateRequest**](CreateCertificateRequest.md) |  |  |

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

