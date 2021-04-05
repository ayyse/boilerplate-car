using System.Threading.Tasks;
using MyFirstProject.Models.TokenAuth;
using MyFirstProject.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyFirstProject.Web.Tests.Controllers
{
    public class HomeController_Tests: MyFirstProjectWebTestBase
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