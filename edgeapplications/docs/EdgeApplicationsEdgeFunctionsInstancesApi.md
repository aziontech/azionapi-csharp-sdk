# edgeapplications.Api.EdgeApplicationsEdgeFunctionsInstancesApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDelete**](EdgeApplicationsEdgeFunctionsInstancesApi.md#edgeapplicationsedgeapplicationidfunctionsinstancesfunctionsinstancesiddelete) | **DELETE** /edge_applications/{edge_application_id}/functions_instances/{functions_instances_id} | /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id: |
| [**EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGet**](EdgeApplicationsEdgeFunctionsInstancesApi.md#edgeapplicationsedgeapplicationidfunctionsinstancesfunctionsinstancesidget) | **GET** /edge_applications/{edge_application_id}/functions_instances/{functions_instances_id} | /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id: |
| [**EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatch**](EdgeApplicationsEdgeFunctionsInstancesApi.md#edgeapplicationsedgeapplicationidfunctionsinstancesfunctionsinstancesidpatch) | **PATCH** /edge_applications/{edge_application_id}/functions_instances/{functions_instances_id} | /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id: |
| [**EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPut**](EdgeApplicationsEdgeFunctionsInstancesApi.md#edgeapplicationsedgeapplicationidfunctionsinstancesfunctionsinstancesidput) | **PUT** /edge_applications/{edge_application_id}/functions_instances/{functions_instances_id} | /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id: |
| [**EdgeApplicationsEdgeApplicationIdFunctionsInstancesGet**](EdgeApplicationsEdgeFunctionsInstancesApi.md#edgeapplicationsedgeapplicationidfunctionsinstancesget) | **GET** /edge_applications/{edge_application_id}/functions_instances | /edge_applications/:edge_application_id:/functions_instances |
| [**EdgeApplicationsEdgeApplicationIdFunctionsInstancesPost**](EdgeApplicationsEdgeFunctionsInstancesApi.md#edgeapplicationsedgeapplicationidfunctionsinstancespost) | **POST** /edge_applications/{edge_application_id}/functions_instances | edge_application/:edge_application_id:/functions_instances |

<a id="edgeapplicationsedgeapplicationidfunctionsinstancesfunctionsinstancesiddelete"></a>
# **EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDelete**
> void EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDelete (string edgeApplicationId, string functionsInstancesId, string accept = null, string contentType = null)

/edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsEdgeFunctionsInstancesApi(config);
            var edgeApplicationId = "edgeApplicationId_example";  // string | 
            var functionsInstancesId = "functionsInstancesId_example";  // string | 
            var accept = application/json; version=3;  // string |  (optional) 
            var contentType = application/json;  // string | The type of coding used in the Body (application/json). <br>  Example: Content-Type: application/json (optional) 

            try
            {
                // /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
                apiInstance.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDelete(edgeApplicationId, functionsInstancesId, accept, contentType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
    apiInstance.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDeleteWithHttpInfo(edgeApplicationId, functionsInstancesId, accept, contentType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **string** |  |  |
| **functionsInstancesId** | **string** |  |  |
| **accept** | **string** |  | [optional]  |
| **contentType** | **string** | The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json | [optional]  |

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT)

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

<a id="edgeapplicationsedgeapplicationidfunctionsinstancesfunctionsinstancesidget"></a>
# **EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGet**
> ApplicationInstancesGetOneResponse EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGet (long edgeApplicationId, long functionsInstancesId, string accept = null)

/edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsEdgeFunctionsInstancesApi(config);
            var edgeApplicationId = 789L;  // long | 
            var functionsInstancesId = 789L;  // long | 
            var accept = application/json; version=3;  // string | The id of the edge function instance you plan to query.  (optional) 

            try
            {
                // /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
                ApplicationInstancesGetOneResponse result = apiInstance.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGet(edgeApplicationId, functionsInstancesId, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
    ApiResponse<ApplicationInstancesGetOneResponse> response = apiInstance.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGetWithHttpInfo(edgeApplicationId, functionsInstancesId, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** |  |  |
| **functionsInstancesId** | **long** |  |  |
| **accept** | **string** | The id of the edge function instance you plan to query.  | [optional]  |

### Return type

[**ApplicationInstancesGetOneResponse**](ApplicationInstancesGetOneResponse.md)

### Authorization

[JWT](../README.md#JWT)

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

<a id="edgeapplicationsedgeapplicationidfunctionsinstancesfunctionsinstancesidpatch"></a>
# **EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatch**
> ApplicationInstanceResults EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatch (string edgeApplicationId, string functionsInstancesId, string accept = null, string contentType = null, ApplicationUpdateInstanceRequest applicationUpdateInstanceRequest = null)

/edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsEdgeFunctionsInstancesApi(config);
            var edgeApplicationId = "edgeApplicationId_example";  // string | The id of the edge application you plan to overwrite 
            var functionsInstancesId = "functionsInstancesId_example";  // string | The id of the edge function instance you plan to overwrite.
            var accept = application/json; version=3;  // string |  (optional) 
            var contentType = application/json;  // string | The type of coding used in the Body (application/json). <br>  Example: Content-Type: application/json (optional) 
            var applicationUpdateInstanceRequest = new ApplicationUpdateInstanceRequest(); // ApplicationUpdateInstanceRequest |  (optional) 

            try
            {
                // /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
                ApplicationInstanceResults result = apiInstance.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatch(edgeApplicationId, functionsInstancesId, accept, contentType, applicationUpdateInstanceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
    ApiResponse<ApplicationInstanceResults> response = apiInstance.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatchWithHttpInfo(edgeApplicationId, functionsInstancesId, accept, contentType, applicationUpdateInstanceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **string** | The id of the edge application you plan to overwrite  |  |
| **functionsInstancesId** | **string** | The id of the edge function instance you plan to overwrite. |  |
| **accept** | **string** |  | [optional]  |
| **contentType** | **string** | The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json | [optional]  |
| **applicationUpdateInstanceRequest** | [**ApplicationUpdateInstanceRequest**](ApplicationUpdateInstanceRequest.md) |  | [optional]  |

### Return type

[**ApplicationInstanceResults**](ApplicationInstanceResults.md)

### Authorization

[JWT](../README.md#JWT)

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

<a id="edgeapplicationsedgeapplicationidfunctionsinstancesfunctionsinstancesidput"></a>
# **EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPut**
> ApplicationInstanceResults EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPut (string edgeApplicationId, string functionsInstancesId, string accept = null, string contentType = null, ApplicationPutInstanceRequest applicationPutInstanceRequest = null)

/edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsEdgeFunctionsInstancesApi(config);
            var edgeApplicationId = "edgeApplicationId_example";  // string | The id of the edge application you plan to overwrite 
            var functionsInstancesId = "functionsInstancesId_example";  // string | The id of the edge function instance you plan to overwrite.
            var accept = application/json; version=3;  // string |  (optional) 
            var contentType = application/json;  // string | The type of coding used in the Body (application/json). <br>  Example: Content-Type: application/json (optional) 
            var applicationPutInstanceRequest = new ApplicationPutInstanceRequest(); // ApplicationPutInstanceRequest |  (optional) 

            try
            {
                // /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
                ApplicationInstanceResults result = apiInstance.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPut(edgeApplicationId, functionsInstancesId, accept, contentType, applicationPutInstanceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
    ApiResponse<ApplicationInstanceResults> response = apiInstance.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPutWithHttpInfo(edgeApplicationId, functionsInstancesId, accept, contentType, applicationPutInstanceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **string** | The id of the edge application you plan to overwrite  |  |
| **functionsInstancesId** | **string** | The id of the edge function instance you plan to overwrite. |  |
| **accept** | **string** |  | [optional]  |
| **contentType** | **string** | The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json | [optional]  |
| **applicationPutInstanceRequest** | [**ApplicationPutInstanceRequest**](ApplicationPutInstanceRequest.md) |  | [optional]  |

### Return type

[**ApplicationInstanceResults**](ApplicationInstanceResults.md)

### Authorization

[JWT](../README.md#JWT)

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

<a id="edgeapplicationsedgeapplicationidfunctionsinstancesget"></a>
# **EdgeApplicationsEdgeApplicationIdFunctionsInstancesGet**
> ApplicationInstancesGetResponse EdgeApplicationsEdgeApplicationIdFunctionsInstancesGet (long edgeApplicationId, long? page = null, long? pageSize = null, string filter = null, string orderBy = null, string sort = null, string accept = null)

/edge_applications/:edge_application_id:/functions_instances

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdFunctionsInstancesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsEdgeFunctionsInstancesApi(config);
            var edgeApplicationId = 789L;  // long | 
            var page = 789L;  // long? |  (optional) 
            var pageSize = 789L;  // long? |  (optional) 
            var filter = "filter_example";  // string |  (optional) 
            var orderBy = "orderBy_example";  // string |  (optional) 
            var sort = "sort_example";  // string |  (optional) 
            var accept = application/json; version=3;  // string |  (optional) 

            try
            {
                // /edge_applications/:edge_application_id:/functions_instances
                ApplicationInstancesGetResponse result = apiInstance.EdgeApplicationsEdgeApplicationIdFunctionsInstancesGet(edgeApplicationId, page, pageSize, filter, orderBy, sort, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdFunctionsInstancesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // /edge_applications/:edge_application_id:/functions_instances
    ApiResponse<ApplicationInstancesGetResponse> response = apiInstance.EdgeApplicationsEdgeApplicationIdFunctionsInstancesGetWithHttpInfo(edgeApplicationId, page, pageSize, filter, orderBy, sort, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** |  |  |
| **page** | **long?** |  | [optional]  |
| **pageSize** | **long?** |  | [optional]  |
| **filter** | **string** |  | [optional]  |
| **orderBy** | **string** |  | [optional]  |
| **sort** | **string** |  | [optional]  |
| **accept** | **string** |  | [optional]  |

### Return type

[**ApplicationInstancesGetResponse**](ApplicationInstancesGetResponse.md)

### Authorization

[JWT](../README.md#JWT)

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

<a id="edgeapplicationsedgeapplicationidfunctionsinstancespost"></a>
# **EdgeApplicationsEdgeApplicationIdFunctionsInstancesPost**
> ApplicationInstanceResults EdgeApplicationsEdgeApplicationIdFunctionsInstancesPost (long edgeApplicationId, string accept = null, string contentType = null, ApplicationCreateInstanceRequest applicationCreateInstanceRequest = null)

edge_application/:edge_application_id:/functions_instances

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class EdgeApplicationsEdgeApplicationIdFunctionsInstancesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsEdgeFunctionsInstancesApi(config);
            var edgeApplicationId = 789L;  // long | 
            var accept = application/json; version=3;  // string |  (optional) 
            var contentType = application/json;  // string | The type of coding used in the Body (application/json). <br>  Example: Content-Type: application/json (optional) 
            var applicationCreateInstanceRequest = new ApplicationCreateInstanceRequest(); // ApplicationCreateInstanceRequest |  (optional) 

            try
            {
                // edge_application/:edge_application_id:/functions_instances
                ApplicationInstanceResults result = apiInstance.EdgeApplicationsEdgeApplicationIdFunctionsInstancesPost(edgeApplicationId, accept, contentType, applicationCreateInstanceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdgeApplicationsEdgeApplicationIdFunctionsInstancesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // edge_application/:edge_application_id:/functions_instances
    ApiResponse<ApplicationInstanceResults> response = apiInstance.EdgeApplicationsEdgeApplicationIdFunctionsInstancesPostWithHttpInfo(edgeApplicationId, accept, contentType, applicationCreateInstanceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edgeApplicationId** | **long** |  |  |
| **accept** | **string** |  | [optional]  |
| **contentType** | **string** | The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json | [optional]  |
| **applicationCreateInstanceRequest** | [**ApplicationCreateInstanceRequest**](ApplicationCreateInstanceRequest.md) |  | [optional]  |

### Return type

[**ApplicationInstanceResults**](ApplicationInstanceResults.md)

### Authorization

[JWT](../README.md#JWT)

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

