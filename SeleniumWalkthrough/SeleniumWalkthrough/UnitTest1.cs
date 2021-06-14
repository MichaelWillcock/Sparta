using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace SeleniumWalkthrough
{
    public class Tests
    {

        [Test]
        public void GivenIAmOnTheHomepage_WhenIClickTheSignInLink_ThenIAmNavigatedToTheSignInPage()
        {
            //Creating a disposable object that can be disposed of when it is out of scope.
            using (IWebDriver driver = new ChromeDriver())
            {
                //Maximise the browser so it is fullscreen
                driver.Manage().Window.Maximize();
                //Navigate to the Automation Practice website.
                driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
                //Grab the sign in link element
                var _signinLink = driver.FindElement(By.LinkText("Sign in"));
                //Interact with web element
                _signinLink.Click();
                //Wait to ensure a response
                Thread.Sleep(5000);
                //Assert that we are now on the sign in page.
                Assert.That(driver.Title, Is.EqualTo("Login - My Store"));
            }
        }
        [Test]
        public void GivenThatIAmOnTheSignInPage_WhenIEnterA4DigitPassword_WhenIClickTheLoginButton_ThenIGetAnErrorMessage()
        {
            //Creating a disposable object that can be disposed of when it is out of scope.
            using (IWebDriver driver = new ChromeDriver())
            {
                //Maximise the browser so it is fullscreen
                driver.Manage().Window.Maximize();
                //Navigate to the Automation Practice website.
                driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication");
                //Grab the email input field
                IWebElement emailfield = driver.FindElement(By.Id("email"));
                //Input a valid email
                emailfield.SendKeys("testing@snailmail.com");
                //Grab the password input field
                IWebElement passwordfield = driver.FindElement(By.Id("passwd"));
                //Input a valid password
                passwordfield.SendKeys("four");
                //Grab the sign in button
                IWebElement signinButton = driver.FindElement(By.Id("SubmitLogin"));
                //Click the login button
                signinButton.Click();
                //Find the alert element
                IWebElement alert = driver.FindElement(By.ClassName("alert"));
                //Check the correct error message is displayed for invalid password
                Assert.That(alert.Text.Contains("Invalid password"));
            }
        }
        [Test]
        public void GivenThatIAmOnTheSignInPage_WhenIEnterAnInvalidEmail_WhenIClickTheLoginButton_ThenIGetAnErrorMessage()
        {
            //Creating a disposable object that can be disposed of when it is out of scope.
            using (IWebDriver driver = new ChromeDriver())
            {
                //Maximise the browser so it is fullscreen
                driver.Manage().Window.Maximize();
                //Navigate to the Automation Practice website.
                driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication");
                //Grab the email input field
                IWebElement emailfield = driver.FindElement(By.Id("email"));
                //Input a valid email
                emailfield.SendKeys("invalidEmail");
                //Grab the password input field
                IWebElement passwordfield = driver.FindElement(By.Id("passwd"));
                //Input a valid password
                passwordfield.SendKeys("four");
                //Grab the sign in button
                IWebElement signinButton = driver.FindElement(By.Id("SubmitLogin"));
                //Click the login button
                signinButton.Click();
                //Find the alert element
                IWebElement alert = driver.FindElement(By.ClassName("alert"));
                //Check the correct error message is displayed for invalid password
                Assert.That(alert.Text.Contains("Invalid email address"));
            }
        }
        [Test]
        public void GivenThatWhenIAmOnTheHomepage_WhenIEnterShirtsIntoTheSearchBarAndClickSearch_IAmTakenToANewPageShowingMyResults()
        {
            //Creating a disposable object that can be disposed of when it is out of scope.
            using (IWebDriver driver = new ChromeDriver())
            {
                //Maximise the browser so it is fullscreen
                driver.Manage().Window.Maximize();
                //Navigate to the Automation Practice website.
                driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
                //Grab the search input field
                IWebElement searchField = driver.FindElement(By.Id("search_query_top"));
                //Input a valid email
                searchField.SendKeys("Shirts");
                //Grab the search button
                IWebElement searchButton = driver.FindElement(By.Name("submit_search"));
                //Click the search button
                searchButton.Click();
                //Assert something
                Assert.That(driver.Title.Contains("Search - My Store"));
            }
        }
        [Test]
        public void GivenThatWhenIAmOnTheHomepage_WhenIHoverOverWomensAndClickOnBlouses_IAmTakenToANewPageShowingWomensBlouses()
        {
            //Creating a disposable object that can be disposed of when it is out of scope.
            using (IWebDriver driver = new ChromeDriver())
            {
                //Maximise the browser so it is fullscreen
                driver.Manage().Window.Maximize();
                //Navigate to the Automation Practice website.
                driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
                //Find women's section
                var womensElement = driver.FindElement(By.LinkText("WOMEN"));
                //Instantiate an action which we can use for more complex things
                Actions action = new Actions(driver);
                //get the mouse to hover over the woman element
                action.MoveToElement(womensElement).Perform();
                Thread.Sleep(5000);
                //Grab the blouses button
                var blouseButton = driver.FindElement(By.LinkText("Blouses"));
                //Click the blouses button
                blouseButton.Click();
                //Assert Something
                Assert.That(driver.Title.Contains("Blouses - My Store"));
            }
        }
        [Test]
        public void JohnLewisTest()
        {
            //Creating a disposable object that can be disposed of when it is out of scope.
            using (IWebDriver driver = new ChromeDriver())
            {
                //Maximise the browser so it is fullscreen
                driver.Manage().Window.Maximize();
                //Navigate to the Automation Practice website.
                driver.Navigate().GoToUrl("https://www.johnlewis.com/");

                //Find homes and gardens section
                var homeAndGardenElement = driver.FindElement(By.LinkText("Home & Garden"));
                Thread.Sleep(5000);
                //If an 'allow cookies' button appears
                var acceptAllCookiesButton = driver.FindElement(By.ClassName("c-button-yMKB7"));
                //Accept all cookies
                acceptAllCookiesButton.Click();
                //Instantiate an action which we can use for more complex action.
                Actions action = new Actions(driver);
                //Get mouse to hover over the house and garden element
                action.MoveToElement(homeAndGardenElement).Perform();
                Thread.Sleep(5000);
                //Grab the bedding link
                var beddingLink = driver.FindElement(By.LinkText("Bedding"));
                //Click bedding link
                beddingLink.Click();
                //Assert something
                Assert.That(driver.Title.Contains("Bedding | Bed Sets and Bed Linen"));
            }
        }
    }
}