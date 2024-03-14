
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;



namespace CollectWordsTestProject
{
    [TestClass]
    public class UnitTest1
    {
        //Providing the path to the ChromeDriver on my pc
        private static readonly string DriverDirectory = "C:\\Driver";
        private static IWebDriver _driver;


        [ClassInitialize]

        //Setting up the driver
        public static void Setup(TestContext context)
        {
            _driver = new ChromeDriver(DriverDirectory);
        }

        [ClassCleanup]

        //Closing the driver with either Dispose or Quit
        public static void TearDown()
        {
            _driver.Dispose();
        }


        [TestMethod]
        public void TestMethod1()
        {
            //Navigating the driver to my website
            _driver.Navigate().GoToUrl("https://vuecollectwordsgulsum.azurewebsites.net/");   

            //Testing.. the title of the websitte
            Assert.AreEqual("Collect words", _driver.Title);

            //Testing.. the input element   
            IWebElement inputElement1 = _driver.FindElement(By.Id("InputWordId"));
            inputElement1.SendKeys("Hello");

            //Testing.. the save button
            IWebElement saveButton = _driver.FindElement(By.Id("SaveButtonId"));
            saveButton.Click();

            //Testing.. the show button
            IWebElement showButton = _driver.FindElement(By.Id("ShowButtonId"));
            showButton.Click();

            //Testing.. the clear button
            IWebElement clearButton = _driver.FindElement(By.Id("ClearButtonId"));

        }


    }
}