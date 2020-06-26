using System.Threading.Tasks;
using TechPOS.Models.TokenAuth;
using TechPOS.Web.Controllers;
using Shouldly;
using Xunit;

namespace TechPOS.Web.Tests.Controllers
{
    public class HomeController_Tests: TechPOSWebTestBase
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