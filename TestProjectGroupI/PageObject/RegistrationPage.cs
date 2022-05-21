using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectGroupI.Utilities;

namespace TestProjectGroupI.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement SignUp => driver.FindElement(By.XPath("/html/body/div[1]/app-header/nav/div/ul[1]/li[3]/a"));
        IWebElement Username => driver.FindElement(By.CssSelector("body > div.ng-scope > div > div > div > div > div > form > fieldset > fieldset:nth-child(1) > input"));
        IWebElement EmailAddress => driver.FindElement(By.XPath("//input[@type='email']"));
        IWebElement Password => driver.FindElement(By.CssSelector("input[type='password']"));
        IWebElement SignUpButton => driver.FindElement(By.XPath("//button[text()='Sign up']"));
        IWebElement NewArticle => driver.FindElement(By.XPath("(//a[@class='nav-link'])[3]"));


        public void ClickOnSignUp()
        {
            SignUp.Click();
        }

        public void EnterUsername()
        {
            Username.SendKeys("ggjjhhhf");
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");
        }

        public void EnterEmailAddress()
        {
            EmailAddress.SendKeys("yakubuwest1923@demo.com");
        }

        public void EnterPassword()
        {
            Password.SendKeys("PasswordSecure");
        }

        public void ClickOnSignUpButton()
        {
            SignUpButton.Click();
        }

        public bool IsNewArticleDisplayed()
        {
            return NewArticle.Displayed;
        }














    }
}
