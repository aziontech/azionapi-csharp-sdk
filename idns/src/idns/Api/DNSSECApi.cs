/*
 * Intelligent DNS
 *
 * Azion Intelligent DNS API
 *
 * The version of the OpenAPI document: 3.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using idns.Client;
using idns.Model;

namespace idns.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDNSSECApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve the DNSSEC zone status
        /// </summary>
        /// <exception cref="idns.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zoneId">The hosted zone id</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetOrPatchDnsSecResponse</returns>
        GetOrPatchDnsSecResponse GetZoneDnsSec(int zoneId, int operationIndex = 0);

        /// <summary>
        /// Retrieve the DNSSEC zone status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="idns.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zoneId">The hosted zone id</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetOrPatchDnsSecResponse</returns>
        ApiResponse<GetOrPatchDnsSecResponse> GetZoneDnsSecWithHttpInfo(int zoneId, int operationIndex = 0);
        /// <summary>
        /// Update the DNSSEC zone
        /// </summary>
        /// <exception cref="idns.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zoneId">The hosted zone id</param>
        /// <param name="dnsSec"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetOrPatchDnsSecResponse</returns>
        GetOrPatchDnsSecResponse PutZoneDnsSec(int zoneId, DnsSec dnsSec = default(DnsSec), int operationIndex = 0);

        /// <summary>
        /// Update the DNSSEC zone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="idns.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zoneId">The hosted zone id</param>
        /// <param name="dnsSec"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetOrPatchDnsSecResponse</returns>
        ApiResponse<GetOrPatchDnsSecResponse> PutZoneDnsSecWithHttpInfo(int zoneId, DnsSec dnsSec = default(DnsSec), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDNSSECApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve the DNSSEC zone status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="idns.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zoneId">The hosted zone id</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetOrPatchDnsSecResponse</returns>
        System.Threading.Tasks.Task<GetOrPatchDnsSecResponse> GetZoneDnsSecAsync(int zoneId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve the DNSSEC zone status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="idns.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zoneId">The hosted zone id</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetOrPatchDnsSecResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetOrPatchDnsSecResponse>> GetZoneDnsSecWithHttpInfoAsync(int zoneId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Update the DNSSEC zone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="idns.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zoneId">The hosted zone id</param>
        /// <param name="dnsSec"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetOrPatchDnsSecResponse</returns>
        System.Threading.Tasks.Task<GetOrPatchDnsSecResponse> PutZoneDnsSecAsync(int zoneId, DnsSec dnsSec = default(DnsSec), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Update the DNSSEC zone
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="idns.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zoneId">The hosted zone id</param>
        /// <param name="dnsSec"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetOrPatchDnsSecResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetOrPatchDnsSecResponse>> PutZoneDnsSecWithHttpInfoAsync(int zoneId, DnsSec dnsSec = default(DnsSec), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDNSSECApi : IDNSSECApiSync, IDNSSECApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DNSSECApi : IDNSSECApi
    {
        private idns.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DNSSECApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DNSSECApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DNSSECApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DNSSECApi(string basePath)
        {
            this.Configuration = idns.Client.Configuration.MergeConfigurations(
                idns.Client.GlobalConfiguration.Instance,
                new idns.Client.Configuration { BasePath = basePath }
            );
            this.Client = new idns.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new idns.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = idns.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DNSSECApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DNSSECApi(idns.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = idns.Client.Configuration.MergeConfigurations(
                idns.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new idns.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new idns.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = idns.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DNSSECApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DNSSECApi(idns.Client.ISynchronousClient client, idns.Client.IAsynchronousClient asyncClient, idns.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = idns.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public idns.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public idns.Client.ISynchronousClient Client { get; set; }

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
        public idns.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public idns.Client.ExceptionFactory ExceptionFactory
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
        /// Retrieve the DNSSEC zone status 
        /// </summary>
        /// <exception cref="idns.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zoneId">The hosted zone id</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetOrPatchDnsSecResponse</returns>
        public GetOrPatchDnsSecResponse GetZoneDnsSec(int zoneId, int operationIndex = 0)
        {
            idns.Client.ApiResponse<GetOrPatchDnsSecResponse> localVarResponse = GetZoneDnsSecWithHttpInfo(zoneId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the DNSSEC zone status 
        /// </summary>
        /// <exception cref="idns.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zoneId">The hosted zone id</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetOrPatchDnsSecResponse</returns>
        public idns.Client.ApiResponse<GetOrPatchDnsSecResponse> GetZoneDnsSecWithHttpInfo(int zoneId, int operationIndex = 0)
        {
            idns.Client.RequestOptions localVarRequestOptions = new idns.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = idns.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = idns.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("zone_id", idns.Client.ClientUtils.ParameterToString(zoneId)); // path parameter

            localVarRequestOptions.Operation = "DNSSECApi.GetZoneDnsSec";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<GetOrPatchDnsSecResponse>("/intelligent_dns/{zone_id}/dnssec", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetZoneDnsSec", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve the DNSSEC zone status 
        /// </summary>
        /// <exception cref="idns.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zoneId">The hosted zone id</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetOrPatchDnsSecResponse</returns>
        public async System.Threading.Tasks.Task<GetOrPatchDnsSecResponse> GetZoneDnsSecAsync(int zoneId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            idns.Client.ApiResponse<GetOrPatchDnsSecResponse> localVarResponse = await GetZoneDnsSecWithHttpInfoAsync(zoneId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the DNSSEC zone status 
        /// </summary>
        /// <exception cref="idns.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zoneId">The hosted zone id</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetOrPatchDnsSecResponse)</returns>
        public async System.Threading.Tasks.Task<idns.Client.ApiResponse<GetOrPatchDnsSecResponse>> GetZoneDnsSecWithHttpInfoAsync(int zoneId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            idns.Client.RequestOptions localVarRequestOptions = new idns.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = idns.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = idns.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("zone_id", idns.Client.ClientUtils.ParameterToString(zoneId)); // path parameter

            localVarRequestOptions.Operation = "DNSSECApi.GetZoneDnsSec";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<GetOrPatchDnsSecResponse>("/intelligent_dns/{zone_id}/dnssec", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetZoneDnsSec", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the DNSSEC zone 
        /// </summary>
        /// <exception cref="idns.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zoneId">The hosted zone id</param>
        /// <param name="dnsSec"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetOrPatchDnsSecResponse</returns>
        public GetOrPatchDnsSecResponse PutZoneDnsSec(int zoneId, DnsSec dnsSec = default(DnsSec), int operationIndex = 0)
        {
            idns.Client.ApiResponse<GetOrPatchDnsSecResponse> localVarResponse = PutZoneDnsSecWithHttpInfo(zoneId, dnsSec);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update the DNSSEC zone 
        /// </summary>
        /// <exception cref="idns.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zoneId">The hosted zone id</param>
        /// <param name="dnsSec"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetOrPatchDnsSecResponse</returns>
        public idns.Client.ApiResponse<GetOrPatchDnsSecResponse> PutZoneDnsSecWithHttpInfo(int zoneId, DnsSec dnsSec = default(DnsSec), int operationIndex = 0)
        {
            idns.Client.RequestOptions localVarRequestOptions = new idns.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = idns.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = idns.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("zone_id", idns.Client.ClientUtils.ParameterToString(zoneId)); // path parameter
            localVarRequestOptions.Data = dnsSec;

            localVarRequestOptions.Operation = "DNSSECApi.PutZoneDnsSec";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Patch<GetOrPatchDnsSecResponse>("/intelligent_dns/{zone_id}/dnssec", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PutZoneDnsSec", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the DNSSEC zone 
        /// </summary>
        /// <exception cref="idns.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zoneId">The hosted zone id</param>
        /// <param name="dnsSec"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetOrPatchDnsSecResponse</returns>
        public async System.Threading.Tasks.Task<GetOrPatchDnsSecResponse> PutZoneDnsSecAsync(int zoneId, DnsSec dnsSec = default(DnsSec), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            idns.Client.ApiResponse<GetOrPatchDnsSecResponse> localVarResponse = await PutZoneDnsSecWithHttpInfoAsync(zoneId, dnsSec, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update the DNSSEC zone 
        /// </summary>
        /// <exception cref="idns.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zoneId">The hosted zone id</param>
        /// <param name="dnsSec"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetOrPatchDnsSecResponse)</returns>
        public async System.Threading.Tasks.Task<idns.Client.ApiResponse<GetOrPatchDnsSecResponse>> PutZoneDnsSecWithHttpInfoAsync(int zoneId, DnsSec dnsSec = default(DnsSec), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            idns.Client.RequestOptions localVarRequestOptions = new idns.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = idns.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = idns.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("zone_id", idns.Client.ClientUtils.ParameterToString(zoneId)); // path parameter
            localVarRequestOptions.Data = dnsSec;

            localVarRequestOptions.Operation = "DNSSECApi.PutZoneDnsSec";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PatchAsync<GetOrPatchDnsSecResponse>("/intelligent_dns/{zone_id}/dnssec", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PutZoneDnsSec", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
