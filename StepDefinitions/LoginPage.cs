using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TestAutomationFramework.Models.Pages;

namespace YourNamespace.StepDefinitions
{
    [Binding]
    public class LoginValidationSteps
    {
        private readonly IWebDriver driver;
        private readonly LoginPage loginPage;

        public LoginValidationSteps()
        {
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
        }

        [Given("I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            loginPage.Open();
        }

        [Then("I should see that I am on the login page")]
        public void ThenIShouldSeeThatIAmOnTheLoginPage()
        {
            bool isLoginPageDisplayed = loginPage.IsDisplayed();

            Assert.IsTrue(isLoginPageDisplayed, "Expected to be on the login page, but it's not.");
        }
    }
}