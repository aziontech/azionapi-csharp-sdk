# idns.Api.RecordsApi

All URIs are relative to *https://api.azionapi.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteZoneRecord**](RecordsApi.md#deletezonerecord) | **DELETE** /intelligent_dns/{zone_id}/records/{record_id} | Remove an Intelligent DNS zone record |
| [**GetZoneRecords**](RecordsApi.md#getzonerecords) | **GET** /intelligent_dns/{zone_id}/records | Get a collection of Intelligent DNS zone records |
| [**PostZoneRecord**](RecordsApi.md#postzonerecord) | **POST** /intelligent_dns/{zone_id}/records | Create a new Intelligent DNS zone record |
| [**PutZoneRecord**](RecordsApi.md#putzonerecord) | **PUT** /intelligent_dns/{zone_id}/records/{record_id} | Update an Intelligent DNS zone record |

<a id="deletezonerecord"></a>
# **DeleteZoneRecord**
> string DeleteZoneRecord (int zoneId, int recordId)

Remove an Intelligent DNS zone record

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using idns.Api;
using idns.Client;
using idns.Model;

namespace Example
{
    public class DeleteZoneRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RecordsApi(config);
            var zoneId = 56;  // int | The hosted zone id
            var recordId = 56;  // int | The zone record id

            try
            {
                // Remove an Intelligent DNS zone record
                string result = apiInstance.DeleteZoneRecord(zoneId, recordId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordsApi.DeleteZoneRecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteZoneRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove an Intelligent DNS zone record
    ApiResponse<string> response = apiInstance.DeleteZoneRecordWithHttpInfo(zoneId, recordId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordsApi.DeleteZoneRecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zoneId** | **int** | The hosted zone id |  |
| **recordId** | **int** | The zone record id |  |

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
| **204** | Record removed |  -  |
| **404** | Record not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getzonerecords"></a>
# **GetZoneRecords**
> GetRecordsResponse GetZoneRecords (int zoneId)

Get a collection of Intelligent DNS zone records

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using idns.Api;
using idns.Client;
using idns.Model;

namespace Example
{
    public class GetZoneRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RecordsApi(config);
            var zoneId = 56;  // int | The hosted zone id

            try
            {
                // Get a collection of Intelligent DNS zone records
                GetRecordsResponse result = apiInstance.GetZoneRecords(zoneId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordsApi.GetZoneRecords: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetZoneRecordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a collection of Intelligent DNS zone records
    ApiResponse<GetRecordsResponse> response = apiInstance.GetZoneRecordsWithHttpInfo(zoneId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordsApi.GetZoneRecordsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zoneId** | **int** | The hosted zone id |  |

### Return type

[**GetRecordsResponse**](GetRecordsResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Zones collection retrieved |  -  |
| **400** | Error |  -  |
| **404** | Zone not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postzonerecord"></a>
# **PostZoneRecord**
> PostOrPutRecordResponse PostZoneRecord (int zoneId, RecordPostOrPut? recordPostOrPut = null)

Create a new Intelligent DNS zone record

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using idns.Api;
using idns.Client;
using idns.Model;

namespace Example
{
    public class PostZoneRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RecordsApi(config);
            var zoneId = 56;  // int | The hosted zone id
            var recordPostOrPut = new RecordPostOrPut?(); // RecordPostOrPut? |  (optional) 

            try
            {
                // Create a new Intelligent DNS zone record
                PostOrPutRecordResponse result = apiInstance.PostZoneRecord(zoneId, recordPostOrPut);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordsApi.PostZoneRecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostZoneRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Intelligent DNS zone record
    ApiResponse<PostOrPutRecordResponse> response = apiInstance.PostZoneRecordWithHttpInfo(zoneId, recordPostOrPut);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordsApi.PostZoneRecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zoneId** | **int** | The hosted zone id |  |
| **recordPostOrPut** | [**RecordPostOrPut?**](RecordPostOrPut?.md) |  | [optional]  |

### Return type

[**PostOrPutRecordResponse**](PostOrPutRecordResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Record added |  -  |
| **400** | Error |  -  |
| **404** | Zone not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putzonerecord"></a>
# **PutZoneRecord**
> PostOrPutRecordResponse PutZoneRecord (int zoneId, int recordId, RecordPostOrPut? recordPostOrPut = null)

Update an Intelligent DNS zone record

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using idns.Api;
using idns.Client;
using idns.Model;

namespace Example
{
    public class PutZoneRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RecordsApi(config);
            var zoneId = 56;  // int | The hosted zone id
            var recordId = 56;  // int | The zone record id
            var recordPostOrPut = new RecordPostOrPut?(); // RecordPostOrPut? |  (optional) 

            try
            {
                // Update an Intelligent DNS zone record
                PostOrPutRecordResponse result = apiInstance.PutZoneRecord(zoneId, recordId, recordPostOrPut);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordsApi.PutZoneRecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutZoneRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an Intelligent DNS zone record
    ApiResponse<PostOrPutRecordResponse> response = apiInstance.PutZoneRecordWithHttpInfo(zoneId, recordId, recordPostOrPut);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordsApi.PutZoneRecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zoneId** | **int** | The hosted zone id |  |
| **recordId** | **int** | The zone record id |  |
| **recordPostOrPut** | [**RecordPostOrPut?**](RecordPostOrPut?.md) |  | [optional]  |

### Return type

[**PostOrPutRecordResponse**](PostOrPutRecordResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json; version=3


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Record updated |  -  |
| **400** | Record update error |  -  |
| **404** | Record not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

