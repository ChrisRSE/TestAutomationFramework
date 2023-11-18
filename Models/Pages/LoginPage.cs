using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationFramework.Models.Pages
{
    internal class LoginPage : DefaultPage
    {
        private readonly string usernameFieldSelector = "#user-name";
        private readonly string passwordFieldSelector = "#password";
        private readonly string loginButtonSelector = "#login-button";
        private readonly string errorMessageSelector = "div.error-message-container > h3";
        internal LoginPage(IWebDriver driver, int waitTimeInSeconds = 1) : base(driver, waitTimeInSeconds)
        {
        }

        public string ErrorMessageContent()
        {
            try 
            {
                return Driver.FindElement(By.CssSelector(errorMessageSelector)).Text;
            } 
            catch (NoSuchElementException)
            {
                return "Error message not found";
            }
        }

        public void AttemptLogin(string username, string password)
        {
            Driver.FindElement(By.CssSelector(usernameFieldSelector)).SendKeys(username);
            Driver.FindElement(By.Id(passwordFieldSelector)).SendKeys(password);
            Driver.FindElement(By.Id(loginButtonSelector)).Click();
        }
    }
}
