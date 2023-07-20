/*
 * Digital Certificates API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using digital_certificates.Client;
using digital_certificates.Model;

namespace digital_certificates.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRetrieveDigitalCertificateListApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List all existing digital certificates and CSRs registered to your account
        /// </summary>
        /// <exception cref="digital_certificates.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderBy">Response field to order by, current options are \&quot;name\&quot; or \&quot;id\&quot; (optional, default to id)</param>
        /// <param name="sort">Sorting direction (optional, default to asc)</param>
        /// <param name="name">Searches certificate for name (optional)</param>
        /// <param name="search">Searches for string in certificate name (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DC200List</returns>
        DC200List ListDigitalCertificates(string orderBy = default(string), string sort = default(string), string name = default(string), string search = default(string), int operationIndex = 0);

        /// <summary>
        /// List all existing digital certificates and CSRs registered to your account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="digital_certificates.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderBy">Response field to order by, current options are \&quot;name\&quot; or \&quot;id\&quot; (optional, default to id)</param>
        /// <param name="sort">Sorting direction (optional, default to asc)</param>
        /// <param name="name">Searches certificate for name (optional)</param>
        /// <param name="search">Searches for string in certificate name (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DC200List</returns>
        ApiResponse<DC200List> ListDigitalCertificatesWithHttpInfo(string orderBy = default(string), string sort = default(string), string name = default(string), string search = default(string), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRetrieveDigitalCertificateListApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// List all existing digital certificates and CSRs registered to your account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="digital_certificates.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderBy">Response field to order by, current options are \&quot;name\&quot; or \&quot;id\&quot; (optional, default to id)</param>
        /// <param name="sort">Sorting direction (optional, default to asc)</param>
        /// <param name="name">Searches certificate for name (optional)</param>
        /// <param name="search">Searches for string in certificate name (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DC200List</returns>
        System.Threading.Tasks.Task<DC200List> ListDigitalCertificatesAsync(string orderBy = default(string), string sort = default(string), string name = default(string), string search = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List all existing digital certificates and CSRs registered to your account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="digital_certificates.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderBy">Response field to order by, current options are \&quot;name\&quot; or \&quot;id\&quot; (optional, default to id)</param>
        /// <param name="sort">Sorting direction (optional, default to asc)</param>
        /// <param name="name">Searches certificate for name (optional)</param>
        /// <param name="search">Searches for string in certificate name (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DC200List)</returns>
        System.Threading.Tasks.Task<ApiResponse<DC200List>> ListDigitalCertificatesWithHttpInfoAsync(string orderBy = default(string), string sort = default(string), string name = default(string), string search = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRetrieveDigitalCertificateListApi : IRetrieveDigitalCertificateListApiSync, IRetrieveDigitalCertificateListApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RetrieveDigitalCertificateListApi : IRetrieveDigitalCertificateListApi
    {
        private digital_certificates.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveDigitalCertificateListApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RetrieveDigitalCertificateListApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveDigitalCertificateListApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RetrieveDigitalCertificateListApi(string basePath)
        {
            this.Configuration = digital_certificates.Client.Configuration.MergeConfigurations(
                digital_certificates.Client.GlobalConfiguration.Instance,
                new digital_certificates.Client.Configuration { BasePath = basePath }
            );
            this.Client = new digital_certificates.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new digital_certificates.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = digital_certificates.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveDigitalCertificateListApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RetrieveDigitalCertificateListApi(digital_certificates.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = digital_certificates.Client.Configuration.MergeConfigurations(
                digital_certificates.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new digital_certificates.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new digital_certificates.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = digital_certificates.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveDigitalCertificateListApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public RetrieveDigitalCertificateListApi(digital_certificates.Client.ISynchronousClient client, digital_certificates.Client.IAsynchronousClient asyncClient, digital_certificates.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = digital_certificates.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public digital_certificates.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public digital_certificates.Client.ISynchronousClient Client { get; set; }

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
        public digital_certificates.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public digital_certificates.Client.ExceptionFactory ExceptionFactory
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
        /// List all existing digital certificates and CSRs registered to your account 
        /// </summary>
        /// <exception cref="digital_certificates.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderBy">Response field to order by, current options are \&quot;name\&quot; or \&quot;id\&quot; (optional, default to id)</param>
        /// <param name="sort">Sorting direction (optional, default to asc)</param>
        /// <param name="name">Searches certificate for name (optional)</param>
        /// <param name="search">Searches for string in certificate name (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>DC200List</returns>
        public DC200List ListDigitalCertificates(string orderBy = default(string), string sort = default(string), string name = default(string), string search = default(string), int operationIndex = 0)
        {
            digital_certificates.Client.ApiResponse<DC200List> localVarResponse = ListDigitalCertificatesWithHttpInfo(orderBy, sort, name, search);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all existing digital certificates and CSRs registered to your account 
        /// </summary>
        /// <exception cref="digital_certificates.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderBy">Response field to order by, current options are \&quot;name\&quot; or \&quot;id\&quot; (optional, default to id)</param>
        /// <param name="sort">Sorting direction (optional, default to asc)</param>
        /// <param name="name">Searches certificate for name (optional)</param>
        /// <param name="search">Searches for string in certificate name (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of DC200List</returns>
        public digital_certificates.Client.ApiResponse<DC200List> ListDigitalCertificatesWithHttpInfo(string orderBy = default(string), string sort = default(string), string name = default(string), string search = default(string), int operationIndex = 0)
        {
            digital_certificates.Client.RequestOptions localVarRequestOptions = new digital_certificates.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = digital_certificates.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = digital_certificates.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(digital_certificates.Client.ClientUtils.ParameterToMultiMap("", "order_by", orderBy));
            }
            if (sort != null)
            {
                localVarRequestOptions.QueryParameters.Add(digital_certificates.Client.ClientUtils.ParameterToMultiMap("", "sort", sort));
            }
            if (name != null)
            {
                localVarRequestOptions.QueryParameters.Add(digital_certificates.Client.ClientUtils.ParameterToMultiMap("", "name", name));
            }
            if (search != null)
            {
                localVarRequestOptions.QueryParameters.Add(digital_certificates.Client.ClientUtils.ParameterToMultiMap("", "search", search));
            }

            localVarRequestOptions.Operation = "RetrieveDigitalCertificateListApi.ListDigitalCertificates";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<DC200List>("/digital_certificates", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListDigitalCertificates", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all existing digital certificates and CSRs registered to your account 
        /// </summary>
        /// <exception cref="digital_certificates.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderBy">Response field to order by, current options are \&quot;name\&quot; or \&quot;id\&quot; (optional, default to id)</param>
        /// <param name="sort">Sorting direction (optional, default to asc)</param>
        /// <param name="name">Searches certificate for name (optional)</param>
        /// <param name="search">Searches for string in certificate name (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DC200List</returns>
        public async System.Threading.Tasks.Task<DC200List> ListDigitalCertificatesAsync(string orderBy = default(string), string sort = default(string), string name = default(string), string search = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            digital_certificates.Client.ApiResponse<DC200List> localVarResponse = await ListDigitalCertificatesWithHttpInfoAsync(orderBy, sort, name, search, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all existing digital certificates and CSRs registered to your account 
        /// </summary>
        /// <exception cref="digital_certificates.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderBy">Response field to order by, current options are \&quot;name\&quot; or \&quot;id\&quot; (optional, default to id)</param>
        /// <param name="sort">Sorting direction (optional, default to asc)</param>
        /// <param name="name">Searches certificate for name (optional)</param>
        /// <param name="search">Searches for string in certificate name (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DC200List)</returns>
        public async System.Threading.Tasks.Task<digital_certificates.Client.ApiResponse<DC200List>> ListDigitalCertificatesWithHttpInfoAsync(string orderBy = default(string), string sort = default(string), string name = default(string), string search = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            digital_certificates.Client.RequestOptions localVarRequestOptions = new digital_certificates.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = digital_certificates.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = digital_certificates.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(digital_certificates.Client.ClientUtils.ParameterToMultiMap("", "order_by", orderBy));
            }
            if (sort != null)
            {
                localVarRequestOptions.QueryParameters.Add(digital_certificates.Client.ClientUtils.ParameterToMultiMap("", "sort", sort));
            }
            if (name != null)
            {
                localVarRequestOptions.QueryParameters.Add(digital_certificates.Client.ClientUtils.ParameterToMultiMap("", "name", name));
            }
            if (search != null)
            {
                localVarRequestOptions.QueryParameters.Add(digital_certificates.Client.ClientUtils.ParameterToMultiMap("", "search", search));
            }

            localVarRequestOptions.Operation = "RetrieveDigitalCertificateListApi.ListDigitalCertificates";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<DC200List>("/digital_certificates", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListDigitalCertificates", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
