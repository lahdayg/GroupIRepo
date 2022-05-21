using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TestProjectGroupI.PageObject;

namespace TestProjectGroupI.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }


        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            registrationPage.NavigateToWebsite();
        }


        [Given(@"I click on sign up")]
        public void GivenIClickOnSignUp()
        {
            registrationPage.ClickOnSignUp();
        }
        
        [Given(@"I enter my Username")]
        public void GivenIEnterMyUsername()
        {
            registrationPage.EnterUsername();
        }
        
        [Given(@"I enter my email address")]
        public void GivenIEnterMyEmailAddress()
        {
            registrationPage.EnterEmailAddress();
        }
        
        [Given(@"I enter my password")]
        public void GivenIEnterMyPassword()
        {
            registrationPage.EnterPassword();
        }
        
        [When(@"I click on the Sign up button")]
        public void WhenIClickOnTheSignUpButton()
        {
            registrationPage.ClickOnSignUpButton();
        }
        
        [Then(@"I should be able to sign up successfully")]
        public void ThenIShouldBeAbleToSignUpSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(registrationPage.IsNewArticleDisplayed);
        }

        

    }
}
