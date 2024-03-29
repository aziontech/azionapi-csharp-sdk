/*
 * Data Streaming - OpenAPI
 *
 * The Data Streaming API allows you to manage your existing data streamings and templates. Data Streaming allows you to feed your stream processing, SIEM, and big data platforms with the event logs from your applications on Azion in real time. 
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
using data_streaming.Client;
using data_streaming.Model;

namespace data_streaming.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDataStreamingTemplatesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get an global Template info by template ID
        /// </summary>
        /// <remarks>
        /// Use the GET method and add the data streaming&#39;s ID to the URI of the request to get more data on a specific data streaming global template.
        /// </remarks>
        /// <exception cref="data_streaming.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TemplateResultById</returns>
        TemplateResultById GetDataStramingTemplateById(int templateId, int operationIndex = 0);

        /// <summary>
        /// Get an global Template info by template ID
        /// </summary>
        /// <remarks>
        /// Use the GET method and add the data streaming&#39;s ID to the URI of the request to get more data on a specific data streaming global template.
        /// </remarks>
        /// <exception cref="data_streaming.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TemplateResultById</returns>
        ApiResponse<TemplateResultById> GetDataStramingTemplateByIdWithHttpInfo(int templateId, int operationIndex = 0);
        /// <summary>
        /// List all global Templates that can be used on Data Streaming operations
        /// </summary>
        /// <remarks>
        /// Use the GET method to list all global templates that can be used on Data Streaming operations.  **Note:** Customized templates won&#39;t be listed. 
        /// </remarks>
        /// <exception cref="data_streaming.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TemplateResults</returns>
        TemplateResults ListDataStreamingTemplates(int operationIndex = 0);

        /// <summary>
        /// List all global Templates that can be used on Data Streaming operations
        /// </summary>
        /// <remarks>
        /// Use the GET method to list all global templates that can be used on Data Streaming operations.  **Note:** Customized templates won&#39;t be listed. 
        /// </remarks>
        /// <exception cref="data_streaming.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TemplateResults</returns>
        ApiResponse<TemplateResults> ListDataStreamingTemplatesWithHttpInfo(int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDataStreamingTemplatesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get an global Template info by template ID
        /// </summary>
        /// <remarks>
        /// Use the GET method and add the data streaming&#39;s ID to the URI of the request to get more data on a specific data streaming global template.
        /// </remarks>
        /// <exception cref="data_streaming.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TemplateResultById</returns>
        System.Threading.Tasks.Task<TemplateResultById> GetDataStramingTemplateByIdAsync(int templateId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get an global Template info by template ID
        /// </summary>
        /// <remarks>
        /// Use the GET method and add the data streaming&#39;s ID to the URI of the request to get more data on a specific data streaming global template.
        /// </remarks>
        /// <exception cref="data_streaming.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TemplateResultById)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateResultById>> GetDataStramingTemplateByIdWithHttpInfoAsync(int templateId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// List all global Templates that can be used on Data Streaming operations
        /// </summary>
        /// <remarks>
        /// Use the GET method to list all global templates that can be used on Data Streaming operations.  **Note:** Customized templates won&#39;t be listed. 
        /// </remarks>
        /// <exception cref="data_streaming.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TemplateResults</returns>
        System.Threading.Tasks.Task<TemplateResults> ListDataStreamingTemplatesAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List all global Templates that can be used on Data Streaming operations
        /// </summary>
        /// <remarks>
        /// Use the GET method to list all global templates that can be used on Data Streaming operations.  **Note:** Customized templates won&#39;t be listed. 
        /// </remarks>
        /// <exception cref="data_streaming.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TemplateResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateResults>> ListDataStreamingTemplatesWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDataStreamingTemplatesApi : IDataStreamingTemplatesApiSync, IDataStreamingTemplatesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DataStreamingTemplatesApi : IDataStreamingTemplatesApi
    {
        private data_streaming.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataStreamingTemplatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DataStreamingTemplatesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataStreamingTemplatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DataStreamingTemplatesApi(string basePath)
        {
            this.Configuration = data_streaming.Client.Configuration.MergeConfigurations(
                data_streaming.Client.GlobalConfiguration.Instance,
                new data_streaming.Client.Configuration { BasePath = basePath }
            );
            this.Client = new data_streaming.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new data_streaming.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = data_streaming.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataStreamingTemplatesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DataStreamingTemplatesApi(data_streaming.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = data_streaming.Client.Configuration.MergeConfigurations(
                data_streaming.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new data_streaming.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new data_streaming.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = data_streaming.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataStreamingTemplatesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DataStreamingTemplatesApi(data_streaming.Client.ISynchronousClient client, data_streaming.Client.IAsynchronousClient asyncClient, data_streaming.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = data_streaming.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public data_streaming.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public data_streaming.Client.ISynchronousClient Client { get; set; }

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
        public data_streaming.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public data_streaming.Client.ExceptionFactory ExceptionFactory
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
        /// Get an global Template info by template ID Use the GET method and add the data streaming&#39;s ID to the URI of the request to get more data on a specific data streaming global template.
        /// </summary>
        /// <exception cref="data_streaming.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TemplateResultById</returns>
        public TemplateResultById GetDataStramingTemplateById(int templateId, int operationIndex = 0)
        {
            data_streaming.Client.ApiResponse<TemplateResultById> localVarResponse = GetDataStramingTemplateByIdWithHttpInfo(templateId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get an global Template info by template ID Use the GET method and add the data streaming&#39;s ID to the URI of the request to get more data on a specific data streaming global template.
        /// </summary>
        /// <exception cref="data_streaming.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TemplateResultById</returns>
        public data_streaming.Client.ApiResponse<TemplateResultById> GetDataStramingTemplateByIdWithHttpInfo(int templateId, int operationIndex = 0)
        {
            data_streaming.Client.RequestOptions localVarRequestOptions = new data_streaming.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = data_streaming.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = data_streaming.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("template_id", data_streaming.Client.ClientUtils.ParameterToString(templateId)); // path parameter

            localVarRequestOptions.Operation = "DataStreamingTemplatesApi.GetDataStramingTemplateById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<TemplateResultById>("/data_streaming/templates/{template_id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDataStramingTemplateById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get an global Template info by template ID Use the GET method and add the data streaming&#39;s ID to the URI of the request to get more data on a specific data streaming global template.
        /// </summary>
        /// <exception cref="data_streaming.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TemplateResultById</returns>
        public async System.Threading.Tasks.Task<TemplateResultById> GetDataStramingTemplateByIdAsync(int templateId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            data_streaming.Client.ApiResponse<TemplateResultById> localVarResponse = await GetDataStramingTemplateByIdWithHttpInfoAsync(templateId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get an global Template info by template ID Use the GET method and add the data streaming&#39;s ID to the URI of the request to get more data on a specific data streaming global template.
        /// </summary>
        /// <exception cref="data_streaming.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TemplateResultById)</returns>
        public async System.Threading.Tasks.Task<data_streaming.Client.ApiResponse<TemplateResultById>> GetDataStramingTemplateByIdWithHttpInfoAsync(int templateId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            data_streaming.Client.RequestOptions localVarRequestOptions = new data_streaming.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = data_streaming.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = data_streaming.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("template_id", data_streaming.Client.ClientUtils.ParameterToString(templateId)); // path parameter

            localVarRequestOptions.Operation = "DataStreamingTemplatesApi.GetDataStramingTemplateById";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<TemplateResultById>("/data_streaming/templates/{template_id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetDataStramingTemplateById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all global Templates that can be used on Data Streaming operations Use the GET method to list all global templates that can be used on Data Streaming operations.  **Note:** Customized templates won&#39;t be listed. 
        /// </summary>
        /// <exception cref="data_streaming.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TemplateResults</returns>
        public TemplateResults ListDataStreamingTemplates(int operationIndex = 0)
        {
            data_streaming.Client.ApiResponse<TemplateResults> localVarResponse = ListDataStreamingTemplatesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all global Templates that can be used on Data Streaming operations Use the GET method to list all global templates that can be used on Data Streaming operations.  **Note:** Customized templates won&#39;t be listed. 
        /// </summary>
        /// <exception cref="data_streaming.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TemplateResults</returns>
        public data_streaming.Client.ApiResponse<TemplateResults> ListDataStreamingTemplatesWithHttpInfo(int operationIndex = 0)
        {
            data_streaming.Client.RequestOptions localVarRequestOptions = new data_streaming.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = data_streaming.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = data_streaming.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "DataStreamingTemplatesApi.ListDataStreamingTemplates";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<TemplateResults>("/data_streaming/templates", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListDataStreamingTemplates", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all global Templates that can be used on Data Streaming operations Use the GET method to list all global templates that can be used on Data Streaming operations.  **Note:** Customized templates won&#39;t be listed. 
        /// </summary>
        /// <exception cref="data_streaming.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TemplateResults</returns>
        public async System.Threading.Tasks.Task<TemplateResults> ListDataStreamingTemplatesAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            data_streaming.Client.ApiResponse<TemplateResults> localVarResponse = await ListDataStreamingTemplatesWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all global Templates that can be used on Data Streaming operations Use the GET method to list all global templates that can be used on Data Streaming operations.  **Note:** Customized templates won&#39;t be listed. 
        /// </summary>
        /// <exception cref="data_streaming.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TemplateResults)</returns>
        public async System.Threading.Tasks.Task<data_streaming.Client.ApiResponse<TemplateResults>> ListDataStreamingTemplatesWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            data_streaming.Client.RequestOptions localVarRequestOptions = new data_streaming.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = data_streaming.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = data_streaming.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "DataStreamingTemplatesApi.ListDataStreamingTemplates";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<TemplateResults>("/data_streaming/templates", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListDataStreamingTemplates", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
