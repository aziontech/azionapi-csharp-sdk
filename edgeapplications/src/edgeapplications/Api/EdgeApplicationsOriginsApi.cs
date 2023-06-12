/*
 * Edge Application
 *
 * ## Welcome to the Azion API!  With the following APIs you can check, remove or update existing settings, besides creating new ones.  * * *  ## Overview  The Azion API is a RESTful API, based on HTTPS requests, that allows you to integrate your systems with our platform, simply, quickly, and securely.  Here you will find instructions on how our API works and what functionality is available.  This documentation is being constantly updated. Make sure you verify if there are any updates or changes before you perform any development in your application, even if you are familiar with our API.  * * *  Both HTTPS requests and responses must be in JavaScript Object Notation (JSON) format. All HTTPS requests and responses must follow these conventions.  **Base URL**  The base URL of the API, which must be used, is:  [**https://api.azionapi.net/_**](https://api.azionapi.net/)  **HTTP Methods**  Each HTTP method defines the type of operation that will be run.  | HTTP Method | CRUD | Whole Collection (e.g. /items) | Specific Item (e.g. /items/:item_id) | | - -- | - -- | - -- | - -- | | GET | Read | It retrieves the list of items in a Collection. | It retrieves a specific item in a Collection. | | POST | Create | It creates a new item in the Collection. | \\- | | PUT | Update/Replace | It replaces a whole Collection with a new one. | It replaces an item in a Collection with a new one. | | PATCH | Update/Modify | It partially updates a Collection. | It partially updates an item in a Collection | | DELETE | Delete | It deletes a whole Collection. | It deletes an item in a Collection. |  * * *  **Status Codes**  The HTTP return code defines the status – successful or not – after the requested operation is run.  | Status Code | Meaning | | - -- | - -- | | 200 OK | General Status for a successful operation. | | 201 CREATED | Successfully created a collection or item, by means of POST or PUT. | | 204 NO CONTENT | Successful operation, but without any content to be return to the Body. Generally used for DELETE or PUT operations. | | 207 MULTI-STATUS | A batch of operations were triggered by a single request, which resulted in different return codes when it was run, for some of the operations. The codes are displayed in the “status” field, in the body of the response, for each sub-batch of operations for whichever are applicable. | | 400 BAD REQUEST | Request error, such as invalid parameters, missing mandatory parameters or others. | | 401 UNAUTHORIZED | Error caused by a missing HTTP Authentication header. | | 403 FORBIDDEN | User does not have the permissions to run the requested operation. | | 404 NOT FOUND | The requested resource does not exist. | | 405 METHOD NOT ALLOWED | The requested method is not applicable with the URL. | | 406 NOT ACCEPTABLE | Accept header missing from the HTTP request or the header contains formatting or the version is not supported by the API. | | 409 CONFLICT | Conflict generated in running the request, such as a request to create an already existing record. | | 429 TOO MANY REQUESTS | The request was temporarily rejected, due to exceeding the limit on operations. Wait for the time defined in the X-Ratelimit-Reset header and try again. | | 500 INTERNAL SERVER ERROR | Unintentional error, due to an unidentified failure in the request process. | | \\- -- |  | | **HTTP Headers** |  |  All requests must be generated with the HTTP header specifying the desired code format for responses and the API version used. The current version of the API is 3 and the format is application/json.  ``` Accept: application/json; version=3  ```  * * *  **Rate Limit**  The limit of operations that can be run via the API is defined by 3 HTTP response headers:  *   **X-ratelimit-limit:** number of operations allowed in one time-frame; *   **X-ratelimit-remaining:** number of operations still available in one time-frame; *   **X-ratelimit-reset:** is the date and time, in IOS 8601 format, which represents the point in the future when the time-frame will be closed and when the limits will, therefore, be reset.       Example of HTTP response headers and a request:  ``` Date: Thu, 02 Nov 2017 12:30:28 GMT X-ratelimit-remaining: 199 X-ratelimit-limit: 200 X-ratelimit-reset: 2017-11-02T12:31:28.675446  ```  In the example provided, 200 operations are allowed within a 1-minute time frame. Of those, there are 199 still available, because one has already been run. The total limit will be reset after 1 minute.  When the X-ratelimit-limit is reached, or in other words, when the X-ratelimit-remaining reaches zero, the API will give the error, HTTP 429 TOO MANY REQUESTS. If your application receives this error, you will need to wait until the time defined in X-ratelimit-reset has passed, to make another request.  *   **X-ratelimit-limit by product**       The *X-ratelimit limit* variations by product are the following:  *   **Real-Time Metrics:** 20 requests per minute. *   **Real-Time Purge:** 200 requests per minute; except for the Wildcard, which is 2000 a day.       > The rate-limit values are based on the client_id.  * * *  **Optional Parameters**  In this version, it is possible to include some optional parameters as part of the GET method, which can help and modify the form in which your data will be returned.  You can combine these parameters to get the result you want.  They are:  | Parameter | Description | Accepted values: | | - -- | - -- | - -- | | order_by | Identifies which field the return should be sorted by. The default ordering is ascending. | Depends on the fields available from the endpoint structure | | sort | Defines which ordering to be used: ascending or descending. | asc  <br>  <br>desc | | page | Identifies which page should be returned, if the return is paginated. The default value is 1. | Page number. | | page_size | Identifies how many items should be returned per page. The default value is 10. | Desired number of items. |  * * *  **Request Exemple**  You can use one parameter, or a combination. See the example below, which uses all of them in the same request.  ``` GET /domains?order_by=name&page_size=20&sort=desc&page=3 Accept: application/json; version=3 Authorization: token 2909f3932069047f4736dc87e72baaddd19c9f75  ```  * * *  # Authentication  Authentication and authorization of operations via Azion API is done through Tokens.  The first step is to create the Token through authenticating a user registered in [Real-Time Manager](https://sso.azion.com/login).  * * *  ## Encoding Username and Password in Base64  Only token creation and cancelling operations are performed through Basic Authentication, that is, with a username and password. You can create and cancel the token through the API itself, but for that you need to encode your username and password in base64.  Base64 encoding can be done from the command line on a Unix terminal:  ``` $ echo 'user@domain:password'|base64 dXNlckBkb21haW46cGFzc3dvcmQK  ```  If you do not have a Unix terminal available, you can use the free online service at [https://www.base64encode.org/](https://www.base64encode.org/)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using edgeapplications.Client;
using edgeapplications.Model;

namespace edgeapplications.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEdgeApplicationsOriginsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// /edge_applications/{edge_application_id}/origins
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="page"> (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="filter"> (optional)</param>
        /// <param name="orderBy"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OriginsResponse</returns>
        OriginsResponse EdgeApplicationsEdgeApplicationIdOriginsGet(long edgeApplicationId, long? page = default(long?), long? pageSize = default(long?), string filter = default(string), string orderBy = default(string), string sort = default(string), string accept = default(string), int operationIndex = 0);

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="page"> (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="filter"> (optional)</param>
        /// <param name="orderBy"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OriginsResponse</returns>
        ApiResponse<OriginsResponse> EdgeApplicationsEdgeApplicationIdOriginsGetWithHttpInfo(long edgeApplicationId, long? page = default(long?), long? pageSize = default(long?), string filter = default(string), string orderBy = default(string), string sort = default(string), string accept = default(string), int operationIndex = 0);
        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_id}
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept">The id of the Origin that you plan to delete. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDelete(long edgeApplicationId, string originKey, string accept = default(string), int operationIndex = 0);

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_id}
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept">The id of the Origin that you plan to delete. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDeleteWithHttpInfo(long edgeApplicationId, string originKey, string accept = default(string), int operationIndex = 0);
        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_key}
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept">The id of the Origin that you plan to query. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OriginsIdResponse</returns>
        OriginsIdResponse EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGet(long edgeApplicationId, string originKey, string accept = default(string), int operationIndex = 0);

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_key}
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept">The id of the Origin that you plan to query. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OriginsIdResponse</returns>
        ApiResponse<OriginsIdResponse> EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGetWithHttpInfo(long edgeApplicationId, string originKey, string accept = default(string), int operationIndex = 0);
        /// <summary>
        /// /edge_applications/:edge_application_id:/origins/:origin_id:
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="patchOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OriginsIdResponse</returns>
        OriginsIdResponse EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatch(long edgeApplicationId, string originKey, string accept = default(string), string contentType = default(string), PatchOriginsRequest patchOriginsRequest = default(PatchOriginsRequest), int operationIndex = 0);

        /// <summary>
        /// /edge_applications/:edge_application_id:/origins/:origin_id:
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="patchOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OriginsIdResponse</returns>
        ApiResponse<OriginsIdResponse> EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatchWithHttpInfo(long edgeApplicationId, string originKey, string accept = default(string), string contentType = default(string), PatchOriginsRequest patchOriginsRequest = default(PatchOriginsRequest), int operationIndex = 0);
        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_id}
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="updateOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OriginsIdResponse</returns>
        OriginsIdResponse EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPut(long edgeApplicationId, string originKey, string accept = default(string), string contentType = default(string), UpdateOriginsRequest updateOriginsRequest = default(UpdateOriginsRequest), int operationIndex = 0);

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_id}
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="updateOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OriginsIdResponse</returns>
        ApiResponse<OriginsIdResponse> EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPutWithHttpInfo(long edgeApplicationId, string originKey, string accept = default(string), string contentType = default(string), UpdateOriginsRequest updateOriginsRequest = default(UpdateOriginsRequest), int operationIndex = 0);
        /// <summary>
        /// /edge_applications/{edge_application_id}/origins
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="createOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OriginsIdResponse</returns>
        OriginsIdResponse EdgeApplicationsEdgeApplicationIdOriginsPost(long edgeApplicationId, string accept = default(string), string contentType = default(string), CreateOriginsRequest createOriginsRequest = default(CreateOriginsRequest), int operationIndex = 0);

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="createOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OriginsIdResponse</returns>
        ApiResponse<OriginsIdResponse> EdgeApplicationsEdgeApplicationIdOriginsPostWithHttpInfo(long edgeApplicationId, string accept = default(string), string contentType = default(string), CreateOriginsRequest createOriginsRequest = default(CreateOriginsRequest), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEdgeApplicationsOriginsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// /edge_applications/{edge_application_id}/origins
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="page"> (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="filter"> (optional)</param>
        /// <param name="orderBy"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OriginsResponse</returns>
        System.Threading.Tasks.Task<OriginsResponse> EdgeApplicationsEdgeApplicationIdOriginsGetAsync(long edgeApplicationId, long? page = default(long?), long? pageSize = default(long?), string filter = default(string), string orderBy = default(string), string sort = default(string), string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="page"> (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="filter"> (optional)</param>
        /// <param name="orderBy"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OriginsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OriginsResponse>> EdgeApplicationsEdgeApplicationIdOriginsGetWithHttpInfoAsync(long edgeApplicationId, long? page = default(long?), long? pageSize = default(long?), string filter = default(string), string orderBy = default(string), string sort = default(string), string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_id}
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept">The id of the Origin that you plan to delete. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDeleteAsync(long edgeApplicationId, string originKey, string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_id}
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept">The id of the Origin that you plan to delete. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDeleteWithHttpInfoAsync(long edgeApplicationId, string originKey, string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_key}
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept">The id of the Origin that you plan to query. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OriginsIdResponse</returns>
        System.Threading.Tasks.Task<OriginsIdResponse> EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGetAsync(long edgeApplicationId, string originKey, string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_key}
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept">The id of the Origin that you plan to query. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OriginsIdResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OriginsIdResponse>> EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGetWithHttpInfoAsync(long edgeApplicationId, string originKey, string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// /edge_applications/:edge_application_id:/origins/:origin_id:
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="patchOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OriginsIdResponse</returns>
        System.Threading.Tasks.Task<OriginsIdResponse> EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatchAsync(long edgeApplicationId, string originKey, string accept = default(string), string contentType = default(string), PatchOriginsRequest patchOriginsRequest = default(PatchOriginsRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// /edge_applications/:edge_application_id:/origins/:origin_id:
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="patchOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OriginsIdResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OriginsIdResponse>> EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatchWithHttpInfoAsync(long edgeApplicationId, string originKey, string accept = default(string), string contentType = default(string), PatchOriginsRequest patchOriginsRequest = default(PatchOriginsRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_id}
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="updateOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OriginsIdResponse</returns>
        System.Threading.Tasks.Task<OriginsIdResponse> EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPutAsync(long edgeApplicationId, string originKey, string accept = default(string), string contentType = default(string), UpdateOriginsRequest updateOriginsRequest = default(UpdateOriginsRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_id}
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="updateOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OriginsIdResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OriginsIdResponse>> EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPutWithHttpInfoAsync(long edgeApplicationId, string originKey, string accept = default(string), string contentType = default(string), UpdateOriginsRequest updateOriginsRequest = default(UpdateOriginsRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// /edge_applications/{edge_application_id}/origins
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="createOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OriginsIdResponse</returns>
        System.Threading.Tasks.Task<OriginsIdResponse> EdgeApplicationsEdgeApplicationIdOriginsPostAsync(long edgeApplicationId, string accept = default(string), string contentType = default(string), CreateOriginsRequest createOriginsRequest = default(CreateOriginsRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="createOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OriginsIdResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OriginsIdResponse>> EdgeApplicationsEdgeApplicationIdOriginsPostWithHttpInfoAsync(long edgeApplicationId, string accept = default(string), string contentType = default(string), CreateOriginsRequest createOriginsRequest = default(CreateOriginsRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEdgeApplicationsOriginsApi : IEdgeApplicationsOriginsApiSync, IEdgeApplicationsOriginsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class EdgeApplicationsOriginsApi : IEdgeApplicationsOriginsApi
    {
        private edgeapplications.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeApplicationsOriginsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EdgeApplicationsOriginsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeApplicationsOriginsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EdgeApplicationsOriginsApi(string basePath)
        {
            this.Configuration = edgeapplications.Client.Configuration.MergeConfigurations(
                edgeapplications.Client.GlobalConfiguration.Instance,
                new edgeapplications.Client.Configuration { BasePath = basePath }
            );
            this.Client = new edgeapplications.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new edgeapplications.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = edgeapplications.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeApplicationsOriginsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EdgeApplicationsOriginsApi(edgeapplications.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = edgeapplications.Client.Configuration.MergeConfigurations(
                edgeapplications.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new edgeapplications.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new edgeapplications.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = edgeapplications.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeApplicationsOriginsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public EdgeApplicationsOriginsApi(edgeapplications.Client.ISynchronousClient client, edgeapplications.Client.IAsynchronousClient asyncClient, edgeapplications.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = edgeapplications.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public edgeapplications.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public edgeapplications.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public edgeapplications.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public edgeapplications.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="page"> (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="filter"> (optional)</param>
        /// <param name="orderBy"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OriginsResponse</returns>
        public OriginsResponse EdgeApplicationsEdgeApplicationIdOriginsGet(long edgeApplicationId, long? page = default(long?), long? pageSize = default(long?), string filter = default(string), string orderBy = default(string), string sort = default(string), string accept = default(string), int operationIndex = 0)
        {
            edgeapplications.Client.ApiResponse<OriginsResponse> localVarResponse = EdgeApplicationsEdgeApplicationIdOriginsGetWithHttpInfo(edgeApplicationId, page, pageSize, filter, orderBy, sort, accept);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="page"> (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="filter"> (optional)</param>
        /// <param name="orderBy"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OriginsResponse</returns>
        public edgeapplications.Client.ApiResponse<OriginsResponse> EdgeApplicationsEdgeApplicationIdOriginsGetWithHttpInfo(long edgeApplicationId, long? page = default(long?), long? pageSize = default(long?), string filter = default(string), string orderBy = default(string), string sort = default(string), string accept = default(string), int operationIndex = 0)
        {
            edgeapplications.Client.RequestOptions localVarRequestOptions = new edgeapplications.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = edgeapplications.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = edgeapplications.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("edge_application_id", edgeapplications.Client.ClientUtils.ParameterToString(edgeApplicationId)); // path parameter
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(edgeapplications.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(edgeapplications.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(edgeapplications.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(edgeapplications.Client.ClientUtils.ParameterToMultiMap("", "order_by", orderBy));
            }
            if (sort != null)
            {
                localVarRequestOptions.QueryParameters.Add(edgeapplications.Client.ClientUtils.ParameterToMultiMap("", "sort", sort));
            }
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", edgeapplications.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }

            localVarRequestOptions.Operation = "EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<OriginsResponse>("/edge_applications/{edge_application_id}/origins", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdOriginsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="page"> (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="filter"> (optional)</param>
        /// <param name="orderBy"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OriginsResponse</returns>
        public async System.Threading.Tasks.Task<OriginsResponse> EdgeApplicationsEdgeApplicationIdOriginsGetAsync(long edgeApplicationId, long? page = default(long?), long? pageSize = default(long?), string filter = default(string), string orderBy = default(string), string sort = default(string), string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            edgeapplications.Client.ApiResponse<OriginsResponse> localVarResponse = await EdgeApplicationsEdgeApplicationIdOriginsGetWithHttpInfoAsync(edgeApplicationId, page, pageSize, filter, orderBy, sort, accept, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="page"> (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="filter"> (optional)</param>
        /// <param name="orderBy"> (optional)</param>
        /// <param name="sort"> (optional)</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OriginsResponse)</returns>
        public async System.Threading.Tasks.Task<edgeapplications.Client.ApiResponse<OriginsResponse>> EdgeApplicationsEdgeApplicationIdOriginsGetWithHttpInfoAsync(long edgeApplicationId, long? page = default(long?), long? pageSize = default(long?), string filter = default(string), string orderBy = default(string), string sort = default(string), string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            edgeapplications.Client.RequestOptions localVarRequestOptions = new edgeapplications.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = edgeapplications.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = edgeapplications.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("edge_application_id", edgeapplications.Client.ClientUtils.ParameterToString(edgeApplicationId)); // path parameter
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(edgeapplications.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(edgeapplications.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(edgeapplications.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(edgeapplications.Client.ClientUtils.ParameterToMultiMap("", "order_by", orderBy));
            }
            if (sort != null)
            {
                localVarRequestOptions.QueryParameters.Add(edgeapplications.Client.ClientUtils.ParameterToMultiMap("", "sort", sort));
            }
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", edgeapplications.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }

            localVarRequestOptions.Operation = "EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<OriginsResponse>("/edge_applications/{edge_application_id}/origins", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdOriginsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_id} 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept">The id of the Origin that you plan to delete. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDelete(long edgeApplicationId, string originKey, string accept = default(string), int operationIndex = 0)
        {
            EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDeleteWithHttpInfo(edgeApplicationId, originKey, accept);
        }

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_id} 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept">The id of the Origin that you plan to delete. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public edgeapplications.Client.ApiResponse<Object> EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDeleteWithHttpInfo(long edgeApplicationId, string originKey, string accept = default(string), int operationIndex = 0)
        {
            // verify the required parameter 'originKey' is set
            if (originKey == null)
            {
                throw new edgeapplications.Client.ApiException(400, "Missing required parameter 'originKey' when calling EdgeApplicationsOriginsApi->EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDelete");
            }

            edgeapplications.Client.RequestOptions localVarRequestOptions = new edgeapplications.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = edgeapplications.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = edgeapplications.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("edge_application_id", edgeapplications.Client.ClientUtils.ParameterToString(edgeApplicationId)); // path parameter
            localVarRequestOptions.PathParameters.Add("origin_key", edgeapplications.Client.ClientUtils.ParameterToString(originKey)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", edgeapplications.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }

            localVarRequestOptions.Operation = "EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/edge_applications/{edge_application_id}/origins/{origin_key}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_id} 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept">The id of the Origin that you plan to delete. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDeleteAsync(long edgeApplicationId, string originKey, string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDeleteWithHttpInfoAsync(edgeApplicationId, originKey, accept, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_id} 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept">The id of the Origin that you plan to delete. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<edgeapplications.Client.ApiResponse<Object>> EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDeleteWithHttpInfoAsync(long edgeApplicationId, string originKey, string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'originKey' is set
            if (originKey == null)
            {
                throw new edgeapplications.Client.ApiException(400, "Missing required parameter 'originKey' when calling EdgeApplicationsOriginsApi->EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDelete");
            }


            edgeapplications.Client.RequestOptions localVarRequestOptions = new edgeapplications.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = edgeapplications.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = edgeapplications.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("edge_application_id", edgeapplications.Client.ClientUtils.ParameterToString(edgeApplicationId)); // path parameter
            localVarRequestOptions.PathParameters.Add("origin_key", edgeapplications.Client.ClientUtils.ParameterToString(originKey)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", edgeapplications.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }

            localVarRequestOptions.Operation = "EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/edge_applications/{edge_application_id}/origins/{origin_key}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdOriginsOriginKeyDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_key} 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept">The id of the Origin that you plan to query. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OriginsIdResponse</returns>
        public OriginsIdResponse EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGet(long edgeApplicationId, string originKey, string accept = default(string), int operationIndex = 0)
        {
            edgeapplications.Client.ApiResponse<OriginsIdResponse> localVarResponse = EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGetWithHttpInfo(edgeApplicationId, originKey, accept);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_key} 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept">The id of the Origin that you plan to query. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OriginsIdResponse</returns>
        public edgeapplications.Client.ApiResponse<OriginsIdResponse> EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGetWithHttpInfo(long edgeApplicationId, string originKey, string accept = default(string), int operationIndex = 0)
        {
            // verify the required parameter 'originKey' is set
            if (originKey == null)
            {
                throw new edgeapplications.Client.ApiException(400, "Missing required parameter 'originKey' when calling EdgeApplicationsOriginsApi->EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGet");
            }

            edgeapplications.Client.RequestOptions localVarRequestOptions = new edgeapplications.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = edgeapplications.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = edgeapplications.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("edge_application_id", edgeapplications.Client.ClientUtils.ParameterToString(edgeApplicationId)); // path parameter
            localVarRequestOptions.PathParameters.Add("origin_key", edgeapplications.Client.ClientUtils.ParameterToString(originKey)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", edgeapplications.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }

            localVarRequestOptions.Operation = "EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<OriginsIdResponse>("/edge_applications/{edge_application_id}/origins/{origin_key}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_key} 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept">The id of the Origin that you plan to query. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OriginsIdResponse</returns>
        public async System.Threading.Tasks.Task<OriginsIdResponse> EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGetAsync(long edgeApplicationId, string originKey, string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            edgeapplications.Client.ApiResponse<OriginsIdResponse> localVarResponse = await EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGetWithHttpInfoAsync(edgeApplicationId, originKey, accept, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_key} 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept">The id of the Origin that you plan to query. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OriginsIdResponse)</returns>
        public async System.Threading.Tasks.Task<edgeapplications.Client.ApiResponse<OriginsIdResponse>> EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGetWithHttpInfoAsync(long edgeApplicationId, string originKey, string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'originKey' is set
            if (originKey == null)
            {
                throw new edgeapplications.Client.ApiException(400, "Missing required parameter 'originKey' when calling EdgeApplicationsOriginsApi->EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGet");
            }


            edgeapplications.Client.RequestOptions localVarRequestOptions = new edgeapplications.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = edgeapplications.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = edgeapplications.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("edge_application_id", edgeapplications.Client.ClientUtils.ParameterToString(edgeApplicationId)); // path parameter
            localVarRequestOptions.PathParameters.Add("origin_key", edgeapplications.Client.ClientUtils.ParameterToString(originKey)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", edgeapplications.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }

            localVarRequestOptions.Operation = "EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<OriginsIdResponse>("/edge_applications/{edge_application_id}/origins/{origin_key}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdOriginsOriginKeyGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /edge_applications/:edge_application_id:/origins/:origin_id: 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="patchOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OriginsIdResponse</returns>
        public OriginsIdResponse EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatch(long edgeApplicationId, string originKey, string accept = default(string), string contentType = default(string), PatchOriginsRequest patchOriginsRequest = default(PatchOriginsRequest), int operationIndex = 0)
        {
            edgeapplications.Client.ApiResponse<OriginsIdResponse> localVarResponse = EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatchWithHttpInfo(edgeApplicationId, originKey, accept, contentType, patchOriginsRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /edge_applications/:edge_application_id:/origins/:origin_id: 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="patchOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OriginsIdResponse</returns>
        public edgeapplications.Client.ApiResponse<OriginsIdResponse> EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatchWithHttpInfo(long edgeApplicationId, string originKey, string accept = default(string), string contentType = default(string), PatchOriginsRequest patchOriginsRequest = default(PatchOriginsRequest), int operationIndex = 0)
        {
            // verify the required parameter 'originKey' is set
            if (originKey == null)
            {
                throw new edgeapplications.Client.ApiException(400, "Missing required parameter 'originKey' when calling EdgeApplicationsOriginsApi->EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatch");
            }

            edgeapplications.Client.RequestOptions localVarRequestOptions = new edgeapplications.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json; version=3"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = edgeapplications.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = edgeapplications.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("edge_application_id", edgeapplications.Client.ClientUtils.ParameterToString(edgeApplicationId)); // path parameter
            localVarRequestOptions.PathParameters.Add("origin_key", edgeapplications.Client.ClientUtils.ParameterToString(originKey)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", edgeapplications.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }
            if (contentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", edgeapplications.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            }
            localVarRequestOptions.Data = patchOriginsRequest;

            localVarRequestOptions.Operation = "EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatch";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Patch<OriginsIdResponse>("/edge_applications/{edge_application_id}/origins/{origin_key}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatch", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /edge_applications/:edge_application_id:/origins/:origin_id: 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="patchOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OriginsIdResponse</returns>
        public async System.Threading.Tasks.Task<OriginsIdResponse> EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatchAsync(long edgeApplicationId, string originKey, string accept = default(string), string contentType = default(string), PatchOriginsRequest patchOriginsRequest = default(PatchOriginsRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            edgeapplications.Client.ApiResponse<OriginsIdResponse> localVarResponse = await EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatchWithHttpInfoAsync(edgeApplicationId, originKey, accept, contentType, patchOriginsRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /edge_applications/:edge_application_id:/origins/:origin_id: 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="patchOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OriginsIdResponse)</returns>
        public async System.Threading.Tasks.Task<edgeapplications.Client.ApiResponse<OriginsIdResponse>> EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatchWithHttpInfoAsync(long edgeApplicationId, string originKey, string accept = default(string), string contentType = default(string), PatchOriginsRequest patchOriginsRequest = default(PatchOriginsRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'originKey' is set
            if (originKey == null)
            {
                throw new edgeapplications.Client.ApiException(400, "Missing required parameter 'originKey' when calling EdgeApplicationsOriginsApi->EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatch");
            }


            edgeapplications.Client.RequestOptions localVarRequestOptions = new edgeapplications.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json; version=3"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = edgeapplications.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = edgeapplications.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("edge_application_id", edgeapplications.Client.ClientUtils.ParameterToString(edgeApplicationId)); // path parameter
            localVarRequestOptions.PathParameters.Add("origin_key", edgeapplications.Client.ClientUtils.ParameterToString(originKey)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", edgeapplications.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }
            if (contentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", edgeapplications.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            }
            localVarRequestOptions.Data = patchOriginsRequest;

            localVarRequestOptions.Operation = "EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatch";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PatchAsync<OriginsIdResponse>("/edge_applications/{edge_application_id}/origins/{origin_key}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPatch", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_id} 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="updateOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OriginsIdResponse</returns>
        public OriginsIdResponse EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPut(long edgeApplicationId, string originKey, string accept = default(string), string contentType = default(string), UpdateOriginsRequest updateOriginsRequest = default(UpdateOriginsRequest), int operationIndex = 0)
        {
            edgeapplications.Client.ApiResponse<OriginsIdResponse> localVarResponse = EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPutWithHttpInfo(edgeApplicationId, originKey, accept, contentType, updateOriginsRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_id} 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="updateOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OriginsIdResponse</returns>
        public edgeapplications.Client.ApiResponse<OriginsIdResponse> EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPutWithHttpInfo(long edgeApplicationId, string originKey, string accept = default(string), string contentType = default(string), UpdateOriginsRequest updateOriginsRequest = default(UpdateOriginsRequest), int operationIndex = 0)
        {
            // verify the required parameter 'originKey' is set
            if (originKey == null)
            {
                throw new edgeapplications.Client.ApiException(400, "Missing required parameter 'originKey' when calling EdgeApplicationsOriginsApi->EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPut");
            }

            edgeapplications.Client.RequestOptions localVarRequestOptions = new edgeapplications.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json; version=3"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = edgeapplications.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = edgeapplications.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("edge_application_id", edgeapplications.Client.ClientUtils.ParameterToString(edgeApplicationId)); // path parameter
            localVarRequestOptions.PathParameters.Add("origin_key", edgeapplications.Client.ClientUtils.ParameterToString(originKey)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", edgeapplications.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }
            if (contentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", edgeapplications.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            }
            localVarRequestOptions.Data = updateOriginsRequest;

            localVarRequestOptions.Operation = "EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<OriginsIdResponse>("/edge_applications/{edge_application_id}/origins/{origin_key}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_id} 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="updateOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OriginsIdResponse</returns>
        public async System.Threading.Tasks.Task<OriginsIdResponse> EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPutAsync(long edgeApplicationId, string originKey, string accept = default(string), string contentType = default(string), UpdateOriginsRequest updateOriginsRequest = default(UpdateOriginsRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            edgeapplications.Client.ApiResponse<OriginsIdResponse> localVarResponse = await EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPutWithHttpInfoAsync(edgeApplicationId, originKey, accept, contentType, updateOriginsRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins/{origin_id} 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="originKey"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="updateOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OriginsIdResponse)</returns>
        public async System.Threading.Tasks.Task<edgeapplications.Client.ApiResponse<OriginsIdResponse>> EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPutWithHttpInfoAsync(long edgeApplicationId, string originKey, string accept = default(string), string contentType = default(string), UpdateOriginsRequest updateOriginsRequest = default(UpdateOriginsRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'originKey' is set
            if (originKey == null)
            {
                throw new edgeapplications.Client.ApiException(400, "Missing required parameter 'originKey' when calling EdgeApplicationsOriginsApi->EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPut");
            }


            edgeapplications.Client.RequestOptions localVarRequestOptions = new edgeapplications.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json; version=3"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = edgeapplications.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = edgeapplications.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("edge_application_id", edgeapplications.Client.ClientUtils.ParameterToString(edgeApplicationId)); // path parameter
            localVarRequestOptions.PathParameters.Add("origin_key", edgeapplications.Client.ClientUtils.ParameterToString(originKey)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", edgeapplications.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }
            if (contentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", edgeapplications.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            }
            localVarRequestOptions.Data = updateOriginsRequest;

            localVarRequestOptions.Operation = "EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PutAsync<OriginsIdResponse>("/edge_applications/{edge_application_id}/origins/{origin_key}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdOriginsOriginKeyPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="createOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OriginsIdResponse</returns>
        public OriginsIdResponse EdgeApplicationsEdgeApplicationIdOriginsPost(long edgeApplicationId, string accept = default(string), string contentType = default(string), CreateOriginsRequest createOriginsRequest = default(CreateOriginsRequest), int operationIndex = 0)
        {
            edgeapplications.Client.ApiResponse<OriginsIdResponse> localVarResponse = EdgeApplicationsEdgeApplicationIdOriginsPostWithHttpInfo(edgeApplicationId, accept, contentType, createOriginsRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="createOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OriginsIdResponse</returns>
        public edgeapplications.Client.ApiResponse<OriginsIdResponse> EdgeApplicationsEdgeApplicationIdOriginsPostWithHttpInfo(long edgeApplicationId, string accept = default(string), string contentType = default(string), CreateOriginsRequest createOriginsRequest = default(CreateOriginsRequest), int operationIndex = 0)
        {
            edgeapplications.Client.RequestOptions localVarRequestOptions = new edgeapplications.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json; version=3"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = edgeapplications.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = edgeapplications.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("edge_application_id", edgeapplications.Client.ClientUtils.ParameterToString(edgeApplicationId)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", edgeapplications.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }
            if (contentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", edgeapplications.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            }
            localVarRequestOptions.Data = createOriginsRequest;

            localVarRequestOptions.Operation = "EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<OriginsIdResponse>("/edge_applications/{edge_application_id}/origins", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdOriginsPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="createOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OriginsIdResponse</returns>
        public async System.Threading.Tasks.Task<OriginsIdResponse> EdgeApplicationsEdgeApplicationIdOriginsPostAsync(long edgeApplicationId, string accept = default(string), string contentType = default(string), CreateOriginsRequest createOriginsRequest = default(CreateOriginsRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            edgeapplications.Client.ApiResponse<OriginsIdResponse> localVarResponse = await EdgeApplicationsEdgeApplicationIdOriginsPostWithHttpInfoAsync(edgeApplicationId, accept, contentType, createOriginsRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /edge_applications/{edge_application_id}/origins 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="createOriginsRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OriginsIdResponse)</returns>
        public async System.Threading.Tasks.Task<edgeapplications.Client.ApiResponse<OriginsIdResponse>> EdgeApplicationsEdgeApplicationIdOriginsPostWithHttpInfoAsync(long edgeApplicationId, string accept = default(string), string contentType = default(string), CreateOriginsRequest createOriginsRequest = default(CreateOriginsRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            edgeapplications.Client.RequestOptions localVarRequestOptions = new edgeapplications.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json; version=3"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = edgeapplications.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = edgeapplications.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("edge_application_id", edgeapplications.Client.ClientUtils.ParameterToString(edgeApplicationId)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", edgeapplications.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }
            if (contentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", edgeapplications.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            }
            localVarRequestOptions.Data = createOriginsRequest;

            localVarRequestOptions.Operation = "EdgeApplicationsOriginsApi.EdgeApplicationsEdgeApplicationIdOriginsPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<OriginsIdResponse>("/edge_applications/{edge_application_id}/origins", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdOriginsPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
