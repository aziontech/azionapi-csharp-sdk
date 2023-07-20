# digital_certificates.Api.RetrieveDigitalCertificateListApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ListDigitalCertificates**](RetrieveDigitalCertificateListApi.md#listdigitalcertificates) | **GET** /digital_certificates | List all existing digital certificates and CSRs registered to your account |

<a id="listdigitalcertificates"></a>
# **ListDigitalCertificates**
> DC200List ListDigitalCertificates (string orderBy = null, string sort = null, string name = null, string search = null)

List all existing digital certificates and CSRs registered to your account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using digital_certificates.Api;
using digital_certificates.Client;
using digital_certificates.Model;

namespace Example
{
    public class ListDigitalCertificatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RetrieveDigitalCertificateListApi(config);
            var orderBy = "name";  // string | Response field to order by, current options are \"name\" or \"id\" (optional)  (default to id)
            var sort = "asc";  // string | Sorting direction (optional)  (default to asc)
            var name = "name_example";  // string | Searches certificate for name (optional) 
            var search = "search_example";  // string | Searches for string in certificate name (optional) 

            try
            {
                // List all existing digital certificates and CSRs registered to your account
                DC200List result = apiInstance.ListDigitalCertificates(orderBy, sort, name, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RetrieveDigitalCertificateListApi.ListDigitalCertificates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListDigitalCertificatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all existing digital certificates and CSRs registered to your account
    ApiResponse<DC200List> response = apiInstance.ListDigitalCertificatesWithHttpInfo(orderBy, sort, name, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RetrieveDigitalCertificateListApi.ListDigitalCertificatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderBy** | **string** | Response field to order by, current options are \&quot;name\&quot; or \&quot;id\&quot; | [optional] [default to id] |
| **sort** | **string** | Sorting direction | [optional] [default to asc] |
| **name** | **string** | Searches certificate for name | [optional]  |
| **search** | **string** | Searches for string in certificate name | [optional]  |

### Return type

[**DC200List**](DC200List.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **406** | Not acceptable |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

