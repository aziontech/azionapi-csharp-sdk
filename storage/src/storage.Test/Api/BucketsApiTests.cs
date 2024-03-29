/*
 * Object Storage
 *
 * REST API OpenAPI documentation for the Object Storage
 *
 * The version of the OpenAPI document: 1.0.0 (v1)
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

using storage.Client;
using storage.Api;
// uncomment below to import models
//using storage.Model;

namespace storage.Test.Api
{
    /// <summary>
    ///  Class for testing BucketsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BucketsApiTests : IDisposable
    {
        private BucketsApi instance;

        public BucketsApiTests()
        {
            instance = new BucketsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BucketsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BucketsApi
            //Assert.IsType<BucketsApi>(instance);
        }

        /// <summary>
        /// Test ApiV1StorageBucketsCreate
        /// </summary>
        [Fact]
        public void ApiV1StorageBucketsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BucketCreate bucketCreate = null;
            //var response = instance.ApiV1StorageBucketsCreate(bucketCreate);
            //Assert.IsType<ResponseBucket>(response);
        }

        /// <summary>
        /// Test ApiV1StorageBucketsDestroy
        /// </summary>
        [Fact]
        public void ApiV1StorageBucketsDestroyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.ApiV1StorageBucketsDestroy(name);
            //Assert.IsType<ResponseDeleteBucket>(response);
        }

        /// <summary>
        /// Test ApiV1StorageBucketsList
        /// </summary>
        [Fact]
        public void ApiV1StorageBucketsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? pageSize = null;
            //var response = instance.ApiV1StorageBucketsList(page, pageSize);
            //Assert.IsType<PaginatedBucketList>(response);
        }

        /// <summary>
        /// Test ApiV1StorageBucketsPartialUpdate
        /// </summary>
        [Fact]
        public void ApiV1StorageBucketsPartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //PatchedBucket? patchedBucket = null;
            //var response = instance.ApiV1StorageBucketsPartialUpdate(name, patchedBucket);
            //Assert.IsType<ResponseBucket>(response);
        }
    }
}
