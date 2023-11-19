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

        internal override bool IsDisplayed()
        {
            try
            {
                return Driver.FindElement(By.CssSelector(loginButtonSelector)).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        internal string ErrorMessageContent()
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

        internal void EnterUsernameAndPassword(string username, string password)
        {
            Driver.FindElement(By.CssSelector(usernameFieldSelector)).SendKeys(username);
            Driver.FindElement(By.CssSelector(passwordFieldSelector)).SendKeys(password);
        }

        internal void ClickLoginButton()
        {
            Driver.FindElement(By.CssSelector(loginButtonSelector)).Click();
        }
    }
}
