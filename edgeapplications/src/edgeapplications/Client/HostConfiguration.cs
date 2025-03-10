/*
 * Edge Application API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using edgeapplications.Api;
using edgeapplications.Model;

namespace edgeapplications.Client
{
    /// <summary>
    /// Provides hosting configuration for edgeapplications
    /// </summary>
    public class HostConfiguration
    {
        private readonly IServiceCollection _services;
        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions();

        internal bool HttpClientsAdded { get; private set; }

        /// <summary>
        /// Instantiates the class 
        /// </summary>
        /// <param name="services"></param>
        public HostConfiguration(IServiceCollection services)
        {
            _services = services;
            _jsonOptions.Converters.Add(new JsonStringEnumConverter());
            _jsonOptions.Converters.Add(new DateTimeJsonConverter());
            _jsonOptions.Converters.Add(new DateTimeNullableJsonConverter());
            _jsonOptions.Converters.Add(new DateOnlyJsonConverter());
            _jsonOptions.Converters.Add(new DateOnlyNullableJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationCacheCreateRequestJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationCacheCreateResponseJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationCacheCreateResultsJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationCacheGetOneResponseJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationCacheGetResponseJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationCachePatchRequestJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationCachePatchResponseJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationCachePutRequestJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationCachePutResponseJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationCacheResponseDetailsJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationCacheResultsJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationCreateInstanceRequestJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationCreateInstanceRequestArgsJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationInstanceResultsJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationInstancesGetOneResponseJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationInstancesGetResponseJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationInstancesResultsJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationLinksJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationOriginsJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationPutInstanceRequestJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationPutRequestJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationPutResultJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationResultsJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationResultsCreateJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationUpdateInstanceRequestJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationUpdateRequestJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationUpdateResponseJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationUpdateResultsJsonConverter());
            _jsonOptions.Converters.Add(new ApplicationsResultsJsonConverter());
            _jsonOptions.Converters.Add(new CreateApplicationRequestJsonConverter());
            _jsonOptions.Converters.Add(new CreateApplicationResultJsonConverter());
            _jsonOptions.Converters.Add(new CreateDeviceGroupsRequestJsonConverter());
            _jsonOptions.Converters.Add(new CreateOriginsRequestJsonConverter());
            _jsonOptions.Converters.Add(new CreateOriginsRequestAddressesJsonConverter());
            _jsonOptions.Converters.Add(new CreateRulesEngineRequestJsonConverter());
            _jsonOptions.Converters.Add(new DeviceGroupsIdResponseJsonConverter());
            _jsonOptions.Converters.Add(new DeviceGroupsResponseJsonConverter());
            _jsonOptions.Converters.Add(new DeviceGroupsResponseLinksJsonConverter());
            _jsonOptions.Converters.Add(new DeviceGroupsResultResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetApplicationResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetApplicationsResponseJsonConverter());
            _jsonOptions.Converters.Add(new OriginsIdResponseJsonConverter());
            _jsonOptions.Converters.Add(new OriginsResponseJsonConverter());
            _jsonOptions.Converters.Add(new OriginsResponseLinksJsonConverter());
            _jsonOptions.Converters.Add(new OriginsResultResponseJsonConverter());
            _jsonOptions.Converters.Add(new OriginsResultResponseAddressesJsonConverter());
            _jsonOptions.Converters.Add(new PatchDeviceGroupsRequestJsonConverter());
            _jsonOptions.Converters.Add(new PatchOriginsRequestJsonConverter());
            _jsonOptions.Converters.Add(new PatchRulesEngineRequestJsonConverter());
            _jsonOptions.Converters.Add(new RulesEngineBehaviorEntryJsonConverter());
            _jsonOptions.Converters.Add(new RulesEngineBehaviorObjectJsonConverter());
            _jsonOptions.Converters.Add(new RulesEngineBehaviorObjectTargetJsonConverter());
            _jsonOptions.Converters.Add(new RulesEngineBehaviorStringJsonConverter());
            _jsonOptions.Converters.Add(new RulesEngineCriteriaJsonConverter());
            _jsonOptions.Converters.Add(new RulesEngineIdResponseJsonConverter());
            _jsonOptions.Converters.Add(new RulesEngineResponseJsonConverter());
            _jsonOptions.Converters.Add(new RulesEngineResultResponseJsonConverter());
            _jsonOptions.Converters.Add(new UpdateDeviceGroupsRequestJsonConverter());
            _jsonOptions.Converters.Add(new UpdateOriginsRequestJsonConverter());
            _jsonOptions.Converters.Add(new UpdateRulesEngineRequestJsonConverter());
            JsonSerializerOptionsProvider jsonSerializerOptionsProvider = new(_jsonOptions);
            _services.AddSingleton(jsonSerializerOptionsProvider);
            _services.AddSingleton<IApiFactory, ApiFactory>();
            _services.AddSingleton<EdgeApplicationsCacheSettingsApiEvents>();
            _services.AddTransient<IEdgeApplicationsCacheSettingsApi, EdgeApplicationsCacheSettingsApi>();
            _services.AddSingleton<EdgeApplicationsDeviceGroupsApiEvents>();
            _services.AddTransient<IEdgeApplicationsDeviceGroupsApi, EdgeApplicationsDeviceGroupsApi>();
            _services.AddSingleton<EdgeApplicationsEdgeFunctionsInstancesApiEvents>();
            _services.AddTransient<IEdgeApplicationsEdgeFunctionsInstancesApi, EdgeApplicationsEdgeFunctionsInstancesApi>();
            _services.AddSingleton<EdgeApplicationsMainSettingsApiEvents>();
            _services.AddTransient<IEdgeApplicationsMainSettingsApi, EdgeApplicationsMainSettingsApi>();
            _services.AddSingleton<EdgeApplicationsOriginsApiEvents>();
            _services.AddTransient<IEdgeApplicationsOriginsApi, EdgeApplicationsOriginsApi>();
            _services.AddSingleton<EdgeApplicationsRulesEngineApiEvents>();
            _services.AddTransient<IEdgeApplicationsRulesEngineApi, EdgeApplicationsRulesEngineApi>();
        }

        /// <summary>
        /// Configures the HttpClients.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        public HostConfiguration AddApiHttpClients
        (
            Action<HttpClient>? client = null, Action<IHttpClientBuilder>? builder = null)
        {
            if (client == null)
                client = c => c.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS);

            List<IHttpClientBuilder> builders = new List<IHttpClientBuilder>();

            builders.Add(_services.AddHttpClient<IEdgeApplicationsCacheSettingsApi, EdgeApplicationsCacheSettingsApi>(client));
            builders.Add(_services.AddHttpClient<IEdgeApplicationsDeviceGroupsApi, EdgeApplicationsDeviceGroupsApi>(client));
            builders.Add(_services.AddHttpClient<IEdgeApplicationsEdgeFunctionsInstancesApi, EdgeApplicationsEdgeFunctionsInstancesApi>(client));
            builders.Add(_services.AddHttpClient<IEdgeApplicationsMainSettingsApi, EdgeApplicationsMainSettingsApi>(client));
            builders.Add(_services.AddHttpClient<IEdgeApplicationsOriginsApi, EdgeApplicationsOriginsApi>(client));
            builders.Add(_services.AddHttpClient<IEdgeApplicationsRulesEngineApi, EdgeApplicationsRulesEngineApi>(client));
            
            if (builder != null)
                foreach (IHttpClientBuilder instance in builders)
                    builder(instance);

            HttpClientsAdded = true;

            return this;
        }

        /// <summary>
        /// Configures the JsonSerializerSettings
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public HostConfiguration ConfigureJsonOptions(Action<JsonSerializerOptions> options)
        {
            options(_jsonOptions);

            return this;
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="token"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(TTokenBase token) where TTokenBase : TokenBase
        {
            return AddTokens(new TTokenBase[]{ token });
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(IEnumerable<TTokenBase> tokens) where TTokenBase : TokenBase
        {
            TokenContainer<TTokenBase> container = new TokenContainer<TTokenBase>(tokens);
            _services.AddSingleton(services => container);

            return this;
        }

        /// <summary>
        /// Adds a token provider to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenProvider"></typeparam>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <returns></returns>
        public HostConfiguration UseProvider<TTokenProvider, TTokenBase>() 
            where TTokenProvider : TokenProvider<TTokenBase>
            where TTokenBase : TokenBase
        {
            _services.AddSingleton<TTokenProvider>();
            _services.AddSingleton<TokenProvider<TTokenBase>>(services => services.GetRequiredService<TTokenProvider>());

            return this;
        }
    }
}
