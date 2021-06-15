using OpenQA.Selenium;
using SeleniumPOMWalkthrough.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOMWalkthrough.lib.pages
{
    public class AP_SigninPage
    {
        //Web Driver
        private IWebDriver _seleniumDriver;

        //URL
        private string _signInPageUrl = AppConfigReader.SignInPageUrl;
        //web elements
        private IWebElement _emailSignInField => _seleniumDriver.FindElement(By.Id("email"));
        private IWebElement _emailCreateField => _seleniumDriver.FindElement(By.Id("email_create"));
        private IWebElement _passwordField => _seleniumDriver.FindElement(By.Id("passwd"));
        private IWebElement _signinButton => _seleniumDriver.FindElement(By.Id("SubmitLogin"));
        private IWebElement _createButton => _seleniumDriver.FindElement(By.Id("SubmitCreate"));
        private IWebElement _signinAlert => _seleniumDriver.FindElement(By.ClassName("alert"));
        private IWebElement _createAlert => _seleniumDriver.FindElement(By.Id("create_account_error"));
        private IWebElement _forgotPasswordLink => this._seleniumDriver.FindElement(By.LinkText("Forgot your password?"));

        public AP_SigninPage(IWebDriver seleniumDriver)
        {
            this._seleniumDriver = seleniumDriver;
        }
        public void VisitSignInPage() => _seleniumDriver.Navigate().GoToUrl(_signInPageUrl);
        public void InputEmailLogin(string email) => _emailSignInField.SendKeys(email);
        public void InputEmailCreate(string email) => _emailCreateField.SendKeys(email);
        public void InputPasswordLogin(string password) => _passwordField.SendKeys(password);
        public void ClickSignin() => _signinButton.Click();
        public void ClickCreate() => _createButton.Click();
        public string GetSignInAlertText() => _signinAlert.Text;
        public string GetCreateAlertTest() => _createAlert.Text;
        public void ClickForgotPasswordLink() => _forgotPasswordLink.Click();

        internal void InputSigninCredentials(Credentials credentials)
        {
            _emailSignInField.SendKeys(credentials.Email);
            _passwordField.SendKeys(credentials.Password);
        }
    }
}
