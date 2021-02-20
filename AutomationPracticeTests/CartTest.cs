using System;
using System.Threading;
using AutomationPractice.AutomationPracticePages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AutomationPractice.AutomationPracticeTests
{
    [TestFixture]
    public class CartTest
    {
        public IWebDriver driver;
        [SetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        [Test]
        public void AddToCart()
        {
            HomePage homePage = new HomePage(driver);
            homePage.SelectBestSeller();
            homePage.ReturnToHomePage();
            homePage.SelectPopular();
        }
        [Test]
        public void OpenCart()
        {
            HomePage homePage = new HomePage(driver);
            homePage.OpenCart();
        }
        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(10000);
            driver.Quit();
        }
    }
}
