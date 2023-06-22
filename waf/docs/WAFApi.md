# waf.Api.WAFApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetWAFDomains**](WAFApi.md#getwafdomains) | **GET** /waf/{wafId}/domains | Find domains attached to a WAF |
| [**GetWAFEvents**](WAFApi.md#getwafevents) | **GET** /waf/{wafId}/waf_events | Find WAF log events |

<a id="getwafdomains"></a>
# **GetWAFDomains**
> WAFDomains200 GetWAFDomains (long wafId, string name = null)

Find domains attached to a WAF

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using waf.Api;
using waf.Client;
using waf.Model;

namespace Example
{
    public class GetWAFDomainsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WAFApi(config);
            var wafId = 789L;  // long | ID of WAF to return
            var name = "name_example";  // string | searches WAF for name (optional) 

            try
            {
                // Find domains attached to a WAF
                WAFDomains200 result = apiInstance.GetWAFDomains(wafId, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WAFApi.GetWAFDomains: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWAFDomainsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find domains attached to a WAF
    ApiResponse<WAFDomains200> response = apiInstance.GetWAFDomainsWithHttpInfo(wafId, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WAFApi.GetWAFDomainsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **wafId** | **long** | ID of WAF to return |  |
| **name** | **string** | searches WAF for name | [optional]  |

### Return type

[**WAFDomains200**](WAFDomains200.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getwafevents"></a>
# **GetWAFEvents**
> WAFEvents200 GetWAFEvents (long wafId, long hourRange, string domainsIds, long? networkListId = null)

Find WAF log events

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using waf.Api;
using waf.Client;
using waf.Model;

namespace Example
{
    public class GetWAFEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WAFApi(config);
            var wafId = 789L;  // long | ID of WAF to return
            var hourRange = 789L;  // long | Last log hours since now (it must be a integer number ranging between 1 and 72)
            var domainsIds = "domainsIds_example";  // string | Multiple domain's id (they must be separated by comma like 1233,1234)
            var networkListId = 789L;  // long? | Id of a network list (optional) 

            try
            {
                // Find WAF log events
                WAFEvents200 result = apiInstance.GetWAFEvents(wafId, hourRange, domainsIds, networkListId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WAFApi.GetWAFEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWAFEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find WAF log events
    ApiResponse<WAFEvents200> response = apiInstance.GetWAFEventsWithHttpInfo(wafId, hourRange, domainsIds, networkListId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WAFApi.GetWAFEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **wafId** | **long** | ID of WAF to return |  |
| **hourRange** | **long** | Last log hours since now (it must be a integer number ranging between 1 and 72) |  |
| **domainsIds** | **string** | Multiple domain&#39;s id (they must be separated by comma like 1233,1234) |  |
| **networkListId** | **long?** | Id of a network list | [optional]  |

### Return type

[**WAFEvents200**](WAFEvents200.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **400** | Bad request |  -  |
| **404** | data not found |  -  |
| **401** | unauthorized operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

