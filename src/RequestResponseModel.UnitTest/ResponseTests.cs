using System;
using Edi.Practice.RequestResponseModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RequestResponseModel.UnitTest
{
    [TestClass]
    public class ResponseTests
    {
        [TestMethod]
        public void TestDefaultResponseTypeCreation()
        {
            var response = new Response();
            Assert.IsFalse(response.IsSuccess);
            Assert.IsNull(response.Exception);
            Assert.IsTrue(response.Message == string.Empty);
            Assert.IsTrue(response.ResponseCode == 0);
        }

        [TestMethod]
        public void TestSuccessResponseTypeCreation()
        {
            var response = new SuccessResponse();
            Assert.IsTrue(response.IsSuccess);
            Assert.IsNull(response.Exception);
            Assert.IsTrue(response.Message == string.Empty);
            Assert.IsTrue(response.ResponseCode == 0);
        }

        [TestMethod]
        public void TestFailedResponseTypeCreation()
        {
            var response = new FailedResponse(250, "Failure", new ArgumentException("test"));
            Assert.IsFalse(response.IsSuccess);
            Assert.IsNotNull(response.Exception);
            Assert.IsTrue(response.Message == "Failure");
            Assert.IsTrue(response.ResponseCode == 250);
        }

        [TestMethod]
        public void TestResponseOfTypeDefaultCreation()
        {
            var response = new Response<Foo>();
            Assert.IsFalse(response.IsSuccess);
            Assert.IsNull(response.Exception);
            Assert.IsTrue(response.Message == string.Empty);
            Assert.IsTrue(response.ResponseCode == 0);
            Assert.IsNull(response.Item);
        }

        [TestMethod]
        public void TestResponseOfTypeCtorCreation()
        {
            var foo = new Foo { Name = "hehe" };
            var response = new Response<Foo>(foo);
            Assert.IsFalse(response.IsSuccess);
            Assert.IsNull(response.Exception);
            Assert.IsTrue(response.Message == string.Empty);
            Assert.IsTrue(response.ResponseCode == 0);
            Assert.IsNotNull(response.Item);
            Assert.IsInstanceOfType(response.Item, typeof(Foo));
            Assert.IsTrue(response.Item.Id == 1);
            Assert.IsTrue(response.Item.Name == "hehe");
        }

        [TestMethod]
        public void TestSucessResponseOfTypeDefaultCreation()
        {
            var response = new SuccessResponse<Foo>();
            Assert.IsTrue(response.IsSuccess);
            Assert.IsNull(response.Exception);
            Assert.IsTrue(response.Message == string.Empty);
            Assert.IsTrue(response.ResponseCode == 0);
            Assert.IsNull(response.Item);
        }

        [TestMethod]
        public void TestSuccessResponseOfTypeCtorCreation()
        {
            var foo = new Foo { Name = "hehe" };
            var response = new SuccessResponse<Foo>(foo);
            Assert.IsTrue(response.IsSuccess);
            Assert.IsNull(response.Exception);
            Assert.IsTrue(response.Message == string.Empty);
            Assert.IsTrue(response.ResponseCode == 0);
            Assert.IsNotNull(response.Item);
            Assert.IsInstanceOfType(response.Item, typeof(Foo));
            Assert.IsTrue(response.Item.Id == 1);
            Assert.IsTrue(response.Item.Name == "hehe");
        }

        // TODO: add failure response of T tests
    }

    class Foo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Foo()
        {
            Id = 1;
            Name = "haha";
        }
    }
}
