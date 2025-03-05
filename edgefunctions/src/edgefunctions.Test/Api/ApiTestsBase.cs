/*
 * Edge Function API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Microsoft.Extensions.Hosting;
using edgefunctions.Client;
using edgefunctions.Extensions;


/* *********************************************************************************
*              Follow these manual steps to construct tests.
*              This file will not be overwritten.
*  *********************************************************************************
* 1. Navigate to ApiTests.Base.cs and ensure any tokens are being created correctly.
*    Take care not to commit credentials to any repository.
*
* 2. Mocking is coordinated by ApiTestsBase#AddApiHttpClients.
*    To mock the client, use the generic AddApiHttpClients.
*    To mock the server, change the client's BaseAddress.
*
* 3. Locate the test you want below
*      - remove the skip property from the Fact attribute
*      - set the value of any variables if necessary
*
* 4. Run the tests and ensure they work.
*
*/


namespace edgefunctions.Test.Api
{
    /// <summary>
    ///  Base class for API tests
    /// </summary>
    public class ApiTestsBase
    {
        protected readonly IHost _host;

        public ApiTestsBase(string[] args)
        {
            _host = CreateHostBuilder(args).Build();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
            .ConfigureApi((context, services, options) =>
            {
                string apiKeyTokenValue1 = context.Configuration["<token>"] ?? throw new Exception("Token not found.");
                ApiKeyToken apiKeyToken1 = new(apiKeyTokenValue1, ClientUtils.ApiKeyHeader.Authorization, timeout: TimeSpan.FromSeconds(1));
                options.AddTokens(apiKeyToken1);
            });
    }
}
