/*
 * Digital Certificates API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using digital_certificates.Client;
using digital_certificates.Api;
// uncomment below to import models
//using digital_certificates.Model;

namespace digital_certificates.Test.Api
{
    /// <summary>
    ///  Class for testing CreateCSRApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CreateCSRApiTests : IDisposable
    {
        private CreateCSRApi instance;

        public CreateCSRApiTests()
        {
            instance = new CreateCSRApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateCSRApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CreateCSRApi
            //Assert.IsType<CreateCSRApi>(instance);
        }

        /// <summary>
        /// Test CreateCSR
        /// </summary>
        [Fact]
        public void CreateCSRTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateCSRRequest createCSRRequest = null;
            //var response = instance.CreateCSR(createCSRRequest);
            //Assert.IsType<DC201>(response);
        }
    }
}
