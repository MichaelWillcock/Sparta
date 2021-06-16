using System;
using TechTalk.SpecFlow;

namespace SeleniumPOMWalkthrough.FeatureFolder
{
    [Binding]
    public class AP_SigninJourneySteps
    {
        AP_SigninSteps steps = new AP_SigninSteps();
        [Given(@"that I have navigated from the home page to the sign in page")]
        public void GivenThatIHaveNavigatedFromTheHomePageToTheSignInPage()
        {
            steps.GivenIAmOnTheSigninPage();
        }
        
        [Then(@"I will be able to go to a form to create an account")]
        public void ThenIWillBeAbleToGoToAFormToCreateAnAccount()
        {
            steps.GivenIHaveEnteredInTheEmailFieldForCreateAccout("testing160621@snailmail.com");
            steps.WhenIClickTheCreateAccountButton();
            steps.ThenAfterWaitingForFiveSecondsIShouldBeTakenToANewPageToCreateAnAccount();
        }
    }
}
