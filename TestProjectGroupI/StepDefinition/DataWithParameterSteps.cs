using System;
using TechTalk.SpecFlow;
using TestProjectGroupI.PageObject;

namespace TestProjectGroupI.StepDefinition
{
    [Binding]
    public class DataWithParameterSteps
    {

        DataDrivenWithParameter dataDrivenWithParameter;

        public DataWithParameterSteps()
        {
            dataDrivenWithParameter = new DataDrivenWithParameter();
        }



        [Given(@"I navigate to the ""(.*)""")]
        public void GivenINavigateToThe(string url)
        {
            dataDrivenWithParameter.NavigateToWebsite(url);
        }
        
        [Given(@"I enter my Username ""(.*)""")]
        public void GivenIEnterMyUsername(string username)
        {
            dataDrivenWithParameter.EnterUsername(username);
        }
        
        [Given(@"I enter my email address ""(.*)""")]
        public void GivenIEnterMyEmailAddress(string email)
        {
            dataDrivenWithParameter.EnterEmailAddress(email);
        }
        
        [Given(@"I enter my password ""(.*)""")]
        public void GivenIEnterMyPassword(string password)
        {
            dataDrivenWithParameter.EnterPassword(password);
        }

        [Given(@"I select any skills from the dropdown")]
        public void GivenISelectAnySkillsFromTheDropdown()
        {
            dataDrivenWithParameter.SelectSkillFromDropDown();
        }

    }
}
