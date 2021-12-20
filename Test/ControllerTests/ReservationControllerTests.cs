using System.Net.Http;
using System.Threading.Tasks;
using BMS;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using Xunit.Abstractions;

namespace Test.ControllerTests
{
    public class ReservationControllerTests : BasicTests
    {
        public ReservationControllerTests(WebApplicationFactory<Startup> factory, ITestOutputHelper testOutputHelper) : base(factory, testOutputHelper)
        {
        }

        [Fact]
        public async Task GetReservationsTest()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "/api/reservations");
            
            // Act
            var response = await Client.SendAsync(request);
             
            // Assert
            OutputHelper.WriteLine(response.StatusCode.ToString());
        }
    }
}