/*
 * Edge Application API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Security.Cryptography;
using edgeapplications.Client;
using edgeapplications.Api;
using edgeapplications.Extensions;
using Xunit;

namespace edgeapplications.Test.Api
{
    /// <summary>
    ///  Tests the dependency injection.
    /// </summary>
    public class DependencyInjectionTest
    {
        private readonly IHost _hostUsingConfigureWithoutAClient =
            Host.CreateDefaultBuilder([]).ConfigureApi((context, services, options) =>
            {
                ApiKeyToken apiKeyToken1 = new("<token>", ClientUtils.ApiKeyHeader.Authorization, timeout: TimeSpan.FromSeconds(1));
                options.AddTokens(apiKeyToken1);
            })
            .Build();

        private readonly IHost _hostUsingConfigureWithAClient =
            Host.CreateDefaultBuilder([]).ConfigureApi((context, services, options) =>
            {
                ApiKeyToken apiKeyToken1 = new("<token>", ClientUtils.ApiKeyHeader.Authorization, timeout: TimeSpan.FromSeconds(1));
                options.AddTokens(apiKeyToken1);
                options.AddApiHttpClients(client => client.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS));
            })
            .Build();

        private readonly IHost _hostUsingAddWithoutAClient =
            Host.CreateDefaultBuilder([]).ConfigureServices((host, services) =>
            {
                services.AddApi(options =>
                {
                    ApiKeyToken apiKeyToken1 = new("<token>", ClientUtils.ApiKeyHeader.Authorization, timeout: TimeSpan.FromSeconds(1));
                    options.AddTokens(apiKeyToken1);
                });
            })
            .Build();

        private readonly IHost _hostUsingAddWithAClient =
            Host.CreateDefaultBuilder([]).ConfigureServices((host, services) =>
            {
                services.AddApi(options =>
                {
                    ApiKeyToken apiKeyToken1 = new("<token>", ClientUtils.ApiKeyHeader.Authorization, timeout: TimeSpan.FromSeconds(1));
                    options.AddTokens(apiKeyToken1);
                    options.AddApiHttpClients(client => client.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS));
                });
            })
            .Build();

        /// <summary>
        /// Test dependency injection when using the configure method
        /// </summary>
        [Fact]
        public void ConfigureApiWithAClientTest()
        {
            var edgeApplicationsCacheSettingsApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IEdgeApplicationsCacheSettingsApi>();
            Assert.True(edgeApplicationsCacheSettingsApi.HttpClient.BaseAddress != null);

            var edgeApplicationsDeviceGroupsApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IEdgeApplicationsDeviceGroupsApi>();
            Assert.True(edgeApplicationsDeviceGroupsApi.HttpClient.BaseAddress != null);

            var edgeApplicationsEdgeFunctionsInstancesApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IEdgeApplicationsEdgeFunctionsInstancesApi>();
            Assert.True(edgeApplicationsEdgeFunctionsInstancesApi.HttpClient.BaseAddress != null);

            var edgeApplicationsMainSettingsApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IEdgeApplicationsMainSettingsApi>();
            Assert.True(edgeApplicationsMainSettingsApi.HttpClient.BaseAddress != null);

            var edgeApplicationsOriginsApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IEdgeApplicationsOriginsApi>();
            Assert.True(edgeApplicationsOriginsApi.HttpClient.BaseAddress != null);

            var edgeApplicationsRulesEngineApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IEdgeApplicationsRulesEngineApi>();
            Assert.True(edgeApplicationsRulesEngineApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the configure method
        /// </summary>
        [Fact]
        public void ConfigureApiWithoutAClientTest()
        {
            var edgeApplicationsCacheSettingsApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IEdgeApplicationsCacheSettingsApi>();
            Assert.True(edgeApplicationsCacheSettingsApi.HttpClient.BaseAddress != null);

            var edgeApplicationsDeviceGroupsApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IEdgeApplicationsDeviceGroupsApi>();
            Assert.True(edgeApplicationsDeviceGroupsApi.HttpClient.BaseAddress != null);

            var edgeApplicationsEdgeFunctionsInstancesApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IEdgeApplicationsEdgeFunctionsInstancesApi>();
            Assert.True(edgeApplicationsEdgeFunctionsInstancesApi.HttpClient.BaseAddress != null);

            var edgeApplicationsMainSettingsApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IEdgeApplicationsMainSettingsApi>();
            Assert.True(edgeApplicationsMainSettingsApi.HttpClient.BaseAddress != null);

            var edgeApplicationsOriginsApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IEdgeApplicationsOriginsApi>();
            Assert.True(edgeApplicationsOriginsApi.HttpClient.BaseAddress != null);

            var edgeApplicationsRulesEngineApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IEdgeApplicationsRulesEngineApi>();
            Assert.True(edgeApplicationsRulesEngineApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the add method
        /// </summary>
        [Fact]
        public void AddApiWithAClientTest()
        {
            var edgeApplicationsCacheSettingsApi = _hostUsingAddWithAClient.Services.GetRequiredService<IEdgeApplicationsCacheSettingsApi>();
            Assert.True(edgeApplicationsCacheSettingsApi.HttpClient.BaseAddress != null);
            
            var edgeApplicationsDeviceGroupsApi = _hostUsingAddWithAClient.Services.GetRequiredService<IEdgeApplicationsDeviceGroupsApi>();
            Assert.True(edgeApplicationsDeviceGroupsApi.HttpClient.BaseAddress != null);
            
            var edgeApplicationsEdgeFunctionsInstancesApi = _hostUsingAddWithAClient.Services.GetRequiredService<IEdgeApplicationsEdgeFunctionsInstancesApi>();
            Assert.True(edgeApplicationsEdgeFunctionsInstancesApi.HttpClient.BaseAddress != null);
            
            var edgeApplicationsMainSettingsApi = _hostUsingAddWithAClient.Services.GetRequiredService<IEdgeApplicationsMainSettingsApi>();
            Assert.True(edgeApplicationsMainSettingsApi.HttpClient.BaseAddress != null);
            
            var edgeApplicationsOriginsApi = _hostUsingAddWithAClient.Services.GetRequiredService<IEdgeApplicationsOriginsApi>();
            Assert.True(edgeApplicationsOriginsApi.HttpClient.BaseAddress != null);
            
            var edgeApplicationsRulesEngineApi = _hostUsingAddWithAClient.Services.GetRequiredService<IEdgeApplicationsRulesEngineApi>();
            Assert.True(edgeApplicationsRulesEngineApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the add method
        /// </summary>
        [Fact]
        public void AddApiWithoutAClientTest()
        {
            var edgeApplicationsCacheSettingsApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IEdgeApplicationsCacheSettingsApi>();
            Assert.True(edgeApplicationsCacheSettingsApi.HttpClient.BaseAddress != null);

            var edgeApplicationsDeviceGroupsApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IEdgeApplicationsDeviceGroupsApi>();
            Assert.True(edgeApplicationsDeviceGroupsApi.HttpClient.BaseAddress != null);

            var edgeApplicationsEdgeFunctionsInstancesApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IEdgeApplicationsEdgeFunctionsInstancesApi>();
            Assert.True(edgeApplicationsEdgeFunctionsInstancesApi.HttpClient.BaseAddress != null);

            var edgeApplicationsMainSettingsApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IEdgeApplicationsMainSettingsApi>();
            Assert.True(edgeApplicationsMainSettingsApi.HttpClient.BaseAddress != null);

            var edgeApplicationsOriginsApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IEdgeApplicationsOriginsApi>();
            Assert.True(edgeApplicationsOriginsApi.HttpClient.BaseAddress != null);

            var edgeApplicationsRulesEngineApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IEdgeApplicationsRulesEngineApi>();
            Assert.True(edgeApplicationsRulesEngineApi.HttpClient.BaseAddress != null);
        }
    }
}
