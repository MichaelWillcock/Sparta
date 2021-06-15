using System;
using TechTalk.SpecFlow;
using SeleniumPOMWalkthrough.lib;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;
using SeleniumPOMWalkthrough.Utils;
using System.Threading;

namespace SeleniumPOMWalkthrough.FeatureFolder
{
    [Binding]
    public class AP_SigninSteps
    {
        public AP_Website<ChromeDriver> AP_Website = new AP_Website<ChromeDriver>();
        private Credentials _credentials;
        [BeforeScenario("@google")]
        public void GoToGoogle()
        {
            AP_Website.SeleniumDriver.Navigate().GoToUrl(@"https://www.google.com");
        }
        [BeforeScenario("create")]
        public void GoToAccountCreation()
        {
            AP_Website.AP_AccountCreation.VisitSignInPage();
            AP_Website.AP_AccountCreation.InputEmailCreate("michaelwillcock7@gmail.com");
            AP_Website.AP_AccountCreation.ClickCreate();
            Thread.Sleep(10000);
        }

        [Given(@"I am on the signin page")]
        public void GivenIAmOnTheSigninPage()
        {
            AP_Website.AP_SigninPage.VisitSignInPage();
        }

        [Given(@"I have entered ""(.*)"" in the email field")]
        public void GivenIHaveEnteredInTheEmailField(string email)
        {
            AP_Website.AP_SigninPage.InputEmailLogin(email);
        }

        [Given(@"I have entered the (.*)")]
        public void GivenIHaveEnteredThe(string password)
        {
            AP_Website.AP_SigninPage.InputPasswordLogin(password);
        }
        
        [When(@"I click the sign in button")]
        public void WhenIClickTheSignInButton()
        {
            AP_Website.AP_SigninPage.ClickSignin();
        }
        
        [Then(@"I should see an alert containing an error message ""(.*)""")]
        public void ThenIShouldSeeAnAlertContainingAnErrorMessage(string expected)
        {
            Assert.That(AP_Website.AP_SigninPage.GetSignInAlertText().Contains(expected));
        }

        [When(@"I click the forgot your password\? link")]
        public void WhenIClickTheForgotYourPasswordLink()
        {
            AP_Website.AP_SigninPage.ClickForgotPasswordLink();
        }

        [Given(@"I have the following credentials:")]
        public void GivenIHaveTheFollowingCredentials(Table table)
        {
            _credentials = table.CreateInstance<Credentials>();
        }

        [When(@"I enter these credentials")]
        public void WhenIEnterTheseCredentials()
        {
            AP_Website.AP_SigninPage.InputSigninCredentials(_credentials);
        }

        [Given(@"I have entered ""(.*)"" in the email field for create accout")]
        public void GivenIHaveEnteredInTheEmailFieldForCreateAccout(string email)
        {
            AP_Website.AP_SigninPage.InputEmailCreate(email);
        }

        [Given(@"I have entered ""(.*)"" into the email field for create account")]
        public void GivenIHaveEnteredIntoTheEmailFieldForCreateAccount(string email)
        {
            AP_Website.AP_SigninPage.InputEmailCreate(email);
        }

        [Given(@"I click register on the create account page")]
        public void GivenIClickRegisterOnTheCreateAccountPage()
        {
            AP_Website.AP_AccountCreation.ClickRegister();
        }

        [Then(@"After waiting for (.*) seconds I should see eight alerts")]
        public void ThenAfterWaitingForSecondsIShouldSeeEightAlerts(int p0)
        {
            Thread.Sleep(10000);
            Assert.That(AP_Website.AP_AccountCreation.GetRegisterAlertText().Contains("8"));
        }


        [When(@"I click the create account button")]
        public void WhenIClickTheCreateAccountButton()
        {
            AP_Website.AP_SigninPage.ClickCreate();
        }

        [Then(@"After waiting for five seconds I should see an separate alert containing an error message ""(.*)""")]
        public void ThenAfterWaitingForFiveSecondsIShouldSeeAnSeparateAlertContainingAnErrorMessage(string p0)
        {
            Thread.Sleep(10000);
            Assert.That(AP_Website.AP_SigninPage.GetCreateAlertTest().Contains("Invalid email address."));
        }

        [Then(@"After waiting for five seconds I should be taken to a new page to create an account")]
        public void ThenAfterWaitingForFiveSecondsIShouldBeTakenToANewPageToCreateAnAccount()
        {
            Thread.Sleep(10000);
            Assert.That(AP_Website.SeleniumDriver.Url.Contains("account-creation"));
        }


        [Then(@"I will go to a form that will reset my password")]
        public void ThenIWillGoToAFormThatWillResetMyPassword()
        {
            Assert.That(AP_Website.SeleniumDriver.Title, Is.EqualTo("Forgot your password - My Store"));
        }

        [After]
        public void DisposeWebDriver()
        {
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();
        }
    }
}
