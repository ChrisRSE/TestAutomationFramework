using OpenQA.Selenium;

namespace TestAutomationFramework.Models.Pages
{
    internal class DefaultPage
    {
        protected IWebDriver Driver;
        protected virtual String BaseUrl { get; } = "https://www.saucedemo.com/";
        protected virtual string Path { get; } = string.Empty;

        internal DefaultPage(IWebDriver driver, int waitTimeInSeconds = 1)
        {
            Driver = driver;
            Driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(waitTimeInSeconds);
        }

        internal void Open()
        {
            Driver.Navigate().GoToUrl(BaseUrl + Path);
        }
    }
}
