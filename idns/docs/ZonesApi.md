# idns.Api.ZonesApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteZone**](ZonesApi.md#deletezone) | **DELETE** /intelligent_dns/{zone_id} | Remove an Intelligent DNS hosted zone |
| [**GetZone**](ZonesApi.md#getzone) | **GET** /intelligent_dns/{zone_id} | Get an Intelligent DNS hosted zone |
| [**GetZones**](ZonesApi.md#getzones) | **GET** /intelligent_dns | Get a collection of Intelligent DNS zones |
| [**PostZone**](ZonesApi.md#postzone) | **POST** /intelligent_dns | Add a new Intelligent DNS zone |
| [**PutZone**](ZonesApi.md#putzone) | **PUT** /intelligent_dns/{zone_id} | Update an Intelligent DNS hosted zone |

<a id="deletezone"></a>
# **DeleteZone**
> string DeleteZone (int zoneId)

Remove an Intelligent DNS hosted zone

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using idns.Api;
using idns.Client;
using idns.Model;

namespace Example
{
    public class DeleteZoneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ZonesApi(config);
            var zoneId = 56;  // int | The hosted zone id

            try
            {
                // Remove an Intelligent DNS hosted zone
                string result = apiInstance.DeleteZone(zoneId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZonesApi.DeleteZone: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteZoneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove an Intelligent DNS hosted zone
    ApiResponse<string> response = apiInstance.DeleteZoneWithHttpInfo(zoneId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ZonesApi.DeleteZoneWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zoneId** | **int** | The hosted zone id |  |

### Return type

**string**

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Zone removed |  -  |
| **404** | Zone not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getzone"></a>
# **GetZone**
> GetZoneResponse GetZone (int zoneId)

Get an Intelligent DNS hosted zone

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using idns.Api;
using idns.Client;
using idns.Model;

namespace Example
{
    public class GetZoneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ZonesApi(config);
            var zoneId = 56;  // int | The hosted zone id

            try
            {
                // Get an Intelligent DNS hosted zone
                GetZoneResponse result = apiInstance.GetZone(zoneId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZonesApi.GetZone: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetZoneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an Intelligent DNS hosted zone
    ApiResponse<GetZoneResponse> response = apiInstance.GetZoneWithHttpInfo(zoneId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ZonesApi.GetZoneWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zoneId** | **int** | The hosted zone id |  |

### Return type

[**GetZoneResponse**](GetZoneResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Zone retrieved |  -  |
| **404** | Zone not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getzones"></a>
# **GetZones**
> GetZonesResponse GetZones ()

Get a collection of Intelligent DNS zones

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using idns.Api;
using idns.Client;
using idns.Model;

namespace Example
{
    public class GetZonesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ZonesApi(config);

            try
            {
                // Get a collection of Intelligent DNS zones
                GetZonesResponse result = apiInstance.GetZones();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZonesApi.GetZones: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetZonesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a collection of Intelligent DNS zones
    ApiResponse<GetZonesResponse> response = apiInstance.GetZonesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ZonesApi.GetZonesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetZonesResponse**](GetZonesResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Zones collection retrieved |  -  |
| **400** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postzone"></a>
# **PostZone**
> PostOrPutZoneResponse PostZone (Zone zone = null)

Add a new Intelligent DNS zone

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using idns.Api;
using idns.Client;
using idns.Model;

namespace Example
{
    public class PostZoneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ZonesApi(config);
            var zone = new Zone(); // Zone |  (optional) 

            try
            {
                // Add a new Intelligent DNS zone
                PostOrPutZoneResponse result = apiInstance.PostZone(zone);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZonesApi.PostZone: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostZoneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a new Intelligent DNS zone
    ApiResponse<PostOrPutZoneResponse> response = apiInstance.PostZoneWithHttpInfo(zone);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ZonesApi.PostZoneWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zone** | [**Zone**](Zone.md) |  | [optional]  |

### Return type

[**PostOrPutZoneResponse**](PostOrPutZoneResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Zone added |  -  |
| **400** | Error |  -  |
| **404** | Zone not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putzone"></a>
# **PutZone**
> PostOrPutZoneResponse PutZone (int zoneId, Zone zone = null)

Update an Intelligent DNS hosted zone

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using idns.Api;
using idns.Client;
using idns.Model;

namespace Example
{
    public class PutZoneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ZonesApi(config);
            var zoneId = 56;  // int | The hosted zone id
            var zone = new Zone(); // Zone |  (optional) 

            try
            {
                // Update an Intelligent DNS hosted zone
                PostOrPutZoneResponse result = apiInstance.PutZone(zoneId, zone);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZonesApi.PutZone: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutZoneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an Intelligent DNS hosted zone
    ApiResponse<PostOrPutZoneResponse> response = apiInstance.PutZoneWithHttpInfo(zoneId, zone);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ZonesApi.PutZoneWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zoneId** | **int** | The hosted zone id |  |
| **zone** | [**Zone**](Zone.md) |  | [optional]  |

### Return type

[**PostOrPutZoneResponse**](PostOrPutZoneResponse.md)

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

