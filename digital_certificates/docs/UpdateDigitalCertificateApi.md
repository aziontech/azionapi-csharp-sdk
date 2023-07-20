# digital_certificates.Api.UpdateDigitalCertificateApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UpdateDigitalCertificate**](UpdateDigitalCertificateApi.md#updatedigitalcertificate) | **PATCH** /digital_certificates/{digital_certificate_id} | Change only select settings of your digital certificate or CSR. |

<a id="updatedigitalcertificate"></a>
# **UpdateDigitalCertificate**
> DC200 UpdateDigitalCertificate (int digitalCertificateId, UpdateDigitalCertificateRequest updateDigitalCertificateRequest)

Change only select settings of your digital certificate or CSR.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using digital_certificates.Api;
using digital_certificates.Client;
using digital_certificates.Model;

namespace Example
{
    public class UpdateDigitalCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UpdateDigitalCertificateApi(config);
            var digitalCertificateId = 56;  // int | ID of certificate to update
            var updateDigitalCertificateRequest = new UpdateDigitalCertificateRequest(); // UpdateDigitalCertificateRequest | 

            try
            {
                // Change only select settings of your digital certificate or CSR.
                DC200 result = apiInstance.UpdateDigitalCertificate(digitalCertificateId, updateDigitalCertificateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UpdateDigitalCertificateApi.UpdateDigitalCertificate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDigitalCertificateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change only select settings of your digital certificate or CSR.
    ApiResponse<DC200> response = apiInstance.UpdateDigitalCertificateWithHttpInfo(digitalCertificateId, updateDigitalCertificateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UpdateDigitalCertificateApi.UpdateDigitalCertificateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **digitalCertificateId** | **int** | ID of certificate to update |  |
| **updateDigitalCertificateRequest** | [**UpdateDigitalCertificateRequest**](UpdateDigitalCertificateRequest.md) |  |  |

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

