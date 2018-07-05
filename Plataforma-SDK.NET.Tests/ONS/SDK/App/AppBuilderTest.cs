using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using ONS.SDK.Builder;
using ONS.SDK.Builder.Generic;
using ONS.SDK.Extensions.Builder;

namespace ONS.SDK.AppTest {

    [TestFixture]
    class AppBuilderTest {

        [Test]
        public void ShouldBuildApp(){
            /*var app = AppBuilder.CreateDefaultBuilder(null)
            .UseStartup<Startup>()
            .UseSDK();*/

            Assert.AreEqual(true, Startup.PassHere);
        }
    }

    class Startup : ONS.SDK.Builder.IStartup
    {
        public static bool PassHere {get;set;}

        public Startup(IConfiguration conf){}

        public void ConfigureServices(IServiceCollection services) => Startup.PassHere = true;

        public void Configure(IAppBuilder app)
        {
            throw new System.NotImplementedException();
        }
    }

    /*class Domain : IDomainContext
    {

    }*/

    class Payload {

    }

}