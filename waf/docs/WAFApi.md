# waf.Api.WAFApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNewWAFRuleset**](WAFApi.md#createnewwafruleset) | **POST** /waf/rulesets | Create a new WAF Rule Set in an account. |
| [**DeleteWAFRuleset**](WAFApi.md#deletewafruleset) | **DELETE** /waf/rulesets/{waf_rule_set_id} | Remove an WAF Rule Set from an account. Warning: this action cannot be undone. |
| [**GetWAFDomains**](WAFApi.md#getwafdomains) | **GET** /waf/{waf_id}/domains | List all domains attached to a Web Application Firewall (WAF) in an account. |
| [**GetWAFEvents**](WAFApi.md#getwafevents) | **GET** /waf/{waf_id}/waf_events | Find WAF log events |
| [**GetWAFRuleset**](WAFApi.md#getwafruleset) | **GET** /waf/rulesets/{waf_rule_set_id} | List a specific Rule Set associated to a Web Application Firewall (WAF) in an account. |
| [**ListAllWAF**](WAFApi.md#listallwaf) | **GET** /waf | List all Web Application Firewalls (WAFs) created in an account |
| [**ListAllWAFRulesets**](WAFApi.md#listallwafrulesets) | **GET** /waf/rulesets | list all Rule Sets associated to a Web Application Firewall (WAF) in an account. |
| [**UpdateWAFRuleset**](WAFApi.md#updatewafruleset) | **PATCH** /waf/rulesets/{waf_rule_set_id} | Change only select settings of a WAF Rule Set |

<a id="createnewwafruleset"></a>
# **CreateNewWAFRuleset**
> SingleWAF CreateNewWAFRuleset (CreateNewWAFRulesetRequest? createNewWAFRulesetRequest = null)

Create a new WAF Rule Set in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using waf.Api;
using waf.Client;
using waf.Model;

namespace Example
{
    public class CreateNewWAFRulesetExample
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
            var createNewWAFRulesetRequest = new CreateNewWAFRulesetRequest?(); // CreateNewWAFRulesetRequest? |  (optional) 

            try
            {
                // Create a new WAF Rule Set in an account.
                SingleWAF result = apiInstance.CreateNewWAFRuleset(createNewWAFRulesetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WAFApi.CreateNewWAFRuleset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateNewWAFRulesetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new WAF Rule Set in an account.
    ApiResponse<SingleWAF> response = apiInstance.CreateNewWAFRulesetWithHttpInfo(createNewWAFRulesetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WAFApi.CreateNewWAFRulesetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createNewWAFRulesetRequest** | [**CreateNewWAFRulesetRequest?**](CreateNewWAFRulesetRequest?.md) |  | [optional]  |

### Return type

[**SingleWAF**](SingleWAF.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json; version=3
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **201** | Successful response |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **415** | Unsupported Media Type |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletewafruleset"></a>
# **DeleteWAFRuleset**
> void DeleteWAFRuleset (string wafRuleSetId)

Remove an WAF Rule Set from an account. Warning: this action cannot be undone.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using waf.Api;
using waf.Client;
using waf.Model;

namespace Example
{
    public class DeleteWAFRulesetExample
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
            var wafRuleSetId = "wafRuleSetId_example";  // string | 

            try
            {
                // Remove an WAF Rule Set from an account. Warning: this action cannot be undone.
                apiInstance.DeleteWAFRuleset(wafRuleSetId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WAFApi.DeleteWAFRuleset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWAFRulesetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove an WAF Rule Set from an account. Warning: this action cannot be undone.
    apiInstance.DeleteWAFRulesetWithHttpInfo(wafRuleSetId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WAFApi.DeleteWAFRulesetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **wafRuleSetId** | **string** |  |  |

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
| **200** | Successful response |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getwafdomains"></a>
# **GetWAFDomains**
> WAFDomains200 GetWAFDomains (long wafId, string? name = null)

List all domains attached to a Web Application Firewall (WAF) in an account.

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
            var name = "name_example";  // string? | searches WAF for name (optional) 

            try
            {
                // List all domains attached to a Web Application Firewall (WAF) in an account.
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
    // List all domains attached to a Web Application Firewall (WAF) in an account.
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
| **name** | **string?** | searches WAF for name | [optional]  |

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
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |
| **404** | data not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getwafevents"></a>
# **GetWAFEvents**
> WAFEvents200 GetWAFEvents (long wafId, long hourRange, string domainsIds, long? networkListId = null, string? sort = null, long? page = null, long? pageSize = null)

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
            var sort = "asc";  // string? |  (optional)  (default to asc)
            var page = 1L;  // long? |  (optional)  (default to 1)
            var pageSize = 10L;  // long? |  (optional)  (default to 10)

            try
            {
                // Find WAF log events
                WAFEvents200 result = apiInstance.GetWAFEvents(wafId, hourRange, domainsIds, networkListId, sort, page, pageSize);
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
    ApiResponse<WAFEvents200> response = apiInstance.GetWAFEventsWithHttpInfo(wafId, hourRange, domainsIds, networkListId, sort, page, pageSize);
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
| **sort** | **string?** |  | [optional] [default to asc] |
| **page** | **long?** |  | [optional] [default to 1] |
| **pageSize** | **long?** |  | [optional] [default to 10] |

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
| **401** | unauthorized operation |  -  |
| **403** | Forbidden |  -  |
| **404** | data not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getwafruleset"></a>
# **GetWAFRuleset**
> WAFSingle200 GetWAFRuleset (long wafRuleSetId)

List a specific Rule Set associated to a Web Application Firewall (WAF) in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using waf.Api;
using waf.Client;
using waf.Model;

namespace Example
{
    public class GetWAFRulesetExample
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
            var wafRuleSetId = 789L;  // long | ID of WAF Ruleset to return

            try
            {
                // List a specific Rule Set associated to a Web Application Firewall (WAF) in an account.
                WAFSingle200 result = apiInstance.GetWAFRuleset(wafRuleSetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WAFApi.GetWAFRuleset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWAFRulesetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List a specific Rule Set associated to a Web Application Firewall (WAF) in an account.
    ApiResponse<WAFSingle200> response = apiInstance.GetWAFRulesetWithHttpInfo(wafRuleSetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WAFApi.GetWAFRulesetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **wafRuleSetId** | **long** | ID of WAF Ruleset to return |  |

### Return type

[**WAFSingle200**](WAFSingle200.md)

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
| **403** | Forbidden |  -  |
| **404** | data not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listallwaf"></a>
# **ListAllWAF**
> WAFList200 ListAllWAF (long? page = null, long? pageSize = null)

List all Web Application Firewalls (WAFs) created in an account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using waf.Api;
using waf.Client;
using waf.Model;

namespace Example
{
    public class ListAllWAFExample
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
            var page = 1L;  // long? | Identifies which page should be returned, if the return is paginated. (optional)  (default to 1)
            var pageSize = 10L;  // long? | Identifies how many items should be returned per page. (optional)  (default to 10)

            try
            {
                // List all Web Application Firewalls (WAFs) created in an account
                WAFList200 result = apiInstance.ListAllWAF(page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WAFApi.ListAllWAF: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAllWAFWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all Web Application Firewalls (WAFs) created in an account
    ApiResponse<WAFList200> response = apiInstance.ListAllWAFWithHttpInfo(page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WAFApi.ListAllWAFWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **long?** | Identifies which page should be returned, if the return is paginated. | [optional] [default to 1] |
| **pageSize** | **long?** | Identifies how many items should be returned per page. | [optional] [default to 10] |

### Return type

[**WAFList200**](WAFList200.md)

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
| **403** | Forbidden |  -  |
| **404** | data not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listallwafrulesets"></a>
# **ListAllWAFRulesets**
> WAFList200 ListAllWAFRulesets (string? orderBy = null, string? sort = null, long? page = null, long? pageSize = null)

list all Rule Sets associated to a Web Application Firewall (WAF) in an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using waf.Api;
using waf.Client;
using waf.Model;

namespace Example
{
    public class ListAllWAFRulesetsExample
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
            var orderBy = "id";  // string? | Identifies which property the return should be sorted by. (optional)  (default to name)
            var sort = "asc";  // string? | Defines whether objects are shown in ascending or descending order depending on the value set in order_by. (optional)  (default to asc)
            var page = 1L;  // long? | Identifies which page should be returned, if the return is paginated. (optional)  (default to 1)
            var pageSize = 10L;  // long? | Identifies how many items should be returned per page. (optional)  (default to 10)

            try
            {
                // list all Rule Sets associated to a Web Application Firewall (WAF) in an account.
                WAFList200 result = apiInstance.ListAllWAFRulesets(orderBy, sort, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WAFApi.ListAllWAFRulesets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAllWAFRulesetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // list all Rule Sets associated to a Web Application Firewall (WAF) in an account.
    ApiResponse<WAFList200> response = apiInstance.ListAllWAFRulesetsWithHttpInfo(orderBy, sort, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WAFApi.ListAllWAFRulesetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderBy** | **string?** | Identifies which property the return should be sorted by. | [optional] [default to name] |
| **sort** | **string?** | Defines whether objects are shown in ascending or descending order depending on the value set in order_by. | [optional] [default to asc] |
| **page** | **long?** | Identifies which page should be returned, if the return is paginated. | [optional] [default to 1] |
| **pageSize** | **long?** | Identifies how many items should be returned per page. | [optional] [default to 10] |

### Return type

[**WAFList200**](WAFList200.md)

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
| **403** | Forbidden |  -  |
| **404** | data not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatewafruleset"></a>
# **UpdateWAFRuleset**
> SingleWAF UpdateWAFRuleset (string wafRuleSetId, SingleWAF? singleWAF = null)

Change only select settings of a WAF Rule Set

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using waf.Api;
using waf.Client;
using waf.Model;

namespace Example
{
    public class UpdateWAFRulesetExample
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
            var wafRuleSetId = "wafRuleSetId_example";  // string | 
            var singleWAF = new SingleWAF?(); // SingleWAF? |  (optional) 

            try
            {
                // Change only select settings of a WAF Rule Set
                SingleWAF result = apiInstance.UpdateWAFRuleset(wafRuleSetId, singleWAF);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WAFApi.UpdateWAFRuleset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateWAFRulesetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change only select settings of a WAF Rule Set
    ApiResponse<SingleWAF> response = apiInstance.UpdateWAFRulesetWithHttpInfo(wafRuleSetId, singleWAF);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WAFApi.UpdateWAFRulesetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **wafRuleSetId** | **string** |  |  |
| **singleWAF** | [**SingleWAF?**](SingleWAF?.md) |  | [optional]  |

### Return type

[**SingleWAF**](SingleWAF.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json; version=3
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

