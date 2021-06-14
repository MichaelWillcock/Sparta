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
    public class AP_SignInTests
    {
        //Instantiate our pages in our tests
        public AP_Website<ChromeDriver> AP_Website = new AP_Website<ChromeDriver>();


        //Test for checking we land on the sign in page
        [Category("Happy Path")]
        [Test]
        public void GivenIAmOnTheHomePage_WhenIClickTheSignInButton_ThenIShouldLandOnTheSignInPage()
        {
            //Navigate to the homepage
            AP_Website.AP_Homepage.VisitHomePage();
            //Navigate to the sign in page
            AP_Website.AP_Homepage.VisitSignInPage();
            //Check the page title is correct
            Assert.That(AP_Website.SeleniumDriver.Title, Is.EqualTo("Login - My Store"));
        }
        [Category("Sad Path")]
        [Test]
        public void GivenIAmOnTheSignInPage_AndEnterAnInvalidEmailToSignIn_WhenIClickSignIn_ThenIShouldGetAnError()
        {
            //Navigate to the sign in page
            AP_Website.AP_SigninPage.VisitSignInPage();
            //Enter an email to sign in
            AP_Website.AP_SigninPage.InputEmailLogin("NotAValidEmail");
            //Enter a password to sign in
            AP_Website.AP_SigninPage.InputPasswordLogin("four");
            //Click the sign in button
            AP_Website.AP_SigninPage.ClickSignin();
            Thread.Sleep(5000);
            //Assert that new page Id has been achieved
            Assert.That(AP_Website.AP_SigninPage.GetSignInAlertText().Contains("Invalid email"));
        }
        [Category("Sad Path")]
        [Test]
        public void GivenIAmOnTheSignINPage_AndEnterA4DigitPassword_WhenIClickTheSignInButton_ThenIShouldLandGetAnErrorMessage()
        {
            //Navigate to the sign in page
            AP_Website.AP_SigninPage.VisitSignInPage();
            AP_Website.AP_SigninPage.InputEmailLogin("testing@snailmail.com");
            AP_Website.AP_SigninPage.InputPasswordLogin("four");
            AP_Website.AP_SigninPage.ClickSignin();
            Assert.That(AP_Website.AP_SigninPage.GetSignInAlertText().Contains("Invalid password"));
        }
        [Category("Happy Path")]
        [Test]
        public void GivenIAmOnTheSignInPage_AndEnterAValidEmailToCreateAnAccount_WhenIClickCreateAnAccount_ThenIShouldGoToAnAuthenticationPage()
        {
            //Navigate to the sign in page
            AP_Website.AP_SigninPage.VisitSignInPage();
            //Enter an email to create an account
            AP_Website.AP_SigninPage.InputEmailCreate("testing140621@snailmail.com");
            //Click create an account button
            AP_Website.AP_SigninPage.ClickCreate();
            Thread.Sleep(5000);
            //Assert that new page Id has been achieved
            Assert.That(AP_Website.SeleniumDriver.Url.Contains("account-creation"));
        }
        [Category("Sad Path")]
        [Test]
        public void GivenIAmOnTheSignInPage_AndEnterAnInvalidEmailToCreateAnAccount_WhenIClickCreateAnAccount_ThenIShouldGetAnError()
        {
            //Navigate to the sign in page
            AP_Website.AP_SigninPage.VisitSignInPage();
            //Enter an email to create an account
            AP_Website.AP_SigninPage.InputEmailCreate("NotAValidEmail");
            //Click create an account button
            AP_Website.AP_SigninPage.ClickCreate();
            Thread.Sleep(5000);
            //Assert that new page Id has been achieved
            Assert.That(AP_Website.AP_SigninPage.GetCreateAlertTest().Contains("Invalid email"));
        }
        [Category("Sad Path")]
        [Test]
        public void GivenIAmOnTheSignInPage_AndEnterAnEmailAlreadyInUseToCreateAnAccount_WhenIClickCreateAnAccount_ThenIShouldGetAnError()
        {
            //Navigate to the sign in page
            AP_Website.AP_SigninPage.VisitSignInPage();
            //Enter an email to create an account
            AP_Website.AP_SigninPage.InputEmailCreate("testing@snailmail.com");
            //Click create an account button
            AP_Website.AP_SigninPage.ClickCreate();
            Thread.Sleep(5000);
            //Assert that new page Id has been achieved
            Assert.That(AP_Website.AP_SigninPage.GetCreateAlertTest().Contains("An account using this email address has already been register"));
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
