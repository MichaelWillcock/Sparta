using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOMWalkthrough.lib.pages
{
    public class AP_AccountCreation
    {
        //Web Driver
        private IWebDriver _seleniumDriver;

        //URL
        private string _signInPageUrl = AppConfigReader.SignInPageUrl;
        //web elements
        private IWebElement _emailCreateField => _seleniumDriver.FindElement(By.Id("email_create"));
        private IWebElement _createButton => _seleniumDriver.FindElement(By.Id("SubmitCreate"));
        private IWebElement _registerButton => _seleniumDriver.FindElement(By.Id("submitAccount"));
        private IWebElement _getRegisterAlert => _seleniumDriver.FindElement(By.ClassName("alert"));
        private IWebElement _returnToHomepage => _seleniumDriver.FindElement(By.CssSelector(".logo"));

        public AP_AccountCreation(IWebDriver seleniumDriver)
        {
            this._seleniumDriver = seleniumDriver;
        }
        public void VisitSignInPage() => _seleniumDriver.Navigate().GoToUrl(_signInPageUrl);
        public void InputEmailCreate(string email) => _emailCreateField.SendKeys(email);
        public void ClickCreate() => _createButton.Click();
        public void ClickRegister() => _registerButton.Click();
        public string GetRegisterAlertText() => _getRegisterAlert.Text;
        public void ClickLogo() => _returnToHomepage.Click();
    }
}
