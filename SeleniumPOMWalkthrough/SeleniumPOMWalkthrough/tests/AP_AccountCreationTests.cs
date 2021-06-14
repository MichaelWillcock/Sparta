using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumPOMWalkthrough.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumPOMWalkthrough.tests
{
    public class AP_AccountCreationTests
    {
        public AP_Website<ChromeDriver> AP_Website = new AP_Website<ChromeDriver>();
        [SetUp]
        public void SetUp()
        {
            AP_Website.AP_AccountCreation.VisitSignInPage();
            AP_Website.AP_AccountCreation.InputEmailCreate("michaelwillcock7@gmail.com");
            AP_Website.AP_AccountCreation.ClickCreate();
            Thread.Sleep(5000);
        }
        [Category("Sad Path")]
        [Test]
        public void GivenThatIClickRegister_WhenNoneOfTheInputBoxesAreInput_ThenIGetAnErrorForEach()
        {
            AP_Website.AP_AccountCreation.ClickRegister();
            Assert.That(AP_Website.AP_AccountCreation.GetRegisterAlertText().Contains("8"));
        }
        [Category("Happy Path")]
        [Test]
        public void GivenThatIClickOnTheLogo_ThenIWantToBeTakenBackToTheHomepage()
        {
            AP_Website.AP_AccountCreation.ClickLogo();
            Assert.That(AP_Website.SeleniumDriver.Title, Is.EqualTo("My Store"));
        }
        //One time tear down to run after we have finished
        [OneTimeTearDown]
        public void CleanUp()
        {
            //Closes all windows
            AP_Website.SeleniumDriver.Quit();
            //Releases unmanaged resources
            AP_Website.SeleniumDriver.Dispose();
        }
    }
}
