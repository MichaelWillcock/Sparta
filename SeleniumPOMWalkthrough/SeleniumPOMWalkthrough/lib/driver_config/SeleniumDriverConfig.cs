using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOMWalkthrough.lib.driver_config
{
    public class SeleniumDriverConfig<T> where T : IWebDriver, new()
    {
        //property driver for later use
        public IWebDriver Driver { get; set; }
        //constructor that calls a method to set up the driver depending on the type of browser we want(firefox or chrome)
        public SeleniumDriverConfig(int pageLoadInSecs, int implicitWaitInSecs)
        {
            Driver = new T();
            DriverSetUp(pageLoadInSecs, implicitWaitInSecs);
        }

        private void DriverSetUp(int pageLoadInSecs, int implicitWaitInSecs)
        {
            //this is the time the driver will wait for the page to load
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadInSecs);
            //This is the time the driver waits for the elements to load before the test fails
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInSecs);
        }
    }
}
