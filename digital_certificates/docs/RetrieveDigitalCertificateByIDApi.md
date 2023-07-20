# digital_certificates.Api.RetrieveDigitalCertificateByIDApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCertificate**](RetrieveDigitalCertificateByIDApi.md#getcertificate) | **GET** /digital_certificates/{digital_certificate_id} | Get more data on a specific digital certificate or CSR. |

<a id="getcertificate"></a>
# **GetCertificate**
> DC200 GetCertificate (long digitalCertificateId)

Get more data on a specific digital certificate or CSR.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using digital_certificates.Api;
using digital_certificates.Client;
using digital_certificates.Model;

namespace Example
{
    public class GetCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RetrieveDigitalCertificateByIDApi(config);
            var digitalCertificateId = 789L;  // long | ID of certificate

            try
            {
                // Get more data on a specific digital certificate or CSR.
                DC200 result = apiInstance.GetCertificate(digitalCertificateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RetrieveDigitalCertificateByIDApi.GetCertificate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCertificateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get more data on a specific digital certificate or CSR.
    ApiResponse<DC200> response = apiInstance.GetCertificateWithHttpInfo(digitalCertificateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RetrieveDigitalCertificateByIDApi.GetCertificateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **digitalCertificateId** | **long** | ID of certificate |  |

### Return type

[**DC200**](DC200.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized operation |  -  |
| **403** | Forbidden operation |  -  |
| **404** | Data not found |  -  |
| **406** | Not Acceptable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

