using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace DemoAutomation
{     
    /// <summary>
    /// Base class to intialize basic functions like driver , reporting etc setup
    /// </summary>
    public class Base
    {

        public ExtentReports extent;  //for extent report generation
        public ExtentTest test;
        public static IWebDriver driver; 

        [OneTimeSetUp]
        // Report generation setup
        public void Setup()
        {
            string workingDir = Environment.CurrentDirectory;
            string projectDir = Directory.GetParent(workingDir).Parent.Parent.FullName;
            string path = projectDir + "//report.html";

            var htmlReporter = new ExtentHtmlReporter(path);
            extent = new ExtentReports();

            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Hostname", "Localhost");
            extent.AddSystemInfo("Tester", "Pushkar");
        }

        [SetUp]
        //Initializing Driver and adding testnames to report
        public void Initialize()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name); //Attaching Testname to report
            String url = "https://jqueryui.com/";
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }


        [TearDown]
        //Checking Test case Pass/Fail status
        public void Close()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = TestContext.CurrentContext.Result.StackTrace;

                     

            if (status == TestStatus.Failed)
            {
                test.Fail("test Failed");
                test.Log(Status.Fail, "test Failed with " + stackTrace);
            }
            else if (status == TestStatus.Passed)
            {
                test.Pass("test Passed");
            }

            driver.Close();
            
        }
        

        [OneTimeTearDown]
        //Flushing report and quitting driver
        public void Quit()
        {
            extent.Flush();
            driver.Quit();
        }

    }
}
