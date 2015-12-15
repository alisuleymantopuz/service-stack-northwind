using System;
using NorthwindServices.App.ServiceModel.Request;
using NorthwindServices.App.ServiceModel.Response;
using NUnit.Framework;
using ServiceStack;
using ServiceStack.Testing;
using NorthwindServices.App.ServiceModel;
using NorthwindServices.App.ServiceInterface;

namespace NorthwindServices.App.Tests
{
    [TestFixture]
    public class UnitTests
    {
        private readonly ServiceStackHost appHost;

        public UnitTests()
        {
            appHost = new BasicAppHost(typeof(MyServices).Assembly)
            {
                ConfigureContainer = container =>
                {
                    //Add your IoC dependencies here
                }
            }
            .Init();
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            appHost.Dispose();
        }

        [Test]
        public void TestMethod1()
        {
            var service = appHost.Container.Resolve<MyServices>();

            var response = (HelloResponse)service.Any(new HelloRequest() { Name = "World" });

            Assert.That(response.Result, Is.EqualTo("Hello, World!"));
        }
    }
}
