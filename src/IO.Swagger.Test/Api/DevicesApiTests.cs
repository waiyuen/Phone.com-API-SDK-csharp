/* 
 * Phone.com API
 *
 * This is a Phone.com api Swagger definition
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apisupport@phone.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing DevicesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DevicesApiTests
    {
        private DevicesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DevicesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DevicesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DevicesApi
            //Assert.IsInstanceOfType(typeof(DevicesApi), instance, "instance is a DevicesApi");
        }

        
        /// <summary>
        /// Test CreateAccountDevice
        /// </summary>
        [Test]
        public void CreateAccountDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? accountId = null;
            //CreateDeviceParams data = null;
            //var response = instance.CreateAccountDevice(accountId, data);
            //Assert.IsInstanceOf<DeviceFull> (response, "response is DeviceFull");
        }
        
        /// <summary>
        /// Test DeleteAccountDevice
        /// </summary>
        [Test]
        public void DeleteAccountDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? accountId = null;
            //int? deviceId = null;
            //var response = instance.DeleteAccountDevice(accountId, deviceId);
            //Assert.IsInstanceOf<DeleteEntry> (response, "response is DeleteEntry");
        }
        
        /// <summary>
        /// Test GetAccountDevice
        /// </summary>
        [Test]
        public void GetAccountDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? accountId = null;
            //int? deviceId = null;
            //var response = instance.GetAccountDevice(accountId, deviceId);
            //Assert.IsInstanceOf<DeviceFull> (response, "response is DeviceFull");
        }
        
        /// <summary>
        /// Test ListAccountDevices
        /// </summary>
        [Test]
        public void ListAccountDevicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? accountId = null;
            //List<string> filtersId = null;
            //List<string> filtersName = null;
            //string sortId = null;
            //string sortName = null;
            //int? limit = null;
            //int? offset = null;
            //string fields = null;
            //var response = instance.ListAccountDevices(accountId, filtersId, filtersName, sortId, sortName, limit, offset, fields);
            //Assert.IsInstanceOf<ListDevices> (response, "response is ListDevices");
        }
        
        /// <summary>
        /// Test ReplaceAccountDevice
        /// </summary>
        [Test]
        public void ReplaceAccountDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? accountId = null;
            //int? deviceId = null;
            //CreateDeviceParams data = null;
            //var response = instance.ReplaceAccountDevice(accountId, deviceId, data);
            //Assert.IsInstanceOf<DeviceFull> (response, "response is DeviceFull");
        }
        
    }

}
