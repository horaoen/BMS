using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using BMS;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using Xunit.Abstractions;

namespace Test.ControllerTests
{
    public class BookTitleControllerTests : BasicTests
    {
        
        public BookTitleControllerTests(WebApplicationFactory<Startup> factory, ITestOutputHelper testOutputHelper) : base(factory, testOutputHelper)
        {
        }
        
        [Fact]
        public async Task GetBookTitlesTest()   
        {
            // Arrange
            var request = new HttpRequestMessage(HttpMethod.Get, "/api/booktitles");
            
            // Act
            var response = await Client.SendAsync(request);
            
            // Assert
            response.EnsureSuccessStatusCode();
        }
    }
}