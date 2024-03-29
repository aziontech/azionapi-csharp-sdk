/*
 * Data Streaming - OpenAPI
 *
 * The Data Streaming API allows you to manage your existing data streamings and templates. Data Streaming allows you to feed your stream processing, SIEM, and big data platforms with the event logs from your applications on Azion in real time. 
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using data_streaming.Model;
using data_streaming.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace data_streaming.Test.Model
{
    /// <summary>
    ///  Class for testing DataStreamingEndpointTypeKafka
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DataStreamingEndpointTypeKafkaTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DataStreamingEndpointTypeKafka
        //private DataStreamingEndpointTypeKafka instance;

        public DataStreamingEndpointTypeKafkaTests()
        {
            // TODO uncomment below to create an instance of DataStreamingEndpointTypeKafka
            //instance = new DataStreamingEndpointTypeKafka();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DataStreamingEndpointTypeKafka
        /// </summary>
        [Fact]
        public void DataStreamingEndpointTypeKafkaInstanceTest()
        {
            // TODO uncomment below to test "IsType" DataStreamingEndpointTypeKafka
            //Assert.IsType<DataStreamingEndpointTypeKafka>(instance);
        }


        /// <summary>
        /// Test the property 'EndpointType'
        /// </summary>
        [Fact]
        public void EndpointTypeTest()
        {
            // TODO unit test for the property 'EndpointType'
        }
        /// <summary>
        /// Test the property 'UseTls'
        /// </summary>
        [Fact]
        public void UseTlsTest()
        {
            // TODO unit test for the property 'UseTls'
        }
        /// <summary>
        /// Test the property 'KafkaTopic'
        /// </summary>
        [Fact]
        public void KafkaTopicTest()
        {
            // TODO unit test for the property 'KafkaTopic'
        }
        /// <summary>
        /// Test the property 'BootstrapServers'
        /// </summary>
        [Fact]
        public void BootstrapServersTest()
        {
            // TODO unit test for the property 'BootstrapServers'
        }

    }

}
