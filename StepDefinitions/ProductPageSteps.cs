using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TestAutomationFramework.Models.Pages;
using TestAutomationFramework.Hooks;

namespace YourNamespace.StepDefinitions
{
    [Binding]
    public class ProductPageSteps
    {
        private readonly IWebDriver driver;
        private readonly ProductPage productPage;

        public ProductPageSteps()
        {
            driver = WebDriverHooks.GetDriver();
            productPage = new ProductPage(driver);
        }

        [Then(@"I should be navigated to the product page")]
        public void ThenIShouldBeNavigatedToTheProductPage()
        {
            Assert.IsTrue(productPage.IsDisplayed());
        }
    }
}