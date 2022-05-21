using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectGroupI.Utilities;

namespace TestProjectGroupI.PageObject
{
    class DataDrivenWithParameter
    {
        public DataDrivenWithParameter()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement Username => driver.FindElement(By.CssSelector("body > div.ng-scope > div > div > div > div > div > form > fieldset > fieldset:nth-child(1) > input"));
        IWebElement EmailAddress => driver.FindElement(By.XPath("//input[@type='email']"));
        IWebElement Password => driver.FindElement(By.CssSelector("input[type='password']"));
        IWebElement Skills => driver.FindElement(By.XPath("//select[@id='Skills']"));




        public void EnterUsername(string username)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Username.SendKeys(username + randomInt);
            //Username.SendKeys(username);
        }

        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterEmailAddress(string email)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            EmailAddress.SendKeys(email + randomInt + "@aol.com");
            //EmailAddress.SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }

        public void SelectSkillFromDropDown()
        {
            SelectElement select = new SelectElement(Skills);
            select.SelectByText("Analytics");
        }











    }
}
