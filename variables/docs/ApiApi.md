# variables.Api.ApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiSchemaRetrieve**](ApiApi.md#apischemaretrieve) | **GET** /api/schema |  |
| [**ApiVariablesCreate**](ApiApi.md#apivariablescreate) | **POST** /api/variables |  |
| [**ApiVariablesDestroy**](ApiApi.md#apivariablesdestroy) | **DELETE** /api/variables/{uuid} |  |
| [**ApiVariablesList**](ApiApi.md#apivariableslist) | **GET** /api/variables |  |
| [**ApiVariablesRetrieve**](ApiApi.md#apivariablesretrieve) | **GET** /api/variables/{uuid} |  |
| [**ApiVariablesUpdate**](ApiApi.md#apivariablesupdate) | **PUT** /api/variables/{uuid} |  |

<a id="apischemaretrieve"></a>
# **ApiSchemaRetrieve**
> Dictionary&lt;string, Object&gt; ApiSchemaRetrieve (string format = null, string lang = null)



OpenApi3 schema for this API. Format can be selected via content negotiation.  - YAML: application/vnd.oai.openapi - JSON: application/vnd.oai.openapi+json

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using variables.Api;
using variables.Client;
using variables.Model;

namespace Example
{
    public class ApiSchemaRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApiApi(config);
            var format = "json";  // string |  (optional) 
            var lang = "af";  // string |  (optional) 

            try
            {
                Dictionary<string, Object> result = apiInstance.ApiSchemaRetrieve(format, lang);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiApi.ApiSchemaRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSchemaRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Dictionary<string, Object>> response = apiInstance.ApiSchemaRetrieveWithHttpInfo(format, lang);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApiApi.ApiSchemaRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | **string** |  | [optional]  |
| **lang** | **string** |  | [optional]  |

### Return type

**Dictionary<string, Object>**

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.oai.openapi, application/yaml, application/vnd.oai.openapi+json, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apivariablescreate"></a>
# **ApiVariablesCreate**
> VariableGet ApiVariablesCreate (VariableCreate variableCreate)



Create a new Variable. <br><ul><li>If the attribute \"secret\" is informed with value \"true\" in request payload the Variable value will be secret and no longer viewable after creation.</li><li>If the attribute \"secret\" is not informed the Variable value will be considered as not secret by default.</li></ul>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using variables.Api;
using variables.Client;
using variables.Model;

namespace Example
{
    public class ApiVariablesCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApiApi(config);
            var variableCreate = new VariableCreate(); // VariableCreate | 

            try
            {
                VariableGet result = apiInstance.ApiVariablesCreate(variableCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiApi.ApiVariablesCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiVariablesCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VariableGet> response = apiInstance.ApiVariablesCreateWithHttpInfo(variableCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApiApi.ApiVariablesCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **variableCreate** | [**VariableCreate**](VariableCreate.md) |  |  |

### Return type

[**VariableGet**](VariableGet.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apivariablesdestroy"></a>
# **ApiVariablesDestroy**
> void ApiVariablesDestroy (string uuid)



Delete a Variable by it's UUID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using variables.Api;
using variables.Client;
using variables.Model;

namespace Example
{
    public class ApiVariablesDestroyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApiApi(config);
            var uuid = "uuid_example";  // string | 

            try
            {
                apiInstance.ApiVariablesDestroy(uuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiApi.ApiVariablesDestroy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiVariablesDestroyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiVariablesDestroyWithHttpInfo(uuid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApiApi.ApiVariablesDestroyWithHttpInfo: " + e.Message);
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
| **204** | No response body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apivariableslist"></a>
# **ApiVariablesList**
> List&lt;Variable&gt; ApiVariablesList ()



List all user's Variables.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using variables.Api;
using variables.Client;
using variables.Model;

namespace Example
{
    public class ApiVariablesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApiApi(config);

            try
            {
                List<Variable> result = apiInstance.ApiVariablesList();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiApi.ApiVariablesList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiVariablesListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Variable>> response = apiInstance.ApiVariablesListWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApiApi.ApiVariablesListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Variable&gt;**](Variable.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apivariablesretrieve"></a>
# **ApiVariablesRetrieve**
> Variable ApiVariablesRetrieve (string uuid)



Retrieve all data for a Variable by it's UUID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using variables.Api;
using variables.Client;
using variables.Model;

namespace Example
{
    public class ApiVariablesRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApiApi(config);
            var uuid = "uuid_example";  // string | 

            try
            {
                Variable result = apiInstance.ApiVariablesRetrieve(uuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiApi.ApiVariablesRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiVariablesRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Variable> response = apiInstance.ApiVariablesRetrieveWithHttpInfo(uuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApiApi.ApiVariablesRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **string** |  |  |

### Return type

[**Variable**](Variable.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apivariablesupdate"></a>
# **ApiVariablesUpdate**
> VariableGet ApiVariablesUpdate (string uuid, VariableCreate variableCreate)



Update variable attributes by it's UUID. Keep the Variable UUID but overwrite all editable attributes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using variables.Api;
using variables.Client;
using variables.Model;

namespace Example
{
    public class ApiVariablesUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApiApi(config);
            var uuid = "uuid_example";  // string | 
            var variableCreate = new VariableCreate(); // VariableCreate | 

            try
            {
                VariableGet result = apiInstance.ApiVariablesUpdate(uuid, variableCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiApi.ApiVariablesUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiVariablesUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VariableGet> response = apiInstance.ApiVariablesUpdateWithHttpInfo(uuid, variableCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApiApi.ApiVariablesUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **string** |  |  |
| **variableCreate** | [**VariableCreate**](VariableCreate.md) |  |  |

### Return type

[**VariableGet**](VariableGet.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

