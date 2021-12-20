using System;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BMS;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using Xunit.Abstractions;

namespace Test
{
    public class BasicTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        protected readonly HttpClient Client;
        protected readonly ITestOutputHelper OutputHelper;
        protected BasicTests(WebApplicationFactory<Startup> factory,
            ITestOutputHelper testOutputHelper)
        {
            Client = factory.CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            });
            OutputHelper = testOutputHelper;
        }
    }
}