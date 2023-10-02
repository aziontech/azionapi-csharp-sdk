# edgefirewall.Api.DefaultApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EdgeFirewallEdgeFirewallIdRulesEngineGet**](DefaultApi.md#edgefirewalledgefirewallidrulesengineget) | **GET** /edge_firewall/{edge_firewall_id}/rules_engine | List all rule sets. |
| [**EdgeFirewallEdgeFirewallIdRulesEnginePost**](DefaultApi.md#edgefirewalledgefirewallidrulesenginepost) | **POST** /edge_firewall/{edge_firewall_id}/rules_engine | Create rule set. |
| [**EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdDelete**](DefaultApi.md#edgefirewalledgefirewallidrulesenginerulesetiddelete) | **DELETE** /edge_firewall/{edge_firewall_id}/rules_engine/{rule_set_id} | Delete rule set. |
| [**EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdGet**](DefaultApi.md#edgefirewalledgefirewallidrulesenginerulesetidget) | **GET** /edge_firewall/{edge_firewall_id}/rules_engine/{rule_set_id} | Retrieve rule set by ID. |
| [**EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdPatch**](DefaultApi.md#edgefirewalledgefirewallidrulesenginerulesetidpatch) | **PATCH** /edge_firewall/{edge_firewall_id}/rules_engine/{rule_set_id} | Edit rule set. |
| [**EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdPut**](DefaultApi.md#edgefirewalledgefirewallidrulesenginerulesetidput) | **PUT** /edge_firewall/{edge_firewall_id}/rules_engine/{rule_set_id} | Overwrite rule set |
| [**EdgeFirewallGet**](DefaultApi.md#edgefirewallget) | **GET** /edge_firewall | List all user edge firewall |
| [**EdgeFirewallPost**](DefaultApi.md#edgefirewallpost) | **POST** /edge_firewall | Create a edge firewall |
| [**EdgeFirewallUuidDelete**](DefaultApi.md#edgefirewalluuiddelete) | **DELETE** /edge_firewall/{uuid} | Delete an edge firewall by uuid |
| [**EdgeFirewallUuidGet**](DefaultApi.md#edgefirewalluuidget) | **GET** /edge_firewall/{uuid} | Retrieve an edge firewall set by uuid |
| [**EdgeFirewallUuidPatch**](DefaultApi.md#edgefirewalluuidpatch) | **PATCH** /edge_firewall/{uuid} | Update some edge firewall attributes, like \&quot;active\&quot; |
| [**EdgeFirewallUuidPut**](DefaultApi.md#edgefirewalluuidput) | **PUT** /edge_firewall/{uuid} | Overwrite some edge firewall attributes, like \&quot;active\&quot; |

<a id="edgefirewalledgefirewallidrulesengineget"></a>
# **EdgeFirewallEdgeFirewallIdRulesEngineGet**
> RuleSetResponseAll EdgeFirewallEdgeFirewallIdRulesEngineGet (long edgeFirewallId)

List all rule sets.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefirewall.Api;
using edgefirewall.Client;
using edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallEdgeFirewallIdRulesEngineGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var edgeFirewallId = 789L;  // long | 

            try
            {
                // List all rule sets.
                RuleSetResponseAll result = apiInstance.EdgeFirewallEdgeFirewallIdRulesEngineGet(edgeFirewallId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdRulesEngineGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallEdgeFirewallIdRulesEngineGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all rule sets.
    ApiResponse<RuleSetResponseAll> response = apiInstance.EdgeFirewallEdgeFirewallIdRulesEngineGetWithHttpInfo(edgeFirewallId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdRulesEngineGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeFirewallId** | **long** |  |  |

### Return type

[**RuleSetResponseAll**](RuleSetResponseAll.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List all rule sets. |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewalledgefirewallidrulesenginepost"></a>
# **EdgeFirewallEdgeFirewallIdRulesEnginePost**
> RuleSetResponse EdgeFirewallEdgeFirewallIdRulesEnginePost (long edgeFirewallId, CreateRuleSetRequest? createRuleSetRequest = null)

Create rule set.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefirewall.Api;
using edgefirewall.Client;
using edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallEdgeFirewallIdRulesEnginePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var edgeFirewallId = 789L;  // long | 
            var createRuleSetRequest = new CreateRuleSetRequest?(); // CreateRuleSetRequest? |  (optional) 

            try
            {
                // Create rule set.
                RuleSetResponse result = apiInstance.EdgeFirewallEdgeFirewallIdRulesEnginePost(edgeFirewallId, createRuleSetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdRulesEnginePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallEdgeFirewallIdRulesEnginePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create rule set.
    ApiResponse<RuleSetResponse> response = apiInstance.EdgeFirewallEdgeFirewallIdRulesEnginePostWithHttpInfo(edgeFirewallId, createRuleSetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdRulesEnginePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeFirewallId** | **long** |  |  |
| **createRuleSetRequest** | [**CreateRuleSetRequest?**](CreateRuleSetRequest?.md) |  | [optional]  |

### Return type

[**RuleSetResponse**](RuleSetResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json; version=3
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Create rule set. |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewalledgefirewallidrulesenginerulesetiddelete"></a>
# **EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdDelete**
> void EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdDelete (long edgeFirewallId, long ruleSetId)

Delete rule set.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefirewall.Api;
using edgefirewall.Client;
using edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var edgeFirewallId = 789L;  // long | 
            var ruleSetId = 789L;  // long | 

            try
            {
                // Delete rule set.
                apiInstance.EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdDelete(edgeFirewallId, ruleSetId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete rule set.
    apiInstance.EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdDeleteWithHttpInfo(edgeFirewallId, ruleSetId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeFirewallId** | **long** |  |  |
| **ruleSetId** | **long** |  |  |

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
| **204** | Delete rule set. |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewalledgefirewallidrulesenginerulesetidget"></a>
# **EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdGet**
> RuleSetResult EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdGet (long edgeFirewallId, long ruleSetId, string? orderBy = null, string? sort = null, long? page = null, long? pageSize = null)

Retrieve rule set by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefirewall.Api;
using edgefirewall.Client;
using edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var edgeFirewallId = 789L;  // long | 
            var ruleSetId = 789L;  // long | 
            var orderBy = "orderBy_example";  // string? |  (optional) 
            var sort = "ASC";  // string? |  (optional) 
            var page = 1L;  // long? |  (optional)  (default to 1)
            var pageSize = 10L;  // long? |  (optional)  (default to 10)

            try
            {
                // Retrieve rule set by ID.
                RuleSetResult result = apiInstance.EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdGet(edgeFirewallId, ruleSetId, orderBy, sort, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve rule set by ID.
    ApiResponse<RuleSetResult> response = apiInstance.EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdGetWithHttpInfo(edgeFirewallId, ruleSetId, orderBy, sort, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeFirewallId** | **long** |  |  |
| **ruleSetId** | **long** |  |  |
| **orderBy** | **string?** |  | [optional]  |
| **sort** | **string?** |  | [optional]  |
| **page** | **long?** |  | [optional] [default to 1] |
| **pageSize** | **long?** |  | [optional] [default to 10] |

### Return type

[**RuleSetResult**](RuleSetResult.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Retrieve rule set by ID. |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewalledgefirewallidrulesenginerulesetidpatch"></a>
# **EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdPatch**
> RuleSetResult EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdPatch (long edgeFirewallId, long ruleSetId, CreateRuleSetRequest? createRuleSetRequest = null)

Edit rule set.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefirewall.Api;
using edgefirewall.Client;
using edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var edgeFirewallId = 789L;  // long | 
            var ruleSetId = 789L;  // long | 
            var createRuleSetRequest = new CreateRuleSetRequest?(); // CreateRuleSetRequest? |  (optional) 

            try
            {
                // Edit rule set.
                RuleSetResult result = apiInstance.EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdPatch(edgeFirewallId, ruleSetId, createRuleSetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit rule set.
    ApiResponse<RuleSetResult> response = apiInstance.EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdPatchWithHttpInfo(edgeFirewallId, ruleSetId, createRuleSetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeFirewallId** | **long** |  |  |
| **ruleSetId** | **long** |  |  |
| **createRuleSetRequest** | [**CreateRuleSetRequest?**](CreateRuleSetRequest?.md) |  | [optional]  |

### Return type

[**RuleSetResult**](RuleSetResult.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json; version=3
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Edit rule set. |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewalledgefirewallidrulesenginerulesetidput"></a>
# **EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdPut**
> RuleSetResult EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdPut (long edgeFirewallId, long ruleSetId, CreateRuleSetRequest? createRuleSetRequest = null)

Overwrite rule set

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefirewall.Api;
using edgefirewall.Client;
using edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var edgeFirewallId = 789L;  // long | 
            var ruleSetId = 789L;  // long | 
            var createRuleSetRequest = new CreateRuleSetRequest?(); // CreateRuleSetRequest? |  (optional) 

            try
            {
                // Overwrite rule set
                RuleSetResult result = apiInstance.EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdPut(edgeFirewallId, ruleSetId, createRuleSetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Overwrite rule set
    ApiResponse<RuleSetResult> response = apiInstance.EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdPutWithHttpInfo(edgeFirewallId, ruleSetId, createRuleSetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallEdgeFirewallIdRulesEngineRuleSetIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeFirewallId** | **long** |  |  |
| **ruleSetId** | **long** |  |  |
| **createRuleSetRequest** | [**CreateRuleSetRequest?**](CreateRuleSetRequest?.md) |  | [optional]  |

### Return type

[**RuleSetResult**](RuleSetResult.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json; version=3
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Overwrite rule set. |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewallget"></a>
# **EdgeFirewallGet**
> ListEdgeFirewallResponse EdgeFirewallGet (long? page = null, long? pageSize = null, string? sort = null, string? orderBy = null)

List all user edge firewall

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefirewall.Api;
using edgefirewall.Client;
using edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var page = 789L;  // long? |  (optional) 
            var pageSize = 789L;  // long? |  (optional) 
            var sort = "sort_example";  // string? |  (optional) 
            var orderBy = "orderBy_example";  // string? |  (optional) 

            try
            {
                // List all user edge firewall
                ListEdgeFirewallResponse result = apiInstance.EdgeFirewallGet(page, pageSize, sort, orderBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all user edge firewall
    ApiResponse<ListEdgeFirewallResponse> response = apiInstance.EdgeFirewallGetWithHttpInfo(page, pageSize, sort, orderBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **long?** |  | [optional]  |
| **pageSize** | **long?** |  | [optional]  |
| **sort** | **string?** |  | [optional]  |
| **orderBy** | **string?** |  | [optional]  |

### Return type

[**ListEdgeFirewallResponse**](ListEdgeFirewallResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of edge firewalls |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewallpost"></a>
# **EdgeFirewallPost**
> EdgeFirewallResponse EdgeFirewallPost (CreateEdgeFirewallRequest createEdgeFirewallRequest)

Create a edge firewall

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefirewall.Api;
using edgefirewall.Client;
using edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var createEdgeFirewallRequest = new CreateEdgeFirewallRequest(); // CreateEdgeFirewallRequest | 

            try
            {
                // Create a edge firewall
                EdgeFirewallResponse result = apiInstance.EdgeFirewallPost(createEdgeFirewallRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a edge firewall
    ApiResponse<EdgeFirewallResponse> response = apiInstance.EdgeFirewallPostWithHttpInfo(createEdgeFirewallRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createEdgeFirewallRequest** | [**CreateEdgeFirewallRequest**](CreateEdgeFirewallRequest.md) |  |  |

### Return type

[**EdgeFirewallResponse**](EdgeFirewallResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Edge firewall created |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewalluuiddelete"></a>
# **EdgeFirewallUuidDelete**
> void EdgeFirewallUuidDelete (string uuid)

Delete an edge firewall by uuid

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefirewall.Api;
using edgefirewall.Client;
using edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallUuidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var uuid = "uuid_example";  // string | 

            try
            {
                // Delete an edge firewall by uuid
                apiInstance.EdgeFirewallUuidDelete(uuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallUuidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallUuidDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an edge firewall by uuid
    apiInstance.EdgeFirewallUuidDeleteWithHttpInfo(uuid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallUuidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **string** |  |  |

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
| **204** | Successfully deleted |  -  |
| **400** | Bad Request |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewalluuidget"></a>
# **EdgeFirewallUuidGet**
> EdgeFirewallResponse EdgeFirewallUuidGet (string uuid)

Retrieve an edge firewall set by uuid

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefirewall.Api;
using edgefirewall.Client;
using edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallUuidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var uuid = "uuid_example";  // string | 

            try
            {
                // Retrieve an edge firewall set by uuid
                EdgeFirewallResponse result = apiInstance.EdgeFirewallUuidGet(uuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallUuidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallUuidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an edge firewall set by uuid
    ApiResponse<EdgeFirewallResponse> response = apiInstance.EdgeFirewallUuidGetWithHttpInfo(uuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallUuidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **string** |  |  |

### Return type

[**EdgeFirewallResponse**](EdgeFirewallResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An edge firewall object |  -  |
| **400** | Bad Request |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewalluuidpatch"></a>
# **EdgeFirewallUuidPatch**
> EdgeFirewallResponse EdgeFirewallUuidPatch (string uuid, UpdateEdgeFirewallRequest updateEdgeFirewallRequest)

Update some edge firewall attributes, like \"active\"

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefirewall.Api;
using edgefirewall.Client;
using edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallUuidPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var uuid = "uuid_example";  // string | 
            var updateEdgeFirewallRequest = new UpdateEdgeFirewallRequest(); // UpdateEdgeFirewallRequest | 

            try
            {
                // Update some edge firewall attributes, like \"active\"
                EdgeFirewallResponse result = apiInstance.EdgeFirewallUuidPatch(uuid, updateEdgeFirewallRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallUuidPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallUuidPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update some edge firewall attributes, like \"active\"
    ApiResponse<EdgeFirewallResponse> response = apiInstance.EdgeFirewallUuidPatchWithHttpInfo(uuid, updateEdgeFirewallRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallUuidPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **string** |  |  |
| **updateEdgeFirewallRequest** | [**UpdateEdgeFirewallRequest**](UpdateEdgeFirewallRequest.md) |  |  |

### Return type

[**EdgeFirewallResponse**](EdgeFirewallResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully updated |  -  |
| **400** | Bad Request |  -  |
| **404** | Not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgefirewalluuidput"></a>
# **EdgeFirewallUuidPut**
> EdgeFirewallResponse EdgeFirewallUuidPut (string uuid, UpdateEdgeFirewallRequest updateEdgeFirewallRequest)

Overwrite some edge firewall attributes, like \"active\"

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgefirewall.Api;
using edgefirewall.Client;
using edgefirewall.Model;

namespace Example
{
    public class EdgeFirewallUuidPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi(config);
            var uuid = "uuid_example";  // string | 
            var updateEdgeFirewallRequest = new UpdateEdgeFirewallRequest(); // UpdateEdgeFirewallRequest | 

            try
            {
                // Overwrite some edge firewall attributes, like \"active\"
                EdgeFirewallResponse result = apiInstance.EdgeFirewallUuidPut(uuid, updateEdgeFirewallRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.EdgeFirewallUuidPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeFirewallUuidPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Overwrite some edge firewall attributes, like \"active\"
    ApiResponse<EdgeFirewallResponse> response = apiInstance.EdgeFirewallUuidPutWithHttpInfo(uuid, updateEdgeFirewallRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.EdgeFirewallUuidPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **string** |  |  |
| **updateEdgeFirewallRequest** | [**UpdateEdgeFirewallRequest**](UpdateEdgeFirewallRequest.md) |  |  |

### Return type

[**EdgeFirewallResponse**](EdgeFirewallResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully updated |  -  |
| **400** | Bad Request |  -  |
| **404** | Not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

