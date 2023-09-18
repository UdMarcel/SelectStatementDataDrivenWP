using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SelectStamentDataDrivenWP.Utilities
{
    [Binding]
    public class SelectStatementHooks
    {
        public static IWebDriver driveme;

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            driveme = new ChromeDriver();
            driveme.Manage().Window.Maximize();
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
           
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //driveme.Quit();
        }
    }
}