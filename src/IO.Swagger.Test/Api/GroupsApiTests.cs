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
    ///  Class for testing GroupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class GroupsApiTests
    {
        private GroupsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GroupsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GroupsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' GroupsApi
            //Assert.IsInstanceOfType(typeof(GroupsApi), instance, "instance is a GroupsApi");
        }

        
        /// <summary>
        /// Test CreateAccountExtensionContactGroup
        /// </summary>
        [Test]
        public void CreateAccountExtensionContactGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? accountId = null;
            //int? extensionId = null;
            //CreateGroupParams data = null;
            //var response = instance.CreateAccountExtensionContactGroup(accountId, extensionId, data);
            //Assert.IsInstanceOf<GroupFull> (response, "response is GroupFull");
        }
        
        /// <summary>
        /// Test DeleteAccountExtensionContactGroup
        /// </summary>
        [Test]
        public void DeleteAccountExtensionContactGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? accountId = null;
            //int? extensionId = null;
            //int? groupId = null;
            //var response = instance.DeleteAccountExtensionContactGroup(accountId, extensionId, groupId);
            //Assert.IsInstanceOf<DeleteEntry> (response, "response is DeleteEntry");
        }
        
        /// <summary>
        /// Test GetAccountExtensionContactGroup
        /// </summary>
        [Test]
        public void GetAccountExtensionContactGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? accountId = null;
            //int? extensionId = null;
            //int? groupId = null;
            //var response = instance.GetAccountExtensionContactGroup(accountId, extensionId, groupId);
            //Assert.IsInstanceOf<GroupFull> (response, "response is GroupFull");
        }
        
        /// <summary>
        /// Test ListAccountExtensionContactGroups
        /// </summary>
        [Test]
        public void ListAccountExtensionContactGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? accountId = null;
            //int? extensionId = null;
            //List<string> filtersId = null;
            //List<string> filtersName = null;
            //string sortId = null;
            //string sortName = null;
            //int? limit = null;
            //int? offset = null;
            //string fields = null;
            //var response = instance.ListAccountExtensionContactGroups(accountId, extensionId, filtersId, filtersName, sortId, sortName, limit, offset, fields);
            //Assert.IsInstanceOf<ListGroups> (response, "response is ListGroups");
        }
        
        /// <summary>
        /// Test ReplaceAccountExtensionContactGroup
        /// </summary>
        [Test]
        public void ReplaceAccountExtensionContactGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? accountId = null;
            //int? extensionId = null;
            //int? groupId = null;
            //CreateGroupParams data = null;
            //var response = instance.ReplaceAccountExtensionContactGroup(accountId, extensionId, groupId, data);
            //Assert.IsInstanceOf<GroupFull> (response, "response is GroupFull");
        }
        
    }

}
