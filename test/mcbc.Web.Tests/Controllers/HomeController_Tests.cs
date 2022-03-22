using System.Threading.Tasks;
using mcbc.Models.TokenAuth;
using mcbc.Web.Controllers;
using Shouldly;
using Xunit;

namespace mcbc.Web.Tests.Controllers
{
    public class HomeController_Tests: mcbcWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}