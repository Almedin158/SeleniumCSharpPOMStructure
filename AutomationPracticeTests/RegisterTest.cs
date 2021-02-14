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
    public class RegisterTest
    {
        public IWebDriver driver;
        [SetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void AccountCreation()
        {
            HomePage automationPracticeHomePage = new HomePage(driver);
            automationPracticeHomePage.AccountCreationSignIn();
            Thread.Sleep(10000);
            AccountCreationSignUp accountCreationSignUp = new AccountCreationSignUp(driver);
            Thread.Sleep(10000);
            accountCreationSignUp.CreateAccount();
        }
        //[TearDown]
        //public void TearDown()
        //{
        //    driver.Quit();
        //}
    }
}
