using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SelectStamentDataDrivenWP.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SelectStamentDataDrivenWP.PageObject
{
    class SelectStatementPageObject
    {

        IWebDriver tester;

        public SelectStatementPageObject()
        {
            tester = SelectStatementHooks.driveme;
        }

        IWebElement Firstname => tester.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(1) > div:nth-child(2) > input"));
        IWebElement Lastname => tester.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(1) > div:nth-child(3) > input"));

        IWebElement Address => tester.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(2) > div > textarea"));

        IWebElement Emailaddress => tester.FindElement(By.CssSelector("#eid > input"));

        IWebElement Phonenumber => tester.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(4) > div > input"));

        IWebElement Password => tester.FindElement(By.CssSelector("input[id='firstpassword']"));

        IWebElement Confirmpassword => tester.FindElement(By.XPath("(//input[@type='password'])[2]")); 

        IWebElement Skills => tester.FindElement(By.XPath("(//select[@type='text'])[1]"));

        IWebElement Gender => tester.FindElement(By.XPath("(//input[@type='radio'])[2]"));
        IWebElement Hobbies => tester.FindElement(By.XPath("//input[@type='checkbox'][1]"));
        IWebElement DayOfBirth => tester.FindElement(By.XPath("(//select[@type='text'])[5]"));
        IWebElement MonthOfBirth => tester.FindElement(By.XPath("(//select[@type='text'])[4]"));
        IWebElement YearOfBirth => tester.FindElement(By.XPath("(//select[@type='text'])[3]"));
        IWebElement Language => tester.FindElement(By.XPath("//div[@id='msdd']"));
        IWebElement Catalan => tester.FindElement(By.XPath("//body[@class='ng-scope']"));
        
        IWebElement FirstCountry => tester.FindElement(By.XPath("(//select[@type='text'])[2]"));

        //IWebElement SecondCountry => tester.FindElement(By.CssSelector("span[role='combobox']"));

       // IWebElement  SelectCountry => tester.FindElement(By.CssSelector("(//li[@role='treeitem'])[4]']"));
        //A question on ccsselector for same code

        IWebElement Login => tester.FindElement(By.CssSelector("button[type='submit']"));

        IWebElement Refresh => tester.FindElement(By.CssSelector("button[type='button']"));

        


        public void NavigateToWebsite(string url)
        {
            tester.Navigate().GoToUrl(url);
        }
        public void EnterFirstName(string firstname)
        {
            Firstname.SendKeys(firstname);
        }
        public void EnterLastName(string lastname)
        {
            Lastname.SendKeys(lastname);
        }
        public void EnterAddress(string address)
        {
            Address.SendKeys(address);
        }
        public void EnterEmailAddress(string emailaddress)
        {
            Emailaddress.SendKeys(emailaddress);
        }
        public void EnterPhoneNumber(string phonenumber)
        {
            Phonenumber.SendKeys(phonenumber);
        }
        public void SelectFromDropDown()
        {
            SelectElement select = new SelectElement(Skills);
            select.SelectByIndex(5);
        }
        public void SelectDayOFBirth()
        {
            SelectElement select = new SelectElement(DayOfBirth);
            select.SelectByIndex(3);
        }
        public void SelectMonthOfBirth()
        {
            SelectElement select = new SelectElement(MonthOfBirth); 
            select.SelectByIndex(5);
        }
        public void SelectYearOfBirth()
        {
           
            SelectElement select = new SelectElement(YearOfBirth);
            select.SelectByIndex(70);
        }
        public void SelectFirstCountry()
        {
            SelectElement select = new SelectElement(FirstCountry);
            select.SelectByText("Select Country");
        }
        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }
        public void EnterConfirmPassword(string confirmpassword)
        {
            Confirmpassword.SendKeys(confirmpassword);
        }
        public void ClickOnGender()
        {
            Gender.Click();
        }
        public void ClickOnHobbies()
        {
            Hobbies.Click();
        }
        public void ClickOnLanguage()
        {
            Language.Click();
            Catalan.Click();
        }
        /*public void ClickOnCountry2()
        {
            //SecondCountry.Click();
            SelectCountry.Click();
            //Catalan.Click();
        }*/
        public void Submitbutton()
        {
            Login.Submit();
        }
        public void Refreshbutton()
        {
            Refresh.Click();
        }




    }
}
