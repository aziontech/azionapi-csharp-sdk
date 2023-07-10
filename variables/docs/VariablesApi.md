# variables.Api.VariablesApi

All URIs are relative to *https://stage-api.azion.net/variables*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiVariablesCreate**](VariablesApi.md#apivariablescreate) | **POST** /variables | /variables |
| [**ApiVariablesDestroy**](VariablesApi.md#apivariablesdestroy) | **DELETE** /variables/{uuid} | /variables/:uuid |
| [**ApiVariablesList**](VariablesApi.md#apivariableslist) | **GET** /variables | /variables |
| [**ApiVariablesRetrieve**](VariablesApi.md#apivariablesretrieve) | **GET** /variables/{uuid} | /variables/:uuid |
| [**ApiVariablesUpdate**](VariablesApi.md#apivariablesupdate) | **PUT** /variables/{uuid} | /variables/:uuid |

<a id="apivariablescreate"></a>
# **ApiVariablesCreate**
> VariableGet ApiVariablesCreate (VariableCreate variableCreate)

/variables

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
            config.BasePath = "https://stage-api.azion.net/variables";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VariablesApi(config);
            var variableCreate = new VariableCreate(); // VariableCreate | 

            try
            {
                // /variables
                VariableGet result = apiInstance.ApiVariablesCreate(variableCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariablesApi.ApiVariablesCreate: " + e.Message);
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
    // /variables
    ApiResponse<VariableGet> response = apiInstance.ApiVariablesCreateWithHttpInfo(variableCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VariablesApi.ApiVariablesCreateWithHttpInfo: " + e.Message);
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

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apivariablesdestroy"></a>
# **ApiVariablesDestroy**
> void ApiVariablesDestroy (string uuid)

/variables/:uuid

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
            config.BasePath = "https://stage-api.azion.net/variables";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VariablesApi(config);
            var uuid = "uuid_example";  // string | 

            try
            {
                // /variables/:uuid
                apiInstance.ApiVariablesDestroy(uuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariablesApi.ApiVariablesDestroy: " + e.Message);
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
    // /variables/:uuid
    apiInstance.ApiVariablesDestroyWithHttpInfo(uuid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VariablesApi.ApiVariablesDestroyWithHttpInfo: " + e.Message);
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
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apivariableslist"></a>
# **ApiVariablesList**
> List&lt;Variable&gt; ApiVariablesList ()

/variables

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
            config.BasePath = "https://stage-api.azion.net/variables";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VariablesApi(config);

            try
            {
                // /variables
                List<Variable> result = apiInstance.ApiVariablesList();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariablesApi.ApiVariablesList: " + e.Message);
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
    // /variables
    ApiResponse<List<Variable>> response = apiInstance.ApiVariablesListWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VariablesApi.ApiVariablesListWithHttpInfo: " + e.Message);
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
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apivariablesretrieve"></a>
# **ApiVariablesRetrieve**
> Variable ApiVariablesRetrieve (string uuid)

/variables/:uuid

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
            config.BasePath = "https://stage-api.azion.net/variables";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VariablesApi(config);
            var uuid = "uuid_example";  // string | 

            try
            {
                // /variables/:uuid
                Variable result = apiInstance.ApiVariablesRetrieve(uuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariablesApi.ApiVariablesRetrieve: " + e.Message);
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
    // /variables/:uuid
    ApiResponse<Variable> response = apiInstance.ApiVariablesRetrieveWithHttpInfo(uuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VariablesApi.ApiVariablesRetrieveWithHttpInfo: " + e.Message);
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
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apivariablesupdate"></a>
# **ApiVariablesUpdate**
> VariableGet ApiVariablesUpdate (string uuid, VariableCreate variableCreate)

/variables/:uuid

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
            config.BasePath = "https://stage-api.azion.net/variables";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VariablesApi(config);
            var uuid = "uuid_example";  // string | 
            var variableCreate = new VariableCreate(); // VariableCreate | 

            try
            {
                // /variables/:uuid
                VariableGet result = apiInstance.ApiVariablesUpdate(uuid, variableCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VariablesApi.ApiVariablesUpdate: " + e.Message);
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
    // /variables/:uuid
    ApiResponse<VariableGet> response = apiInstance.ApiVariablesUpdateWithHttpInfo(uuid, variableCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VariablesApi.ApiVariablesUpdateWithHttpInfo: " + e.Message);
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
| **200** |  |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

