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
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using edgeapplications.Client;

namespace edgeapplications.Extensions
{
    /// <summary>
    /// Extension methods for IServiceCollection
    /// </summary>
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Add the api to your host builder.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="options"></param>
        public static void AddApi(this IServiceCollection services, Action<HostConfiguration> options)
        {
            HostConfiguration config = new(services);
            options(config);
            AddApi(services, config);
        }

        internal static void AddApi(IServiceCollection services, HostConfiguration host)
        {
            if (!host.HttpClientsAdded)
                host.AddApiHttpClients();

            services.AddSingleton<CookieContainer>();

            // ensure that a token provider was provided for this token type
            // if not, default to RateLimitProvider
            var containerServices = services.Where(s => s.ServiceType.IsGenericType &&
                s.ServiceType.GetGenericTypeDefinition().IsAssignableFrom(typeof(TokenContainer<>))).ToArray();

            foreach(var containerService in containerServices)
            {
                var tokenType = containerService.ServiceType.GenericTypeArguments[0];

                var provider = services.FirstOrDefault(s => s.ServiceType.IsAssignableFrom(typeof(TokenProvider<>).MakeGenericType(tokenType)));

                if (provider == null)
                {
                    services.AddSingleton(typeof(RateLimitProvider<>).MakeGenericType(tokenType));
                    services.AddSingleton(typeof(TokenProvider<>).MakeGenericType(tokenType), 
                        s => s.GetRequiredService(typeof(RateLimitProvider<>).MakeGenericType(tokenType)));
                }
            }
        }
    }
}
