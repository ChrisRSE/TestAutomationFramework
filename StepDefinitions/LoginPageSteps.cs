using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestAutomationFramework.Models.Pages;
using TestAutomationFramework.Hooks;

namespace YourNamespace.StepDefinitions
{
    [Binding]
    public class LoginPageSteps
    {
        private readonly IWebDriver driver;
        private readonly LoginPage loginPage;
        private readonly ScenarioContext _scenarioContext;

        public LoginPageSteps(ScenarioContext scenarioContext)
        {
            driver = WebDriverHooks.GetDriver();
            loginPage = new LoginPage(driver);
            _scenarioContext = scenarioContext;
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

        [Then(@"an error message will be displayed containing ""([^""]*)""")]
        public void ThenAnErrorMessageWillBeDisplayedContaining(string errorMessage)
        {
            StringAssert.Contains(errorMessage, loginPage.ErrorMessageContent());
        }
    }
}