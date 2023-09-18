using SelectStamentDataDrivenWP.PageObject;
using System;
using TechTalk.SpecFlow;

namespace SelectStamentDataDrivenWP.StepDefinitions
{
    [Binding]
    public class SelectSatementStepDefinitions
    {
        SelectStatementPageObject selectStatementPageObject;
        public SelectSatementStepDefinitions()
        {
         selectStatementPageObject = new SelectStatementPageObject();
        }
        [Given(@"I naviagte to the website ""([^""]*)""")]
        public void GivenINaviagteToTheWebsite(string url)
        {
            selectStatementPageObject.NavigateToWebsite(url);
        }
        [Given(@"I enter my firstname ""([^""]*)""")]
        public void GivenIEnterMyFirstname(string firstname)
        {
            selectStatementPageObject.EnterFirstName(firstname);
        }

        [Given(@"I enter last name ""([^""]*)""")]
        public void GivenIEnterLastName(string lastname)
        {
            selectStatementPageObject.EnterLastName(lastname);
        }

        [Given(@"I enter my address ""([^""]*)""")]
        public void GivenIEnterMyAddress(string address)
        {
            selectStatementPageObject.EnterAddress(address);
        }

        [Given(@"I enter my email address ""([^""]*)""")]
        public void GivenIEnterMyEmailAddress(string emailaddress)
        {
            selectStatementPageObject.EnterEmailAddress(emailaddress);
        }

        [Given(@"I enter my phone number ""([^""]*)""")]
        public void GivenIEnterMyPhoneNumber(string phonenumber)
        {
            selectStatementPageObject.EnterPhoneNumber(phonenumber);
        }

        [Given(@"I choose my gender")]
        public void GivenIChooseMyGender()
        {
            selectStatementPageObject.ClickOnGender();
        }

        [Given(@"I choose my hobbies")]
        public void GivenIChooseMyHobbies()
        {
            selectStatementPageObject.ClickOnHobbies();
        }

        [Given(@"I select my language")]
        public void GivenISelectMyLanguage()
        {
            selectStatementPageObject.ClickOnLanguage();
        }

        [Given(@"I select my skills")]
        public void GivenISelectMySkills()
        {
            selectStatementPageObject.SelectFromDropDown();
        }

        [Given(@"I select my country")]
        public void GivenISelectMyCountry()
        {
            selectStatementPageObject.SelectFirstCountry();
        }
        [Given(@"I select my secondcountry")]
        /*public void GivenISelectMySecondcountry()
        {
            selectStatementPageObject.ClickOnCountry2();
        }*/
        [Given(@"I select DOB")]
        public void GivenISelectDOB()
        {
            selectStatementPageObject.SelectDayOFBirth();
        }

        [Given(@"I select MOB")]
        public void GivenISelectMOB()
        {
            selectStatementPageObject.SelectMonthOfBirth();
        }

        [Given(@"I select YOB")]
        public void GivenISelectYOB()
        {
            selectStatementPageObject.SelectYearOfBirth();
        }


        [Given(@"I enter my password ""([^""]*)""")]
        public void GivenIEnterMyPassword(string password)
        {
            selectStatementPageObject.EnterPassword(password);
        }

        [Given(@"I enter my confirm password ""([^""]*)""")]
        public void GivenIEnterMyConfirmPassword(string confirmpassword)
        {
            selectStatementPageObject.EnterConfirmPassword(confirmpassword);
        }

        [When(@"I click submit")]
        public void WhenIClickSubmit()
        {
            Thread.Sleep(5000);
            selectStatementPageObject.Submitbutton();
        }
        /*[When(@"I click on refresh")]
        public void WhenIClickOnRefresh()
        {
            throw new PendingStepException();
        }*/


        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}


