using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOMWalkthrough.lib.pages
{
    public class AP_HomePage
    {
        private IWebDriver _seleniumDriver;
        //set the homepage url
        private string _homePageUrl = AppConfigReader.BaseUrl;

        //create a private copy that models the sign in link

        private IWebElement _signInLink => _seleniumDriver.FindElement(By.LinkText("Sign in"));

        //CTOR
        public AP_HomePage(IWebDriver seleniumDriver)
        {
            this._seleniumDriver = seleniumDriver;
        }
        //Methods to interact with the elements
        public void VisitHomePage()
        {
            _seleniumDriver.Navigate().GoToUrl(_homePageUrl);
        }
        public void VisitSignInPage() => _signInLink.Click();

        public string GetPageTitle() => _seleniumDriver.Title;
    }
}
