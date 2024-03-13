
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
        private static readonly string DriverDirectory = "C:\\Driver";
        private static IWebDriver _driver;


        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _driver = new ChromeDriver(DriverDirectory);
        }

        [ClassCleanup]
        public static void TearDown()
        {
            _driver.Dispose();
        }


        [TestMethod]
        public void TestMethod1()
        {
            _driver.Navigate().GoToUrl("https://vuecollectwordsgulsum.azurewebsites.net/");   
            Assert.AreEqual("Collect words", _driver.Title);
        }


    }
}