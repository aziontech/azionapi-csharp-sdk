/*
 * Domain
 *
 * ## Welcome to the Azion API!  With the following APIs you can check, remove or update existing settings, besides creating new ones.  * * *  ## Overview  The Azion API is a RESTful API, based on HTTPS requests, that allows you to integrate your systems with our platform, simply, quickly, and securely.  Here you will find instructions on how our API works and what functionality is available.  This documentation is being constantly updated. Make sure you verify if there are any updates or changes before you perform any development in your application, even if you are familiar with our API.  * * *  Both HTTPS requests and responses must be in JavaScript Object Notation (JSON) format. All HTTPS requests and responses must follow these conventions.  **Base URL**  The base URL of the API, which must be used, is:  [**https://api.azionapi.net/_**](https://api.azionapi.net/)  **HTTP Methods**  Each HTTP method defines the type of operation that will be run.  | HTTP Method | CRUD | Whole Collection (e.g. /items) | Specific Item (e.g. /items/:item_id) | | - -- | - -- | - -- | - -- | | GET | Read | It retrieves the list of items in a Collection. | It retrieves a specific item in a Collection. | | POST | Create | It creates a new item in the Collection. | \\- | | PUT | Update/Replace | It replaces a whole Collection with a new one. | It replaces an item in a Collection with a new one. | | PATCH | Update/Modify | It partially updates a Collection. | It partially updates an item in a Collection | | DELETE | Delete | It deletes a whole Collection. | It deletes an item in a Collection. |  * * *  **Status Codes**  The HTTP return code defines the status – successful or not – after the requested operation is run.  | Status Code | Meaning | | - -- | - -- | | 200 OK | General Status for a successful operation. | | 201 CREATED | Successfully created a collection or item, by means of POST or PUT. | | 204 NO CONTENT | Successful operation, but without any content to be return to the Body. Generally used for DELETE or PUT operations. | | 207 MULTI-STATUS | A batch of operations were triggered by a single request, which resulted in different return codes when it was run, for some of the operations. The codes are displayed in the “status” field, in the body of the response, for each sub-batch of operations for whichever are applicable. | | 400 BAD REQUEST | Request error, such as invalid parameters, missing mandatory parameters or others. | | 401 UNAUTHORIZED | Error caused by a missing HTTP Authentication header. | | 403 FORBIDDEN | User does not have the permissions to run the requested operation. | | 404 NOT FOUND | The requested resource does not exist. | | 405 METHOD NOT ALLOWED | The requested method is not applicable with the URL. | | 406 NOT ACCEPTABLE | Accept header missing from the HTTP request or the header contains formatting or the version is not supported by the API. | | 409 CONFLICT | Conflict generated in running the request, such as a request to create an already existing record. | | 429 TOO MANY REQUESTS | The request was temporarily rejected, due to exceeding the limit on operations. Wait for the time defined in the X-Ratelimit-Reset header and try again. | | 500 INTERNAL SERVER ERROR | Unintentional error, due to an unidentified failure in the request process. | | \\- -- |  | | **HTTP Headers** |  |  All requests must be generated with the HTTP header specifying the desired code format for responses and the API version used. The current version of the API is 3 and the format is application/json.  ``` Accept: application/json; version=3  ```  * * *  **Rate Limit**  The limit of operations that can be run via the API is defined by 3 HTTP response headers:  *   **X-ratelimit-limit:** number of operations allowed in one time-frame; *   **X-ratelimit-remaining:** number of operations still available in one time-frame; *   **X-ratelimit-reset:** is the date and time, in IOS 8601 format, which represents the point in the future when the time-frame will be closed and when the limits will, therefore, be reset.       Example of HTTP response headers and a request:  ``` Date: Thu, 02 Nov 2017 12:30:28 GMT X-ratelimit-remaining: 199 X-ratelimit-limit: 200 X-ratelimit-reset: 2017-11-02T12:31:28.675446  ```  In the example provided, 200 operations are allowed within a 1-minute time frame. Of those, there are 199 still available, because one has already been run. The total limit will be reset after 1 minute.  When the X-ratelimit-limit is reached, or in other words, when the X-ratelimit-remaining reaches zero, the API will give the error, HTTP 429 TOO MANY REQUESTS. If your application receives this error, you will need to wait until the time defined in X-ratelimit-reset has passed, to make another request.  *   **X-ratelimit-limit by product**       The *X-ratelimit limit* variations by product are the following:  *   **Real-Time Metrics:** 20 requests per minute. *   **Real-Time Purge:** 200 requests per minute; except for the Wildcard, which is 2000 a day.       > The rate-limit values are based on the client_id.  * * *  **Optional Parameters**  In this version, it is possible to include some optional parameters as part of the GET method, which can help and modify the form in which your data will be returned.  You can combine these parameters to get the result you want.  They are:  | Parameter | Description | Accepted values: | | - -- | - -- | - -- | | order_by | Identifies which field the return should be sorted by. The default ordering is ascending. | Depends on the fields available from the endpoint structure | | sort | Defines which ordering to be used: ascending or descending. | asc  <br>  <br>desc | | page | Identifies which page should be returned, if the return is paginated. The default value is 1. | Page number. | | page_size | Identifies how many items should be returned per page. The default value is 10. | Desired number of items. |  * * *  **Request Exemple**  You can use one parameter, or a combination. See the example below, which uses all of them in the same request.  ``` GET /domains?order_by=name&page_size=20&sort=desc&page=3 Accept: application/json; version=3 Authorization: token 2909f3932069047f4736dc87e72baaddd19c9f75  ```  * * *  # Authentication  Authentication and authorization of operations via Azion API is done through Tokens.  The first step is to create the Token through authenticating a user registered in [Real-Time Manager](https://sso.azion.com/login).  * * *  ## Encoding Username and Password in Base64  Only token creation and cancelling operations are performed through Basic Authentication, that is, with a username and password. You can create and cancel the token through the API itself, but for that you need to encode your username and password in base64.  Base64 encoding can be done from the command line on a Unix terminal:  ``` $ echo 'user@domain:password'|base64 dXNlckBkb21haW46cGFzc3dvcmQK  ```
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
using domains.Client;
using domains.Model;

namespace domains.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDomainsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// /domains
        /// </summary>
        /// <remarks>
        /// It enables you to include a new domain into an account.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="createDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DomainResponseWithResult</returns>
        DomainResponseWithResult CreateDomain(string accept = default(string), string contentType = default(string), CreateDomainRequest createDomainRequest = default(CreateDomainRequest), int operationIndex = 0);

        /// <summary>
        /// /domains
        /// </summary>
        /// <remarks>
        /// It enables you to include a new domain into an account.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="createDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DomainResponseWithResult</returns>
        ApiResponse<DomainResponseWithResult> CreateDomainWithHttpInfo(string accept = default(string), string contentType = default(string), CreateDomainRequest createDomainRequest = default(CreateDomainRequest), int operationIndex = 0);
        /// <summary>
        /// /domains/:id
        /// </summary>
        /// <remarks>
        /// It enables you to delete a domain.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the domain to be deleted. </param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void DelDomain(string id, string accept = default(string), int operationIndex = 0);

        /// <summary>
        /// /domains/:id
        /// </summary>
        /// <remarks>
        /// It enables you to delete a domain.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the domain to be deleted. </param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DelDomainWithHttpInfo(string id, string accept = default(string), int operationIndex = 0);
        /// <summary>
        /// /domains/:id
        /// </summary>
        /// <remarks>
        /// It returns details of a domain.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the domain to be consulted. </param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DomainResponseWithResult</returns>
        DomainResponseWithResult GetDomain(string id, string accept = default(string), int operationIndex = 0);

        /// <summary>
        /// /domains/:id
        /// </summary>
        /// <remarks>
        /// It returns details of a domain.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the domain to be consulted. </param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DomainResponseWithResult</returns>
        ApiResponse<DomainResponseWithResult> GetDomainWithHttpInfo(string id, string accept = default(string), int operationIndex = 0);
        /// <summary>
        /// /domains
        /// </summary>
        /// <remarks>
        /// It returns the list of domains of an account.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DomainResponseWithResults</returns>
        DomainResponseWithResults GetDomains(string accept = default(string), int operationIndex = 0);

        /// <summary>
        /// /domains
        /// </summary>
        /// <remarks>
        /// It returns the list of domains of an account.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DomainResponseWithResults</returns>
        ApiResponse<DomainResponseWithResults> GetDomainsWithHttpInfo(string accept = default(string), int operationIndex = 0);
        /// <summary>
        /// /domains:/:id
        /// </summary>
        /// <remarks>
        /// It overwrites all fields of a domain, while preserving the id. Optional fields not filled in will be replaced by the default values.  To update only some fields in a domain, consider using the PATCH method instead of PUT.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="putDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DomainResponseWithResult</returns>
        DomainResponseWithResult PutDomain(string id, string accept = default(string), string contentType = default(string), PutDomainRequest putDomainRequest = default(PutDomainRequest), int operationIndex = 0);

        /// <summary>
        /// /domains:/:id
        /// </summary>
        /// <remarks>
        /// It overwrites all fields of a domain, while preserving the id. Optional fields not filled in will be replaced by the default values.  To update only some fields in a domain, consider using the PATCH method instead of PUT.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="putDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DomainResponseWithResult</returns>
        ApiResponse<DomainResponseWithResult> PutDomainWithHttpInfo(string id, string accept = default(string), string contentType = default(string), PutDomainRequest putDomainRequest = default(PutDomainRequest), int operationIndex = 0);
        /// <summary>
        /// /domains/:id
        /// </summary>
        /// <remarks>
        /// It updates one or more fields in a Domain, preserving the value of the fields not informed.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="updateDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DomainResponseWithResult</returns>
        DomainResponseWithResult UpdateDomain(string id, string accept = default(string), string contentType = default(string), UpdateDomainRequest updateDomainRequest = default(UpdateDomainRequest), int operationIndex = 0);

        /// <summary>
        /// /domains/:id
        /// </summary>
        /// <remarks>
        /// It updates one or more fields in a Domain, preserving the value of the fields not informed.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="updateDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DomainResponseWithResult</returns>
        ApiResponse<DomainResponseWithResult> UpdateDomainWithHttpInfo(string id, string accept = default(string), string contentType = default(string), UpdateDomainRequest updateDomainRequest = default(UpdateDomainRequest), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDomainsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// /domains
        /// </summary>
        /// <remarks>
        /// It enables you to include a new domain into an account.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="createDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DomainResponseWithResult</returns>
        System.Threading.Tasks.Task<DomainResponseWithResult> CreateDomainAsync(string accept = default(string), string contentType = default(string), CreateDomainRequest createDomainRequest = default(CreateDomainRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// /domains
        /// </summary>
        /// <remarks>
        /// It enables you to include a new domain into an account.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="createDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DomainResponseWithResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainResponseWithResult>> CreateDomainWithHttpInfoAsync(string accept = default(string), string contentType = default(string), CreateDomainRequest createDomainRequest = default(CreateDomainRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// /domains/:id
        /// </summary>
        /// <remarks>
        /// It enables you to delete a domain.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the domain to be deleted. </param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DelDomainAsync(string id, string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// /domains/:id
        /// </summary>
        /// <remarks>
        /// It enables you to delete a domain.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the domain to be deleted. </param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DelDomainWithHttpInfoAsync(string id, string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// /domains/:id
        /// </summary>
        /// <remarks>
        /// It returns details of a domain.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the domain to be consulted. </param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DomainResponseWithResult</returns>
        System.Threading.Tasks.Task<DomainResponseWithResult> GetDomainAsync(string id, string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// /domains/:id
        /// </summary>
        /// <remarks>
        /// It returns details of a domain.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the domain to be consulted. </param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DomainResponseWithResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainResponseWithResult>> GetDomainWithHttpInfoAsync(string id, string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// /domains
        /// </summary>
        /// <remarks>
        /// It returns the list of domains of an account.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DomainResponseWithResults</returns>
        System.Threading.Tasks.Task<DomainResponseWithResults> GetDomainsAsync(string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// /domains
        /// </summary>
        /// <remarks>
        /// It returns the list of domains of an account.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DomainResponseWithResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainResponseWithResults>> GetDomainsWithHttpInfoAsync(string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// /domains:/:id
        /// </summary>
        /// <remarks>
        /// It overwrites all fields of a domain, while preserving the id. Optional fields not filled in will be replaced by the default values.  To update only some fields in a domain, consider using the PATCH method instead of PUT.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="putDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DomainResponseWithResult</returns>
        System.Threading.Tasks.Task<DomainResponseWithResult> PutDomainAsync(string id, string accept = default(string), string contentType = default(string), PutDomainRequest putDomainRequest = default(PutDomainRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// /domains:/:id
        /// </summary>
        /// <remarks>
        /// It overwrites all fields of a domain, while preserving the id. Optional fields not filled in will be replaced by the default values.  To update only some fields in a domain, consider using the PATCH method instead of PUT.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="putDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DomainResponseWithResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainResponseWithResult>> PutDomainWithHttpInfoAsync(string id, string accept = default(string), string contentType = default(string), PutDomainRequest putDomainRequest = default(PutDomainRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// /domains/:id
        /// </summary>
        /// <remarks>
        /// It updates one or more fields in a Domain, preserving the value of the fields not informed.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="updateDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DomainResponseWithResult</returns>
        System.Threading.Tasks.Task<DomainResponseWithResult> UpdateDomainAsync(string id, string accept = default(string), string contentType = default(string), UpdateDomainRequest updateDomainRequest = default(UpdateDomainRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// /domains/:id
        /// </summary>
        /// <remarks>
        /// It updates one or more fields in a Domain, preserving the value of the fields not informed.
        /// </remarks>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="updateDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DomainResponseWithResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainResponseWithResult>> UpdateDomainWithHttpInfoAsync(string id, string accept = default(string), string contentType = default(string), UpdateDomainRequest updateDomainRequest = default(UpdateDomainRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDomainsApi : IDomainsApiSync, IDomainsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DomainsApi : IDomainsApi
    {
        private domains.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DomainsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DomainsApi(string basePath)
        {
            this.Configuration = domains.Client.Configuration.MergeConfigurations(
                domains.Client.GlobalConfiguration.Instance,
                new domains.Client.Configuration { BasePath = basePath }
            );
            this.Client = new domains.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new domains.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = domains.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DomainsApi(domains.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = domains.Client.Configuration.MergeConfigurations(
                domains.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new domains.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new domains.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = domains.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DomainsApi(domains.Client.ISynchronousClient client, domains.Client.IAsynchronousClient asyncClient, domains.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = domains.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public domains.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public domains.Client.ISynchronousClient Client { get; set; }

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
        public domains.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public domains.Client.ExceptionFactory ExceptionFactory
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
        /// /domains It enables you to include a new domain into an account.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="createDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DomainResponseWithResult</returns>
        public DomainResponseWithResult CreateDomain(string accept = default(string), string contentType = default(string), CreateDomainRequest createDomainRequest = default(CreateDomainRequest), int operationIndex = 0)
        {
            domains.Client.ApiResponse<DomainResponseWithResult> localVarResponse = CreateDomainWithHttpInfo(accept, contentType, createDomainRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /domains It enables you to include a new domain into an account.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="createDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DomainResponseWithResult</returns>
        public domains.Client.ApiResponse<DomainResponseWithResult> CreateDomainWithHttpInfo(string accept = default(string), string contentType = default(string), CreateDomainRequest createDomainRequest = default(CreateDomainRequest), int operationIndex = 0)
        {
            domains.Client.RequestOptions localVarRequestOptions = new domains.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json; version=3"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = domains.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = domains.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", domains.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }
            if (contentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", domains.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            }
            localVarRequestOptions.Data = createDomainRequest;

            localVarRequestOptions.Operation = "DomainsApi.CreateDomain";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<DomainResponseWithResult>("/domains", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateDomain", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /domains It enables you to include a new domain into an account.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="createDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DomainResponseWithResult</returns>
        public async System.Threading.Tasks.Task<DomainResponseWithResult> CreateDomainAsync(string accept = default(string), string contentType = default(string), CreateDomainRequest createDomainRequest = default(CreateDomainRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            domains.Client.ApiResponse<DomainResponseWithResult> localVarResponse = await CreateDomainWithHttpInfoAsync(accept, contentType, createDomainRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /domains It enables you to include a new domain into an account.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="createDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DomainResponseWithResult)</returns>
        public async System.Threading.Tasks.Task<domains.Client.ApiResponse<DomainResponseWithResult>> CreateDomainWithHttpInfoAsync(string accept = default(string), string contentType = default(string), CreateDomainRequest createDomainRequest = default(CreateDomainRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            domains.Client.RequestOptions localVarRequestOptions = new domains.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json; version=3"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = domains.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = domains.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", domains.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }
            if (contentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", domains.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            }
            localVarRequestOptions.Data = createDomainRequest;

            localVarRequestOptions.Operation = "DomainsApi.CreateDomain";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<DomainResponseWithResult>("/domains", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateDomain", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /domains/:id It enables you to delete a domain.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the domain to be deleted. </param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void DelDomain(string id, string accept = default(string), int operationIndex = 0)
        {
            DelDomainWithHttpInfo(id, accept);
        }

        /// <summary>
        /// /domains/:id It enables you to delete a domain.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the domain to be deleted. </param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public domains.Client.ApiResponse<Object> DelDomainWithHttpInfo(string id, string accept = default(string), int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new domains.Client.ApiException(400, "Missing required parameter 'id' when calling DomainsApi->DelDomain");
            }

            domains.Client.RequestOptions localVarRequestOptions = new domains.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = domains.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = domains.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", domains.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", domains.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }

            localVarRequestOptions.Operation = "DomainsApi.DelDomain";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/domains/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DelDomain", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /domains/:id It enables you to delete a domain.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the domain to be deleted. </param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DelDomainAsync(string id, string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await DelDomainWithHttpInfoAsync(id, accept, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// /domains/:id It enables you to delete a domain.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the domain to be deleted. </param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<domains.Client.ApiResponse<Object>> DelDomainWithHttpInfoAsync(string id, string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new domains.Client.ApiException(400, "Missing required parameter 'id' when calling DomainsApi->DelDomain");
            }


            domains.Client.RequestOptions localVarRequestOptions = new domains.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = domains.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = domains.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", domains.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", domains.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }

            localVarRequestOptions.Operation = "DomainsApi.DelDomain";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/domains/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DelDomain", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /domains/:id It returns details of a domain.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the domain to be consulted. </param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DomainResponseWithResult</returns>
        public DomainResponseWithResult GetDomain(string id, string accept = default(string), int operationIndex = 0)
        {
            domains.Client.ApiResponse<DomainResponseWithResult> localVarResponse = GetDomainWithHttpInfo(id, accept);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /domains/:id It returns details of a domain.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the domain to be consulted. </param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DomainResponseWithResult</returns>
        public domains.Client.ApiResponse<DomainResponseWithResult> GetDomainWithHttpInfo(string id, string accept = default(string), int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new domains.Client.ApiException(400, "Missing required parameter 'id' when calling DomainsApi->GetDomain");
            }

            domains.Client.RequestOptions localVarRequestOptions = new domains.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = domains.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = domains.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", domains.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", domains.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }

            localVarRequestOptions.Operation = "DomainsApi.GetDomain";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<DomainResponseWithResult>("/domains/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDomain", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /domains/:id It returns details of a domain.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the domain to be consulted. </param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DomainResponseWithResult</returns>
        public async System.Threading.Tasks.Task<DomainResponseWithResult> GetDomainAsync(string id, string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            domains.Client.ApiResponse<DomainResponseWithResult> localVarResponse = await GetDomainWithHttpInfoAsync(id, accept, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /domains/:id It returns details of a domain.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the domain to be consulted. </param>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DomainResponseWithResult)</returns>
        public async System.Threading.Tasks.Task<domains.Client.ApiResponse<DomainResponseWithResult>> GetDomainWithHttpInfoAsync(string id, string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new domains.Client.ApiException(400, "Missing required parameter 'id' when calling DomainsApi->GetDomain");
            }


            domains.Client.RequestOptions localVarRequestOptions = new domains.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = domains.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = domains.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", domains.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", domains.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }

            localVarRequestOptions.Operation = "DomainsApi.GetDomain";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<DomainResponseWithResult>("/domains/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDomain", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /domains It returns the list of domains of an account.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DomainResponseWithResults</returns>
        public DomainResponseWithResults GetDomains(string accept = default(string), int operationIndex = 0)
        {
            domains.Client.ApiResponse<DomainResponseWithResults> localVarResponse = GetDomainsWithHttpInfo(accept);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /domains It returns the list of domains of an account.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DomainResponseWithResults</returns>
        public domains.Client.ApiResponse<DomainResponseWithResults> GetDomainsWithHttpInfo(string accept = default(string), int operationIndex = 0)
        {
            domains.Client.RequestOptions localVarRequestOptions = new domains.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = domains.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = domains.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", domains.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }

            localVarRequestOptions.Operation = "DomainsApi.GetDomains";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<DomainResponseWithResults>("/domains", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDomains", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /domains It returns the list of domains of an account.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DomainResponseWithResults</returns>
        public async System.Threading.Tasks.Task<DomainResponseWithResults> GetDomainsAsync(string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            domains.Client.ApiResponse<DomainResponseWithResults> localVarResponse = await GetDomainsWithHttpInfoAsync(accept, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /domains It returns the list of domains of an account.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DomainResponseWithResults)</returns>
        public async System.Threading.Tasks.Task<domains.Client.ApiResponse<DomainResponseWithResults>> GetDomainsWithHttpInfoAsync(string accept = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            domains.Client.RequestOptions localVarRequestOptions = new domains.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = domains.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = domains.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", domains.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }

            localVarRequestOptions.Operation = "DomainsApi.GetDomains";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<DomainResponseWithResults>("/domains", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDomains", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /domains:/:id It overwrites all fields of a domain, while preserving the id. Optional fields not filled in will be replaced by the default values.  To update only some fields in a domain, consider using the PATCH method instead of PUT.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="putDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DomainResponseWithResult</returns>
        public DomainResponseWithResult PutDomain(string id, string accept = default(string), string contentType = default(string), PutDomainRequest putDomainRequest = default(PutDomainRequest), int operationIndex = 0)
        {
            domains.Client.ApiResponse<DomainResponseWithResult> localVarResponse = PutDomainWithHttpInfo(id, accept, contentType, putDomainRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /domains:/:id It overwrites all fields of a domain, while preserving the id. Optional fields not filled in will be replaced by the default values.  To update only some fields in a domain, consider using the PATCH method instead of PUT.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="putDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DomainResponseWithResult</returns>
        public domains.Client.ApiResponse<DomainResponseWithResult> PutDomainWithHttpInfo(string id, string accept = default(string), string contentType = default(string), PutDomainRequest putDomainRequest = default(PutDomainRequest), int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new domains.Client.ApiException(400, "Missing required parameter 'id' when calling DomainsApi->PutDomain");
            }

            domains.Client.RequestOptions localVarRequestOptions = new domains.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json; version=3"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = domains.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = domains.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", domains.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", domains.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }
            if (contentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", domains.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            }
            localVarRequestOptions.Data = putDomainRequest;

            localVarRequestOptions.Operation = "DomainsApi.PutDomain";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<DomainResponseWithResult>("/domains/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PutDomain", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /domains:/:id It overwrites all fields of a domain, while preserving the id. Optional fields not filled in will be replaced by the default values.  To update only some fields in a domain, consider using the PATCH method instead of PUT.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="putDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DomainResponseWithResult</returns>
        public async System.Threading.Tasks.Task<DomainResponseWithResult> PutDomainAsync(string id, string accept = default(string), string contentType = default(string), PutDomainRequest putDomainRequest = default(PutDomainRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            domains.Client.ApiResponse<DomainResponseWithResult> localVarResponse = await PutDomainWithHttpInfoAsync(id, accept, contentType, putDomainRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /domains:/:id It overwrites all fields of a domain, while preserving the id. Optional fields not filled in will be replaced by the default values.  To update only some fields in a domain, consider using the PATCH method instead of PUT.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="putDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DomainResponseWithResult)</returns>
        public async System.Threading.Tasks.Task<domains.Client.ApiResponse<DomainResponseWithResult>> PutDomainWithHttpInfoAsync(string id, string accept = default(string), string contentType = default(string), PutDomainRequest putDomainRequest = default(PutDomainRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new domains.Client.ApiException(400, "Missing required parameter 'id' when calling DomainsApi->PutDomain");
            }


            domains.Client.RequestOptions localVarRequestOptions = new domains.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json; version=3"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = domains.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = domains.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", domains.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", domains.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }
            if (contentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", domains.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            }
            localVarRequestOptions.Data = putDomainRequest;

            localVarRequestOptions.Operation = "DomainsApi.PutDomain";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PutAsync<DomainResponseWithResult>("/domains/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PutDomain", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /domains/:id It updates one or more fields in a Domain, preserving the value of the fields not informed.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="updateDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DomainResponseWithResult</returns>
        public DomainResponseWithResult UpdateDomain(string id, string accept = default(string), string contentType = default(string), UpdateDomainRequest updateDomainRequest = default(UpdateDomainRequest), int operationIndex = 0)
        {
            domains.Client.ApiResponse<DomainResponseWithResult> localVarResponse = UpdateDomainWithHttpInfo(id, accept, contentType, updateDomainRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /domains/:id It updates one or more fields in a Domain, preserving the value of the fields not informed.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="updateDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DomainResponseWithResult</returns>
        public domains.Client.ApiResponse<DomainResponseWithResult> UpdateDomainWithHttpInfo(string id, string accept = default(string), string contentType = default(string), UpdateDomainRequest updateDomainRequest = default(UpdateDomainRequest), int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new domains.Client.ApiException(400, "Missing required parameter 'id' when calling DomainsApi->UpdateDomain");
            }

            domains.Client.RequestOptions localVarRequestOptions = new domains.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json; version=3"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = domains.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = domains.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", domains.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", domains.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }
            if (contentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", domains.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            }
            localVarRequestOptions.Data = updateDomainRequest;

            localVarRequestOptions.Operation = "DomainsApi.UpdateDomain";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Patch<DomainResponseWithResult>("/domains/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateDomain", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /domains/:id It updates one or more fields in a Domain, preserving the value of the fields not informed.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="updateDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DomainResponseWithResult</returns>
        public async System.Threading.Tasks.Task<DomainResponseWithResult> UpdateDomainAsync(string id, string accept = default(string), string contentType = default(string), UpdateDomainRequest updateDomainRequest = default(UpdateDomainRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            domains.Client.ApiResponse<DomainResponseWithResult> localVarResponse = await UpdateDomainWithHttpInfoAsync(id, accept, contentType, updateDomainRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /domains/:id It updates one or more fields in a Domain, preserving the value of the fields not informed.
        /// </summary>
        /// <exception cref="domains.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accept"> (optional)</param>
        /// <param name="contentType"> (optional)</param>
        /// <param name="updateDomainRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DomainResponseWithResult)</returns>
        public async System.Threading.Tasks.Task<domains.Client.ApiResponse<DomainResponseWithResult>> UpdateDomainWithHttpInfoAsync(string id, string accept = default(string), string contentType = default(string), UpdateDomainRequest updateDomainRequest = default(UpdateDomainRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new domains.Client.ApiException(400, "Missing required parameter 'id' when calling DomainsApi->UpdateDomain");
            }


            domains.Client.RequestOptions localVarRequestOptions = new domains.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json; version=3"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = domains.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = domains.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", domains.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (accept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", domains.Client.ClientUtils.ParameterToString(accept)); // header parameter
            }
            if (contentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", domains.Client.ClientUtils.ParameterToString(contentType)); // header parameter
            }
            localVarRequestOptions.Data = updateDomainRequest;

            localVarRequestOptions.Operation = "DomainsApi.UpdateDomain";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PatchAsync<DomainResponseWithResult>("/domains/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateDomain", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
