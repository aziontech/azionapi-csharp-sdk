# edgeapplications.Api.EdgeApplicationsRulesEngineApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesGet**](EdgeApplicationsRulesEngineApi.md#edgeapplicationsedgeapplicationidrulesenginephaserulesget) | **GET** /edge_applications/{edge_application_id}/rules_engine/{phase}/rules | /edge_applications/{edge_application_id}/rules_engine/{phase}/rules |
| [**EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesPost**](EdgeApplicationsRulesEngineApi.md#edgeapplicationsedgeapplicationidrulesenginephaserulespost) | **POST** /edge_applications/{edge_application_id}/rules_engine/{phase}/rules | /edge_applications/{edge_application_id}/rules_engine/{phase}/rules |
| [**EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdDelete**](EdgeApplicationsRulesEngineApi.md#edgeapplicationsedgeapplicationidrulesenginephaserulesruleiddelete) | **DELETE** /edge_applications/{edge_application_id}/rules_engine/{phase}/rules/{rule_id} | /edge_applications/{edge_application_id}/rules_engine/{phase}/rules |
| [**EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdGet**](EdgeApplicationsRulesEngineApi.md#edgeapplicationsedgeapplicationidrulesenginephaserulesruleidget) | **GET** /edge_applications/{edge_application_id}/rules_engine/{phase}/rules/{rule_id} | /edge_applications/{edge_application_id}/rules_engine/{phase}/rules |
| [**EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdPatch**](EdgeApplicationsRulesEngineApi.md#edgeapplicationsedgeapplicationidrulesenginephaserulesruleidpatch) | **PATCH** /edge_applications/{edge_application_id}/rules_engine/{phase}/rules/{rule_id} | /edge_applications/:edge_application_id:/rules_engine/:phase:/rules/:rule_id: |
| [**EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdPut**](EdgeApplicationsRulesEngineApi.md#edgeapplicationsedgeapplicationidrulesenginephaserulesruleidput) | **PUT** /edge_applications/{edge_application_id}/rules_engine/{phase}/rules/{rule_id} | /edge_applications/:edge_application_id:/rules_engine/:phase:/rules/:rule_id: |

<a id="edgeapplicationsedgeapplicationidrulesenginephaserulesget"></a>
# **EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesGet**
> RulesEngineResponse EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesGet (long edgeApplicationId, string phase, long? page = null, long? pageSize = null, string? filter = null, string? orderBy = null, string? sort = null, string? accept = null)

/edge_applications/{edge_application_id}/rules_engine/{phase}/rules

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsRulesEngineApi(config);
            var edgeApplicationId = 789L;  // long | 
            var phase = "phase_example";  // string | 
            var page = 789L;  // long? |  (optional) 
            var pageSize = 789L;  // long? |  (optional) 
            var filter = "filter_example";  // string? |  (optional) 
            var orderBy = "orderBy_example";  // string? |  (optional) 
            var sort = "sort_example";  // string? |  (optional) 
            var accept = application/json; version=3;  // string? |  (optional) 

            try
            {
                // /edge_applications/{edge_application_id}/rules_engine/{phase}/rules
                RulesEngineResponse result = apiInstance.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesGet(edgeApplicationId, phase, page, pageSize, filter, orderBy, sort, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsRulesEngineApi.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/{edge_application_id}/rules_engine/{phase}/rules
    ApiResponse<RulesEngineResponse> response = apiInstance.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesGetWithHttpInfo(edgeApplicationId, phase, page, pageSize, filter, orderBy, sort, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsRulesEngineApi.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** |  |  |
| **phase** | **string** |  |  |
| **page** | **long?** |  | [optional]  |
| **pageSize** | **long?** |  | [optional]  |
| **filter** | **string?** |  | [optional]  |
| **orderBy** | **string?** |  | [optional]  |
| **sort** | **string?** |  | [optional]  |
| **accept** | **string?** |  | [optional]  |

### Return type

[**RulesEngineResponse**](RulesEngineResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgeapplicationsedgeapplicationidrulesenginephaserulespost"></a>
# **EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesPost**
> RulesEngineIdResponse EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesPost (long edgeApplicationId, string phase, string? accept = null, string? contentType = null, CreateRulesEngineRequest? createRulesEngineRequest = null)

/edge_applications/{edge_application_id}/rules_engine/{phase}/rules

Check below the list of behaviors that can be applied:  | Name                                | Behavior               | | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | - -- -- -- -- -- -- -- -- -- -- - | | Add Request Cookie                  | add_request_cookie     | | Add Request Header                  | add_request_header     | | Add Response Cookie                 | set_cookie             | | Add Response Header                 | add_response_header    | | Bypass Cache                        | bypass_cache_phase     | | Capture Match Groups                | capture_match_groups   | | Deliver                             | deliver                | | Deny (403 Forbidden)                | deny                   | | Enable Gzip                         | enable_gzip            | | Filter Request Cookie               | filter_request_cookie  | | Filter Request Header               | filter_request_header  | | Filter Response Cookie              | filter_response_cookie | | Filter Response Header              | filter_response_header | | Finish Request Phase                | finish_request_phase   | | Forward Cookies                     | forward_cookies        | | Optimize Images                     | optimize_images        | | Redirect HTTP to HTTPS              | redirect_http_to_https | | Redirect To (301 Moved Permanently) | redirect_to_301        | | Redirect To (302 Found)             | redirect_to_302        | | Rewrite Request                     | rewrite_request        | | Run Function                        | run_function           | | Set Cache Policy                    | set_cache_policy       | | Set Origin                          | set_origin             |

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsRulesEngineApi(config);
            var edgeApplicationId = 789L;  // long | 
            var phase = "phase_example";  // string | 
            var accept = application/json; version=3;  // string? |  (optional) 
            var contentType = application/json;  // string? | The type of coding used in the Body (application/json). <br>  Example: Content-Type: application/json (optional) 
            var createRulesEngineRequest = new CreateRulesEngineRequest?(); // CreateRulesEngineRequest? |  (optional) 

            try
            {
                // /edge_applications/{edge_application_id}/rules_engine/{phase}/rules
                RulesEngineIdResponse result = apiInstance.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesPost(edgeApplicationId, phase, accept, contentType, createRulesEngineRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsRulesEngineApi.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/{edge_application_id}/rules_engine/{phase}/rules
    ApiResponse<RulesEngineIdResponse> response = apiInstance.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesPostWithHttpInfo(edgeApplicationId, phase, accept, contentType, createRulesEngineRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsRulesEngineApi.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** |  |  |
| **phase** | **string** |  |  |
| **accept** | **string?** |  | [optional]  |
| **contentType** | **string?** | The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json | [optional]  |
| **createRulesEngineRequest** | [**CreateRulesEngineRequest?**](CreateRulesEngineRequest?.md) |  | [optional]  |

### Return type

[**RulesEngineIdResponse**](RulesEngineIdResponse.md)

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
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgeapplicationsedgeapplicationidrulesenginephaserulesruleiddelete"></a>
# **EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdDelete**
> void EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdDelete (long edgeApplicationId, string phase, long ruleId, string? accept = null)

/edge_applications/{edge_application_id}/rules_engine/{phase}/rules

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsRulesEngineApi(config);
            var edgeApplicationId = 789L;  // long | The id of the edge application you plan to delete. 
            var phase = "phase_example";  // string | 
            var ruleId = 789L;  // long | The id of the rule you plan to delete. 
            var accept = application/json; version=3;  // string? |  (optional) 

            try
            {
                // /edge_applications/{edge_application_id}/rules_engine/{phase}/rules
                apiInstance.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdDelete(edgeApplicationId, phase, ruleId, accept);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsRulesEngineApi.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/{edge_application_id}/rules_engine/{phase}/rules
    apiInstance.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdDeleteWithHttpInfo(edgeApplicationId, phase, ruleId, accept);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsRulesEngineApi.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** | The id of the edge application you plan to delete.  |  |
| **phase** | **string** |  |  |
| **ruleId** | **long** | The id of the rule you plan to delete.  |  |
| **accept** | **string?** |  | [optional]  |

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
| **204** | No response |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgeapplicationsedgeapplicationidrulesenginephaserulesruleidget"></a>
# **EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdGet**
> RulesEngineIdResponse EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdGet (long edgeApplicationId, string phase, long ruleId, string? accept = null)

/edge_applications/{edge_application_id}/rules_engine/{phase}/rules

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsRulesEngineApi(config);
            var edgeApplicationId = 789L;  // long | The id of the edge application you want to get. 
            var phase = "phase_example";  // string | 
            var ruleId = 789L;  // long | The id of the rule you plan to delete. 
            var accept = application/json; version=3;  // string? |  (optional) 

            try
            {
                // /edge_applications/{edge_application_id}/rules_engine/{phase}/rules
                RulesEngineIdResponse result = apiInstance.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdGet(edgeApplicationId, phase, ruleId, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsRulesEngineApi.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/{edge_application_id}/rules_engine/{phase}/rules
    ApiResponse<RulesEngineIdResponse> response = apiInstance.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdGetWithHttpInfo(edgeApplicationId, phase, ruleId, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsRulesEngineApi.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** | The id of the edge application you want to get.  |  |
| **phase** | **string** |  |  |
| **ruleId** | **long** | The id of the rule you plan to delete.  |  |
| **accept** | **string?** |  | [optional]  |

### Return type

[**RulesEngineIdResponse**](RulesEngineIdResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgeapplicationsedgeapplicationidrulesenginephaserulesruleidpatch"></a>
# **EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdPatch**
> RulesEngineIdResponse EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdPatch (long edgeApplicationId, string phase, long ruleId, string? accept = null, string? contentType = null, PatchRulesEngineRequest? patchRulesEngineRequest = null)

/edge_applications/:edge_application_id:/rules_engine/:phase:/rules/:rule_id:

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsRulesEngineApi(config);
            var edgeApplicationId = 789L;  // long | 
            var phase = "phase_example";  // string | 
            var ruleId = 789L;  // long | 
            var accept = application/json; version=3;  // string? |  (optional) 
            var contentType = application/json;  // string? | The type of coding used in the Body (application/json). <br>  Example: Content-Type: application/json (optional) 
            var patchRulesEngineRequest = new PatchRulesEngineRequest?(); // PatchRulesEngineRequest? |  (optional) 

            try
            {
                // /edge_applications/:edge_application_id:/rules_engine/:phase:/rules/:rule_id:
                RulesEngineIdResponse result = apiInstance.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdPatch(edgeApplicationId, phase, ruleId, accept, contentType, patchRulesEngineRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsRulesEngineApi.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/:edge_application_id:/rules_engine/:phase:/rules/:rule_id:
    ApiResponse<RulesEngineIdResponse> response = apiInstance.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdPatchWithHttpInfo(edgeApplicationId, phase, ruleId, accept, contentType, patchRulesEngineRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsRulesEngineApi.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** |  |  |
| **phase** | **string** |  |  |
| **ruleId** | **long** |  |  |
| **accept** | **string?** |  | [optional]  |
| **contentType** | **string?** | The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json | [optional]  |
| **patchRulesEngineRequest** | [**PatchRulesEngineRequest?**](PatchRulesEngineRequest?.md) |  | [optional]  |

### Return type

[**RulesEngineIdResponse**](RulesEngineIdResponse.md)

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
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="edgeapplicationsedgeapplicationidrulesenginephaserulesruleidput"></a>
# **EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdPut**
> RulesEngineIdResponse EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdPut (long edgeApplicationId, string phase, long ruleId, string? accept = null, string? contentType = null, UpdateRulesEngineRequest? updateRulesEngineRequest = null)

/edge_applications/:edge_application_id:/rules_engine/:phase:/rules/:rule_id:

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsRulesEngineApi(config);
            var edgeApplicationId = 789L;  // long | 
            var phase = "phase_example";  // string | 
            var ruleId = 789L;  // long | 
            var accept = application/json; version=3;  // string? |  (optional) 
            var contentType = application/json;  // string? | The type of coding used in the Body (application/json). <br>  Example: Content-Type: application/json (optional) 
            var updateRulesEngineRequest = new UpdateRulesEngineRequest?(); // UpdateRulesEngineRequest? |  (optional) 

            try
            {
                // /edge_applications/:edge_application_id:/rules_engine/:phase:/rules/:rule_id:
                RulesEngineIdResponse result = apiInstance.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdPut(edgeApplicationId, phase, ruleId, accept, contentType, updateRulesEngineRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsRulesEngineApi.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/:edge_application_id:/rules_engine/:phase:/rules/:rule_id:
    ApiResponse<RulesEngineIdResponse> response = apiInstance.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdPutWithHttpInfo(edgeApplicationId, phase, ruleId, accept, contentType, updateRulesEngineRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsRulesEngineApi.EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** |  |  |
| **phase** | **string** |  |  |
| **ruleId** | **long** |  |  |
| **accept** | **string?** |  | [optional]  |
| **contentType** | **string?** | The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json | [optional]  |
| **updateRulesEngineRequest** | [**UpdateRulesEngineRequest?**](UpdateRulesEngineRequest?.md) |  | [optional]  |

### Return type

[**RulesEngineIdResponse**](RulesEngineIdResponse.md)

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
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

