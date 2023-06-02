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
    public interface IEdgeApplicationsEdgeFunctionsInstancesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="functionsInstancesId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDelete(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), int operationIndex = 0);

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="functionsInstancesId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDeleteWithHttpInfo(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), int operationIndex = 0);
        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="functionsInstancesId"></param>
        /// <param name="accept">The id of the edge function instance you plan to query.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationInstancesGetOneResponse</returns>
        ApplicationInstancesGetOneResponse EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGet(long edgeApplicationId, long functionsInstancesId, string accept = default(string), int operationIndex = 0);

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="functionsInstancesId"></param>
        /// <param name="accept">The id of the edge function instance you plan to query.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationInstancesGetOneResponse</returns>
        ApiResponse<ApplicationInstancesGetOneResponse> EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGetWithHttpInfo(long edgeApplicationId, long functionsInstancesId, string accept = default(string), int operationIndex = 0);
        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId">The id of the edge application you plan to overwrite </param>
        /// <param name="functionsInstancesId">The id of the edge function instance you plan to overwrite.</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationUpdateInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationInstanceResults</returns>
        ApplicationInstanceResults EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatch(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), ApplicationUpdateInstanceRequest applicationUpdateInstanceRequest = default(ApplicationUpdateInstanceRequest), int operationIndex = 0);

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId">The id of the edge application you plan to overwrite </param>
        /// <param name="functionsInstancesId">The id of the edge function instance you plan to overwrite.</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationUpdateInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationInstanceResults</returns>
        ApiResponse<ApplicationInstanceResults> EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatchWithHttpInfo(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), ApplicationUpdateInstanceRequest applicationUpdateInstanceRequest = default(ApplicationUpdateInstanceRequest), int operationIndex = 0);
        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId">The id of the edge application you plan to overwrite </param>
        /// <param name="functionsInstancesId">The id of the edge function instance you plan to overwrite.</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationPutInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationInstanceResults</returns>
        ApplicationInstanceResults EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPut(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), ApplicationPutInstanceRequest applicationPutInstanceRequest = default(ApplicationPutInstanceRequest), int operationIndex = 0);

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId">The id of the edge application you plan to overwrite </param>
        /// <param name="functionsInstancesId">The id of the edge function instance you plan to overwrite.</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationPutInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationInstanceResults</returns>
        ApiResponse<ApplicationInstanceResults> EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPutWithHttpInfo(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), ApplicationPutInstanceRequest applicationPutInstanceRequest = default(ApplicationPutInstanceRequest), int operationIndex = 0);
        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances
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
        /// <returns>ApplicationInstancesGetResponse</returns>
        ApplicationInstancesGetResponse EdgeApplicationsEdgeApplicationIdFunctionsInstancesGet(long edgeApplicationId, long? page = default(long?), long? pageSize = default(long?), string filter = default(string), string orderBy = default(string), string sort = default(string), string accept = default(string), int operationIndex = 0);

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances
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
        /// <returns>ApiResponse of ApplicationInstancesGetResponse</returns>
        ApiResponse<ApplicationInstancesGetResponse> EdgeApplicationsEdgeApplicationIdFunctionsInstancesGetWithHttpInfo(long edgeApplicationId, long? page = default(long?), long? pageSize = default(long?), string filter = default(string), string orderBy = default(string), string sort = default(string), string accept = default(string), int operationIndex = 0);
        /// <summary>
        /// edge_application/:edge_application_id:/functions_instances
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationCreateInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationInstanceResults</returns>
        ApplicationInstanceResults EdgeApplicationsEdgeApplicationIdFunctionsInstancesPost(long edgeApplicationId, string accept = default(string), string contentType = default(string), ApplicationCreateInstanceRequest applicationCreateInstanceRequest = default(ApplicationCreateInstanceRequest), int operationIndex = 0);

        /// <summary>
        /// edge_application/:edge_application_id:/functions_instances
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationCreateInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationInstanceResults</returns>
        ApiResponse<ApplicationInstanceResults> EdgeApplicationsEdgeApplicationIdFunctionsInstancesPostWithHttpInfo(long edgeApplicationId, string accept = default(string), string contentType = default(string), ApplicationCreateInstanceRequest applicationCreateInstanceRequest = default(ApplicationCreateInstanceRequest), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEdgeApplicationsEdgeFunctionsInstancesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="functionsInstancesId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDeleteAsync(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="functionsInstancesId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDeleteWithHttpInfoAsync(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="functionsInstancesId"></param>
        /// <param name="accept">The id of the edge function instance you plan to query.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationInstancesGetOneResponse</returns>
        System.Threading.Tasks.Task<ApplicationInstancesGetOneResponse> EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGetAsync(long edgeApplicationId, long functionsInstancesId, string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="functionsInstancesId"></param>
        /// <param name="accept">The id of the edge function instance you plan to query.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationInstancesGetOneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApplicationInstancesGetOneResponse>> EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGetWithHttpInfoAsync(long edgeApplicationId, long functionsInstancesId, string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId">The id of the edge application you plan to overwrite </param>
        /// <param name="functionsInstancesId">The id of the edge function instance you plan to overwrite.</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationUpdateInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationInstanceResults</returns>
        System.Threading.Tasks.Task<ApplicationInstanceResults> EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatchAsync(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), ApplicationUpdateInstanceRequest applicationUpdateInstanceRequest = default(ApplicationUpdateInstanceRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId">The id of the edge application you plan to overwrite </param>
        /// <param name="functionsInstancesId">The id of the edge function instance you plan to overwrite.</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationUpdateInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationInstanceResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApplicationInstanceResults>> EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatchWithHttpInfoAsync(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), ApplicationUpdateInstanceRequest applicationUpdateInstanceRequest = default(ApplicationUpdateInstanceRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId">The id of the edge application you plan to overwrite </param>
        /// <param name="functionsInstancesId">The id of the edge function instance you plan to overwrite.</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationPutInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationInstanceResults</returns>
        System.Threading.Tasks.Task<ApplicationInstanceResults> EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPutAsync(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), ApplicationPutInstanceRequest applicationPutInstanceRequest = default(ApplicationPutInstanceRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id:
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId">The id of the edge application you plan to overwrite </param>
        /// <param name="functionsInstancesId">The id of the edge function instance you plan to overwrite.</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationPutInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationInstanceResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApplicationInstanceResults>> EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPutWithHttpInfoAsync(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), ApplicationPutInstanceRequest applicationPutInstanceRequest = default(ApplicationPutInstanceRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances
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
        /// <returns>Task of ApplicationInstancesGetResponse</returns>
        System.Threading.Tasks.Task<ApplicationInstancesGetResponse> EdgeApplicationsEdgeApplicationIdFunctionsInstancesGetAsync(long edgeApplicationId, long? page = default(long?), long? pageSize = default(long?), string filter = default(string), string orderBy = default(string), string sort = default(string), string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances
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
        /// <returns>Task of ApiResponse (ApplicationInstancesGetResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApplicationInstancesGetResponse>> EdgeApplicationsEdgeApplicationIdFunctionsInstancesGetWithHttpInfoAsync(long edgeApplicationId, long? page = default(long?), long? pageSize = default(long?), string filter = default(string), string orderBy = default(string), string sort = default(string), string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// edge_application/:edge_application_id:/functions_instances
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationCreateInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationInstanceResults</returns>
        System.Threading.Tasks.Task<ApplicationInstanceResults> EdgeApplicationsEdgeApplicationIdFunctionsInstancesPostAsync(long edgeApplicationId, string accept = default(string), string contentType = default(string), ApplicationCreateInstanceRequest applicationCreateInstanceRequest = default(ApplicationCreateInstanceRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// edge_application/:edge_application_id:/functions_instances
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationCreateInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationInstanceResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApplicationInstanceResults>> EdgeApplicationsEdgeApplicationIdFunctionsInstancesPostWithHttpInfoAsync(long edgeApplicationId, string accept = default(string), string contentType = default(string), ApplicationCreateInstanceRequest applicationCreateInstanceRequest = default(ApplicationCreateInstanceRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEdgeApplicationsEdgeFunctionsInstancesApi : IEdgeApplicationsEdgeFunctionsInstancesApiSync, IEdgeApplicationsEdgeFunctionsInstancesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class EdgeApplicationsEdgeFunctionsInstancesApi : IEdgeApplicationsEdgeFunctionsInstancesApi
    {
        private edgeapplications.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeApplicationsEdgeFunctionsInstancesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EdgeApplicationsEdgeFunctionsInstancesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeApplicationsEdgeFunctionsInstancesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EdgeApplicationsEdgeFunctionsInstancesApi(string basePath)
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
        /// Initializes a new instance of the <see cref="EdgeApplicationsEdgeFunctionsInstancesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EdgeApplicationsEdgeFunctionsInstancesApi(edgeapplications.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="EdgeApplicationsEdgeFunctionsInstancesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public EdgeApplicationsEdgeFunctionsInstancesApi(edgeapplications.Client.ISynchronousClient client, edgeapplications.Client.IAsynchronousClient asyncClient, edgeapplications.Client.IReadableConfiguration configuration)
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
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id: 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="functionsInstancesId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDelete(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), int operationIndex = 0)
        {
            EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDeleteWithHttpInfo(edgeApplicationId, functionsInstancesId, accept, contentType);
        }

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id: 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="functionsInstancesId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public edgeapplications.Client.ApiResponse<Object> EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDeleteWithHttpInfo(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), int operationIndex = 0)
        {
            // verify the required parameter 'edgeApplicationId' is set
            if (edgeApplicationId == null)
            {
                throw new edgeapplications.Client.ApiException(400, "Missing required parameter 'edgeApplicationId' when calling EdgeApplicationsEdgeFunctionsInstancesApi->EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDelete");
            }

            // verify the required parameter 'functionsInstancesId' is set
            if (functionsInstancesId == null)
            {
                throw new edgeapplications.Client.ApiException(400, "Missing required parameter 'functionsInstancesId' when calling EdgeApplicationsEdgeFunctionsInstancesApi->EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDelete");
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
            localVarRequestOptions.PathParameters.Add("functions_instances_id", edgeapplications.Client.ClientUtils.ParameterToString(functionsInstancesId)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", edgeapplications.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }
            if (contentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", edgeapplications.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            }

            localVarRequestOptions.Operation = "EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JWT) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/edge_applications/{edge_application_id}/functions_instances/{functions_instances_id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id: 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="functionsInstancesId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDeleteAsync(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDeleteWithHttpInfoAsync(edgeApplicationId, functionsInstancesId, accept, contentType, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id: 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="functionsInstancesId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<edgeapplications.Client.ApiResponse<Object>> EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDeleteWithHttpInfoAsync(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'edgeApplicationId' is set
            if (edgeApplicationId == null)
            {
                throw new edgeapplications.Client.ApiException(400, "Missing required parameter 'edgeApplicationId' when calling EdgeApplicationsEdgeFunctionsInstancesApi->EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDelete");
            }

            // verify the required parameter 'functionsInstancesId' is set
            if (functionsInstancesId == null)
            {
                throw new edgeapplications.Client.ApiException(400, "Missing required parameter 'functionsInstancesId' when calling EdgeApplicationsEdgeFunctionsInstancesApi->EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDelete");
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
            localVarRequestOptions.PathParameters.Add("functions_instances_id", edgeapplications.Client.ClientUtils.ParameterToString(functionsInstancesId)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", edgeapplications.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }
            if (contentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", edgeapplications.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            }

            localVarRequestOptions.Operation = "EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDelete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JWT) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/edge_applications/{edge_application_id}/functions_instances/{functions_instances_id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdDelete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id: 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="functionsInstancesId"></param>
        /// <param name="accept">The id of the edge function instance you plan to query.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationInstancesGetOneResponse</returns>
        public ApplicationInstancesGetOneResponse EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGet(long edgeApplicationId, long functionsInstancesId, string accept = default(string), int operationIndex = 0)
        {
            edgeapplications.Client.ApiResponse<ApplicationInstancesGetOneResponse> localVarResponse = EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGetWithHttpInfo(edgeApplicationId, functionsInstancesId, accept);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id: 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="functionsInstancesId"></param>
        /// <param name="accept">The id of the edge function instance you plan to query.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationInstancesGetOneResponse</returns>
        public edgeapplications.Client.ApiResponse<ApplicationInstancesGetOneResponse> EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGetWithHttpInfo(long edgeApplicationId, long functionsInstancesId, string accept = default(string), int operationIndex = 0)
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
            localVarRequestOptions.PathParameters.Add("functions_instances_id", edgeapplications.Client.ClientUtils.ParameterToString(functionsInstancesId)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", edgeapplications.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }

            localVarRequestOptions.Operation = "EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JWT) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ApplicationInstancesGetOneResponse>("/edge_applications/{edge_application_id}/functions_instances/{functions_instances_id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id: 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="functionsInstancesId"></param>
        /// <param name="accept">The id of the edge function instance you plan to query.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationInstancesGetOneResponse</returns>
        public async System.Threading.Tasks.Task<ApplicationInstancesGetOneResponse> EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGetAsync(long edgeApplicationId, long functionsInstancesId, string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            edgeapplications.Client.ApiResponse<ApplicationInstancesGetOneResponse> localVarResponse = await EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGetWithHttpInfoAsync(edgeApplicationId, functionsInstancesId, accept, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id: 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="functionsInstancesId"></param>
        /// <param name="accept">The id of the edge function instance you plan to query.  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationInstancesGetOneResponse)</returns>
        public async System.Threading.Tasks.Task<edgeapplications.Client.ApiResponse<ApplicationInstancesGetOneResponse>> EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGetWithHttpInfoAsync(long edgeApplicationId, long functionsInstancesId, string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
            localVarRequestOptions.PathParameters.Add("functions_instances_id", edgeapplications.Client.ClientUtils.ParameterToString(functionsInstancesId)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", edgeapplications.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }

            localVarRequestOptions.Operation = "EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JWT) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ApplicationInstancesGetOneResponse>("/edge_applications/{edge_application_id}/functions_instances/{functions_instances_id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id: 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId">The id of the edge application you plan to overwrite </param>
        /// <param name="functionsInstancesId">The id of the edge function instance you plan to overwrite.</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationUpdateInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationInstanceResults</returns>
        public ApplicationInstanceResults EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatch(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), ApplicationUpdateInstanceRequest applicationUpdateInstanceRequest = default(ApplicationUpdateInstanceRequest), int operationIndex = 0)
        {
            edgeapplications.Client.ApiResponse<ApplicationInstanceResults> localVarResponse = EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatchWithHttpInfo(edgeApplicationId, functionsInstancesId, accept, contentType, applicationUpdateInstanceRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id: 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId">The id of the edge application you plan to overwrite </param>
        /// <param name="functionsInstancesId">The id of the edge function instance you plan to overwrite.</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationUpdateInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationInstanceResults</returns>
        public edgeapplications.Client.ApiResponse<ApplicationInstanceResults> EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatchWithHttpInfo(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), ApplicationUpdateInstanceRequest applicationUpdateInstanceRequest = default(ApplicationUpdateInstanceRequest), int operationIndex = 0)
        {
            // verify the required parameter 'edgeApplicationId' is set
            if (edgeApplicationId == null)
            {
                throw new edgeapplications.Client.ApiException(400, "Missing required parameter 'edgeApplicationId' when calling EdgeApplicationsEdgeFunctionsInstancesApi->EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatch");
            }

            // verify the required parameter 'functionsInstancesId' is set
            if (functionsInstancesId == null)
            {
                throw new edgeapplications.Client.ApiException(400, "Missing required parameter 'functionsInstancesId' when calling EdgeApplicationsEdgeFunctionsInstancesApi->EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatch");
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
            localVarRequestOptions.PathParameters.Add("functions_instances_id", edgeapplications.Client.ClientUtils.ParameterToString(functionsInstancesId)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", edgeapplications.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }
            if (contentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", edgeapplications.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            }
            localVarRequestOptions.Data = applicationUpdateInstanceRequest;

            localVarRequestOptions.Operation = "EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatch";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JWT) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Patch<ApplicationInstanceResults>("/edge_applications/{edge_application_id}/functions_instances/{functions_instances_id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatch", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id: 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId">The id of the edge application you plan to overwrite </param>
        /// <param name="functionsInstancesId">The id of the edge function instance you plan to overwrite.</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationUpdateInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationInstanceResults</returns>
        public async System.Threading.Tasks.Task<ApplicationInstanceResults> EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatchAsync(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), ApplicationUpdateInstanceRequest applicationUpdateInstanceRequest = default(ApplicationUpdateInstanceRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            edgeapplications.Client.ApiResponse<ApplicationInstanceResults> localVarResponse = await EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatchWithHttpInfoAsync(edgeApplicationId, functionsInstancesId, accept, contentType, applicationUpdateInstanceRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id: 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId">The id of the edge application you plan to overwrite </param>
        /// <param name="functionsInstancesId">The id of the edge function instance you plan to overwrite.</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationUpdateInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationInstanceResults)</returns>
        public async System.Threading.Tasks.Task<edgeapplications.Client.ApiResponse<ApplicationInstanceResults>> EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatchWithHttpInfoAsync(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), ApplicationUpdateInstanceRequest applicationUpdateInstanceRequest = default(ApplicationUpdateInstanceRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'edgeApplicationId' is set
            if (edgeApplicationId == null)
            {
                throw new edgeapplications.Client.ApiException(400, "Missing required parameter 'edgeApplicationId' when calling EdgeApplicationsEdgeFunctionsInstancesApi->EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatch");
            }

            // verify the required parameter 'functionsInstancesId' is set
            if (functionsInstancesId == null)
            {
                throw new edgeapplications.Client.ApiException(400, "Missing required parameter 'functionsInstancesId' when calling EdgeApplicationsEdgeFunctionsInstancesApi->EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatch");
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
            localVarRequestOptions.PathParameters.Add("functions_instances_id", edgeapplications.Client.ClientUtils.ParameterToString(functionsInstancesId)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", edgeapplications.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }
            if (contentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", edgeapplications.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            }
            localVarRequestOptions.Data = applicationUpdateInstanceRequest;

            localVarRequestOptions.Operation = "EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatch";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JWT) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PatchAsync<ApplicationInstanceResults>("/edge_applications/{edge_application_id}/functions_instances/{functions_instances_id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPatch", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id: 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId">The id of the edge application you plan to overwrite </param>
        /// <param name="functionsInstancesId">The id of the edge function instance you plan to overwrite.</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationPutInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationInstanceResults</returns>
        public ApplicationInstanceResults EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPut(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), ApplicationPutInstanceRequest applicationPutInstanceRequest = default(ApplicationPutInstanceRequest), int operationIndex = 0)
        {
            edgeapplications.Client.ApiResponse<ApplicationInstanceResults> localVarResponse = EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPutWithHttpInfo(edgeApplicationId, functionsInstancesId, accept, contentType, applicationPutInstanceRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id: 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId">The id of the edge application you plan to overwrite </param>
        /// <param name="functionsInstancesId">The id of the edge function instance you plan to overwrite.</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationPutInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationInstanceResults</returns>
        public edgeapplications.Client.ApiResponse<ApplicationInstanceResults> EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPutWithHttpInfo(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), ApplicationPutInstanceRequest applicationPutInstanceRequest = default(ApplicationPutInstanceRequest), int operationIndex = 0)
        {
            // verify the required parameter 'edgeApplicationId' is set
            if (edgeApplicationId == null)
            {
                throw new edgeapplications.Client.ApiException(400, "Missing required parameter 'edgeApplicationId' when calling EdgeApplicationsEdgeFunctionsInstancesApi->EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPut");
            }

            // verify the required parameter 'functionsInstancesId' is set
            if (functionsInstancesId == null)
            {
                throw new edgeapplications.Client.ApiException(400, "Missing required parameter 'functionsInstancesId' when calling EdgeApplicationsEdgeFunctionsInstancesApi->EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPut");
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
            localVarRequestOptions.PathParameters.Add("functions_instances_id", edgeapplications.Client.ClientUtils.ParameterToString(functionsInstancesId)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", edgeapplications.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }
            if (contentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", edgeapplications.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            }
            localVarRequestOptions.Data = applicationPutInstanceRequest;

            localVarRequestOptions.Operation = "EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JWT) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<ApplicationInstanceResults>("/edge_applications/{edge_application_id}/functions_instances/{functions_instances_id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id: 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId">The id of the edge application you plan to overwrite </param>
        /// <param name="functionsInstancesId">The id of the edge function instance you plan to overwrite.</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationPutInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationInstanceResults</returns>
        public async System.Threading.Tasks.Task<ApplicationInstanceResults> EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPutAsync(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), ApplicationPutInstanceRequest applicationPutInstanceRequest = default(ApplicationPutInstanceRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            edgeapplications.Client.ApiResponse<ApplicationInstanceResults> localVarResponse = await EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPutWithHttpInfoAsync(edgeApplicationId, functionsInstancesId, accept, contentType, applicationPutInstanceRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances/:functions_instances_id: 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId">The id of the edge application you plan to overwrite </param>
        /// <param name="functionsInstancesId">The id of the edge function instance you plan to overwrite.</param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationPutInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationInstanceResults)</returns>
        public async System.Threading.Tasks.Task<edgeapplications.Client.ApiResponse<ApplicationInstanceResults>> EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPutWithHttpInfoAsync(string edgeApplicationId, string functionsInstancesId, string accept = default(string), string contentType = default(string), ApplicationPutInstanceRequest applicationPutInstanceRequest = default(ApplicationPutInstanceRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'edgeApplicationId' is set
            if (edgeApplicationId == null)
            {
                throw new edgeapplications.Client.ApiException(400, "Missing required parameter 'edgeApplicationId' when calling EdgeApplicationsEdgeFunctionsInstancesApi->EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPut");
            }

            // verify the required parameter 'functionsInstancesId' is set
            if (functionsInstancesId == null)
            {
                throw new edgeapplications.Client.ApiException(400, "Missing required parameter 'functionsInstancesId' when calling EdgeApplicationsEdgeFunctionsInstancesApi->EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPut");
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
            localVarRequestOptions.PathParameters.Add("functions_instances_id", edgeapplications.Client.ClientUtils.ParameterToString(functionsInstancesId)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", edgeapplications.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }
            if (contentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", edgeapplications.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            }
            localVarRequestOptions.Data = applicationPutInstanceRequest;

            localVarRequestOptions.Operation = "EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPut";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JWT) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PutAsync<ApplicationInstanceResults>("/edge_applications/{edge_application_id}/functions_instances/{functions_instances_id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdFunctionsInstancesFunctionsInstancesIdPut", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances 
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
        /// <returns>ApplicationInstancesGetResponse</returns>
        public ApplicationInstancesGetResponse EdgeApplicationsEdgeApplicationIdFunctionsInstancesGet(long edgeApplicationId, long? page = default(long?), long? pageSize = default(long?), string filter = default(string), string orderBy = default(string), string sort = default(string), string accept = default(string), int operationIndex = 0)
        {
            edgeapplications.Client.ApiResponse<ApplicationInstancesGetResponse> localVarResponse = EdgeApplicationsEdgeApplicationIdFunctionsInstancesGetWithHttpInfo(edgeApplicationId, page, pageSize, filter, orderBy, sort, accept);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances 
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
        /// <returns>ApiResponse of ApplicationInstancesGetResponse</returns>
        public edgeapplications.Client.ApiResponse<ApplicationInstancesGetResponse> EdgeApplicationsEdgeApplicationIdFunctionsInstancesGetWithHttpInfo(long edgeApplicationId, long? page = default(long?), long? pageSize = default(long?), string filter = default(string), string orderBy = default(string), string sort = default(string), string accept = default(string), int operationIndex = 0)
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

            localVarRequestOptions.Operation = "EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JWT) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ApplicationInstancesGetResponse>("/edge_applications/{edge_application_id}/functions_instances", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdFunctionsInstancesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances 
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
        /// <returns>Task of ApplicationInstancesGetResponse</returns>
        public async System.Threading.Tasks.Task<ApplicationInstancesGetResponse> EdgeApplicationsEdgeApplicationIdFunctionsInstancesGetAsync(long edgeApplicationId, long? page = default(long?), long? pageSize = default(long?), string filter = default(string), string orderBy = default(string), string sort = default(string), string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            edgeapplications.Client.ApiResponse<ApplicationInstancesGetResponse> localVarResponse = await EdgeApplicationsEdgeApplicationIdFunctionsInstancesGetWithHttpInfoAsync(edgeApplicationId, page, pageSize, filter, orderBy, sort, accept, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /edge_applications/:edge_application_id:/functions_instances 
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
        /// <returns>Task of ApiResponse (ApplicationInstancesGetResponse)</returns>
        public async System.Threading.Tasks.Task<edgeapplications.Client.ApiResponse<ApplicationInstancesGetResponse>> EdgeApplicationsEdgeApplicationIdFunctionsInstancesGetWithHttpInfoAsync(long edgeApplicationId, long? page = default(long?), long? pageSize = default(long?), string filter = default(string), string orderBy = default(string), string sort = default(string), string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Operation = "EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JWT) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ApplicationInstancesGetResponse>("/edge_applications/{edge_application_id}/functions_instances", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdFunctionsInstancesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// edge_application/:edge_application_id:/functions_instances 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationCreateInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApplicationInstanceResults</returns>
        public ApplicationInstanceResults EdgeApplicationsEdgeApplicationIdFunctionsInstancesPost(long edgeApplicationId, string accept = default(string), string contentType = default(string), ApplicationCreateInstanceRequest applicationCreateInstanceRequest = default(ApplicationCreateInstanceRequest), int operationIndex = 0)
        {
            edgeapplications.Client.ApiResponse<ApplicationInstanceResults> localVarResponse = EdgeApplicationsEdgeApplicationIdFunctionsInstancesPostWithHttpInfo(edgeApplicationId, accept, contentType, applicationCreateInstanceRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// edge_application/:edge_application_id:/functions_instances 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationCreateInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApplicationInstanceResults</returns>
        public edgeapplications.Client.ApiResponse<ApplicationInstanceResults> EdgeApplicationsEdgeApplicationIdFunctionsInstancesPostWithHttpInfo(long edgeApplicationId, string accept = default(string), string contentType = default(string), ApplicationCreateInstanceRequest applicationCreateInstanceRequest = default(ApplicationCreateInstanceRequest), int operationIndex = 0)
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
            localVarRequestOptions.Data = applicationCreateInstanceRequest;

            localVarRequestOptions.Operation = "EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JWT) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<ApplicationInstanceResults>("/edge_applications/{edge_application_id}/functions_instances", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdFunctionsInstancesPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// edge_application/:edge_application_id:/functions_instances 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationCreateInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApplicationInstanceResults</returns>
        public async System.Threading.Tasks.Task<ApplicationInstanceResults> EdgeApplicationsEdgeApplicationIdFunctionsInstancesPostAsync(long edgeApplicationId, string accept = default(string), string contentType = default(string), ApplicationCreateInstanceRequest applicationCreateInstanceRequest = default(ApplicationCreateInstanceRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            edgeapplications.Client.ApiResponse<ApplicationInstanceResults> localVarResponse = await EdgeApplicationsEdgeApplicationIdFunctionsInstancesPostWithHttpInfoAsync(edgeApplicationId, accept, contentType, applicationCreateInstanceRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// edge_application/:edge_application_id:/functions_instances 
        /// </summary>
        /// <exception cref="edgeapplications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="edgeApplicationId"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType">The type of coding used in the Body (application/json). &lt;br&gt;  Example: Content-Type: application/json (optional)</param>
        /// <param name="applicationCreateInstanceRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApplicationInstanceResults)</returns>
        public async System.Threading.Tasks.Task<edgeapplications.Client.ApiResponse<ApplicationInstanceResults>> EdgeApplicationsEdgeApplicationIdFunctionsInstancesPostWithHttpInfoAsync(long edgeApplicationId, string accept = default(string), string contentType = default(string), ApplicationCreateInstanceRequest applicationCreateInstanceRequest = default(ApplicationCreateInstanceRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
            localVarRequestOptions.Data = applicationCreateInstanceRequest;

            localVarRequestOptions.Operation = "EdgeApplicationsEdgeFunctionsInstancesApi.EdgeApplicationsEdgeApplicationIdFunctionsInstancesPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JWT) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<ApplicationInstanceResults>("/edge_applications/{edge_application_id}/functions_instances", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdgeApplicationsEdgeApplicationIdFunctionsInstancesPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
