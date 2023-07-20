# digital_certificates.Api.OverwriteDigitalCertificateApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**OverwriteDigitalCertificate**](OverwriteDigitalCertificateApi.md#overwritedigitalcertificate) | **PUT** /digital_certificates/{digital_certificate_id} | Overwrite a digital certificate with another complete digital certificate |

<a id="overwritedigitalcertificate"></a>
# **OverwriteDigitalCertificate**
> DC200 OverwriteDigitalCertificate (int digitalCertificateId, CreateCertificateRequest createCertificateRequest)

Overwrite a digital certificate with another complete digital certificate

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using digital_certificates.Api;
using digital_certificates.Client;
using digital_certificates.Model;

namespace Example
{
    public class OverwriteDigitalCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OverwriteDigitalCertificateApi(config);
            var digitalCertificateId = 56;  // int | ID of certificate to overwrite
            var createCertificateRequest = new CreateCertificateRequest(); // CreateCertificateRequest | 

            try
            {
                // Overwrite a digital certificate with another complete digital certificate
                DC200 result = apiInstance.OverwriteDigitalCertificate(digitalCertificateId, createCertificateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OverwriteDigitalCertificateApi.OverwriteDigitalCertificate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OverwriteDigitalCertificateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Overwrite a digital certificate with another complete digital certificate
    ApiResponse<DC200> response = apiInstance.OverwriteDigitalCertificateWithHttpInfo(digitalCertificateId, createCertificateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OverwriteDigitalCertificateApi.OverwriteDigitalCertificateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **digitalCertificateId** | **int** | ID of certificate to overwrite |  |
| **createCertificateRequest** | [**CreateCertificateRequest**](CreateCertificateRequest.md) |  |  |

### Return type

[**DC200**](DC200.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

