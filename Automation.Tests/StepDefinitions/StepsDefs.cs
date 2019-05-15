using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests.StepDefinitions
{
    [Binding]
    public class StepDefinitions
    {
        [Given(@"I launch the Application")]
        public void IlaunchTheBrowser()
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\rahul.anshuman\Documents\VSCode\Automation_Nunit\Automation.Tests\drivers");
            driver.Navigate().GoToUrl("http://testapp.galenframework.com");
        }
    }
}