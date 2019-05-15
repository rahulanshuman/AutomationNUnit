using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using WebServices;

namespace Tests
{
    [TestFixture]
    public class AutomationTester
    {
        private readonly SampleService _sampleService;
        private static IWebDriver _driver;
        private string _browser = "chrome";
        //private string _applicationUrl = "http://shop.demoqa.com/";
        private string _applicationUrl = "https://www.google.com/";

        public AutomationTester()
        {
            _sampleService = new SampleService();
        }

        private void initiateBrowser()
        {
            if (_browser.Equals("chrome"))
            {
                ChromeOptions chromeoptions = new ChromeOptions()
                {

                };
            
                _driver = new ChromeDriver(@"C:\Users\rahul.anshuman\Documents\VSCode\Automation_Nunit\Automation.Tests\drivers");
            }
        
            // if (_browser.Equals("ie"))
            // {
            //     InternetExplorerOptions ieoptions = new InternetExplorerOptions()
            //     {
            //         EnsureCleanSession = false,
            //         IgnoreZoomLevel = true,
            //         IntroduceInstabilityByIgnoringProtectedModeSettings = true,
            //         EnableNativeEvents = true
            //     };

            //     _driver = new InternetExplorerDriver(@"C:\Users\sushrut.naik\VSCodeWorkSpace\Automation_Nunit\Automation.Tests\drivers\", ieoptions);
            //     return;
            // }
            // if (_browser.Equals("edge"))
            // {
            //     EdgeOptions edgeoptions = new EdgeOptions();                
            //     _driver = new EdgeDriver(@"C:\Users\rahul.anshuman\Documents\VSCode\Automation_Nunit\Automation.Tests\drivers");
            //     return;
            // }
        //     FirefoxOptions firefoxoptions = new FirefoxOptions()
        //     {
        //         AcceptInsecureCertificates = true,
        //     };
        //     _driver = new FirefoxDriver(@"C:\Users\sushrut.naik\VSCodeWorkSpace\Automation_Nunit\Automation.Tests\drivers\", firefoxoptions);
        // }
        }

        [SetUp]
        public void Setup()
        {
            initiateBrowser();
        }

        [Test]
        public void LaunchTestDemo()
        {
            //Open the specified URL in browser
            _driver.Navigate().GoToUrl(_applicationUrl);

            //_driver.Manage().Timeouts().ImplicitWait.(new TimeSpan(0, 0, timeout));
            _driver.Manage().Cookies.DeleteAllCookies();
            //maximize the browser window
            _driver.Manage().Window.Maximize();

            // Storing URL in String variable
            string actualUrl = _driver.Url;

            if (actualUrl.Equals(_applicationUrl))
            {
                System.Console.WriteLine("Verification Successful - The correct Url is opened.");
                
            }
            else
            {
                System.Console.WriteLine("Verification Failed - An incorrect Url is opened.");
                //In case of Fail, you like to print the actual and expected URL for the record purpose
                System.Console.WriteLine("Page URL is : " + actualUrl);
                System.Console.WriteLine("Expected URL is : " + _applicationUrl);
            }
            Assert.AreEqual(actualUrl, _applicationUrl);
            //_driver.FindElement(By.ClassName("noo-search")).SendKeys("Test");
            //_driver.FindElement(By.LinkText(""));  

            System.Console.WriteLine("Page  URL is : " + actualUrl);
            //System.Console.ReadKey();
            
            
        }
        [Test]
        public void getdetail()
        {
            string PageTitle= _driver.Title;
		    int PageLength= PageTitle.Length;
            
             System.Console.WriteLine("Page Title is:" +PageTitle);
             //System.Console.ReadKey();
            // System.Console.WriteLine("Page Length is:" +PageLength); 
             //System.Console.ReadKey();
            
        }
        
    
       
        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}