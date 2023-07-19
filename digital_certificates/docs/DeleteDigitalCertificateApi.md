# digital_certificates.Api.DeleteDigitalCertificateApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RemoveDigitalCertificates**](DeleteDigitalCertificateApi.md#removedigitalcertificates) | **DELETE** /digital_certificates/{digital_certificate_id} | Remove a digital certificate or CSR from your account |

<a id="removedigitalcertificates"></a>
# **RemoveDigitalCertificates**
> void RemoveDigitalCertificates (int digitalCertificateId)

Remove a digital certificate or CSR from your account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using digital_certificates.Api;
using digital_certificates.Client;
using digital_certificates.Model;

namespace Example
{
    public class RemoveDigitalCertificatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DeleteDigitalCertificateApi(config);
            var digitalCertificateId = 56;  // int | ID of certificate to delete

            try
            {
                // Remove a digital certificate or CSR from your account
                apiInstance.RemoveDigitalCertificates(digitalCertificateId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeleteDigitalCertificateApi.RemoveDigitalCertificates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveDigitalCertificatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a digital certificate or CSR from your account
    apiInstance.RemoveDigitalCertificatesWithHttpInfo(digitalCertificateId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeleteDigitalCertificateApi.RemoveDigitalCertificatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **digitalCertificateId** | **int** | ID of certificate to delete |  |

### Return type

void (empty response body)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

