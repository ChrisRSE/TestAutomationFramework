using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TestAutomationFramework.Models.Pages;
using TestAutomationFramework.Hooks;

namespace YourNamespace.StepDefinitions
{
    [Binding]
    public class LoginValidationSteps
    {
        private readonly IWebDriver driver;
        private readonly LoginPage loginPage;

        public LoginValidationSteps()
        {
            driver = WebDriverHooks.GetDriver();
            loginPage = new LoginPage(driver);
        }

        [Given("I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            loginPage.Open();
        }

        [When(@"I enter username ""(.*)"" and password ""(.*)""")]
        public void WhenIEnterUsernameAndPassword(string username, string password)
        {
            loginPage.EnterUsernameAndPassword(username, password);
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            loginPage.ClickLoginButton();
        }
    }
}