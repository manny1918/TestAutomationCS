using AutomatedTests.Pages;
using AutomatedTests.Utils;
using Xunit;
using Xunit.Abstractions;

namespace AutomatedTests.Tests
{
    public class LoginTests
    {
        private ITestOutputHelper _outputter;
        LoginPage login = new LoginPage();
        public LoginTests()
        {
        }

        [Fact]
        public void Login_shoudLogIn()
        {
            login.openApp();
            login.TypeEmail(Parameters.Email);
            login.ClickNext();
        }
    }
}
