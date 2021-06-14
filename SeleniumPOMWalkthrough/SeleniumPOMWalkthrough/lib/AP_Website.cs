using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumPOMWalkthrough.lib.pages;
using SeleniumPOMWalkthrough.lib.driver_config;
using OpenQA.Selenium;

namespace SeleniumPOMWalkthrough.lib
{
    //Superclass for all service objects
    public class AP_Website<T> where T : IWebDriver, new()
    {
        public IWebDriver SeleniumDriver { get; set; }
        public AP_HomePage AP_Homepage { get; set; }

        public AP_SigninPage AP_SigninPage { get; set; }

        public AP_AccountCreation AP_AccountCreation { get; set; }

        public AP_Website(int pageLostInSecs = 30, int implicitWaitInSecs = 30)
        {
            //instantiate the driver
            SeleniumDriver = new SeleniumDriverConfig<T>(pageLostInSecs, implicitWaitInSecs).Driver;

            //Instantiate the page objects WITH the selenium driver
            AP_SigninPage = new AP_SigninPage(SeleniumDriver);
            AP_Homepage = new AP_HomePage(SeleniumDriver);
            AP_AccountCreation = new AP_AccountCreation(SeleniumDriver);
        }

        //Delete cookies

    }
}
