using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationFramework.Models.Pages
{
    internal class ProductPage : DefaultPage
    {
        private readonly string spanTitleSelector = ".title";

        internal ProductPage(IWebDriver driver, int waitTimeInSeconds = 1) : base(driver, waitTimeInSeconds)
        {
        }

        internal override bool IsDisplayed()
        {
            try
            {
                return Driver.FindElement(By.CssSelector(spanTitleSelector)).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
