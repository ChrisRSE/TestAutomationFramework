using OpenQA.Selenium;

namespace TestAutomationFramework.Models.Pages
{
    internal class DefaultPage
    {
        internal IWebDriver Driver;
        private String BaseUrl { get; } = "https://www.saucedemo.com/";
        private String Path { get; } = string.Empty;

        internal DefaultPage(IWebDriver driver, int waitTimeInSeconds = 1)
        {
            Driver = driver;
            Driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(waitTimeInSeconds);
        }

        internal virtual bool IsDisplayed()
        {
            return false;
        }

        internal void Open()
        {
            Driver.Navigate().GoToUrl(BaseUrl + Path);
        }
    }
}
