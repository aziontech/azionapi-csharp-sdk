# idns.Api.DNSSECApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetZoneDnsSec**](DNSSECApi.md#getzonednssec) | **GET** /intelligent_dns/{zone_id}/dnssec | Retrieve the DNSSEC zone status |
| [**PutZoneDnsSec**](DNSSECApi.md#putzonednssec) | **PATCH** /intelligent_dns/{zone_id}/dnssec | Update the DNSSEC zone |

<a id="getzonednssec"></a>
# **GetZoneDnsSec**
> GetOrPatchDnsSecResponse GetZoneDnsSec (int zoneId)

Retrieve the DNSSEC zone status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using idns.Api;
using idns.Client;
using idns.Model;

namespace Example
{
    public class GetZoneDnsSecExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DNSSECApi(config);
            var zoneId = 56;  // int | The hosted zone id

            try
            {
                // Retrieve the DNSSEC zone status
                GetOrPatchDnsSecResponse result = apiInstance.GetZoneDnsSec(zoneId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSSECApi.GetZoneDnsSec: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetZoneDnsSecWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the DNSSEC zone status
    ApiResponse<GetOrPatchDnsSecResponse> response = apiInstance.GetZoneDnsSecWithHttpInfo(zoneId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSSECApi.GetZoneDnsSecWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zoneId** | **int** | The hosted zone id |  |

### Return type

[**GetOrPatchDnsSecResponse**](GetOrPatchDnsSecResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | DNSSEC status retrieved |  -  |
| **400** | Error |  -  |
| **404** | Zone not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putzonednssec"></a>
# **PutZoneDnsSec**
> GetOrPatchDnsSecResponse PutZoneDnsSec (int zoneId, DnsSec dnsSec = null)

Update the DNSSEC zone

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using idns.Api;
using idns.Client;
using idns.Model;

namespace Example
{
    public class PutZoneDnsSecExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DNSSECApi(config);
            var zoneId = 56;  // int | The hosted zone id
            var dnsSec = new DnsSec(); // DnsSec |  (optional) 

            try
            {
                // Update the DNSSEC zone
                GetOrPatchDnsSecResponse result = apiInstance.PutZoneDnsSec(zoneId, dnsSec);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSSECApi.PutZoneDnsSec: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutZoneDnsSecWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the DNSSEC zone
    ApiResponse<GetOrPatchDnsSecResponse> response = apiInstance.PutZoneDnsSecWithHttpInfo(zoneId, dnsSec);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSSECApi.PutZoneDnsSecWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zoneId** | **int** | The hosted zone id |  |
| **dnsSec** | [**DnsSec**](DnsSec.md) |  | [optional]  |

### Return type

[**GetOrPatchDnsSecResponse**](GetOrPatchDnsSecResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Zone updated |  -  |
| **400** | Zone update error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

