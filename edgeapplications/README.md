# edgeapplications - the C# library for the Edge Application

## Welcome to the Azion API!

With the following APIs you can check, remove or update existing settings, besides creating new ones.

* * *

## Overview

The Azion API is a RESTful API, based on HTTPS requests, that allows you to integrate your systems with our platform, simply, quickly, and securely.

Here you will find instructions on how our API works and what functionality is available.

This documentation is being constantly updated. Make sure you verify if there are any updates or changes before you perform any development in your application, even if you are familiar with our API.

* * *

Both HTTPS requests and responses must be in JavaScript Object Notation (JSON) format. All HTTPS requests and responses must follow these conventions.

**Base URL**

The base URL of the API, which must be used, is:

[**https://api.azionapi.net/_**](https://api.azionapi.net/)

**HTTP Methods**

Each HTTP method defines the type of operation that will be run.

| HTTP Method | CRUD | Whole Collection (e.g. /items) | Specific Item (e.g. /items/:item_id) |
| - -- | - -- | - -- | - -- |
| GET | Read | It retrieves the list of items in a Collection. | It retrieves a specific item in a Collection. |
| POST | Create | It creates a new item in the Collection. | \\- |
| PUT | Update/Replace | It replaces a whole Collection with a new one. | It replaces an item in a Collection with a new one. |
| PATCH | Update/Modify | It partially updates a Collection. | It partially updates an item in a Collection |
| DELETE | Delete | It deletes a whole Collection. | It deletes an item in a Collection. |

* * *

**Status Codes**

The HTTP return code defines the status – successful or not – after the requested operation is run.

| Status Code | Meaning |
| - -- | - -- |
| 200 OK | General Status for a successful operation. |
| 201 CREATED | Successfully created a collection or item, by means of POST or PUT. |
| 204 NO CONTENT | Successful operation, but without any content to be return to the Body. Generally used for DELETE or PUT operations. |
| 207 MULTI-STATUS | A batch of operations were triggered by a single request, which resulted in different return codes when it was run, for some of the operations. The codes are displayed in the “status” field, in the body of the response, for each sub-batch of operations for whichever are applicable. |
| 400 BAD REQUEST | Request error, such as invalid parameters, missing mandatory parameters or others. |
| 401 UNAUTHORIZED | Error caused by a missing HTTP Authentication header. |
| 403 FORBIDDEN | User does not have the permissions to run the requested operation. |
| 404 NOT FOUND | The requested resource does not exist. |
| 405 METHOD NOT ALLOWED | The requested method is not applicable with the URL. |
| 406 NOT ACCEPTABLE | Accept header missing from the HTTP request or the header contains formatting or the version is not supported by the API. |
| 409 CONFLICT | Conflict generated in running the request, such as a request to create an already existing record. |
| 429 TOO MANY REQUESTS | The request was temporarily rejected, due to exceeding the limit on operations. Wait for the time defined in the X-Ratelimit-Reset header and try again. |
| 500 INTERNAL SERVER ERROR | Unintentional error, due to an unidentified failure in the request process. |
| \\- -- |  |
| **HTTP Headers** |  |

All requests must be generated with the HTTP header specifying the desired code format for responses and the API version used. The current version of the API is 3 and the format is application/json.

```
Accept: application/json; version=3

```

* * *

**Rate Limit**

The limit of operations that can be run via the API is defined by 3 HTTP response headers:

*   **X-ratelimit-limit:** number of operations allowed in one time-frame;
*   **X-ratelimit-remaining:** number of operations still available in one time-frame;
*   **X-ratelimit-reset:** is the date and time, in IOS 8601 format, which represents the point in the future when the time-frame will be closed and when the limits will, therefore, be reset.
    

Example of HTTP response headers and a request:

```
Date: Thu, 02 Nov 2017 12:30:28 GMT
X-ratelimit-remaining: 199
X-ratelimit-limit: 200
X-ratelimit-reset: 2017-11-02T12:31:28.675446

```

In the example provided, 200 operations are allowed within a 1-minute time frame. Of those, there are 199 still available, because one has already been run. The total limit will be reset after 1 minute.

When the X-ratelimit-limit is reached, or in other words, when the X-ratelimit-remaining reaches zero, the API will give the error, HTTP 429 TOO MANY REQUESTS. If your application receives this error, you will need to wait until the time defined in X-ratelimit-reset has passed, to make another request.

*   **X-ratelimit-limit by product**
    

The *X-ratelimit limit* variations by product are the following:

*   **Real-Time Metrics:** 20 requests per minute.
*   **Real-Time Purge:** 200 requests per minute; except for the Wildcard, which is 2000 a day.
    

> The rate-limit values are based on the client_id.

* * *

**Optional Parameters**

In this version, it is possible to include some optional parameters as part of the GET method, which can help and modify the form in which your data will be returned.

You can combine these parameters to get the result you want.

They are:

| Parameter | Description | Accepted values: |
| - -- | - -- | - -- |
| order_by | Identifies which field the return should be sorted by. The default ordering is ascending. | Depends on the fields available from the endpoint structure |
| sort | Defines which ordering to be used: ascending or descending. | asc  <br>  <br>desc |
| page | Identifies which page should be returned, if the return is paginated. The default value is 1. | Page number. |
| page_size | Identifies how many items should be returned per page. The default value is 10. | Desired number of items. |

* * *

**Request Exemple**

You can use one parameter, or a combination. See the example below, which uses all of them in the same request.

```
GET /domains?order_by=name&page_size=20&sort=desc&page=3
Accept: application/json; version=3
Authorization: token 2909f3932069047f4736dc87e72baaddd19c9f75

```

* * *

# Authentication

Authentication and authorization of operations via Azion API is done through Tokens.

The first step is to create the Token through authenticating a user registered in [Real-Time Manager](https://sso.azion.com/login).

* * *

## Encoding Username and Password in Base64

Only token creation and cancelling operations are performed through Basic Authentication, that is, with a username and password. You can create and cancel the token through the API itself, but for that you need to encode your username and password in base64.

Base64 encoding can be done from the command line on a Unix terminal:

```
$ echo 'user@domain:password'|base64
dXNlckBkb21haW46cGFzc3dvcmQK

```

If you do not have a Unix terminal available, you can use the free online service at [https://www.base64encode.org/](https://www.base64encode.org/)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a id="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;
```
<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using edgeapplications.Api;
using edgeapplications.Client;
using edgeapplications.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.azionapi.net";
            // Configure API key authorization: tokenAuth
            config.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new EdgeApplicationsCacheSettingsApi(config);
            var edgeApplicationId = 789L;  // long | 
            var cacheSettings = 789L;  // long | 
            var accept = application/json; version=3;  // string |  (optional) 
            var contentType = application/json;  // string | The type of coding used in the Body (application/json). <br>  Example: Content-Type: application/json (optional) 

            try
            {
                // /edge_applications/:edge_application_id:/cache_settings/:cache_settings:
                apiInstance.EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsDelete(edgeApplicationId, cacheSettings, accept, contentType);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EdgeApplicationsCacheSettingsApi.EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.azionapi.net*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*EdgeApplicationsCacheSettingsApi* | [**EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsDelete**](docs/EdgeApplicationsCacheSettingsApi.md#edgeapplicationsedgeapplicationidcachesettingscachesettingsdelete) | **DELETE** /edge_applications/{edge_application_id}/cache_settings/{cache_settings} | /edge_applications/:edge_application_id:/cache_settings/:cache_settings:
*EdgeApplicationsCacheSettingsApi* | [**EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsIdGet**](docs/EdgeApplicationsCacheSettingsApi.md#edgeapplicationsedgeapplicationidcachesettingscachesettingsidget) | **GET** /edge_applications/{edge_application_id}/cache_settings/{cache_settings_id} | /edge_applications/:edge_application_id:/cache_settings/:cache_settings_id:
*EdgeApplicationsCacheSettingsApi* | [**EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsIdPut**](docs/EdgeApplicationsCacheSettingsApi.md#edgeapplicationsedgeapplicationidcachesettingscachesettingsidput) | **PUT** /edge_applications/{edge_application_id}/cache_settings/{cache_settings_id} | /edge_applications/:edge_application_id:/cache_settings/ca
*EdgeApplicationsCacheSettingsApi* | [**EdgeApplicationsEdgeApplicationIdCacheSettingsCacheSettingsPatch**](docs/EdgeApplicationsCacheSettingsApi.md#edgeapplicationsedgeapplicationidcachesettingscachesettingspatch) | **PATCH** /edge_applications/{edge_application_id}/cache_settings/{cache_settings} | /edge_applications/:edge_application_id:/cache_settings/:cache_settings_id:
*EdgeApplicationsCacheSettingsApi* | [**EdgeApplicationsEdgeApplicationIdCacheSettingsGet**](docs/EdgeApplicationsCacheSettingsApi.md#edgeapplicationsedgeapplicationidcachesettingsget) | **GET** /edge_applications/{edge_application_id}/cache_settings | /edge_applications/{edge_application_id}/cache_settings
*EdgeApplicationsCacheSettingsApi* | [**EdgeApplicationsEdgeApplicationIdCacheSettingsPost**](docs/EdgeApplicationsCacheSettingsApi.md#edgeapplicationsedgeapplicationidcachesettingspost) | **POST** /edge_applications/{edge_application_id}/cache_settings | /edge_applications/:edge_application_id:/cache_settings
*EdgeApplicationsDeviceGroupsApi* | [**EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdDelete**](docs/EdgeApplicationsDeviceGroupsApi.md#edgeapplicationsedgeapplicationiddevicegroupsdevicegroupiddelete) | **DELETE** /edge_applications/{edge_application_id}/device_groups/{device_group_id} | /edge_applications/{edge_application_id}/device_groups/{device_group_id}
*EdgeApplicationsDeviceGroupsApi* | [**EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdGet**](docs/EdgeApplicationsDeviceGroupsApi.md#edgeapplicationsedgeapplicationiddevicegroupsdevicegroupidget) | **GET** /edge_applications/{edge_application_id}/device_groups/{device_group_id} | /edge_applications/{edge_application_id}/device_groups/{device_group_id}
*EdgeApplicationsDeviceGroupsApi* | [**EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdPatch**](docs/EdgeApplicationsDeviceGroupsApi.md#edgeapplicationsedgeapplicationiddevicegroupsdevicegroupidpatch) | **PATCH** /edge_applications/{edge_application_id}/device_groups/{device_group_id} | /edge_applications/{edge_application_id}/device_groups/{device_group_id}
*EdgeApplicationsDeviceGroupsApi* | [**EdgeApplicationsEdgeApplicationIdDeviceGroupsDeviceGroupIdPut**](docs/EdgeApplicationsDeviceGroupsApi.md#edgeapplicationsedgeapplicationiddevicegroupsdevicegroupidput) | **PUT** /edge_applications/{edge_application_id}/device_groups/{device_group_id} | /edge_applications/{edge_application_id}/device_groups/{device_group_id}
*EdgeApplicationsDeviceGroupsApi* | [**EdgeApplicationsEdgeApplicationIdDeviceGroupsGet**](docs/EdgeApplicationsDeviceGroupsApi.md#edgeapplicationsedgeapplicationiddevicegroupsget) | **GET** /edge_applications/{edge_application_id}/device_groups | /edge_applications/{edge_application_id}/device_groups
*EdgeApplicationsDeviceGroupsApi* | [**EdgeApplicationsEdgeApplicationIdDeviceGroupsPost**](docs/EdgeApplicationsDeviceGroupsApi.md#edgeapplicationsedgeapplicationiddevicegroupspost) | **POST** /edge_applications/{edge_application_id}/device_groups | /edge_applications/{edge_application_id}/device_groups
*EdgeApplicationsEdgeFunctionsInstancesApi* | [**EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDelete**](docs/EdgeApplicationsEdgeFunctionsInstancesApi.md#edgeapplicationsedgeapplicationidfunctionsinstancesfunctionsinstancesiddelete) | **DELETE** /edge_applications/{edge_application_id}/functions_instances/{functions_instances_id} | /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
*EdgeApplicationsEdgeFunctionsInstancesApi* | [**EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGet**](docs/EdgeApplicationsEdgeFunctionsInstancesApi.md#edgeapplicationsedgeapplicationidfunctionsinstancesfunctionsinstancesidget) | **GET** /edge_applications/{edge_application_id}/functions_instances/{functions_instances_id} | /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
*EdgeApplicationsEdgeFunctionsInstancesApi* | [**EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatch**](docs/EdgeApplicationsEdgeFunctionsInstancesApi.md#edgeapplicationsedgeapplicationidfunctionsinstancesfunctionsinstancesidpatch) | **PATCH** /edge_applications/{edge_application_id}/functions_instances/{functions_instances_id} | /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
*EdgeApplicationsEdgeFunctionsInstancesApi* | [**EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPut**](docs/EdgeApplicationsEdgeFunctionsInstancesApi.md#edgeapplicationsedgeapplicationidfunctionsinstancesfunctionsinstancesidput) | **PUT** /edge_applications/{edge_application_id}/functions_instances/{functions_instances_id} | /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
*EdgeApplicationsEdgeFunctionsInstancesApi* | [**EdgeApplicationsEdgeApplicationIdFunctionsInstancesGet**](docs/EdgeApplicationsEdgeFunctionsInstancesApi.md#edgeapplicationsedgeapplicationidfunctionsinstancesget) | **GET** /edge_applications/{edge_application_id}/functions_instances | /edge_applications/:edge_application_id:/functions_instances
*EdgeApplicationsEdgeFunctionsInstancesApi* | [**EdgeApplicationsEdgeApplicationIdFunctionsInstancesPost**](docs/EdgeApplicationsEdgeFunctionsInstancesApi.md#edgeapplicationsedgeapplicationidfunctionsinstancespost) | **POST** /edge_applications/{edge_application_id}/functions_instances | edge_application/:edge_application_id:/functions_instances
*EdgeApplicationsMainSettingsApi* | [**EdgeApplicationsGet**](docs/EdgeApplicationsMainSettingsApi.md#edgeapplicationsget) | **GET** /edge_applications | /edge_applications
*EdgeApplicationsMainSettingsApi* | [**EdgeApplicationsIdDelete**](docs/EdgeApplicationsMainSettingsApi.md#edgeapplicationsiddelete) | **DELETE** /edge_applications/{id} | /edge_applications/:id
*EdgeApplicationsMainSettingsApi* | [**EdgeApplicationsIdGet**](docs/EdgeApplicationsMainSettingsApi.md#edgeapplicationsidget) | **GET** /edge_applications/{id} | /edge_applications/:id
*EdgeApplicationsMainSettingsApi* | [**EdgeApplicationsIdPatch**](docs/EdgeApplicationsMainSettingsApi.md#edgeapplicationsidpatch) | **PATCH** /edge_applications/{id} | /edge_applications/:id
*EdgeApplicationsMainSettingsApi* | [**EdgeApplicationsIdPut**](docs/EdgeApplicationsMainSettingsApi.md#edgeapplicationsidput) | **PUT** /edge_applications/{id} | /edge_applications/:id
*EdgeApplicationsMainSettingsApi* | [**EdgeApplicationsPost**](docs/EdgeApplicationsMainSettingsApi.md#edgeapplicationspost) | **POST** /edge_applications | /edge_applications
*EdgeApplicationsOriginsApi* | [**EdgeApplicationsEdgeApplicationIdOriginsGet**](docs/EdgeApplicationsOriginsApi.md#edgeapplicationsedgeapplicationidoriginsget) | **GET** /edge_applications/{edge_application_id}/origins | /edge_applications/{edge_application_id}/origins
*EdgeApplicationsOriginsApi* | [**EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDelete**](docs/EdgeApplicationsOriginsApi.md#edgeapplicationsedgeapplicationidoriginsoriginkeydelete) | **DELETE** /edge_applications/{edge_application_id}/origins/{origin_key} | /edge_applications/{edge_application_id}/origins/{origin_id}
*EdgeApplicationsOriginsApi* | [**EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGet**](docs/EdgeApplicationsOriginsApi.md#edgeapplicationsedgeapplicationidoriginsoriginkeyget) | **GET** /edge_applications/{edge_application_id}/origins/{origin_key} | /edge_applications/{edge_application_id}/origins/{origin_key}
*EdgeApplicationsOriginsApi* | [**EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatch**](docs/EdgeApplicationsOriginsApi.md#edgeapplicationsedgeapplicationidoriginsoriginkeypatch) | **PATCH** /edge_applications/{edge_application_id}/origins/{origin_key} | /edge_applications/:edge_application_id:/origins/:origin_id:
*EdgeApplicationsOriginsApi* | [**EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPut**](docs/EdgeApplicationsOriginsApi.md#edgeapplicationsedgeapplicationidoriginsoriginkeyput) | **PUT** /edge_applications/{edge_application_id}/origins/{origin_key} | /edge_applications/{edge_application_id}/origins/{origin_id}
*EdgeApplicationsOriginsApi* | [**EdgeApplicationsEdgeApplicationIdOriginsPost**](docs/EdgeApplicationsOriginsApi.md#edgeapplicationsedgeapplicationidoriginspost) | **POST** /edge_applications/{edge_application_id}/origins | /edge_applications/{edge_application_id}/origins
*EdgeApplicationsRulesEngineApi* | [**EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesGet**](docs/EdgeApplicationsRulesEngineApi.md#edgeapplicationsedgeapplicationidrulesenginephaserulesget) | **GET** /edge_applications/{edge_application_id}/rules_engine/{phase}/rules | /edge_applications/{edge_application_id}/rules_engine/{phase}/rules
*EdgeApplicationsRulesEngineApi* | [**EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesPost**](docs/EdgeApplicationsRulesEngineApi.md#edgeapplicationsedgeapplicationidrulesenginephaserulespost) | **POST** /edge_applications/{edge_application_id}/rules_engine/{phase}/rules | /edge_applications/{edge_application_id}/rules_engine/{phase}/rules
*EdgeApplicationsRulesEngineApi* | [**EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdDelete**](docs/EdgeApplicationsRulesEngineApi.md#edgeapplicationsedgeapplicationidrulesenginephaserulesruleiddelete) | **DELETE** /edge_applications/{edge_application_id}/rules_engine/{phase}/rules/{rule_id} | /edge_applications/{edge_application_id}/rules_engine/{phase}/rules
*EdgeApplicationsRulesEngineApi* | [**EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdGet**](docs/EdgeApplicationsRulesEngineApi.md#edgeapplicationsedgeapplicationidrulesenginephaserulesruleidget) | **GET** /edge_applications/{edge_application_id}/rules_engine/{phase}/rules/{rule_id} | /edge_applications/{edge_application_id}/rules_engine/{phase}/rules
*EdgeApplicationsRulesEngineApi* | [**EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdPatch**](docs/EdgeApplicationsRulesEngineApi.md#edgeapplicationsedgeapplicationidrulesenginephaserulesruleidpatch) | **PATCH** /edge_applications/{edge_application_id}/rules_engine/{phase}/rules/{rule_id} | /edge_applications/:edge_application_id:/rules_engine/:phase:/rules/:rule_id:
*EdgeApplicationsRulesEngineApi* | [**EdgeApplicationsEdgeApplicationIdRulesEnginePhaseRulesRuleIdPut**](docs/EdgeApplicationsRulesEngineApi.md#edgeapplicationsedgeapplicationidrulesenginephaserulesruleidput) | **PUT** /edge_applications/{edge_application_id}/rules_engine/{phase}/rules/{rule_id} | /edge_applications/:edge_application_id:/rules_engine/:phase:/rules/:rule_id:


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.ApplicationCacheCreateRequest](docs/ApplicationCacheCreateRequest.md)
 - [Model.ApplicationCacheCreateResponse](docs/ApplicationCacheCreateResponse.md)
 - [Model.ApplicationCacheCreateResults](docs/ApplicationCacheCreateResults.md)
 - [Model.ApplicationCacheGetOneResponse](docs/ApplicationCacheGetOneResponse.md)
 - [Model.ApplicationCacheGetResponse](docs/ApplicationCacheGetResponse.md)
 - [Model.ApplicationCachePatchRequest](docs/ApplicationCachePatchRequest.md)
 - [Model.ApplicationCachePatchResponse](docs/ApplicationCachePatchResponse.md)
 - [Model.ApplicationCachePutRequest](docs/ApplicationCachePutRequest.md)
 - [Model.ApplicationCachePutResponse](docs/ApplicationCachePutResponse.md)
 - [Model.ApplicationCacheResponseDetails](docs/ApplicationCacheResponseDetails.md)
 - [Model.ApplicationCacheResults](docs/ApplicationCacheResults.md)
 - [Model.ApplicationCreateInstanceRequest](docs/ApplicationCreateInstanceRequest.md)
 - [Model.ApplicationInstanceResults](docs/ApplicationInstanceResults.md)
 - [Model.ApplicationInstancesGetOneResponse](docs/ApplicationInstancesGetOneResponse.md)
 - [Model.ApplicationInstancesGetResponse](docs/ApplicationInstancesGetResponse.md)
 - [Model.ApplicationInstancesResults](docs/ApplicationInstancesResults.md)
 - [Model.ApplicationLinks](docs/ApplicationLinks.md)
 - [Model.ApplicationOrigins](docs/ApplicationOrigins.md)
 - [Model.ApplicationPutInstanceRequest](docs/ApplicationPutInstanceRequest.md)
 - [Model.ApplicationPutRequest](docs/ApplicationPutRequest.md)
 - [Model.ApplicationPutResult](docs/ApplicationPutResult.md)
 - [Model.ApplicationResults](docs/ApplicationResults.md)
 - [Model.ApplicationResultsCreate](docs/ApplicationResultsCreate.md)
 - [Model.ApplicationUpdateInstanceRequest](docs/ApplicationUpdateInstanceRequest.md)
 - [Model.ApplicationUpdateRequest](docs/ApplicationUpdateRequest.md)
 - [Model.ApplicationUpdateResponse](docs/ApplicationUpdateResponse.md)
 - [Model.ApplicationUpdateResults](docs/ApplicationUpdateResults.md)
 - [Model.ApplicationsResults](docs/ApplicationsResults.md)
 - [Model.CreateApplicationRequest](docs/CreateApplicationRequest.md)
 - [Model.CreateApplicationResult](docs/CreateApplicationResult.md)
 - [Model.CreateDeviceGroupsRequest](docs/CreateDeviceGroupsRequest.md)
 - [Model.CreateOriginsRequest](docs/CreateOriginsRequest.md)
 - [Model.CreateOriginsRequestAddresses](docs/CreateOriginsRequestAddresses.md)
 - [Model.CreateRulesEngineRequest](docs/CreateRulesEngineRequest.md)
 - [Model.DeviceGroupsIdResponse](docs/DeviceGroupsIdResponse.md)
 - [Model.DeviceGroupsResponse](docs/DeviceGroupsResponse.md)
 - [Model.DeviceGroupsResponseLinks](docs/DeviceGroupsResponseLinks.md)
 - [Model.DeviceGroupsResultResponse](docs/DeviceGroupsResultResponse.md)
 - [Model.GetApplicationResponse](docs/GetApplicationResponse.md)
 - [Model.GetApplicationsResponse](docs/GetApplicationsResponse.md)
 - [Model.OriginsIdResponse](docs/OriginsIdResponse.md)
 - [Model.OriginsResponse](docs/OriginsResponse.md)
 - [Model.OriginsResponseLinks](docs/OriginsResponseLinks.md)
 - [Model.OriginsResultResponse](docs/OriginsResultResponse.md)
 - [Model.OriginsResultResponseAddresses](docs/OriginsResultResponseAddresses.md)
 - [Model.PatchDeviceGroupsRequest](docs/PatchDeviceGroupsRequest.md)
 - [Model.PatchOriginsRequest](docs/PatchOriginsRequest.md)
 - [Model.PatchRulesEngineRequest](docs/PatchRulesEngineRequest.md)
 - [Model.RulesEngineBehavior](docs/RulesEngineBehavior.md)
 - [Model.RulesEngineCriteria](docs/RulesEngineCriteria.md)
 - [Model.RulesEngineIdResponse](docs/RulesEngineIdResponse.md)
 - [Model.RulesEngineResponse](docs/RulesEngineResponse.md)
 - [Model.RulesEngineResultResponse](docs/RulesEngineResultResponse.md)
 - [Model.RulesEngineResultResponseBehaviors](docs/RulesEngineResultResponseBehaviors.md)
 - [Model.UpdateDeviceGroupsRequest](docs/UpdateDeviceGroupsRequest.md)
 - [Model.UpdateOriginsRequest](docs/UpdateOriginsRequest.md)
 - [Model.UpdateRulesEngineRequest](docs/UpdateRulesEngineRequest.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="tokenAuth"></a>
### tokenAuth

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

