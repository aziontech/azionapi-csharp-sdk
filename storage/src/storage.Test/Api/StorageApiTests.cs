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
    ///  Class for testing StorageApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class StorageApiTests : IDisposable
    {
        private StorageApi instance;

        public StorageApiTests()
        {
            instance = new StorageApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of StorageApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' StorageApi
            //Assert.IsType<StorageApi>(instance);
        }

        /// <summary>
        /// Test StorageApiBucketsCreate
        /// </summary>
        [Fact]
        public void StorageApiBucketsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BucketCreate bucketCreate = null;
            //var response = instance.StorageApiBucketsCreate(bucketCreate);
            //Assert.IsType<ResponseBucket>(response);
        }

        /// <summary>
        /// Test StorageApiBucketsDestroy
        /// </summary>
        [Fact]
        public void StorageApiBucketsDestroyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.StorageApiBucketsDestroy(name);
            //Assert.IsType<SuccessBucketOperation>(response);
        }

        /// <summary>
        /// Test StorageApiBucketsList
        /// </summary>
        [Fact]
        public void StorageApiBucketsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? pageSize = null;
            //var response = instance.StorageApiBucketsList(page, pageSize);
            //Assert.IsType<PaginatedBucketList>(response);
        }

        /// <summary>
        /// Test StorageApiBucketsObjectsCreate
        /// </summary>
        [Fact]
        public void StorageApiBucketsObjectsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bucketName = null;
            //string objectKey = null;
            //Dictionary<string, Object>? requestBody = null;
            //var response = instance.StorageApiBucketsObjectsCreate(bucketName, objectKey, requestBody);
            //Assert.IsType<SuccessObjectOperation>(response);
        }

        /// <summary>
        /// Test StorageApiBucketsObjectsDestroy
        /// </summary>
        [Fact]
        public void StorageApiBucketsObjectsDestroyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bucketName = null;
            //string objectKey = null;
            //var response = instance.StorageApiBucketsObjectsDestroy(bucketName, objectKey);
            //Assert.IsType<SuccessObjectOperation>(response);
        }

        /// <summary>
        /// Test StorageApiBucketsObjectsList
        /// </summary>
        [Fact]
        public void StorageApiBucketsObjectsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bucketName = null;
            //int? page = null;
            //int? pageSize = null;
            //var response = instance.StorageApiBucketsObjectsList(bucketName, page, pageSize);
            //Assert.IsType<PaginatedBucketObjectList>(response);
        }

        /// <summary>
        /// Test StorageApiBucketsObjectsRetrieve
        /// </summary>
        [Fact]
        public void StorageApiBucketsObjectsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bucketName = null;
            //string objectKey = null;
            //var response = instance.StorageApiBucketsObjectsRetrieve(bucketName, objectKey);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test StorageApiBucketsObjectsUpdate
        /// </summary>
        [Fact]
        public void StorageApiBucketsObjectsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bucketName = null;
            //string objectKey = null;
            //Dictionary<string, Object>? requestBody = null;
            //var response = instance.StorageApiBucketsObjectsUpdate(bucketName, objectKey, requestBody);
            //Assert.IsType<SuccessObjectOperation>(response);
        }

        /// <summary>
        /// Test StorageApiBucketsPartialUpdate
        /// </summary>
        [Fact]
        public void StorageApiBucketsPartialUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.StorageApiBucketsPartialUpdate(name);
            //Assert.IsType<ResponseBucket>(response);
        }
    }
}
