/*
 * Personal Tokens - OpenAPI
 *
 * The Personal Tokens API allows you to manage your existing personal tokens. 
 *
 * The version of the OpenAPI document: 1.0.0
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

using personal_tokens.Client;
using personal_tokens.Api;
// uncomment below to import models
//using personal_tokens.Model;

namespace personal_tokens.Test.Api
{
    /// <summary>
    ///  Class for testing PersonalTokenApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PersonalTokenApiTests : IDisposable
    {
        private PersonalTokenApi instance;

        public PersonalTokenApiTests()
        {
            instance = new PersonalTokenApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PersonalTokenApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PersonalTokenApi
            //Assert.IsType<PersonalTokenApi>(instance);
        }

        /// <summary>
        /// Test CreatePersonalToken
        /// </summary>
        [Fact]
        public void CreatePersonalTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreatePersonalTokenRequest createPersonalTokenRequest = null;
            //var response = instance.CreatePersonalToken(createPersonalTokenRequest);
            //Assert.IsType<CreatePersonalTokenResponse>(response);
        }

        /// <summary>
        /// Test DeletePersonalToken
        /// </summary>
        [Fact]
        public void DeletePersonalTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid personalTokenId = null;
            //instance.DeletePersonalToken(personalTokenId);
        }

        /// <summary>
        /// Test GetPersonalToken
        /// </summary>
        [Fact]
        public void GetPersonalTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid personalTokenId = null;
            //var response = instance.GetPersonalToken(personalTokenId);
            //Assert.IsType<PersonalTokenResponseGet>(response);
        }

        /// <summary>
        /// Test ListPersonalToken
        /// </summary>
        [Fact]
        public void ListPersonalTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListPersonalToken();
            //Assert.IsType<PersonalTokenResponseWithResults>(response);
        }
    }
}