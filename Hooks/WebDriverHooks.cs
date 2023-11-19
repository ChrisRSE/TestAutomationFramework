using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationFramework.Hooks
{
    [Binding]
    public class WebDriverHooks
    {
        private static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }
    }
}
