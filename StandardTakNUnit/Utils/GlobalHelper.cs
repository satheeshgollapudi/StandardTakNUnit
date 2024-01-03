using System;
using System.Threading;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using test.Steps;


namespace test.Utils
{
	public class GobalHelper
	{
        public static IWebDriver driver;
        public static ExtentReports extent;
       public static ExtentTest test;
        public static ExtentHtmlReporter htmlReporter;


        [OneTimeSetUp]
        public static void Reports()
         {
           

            string reportPath = @"C:\Users\gskum\OneDrive\Desktop\StandardTakNUnit\StandardTakNUnit\Reports\Report.html"; // Specify the path where you want to save the report

              htmlReporter = new ExtentHtmlReporter(reportPath);
             extent = new ExtentReports();
             extent.AttachReporter(htmlReporter);
         }





        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();


           
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
          
            driver.Navigate().GoToUrl("http://localhost:5000");

            Thread.Sleep(1000);

          

             LoginSteps loginSteps = new LoginSteps();
            loginSteps.doLogin();
        }



        [TearDown]
        public void closeBrowser()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            Status logstatus;

            switch (status)
            {

                case TestStatus.Failed:
                    logstatus=Status.Fail;
                   test.Log(Status.Fail, "Failed");
                    CommonMethods.SaveScreenShotClass.SaveScreenshot(driver, TestContext.CurrentContext.Test.Name);
                    break;

                case TestStatus.Passed:
                    logstatus = Status.Pass;
                   test.Log(Status.Pass, "Passed");
                    //test.AddScreenCaptureFromPath(@"C\Users\gskum\OneDrive\Documents\SatheeshProject\StandardTaskNunitFramework\MarNunitPOMExmaple\Reports\Screenshots");
                    CommonMethods.SaveScreenShotClass.SaveScreenshot(driver, TestContext.CurrentContext.Test.Name);
                    break;

                    
            }
            extent.Flush();
            driver.Close();
           

         
        }

    }
}

