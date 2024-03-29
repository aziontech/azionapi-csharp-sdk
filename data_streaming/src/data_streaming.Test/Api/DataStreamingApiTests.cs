/*
 * Data Streaming - OpenAPI
 *
 * The Data Streaming API allows you to manage your existing data streamings and templates. Data Streaming allows you to feed your stream processing, SIEM, and big data platforms with the event logs from your applications on Azion in real time. 
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

using data_streaming.Client;
using data_streaming.Api;
// uncomment below to import models
//using data_streaming.Model;

namespace data_streaming.Test.Api
{
    /// <summary>
    ///  Class for testing DataStreamingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DataStreamingApiTests : IDisposable
    {
        private DataStreamingApi instance;

        public DataStreamingApiTests()
        {
            instance = new DataStreamingApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DataStreamingApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DataStreamingApi
            //Assert.IsType<DataStreamingApi>(instance);
        }

        /// <summary>
        /// Test CreateNewDataStreaming
        /// </summary>
        [Fact]
        public void CreateNewDataStreamingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateNewDataStreamingRequest createNewDataStreamingRequest = null;
            //var response = instance.CreateNewDataStreaming(createNewDataStreamingRequest);
            //Assert.IsType<CreateNewDataStreaming201Response>(response);
        }

        /// <summary>
        /// Test DeleteDataStreamingById
        /// </summary>
        [Fact]
        public void DeleteDataStreamingByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int dataStreamingId = null;
            //instance.DeleteDataStreamingById(dataStreamingId);
        }

        /// <summary>
        /// Test EditDataStreamingById
        /// </summary>
        [Fact]
        public void EditDataStreamingByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int dataStreamingId = null;
            //CreateNewDataStreamingRequest createNewDataStreamingRequest = null;
            //var response = instance.EditDataStreamingById(dataStreamingId, createNewDataStreamingRequest);
            //Assert.IsType<CreateNewDataStreaming201Response>(response);
        }

        /// <summary>
        /// Test ListDataStreamingById
        /// </summary>
        [Fact]
        public void ListDataStreamingByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int dataStreamingId = null;
            //var response = instance.ListDataStreamingById(dataStreamingId);
            //Assert.IsType<DataStreamingsById>(response);
        }

        /// <summary>
        /// Test ListDataStreamings
        /// </summary>
        [Fact]
        public void ListDataStreamingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListDataStreamings();
            //Assert.IsType<DataStreamingResponseWithResults>(response);
        }

        /// <summary>
        /// Test OverwriteDataStreamingById
        /// </summary>
        [Fact]
        public void OverwriteDataStreamingByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int dataStreamingId = null;
            //CreateNewDataStreamingRequest createNewDataStreamingRequest = null;
            //var response = instance.OverwriteDataStreamingById(dataStreamingId, createNewDataStreamingRequest);
            //Assert.IsType<CreateNewDataStreaming201Response>(response);
        }
    }
}
