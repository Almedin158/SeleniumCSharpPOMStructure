using System;
using System.Threading;
using AutomationPractice.AutomationPracticePages;
using AutomationPractice.DataSaveClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AutomationPractice.AutomationPracticeTests
{
    [TestFixture]
    public class LogInLogOutTest
    {
        public IWebDriver driver;

        public LogInLogOutTest(IWebDriver driver)
        {
            this.driver = driver;
        }
        [SetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        [Test]
        public void SignIn(IWebDriver driver,Person person)
        {
            HomePage homePage = new HomePage(driver);
            homePage.AccountCreationSignIn();
            AccountCreationSignUp accountCreationSignUp = new AccountCreationSignUp(driver);
            accountCreationSignUp.SignIn(person);
        }
        [Test]
        public void SignOut(IWebDriver driver,Person person)
        {
            AccountCreationSignUp accountCreationSignUp = new AccountCreationSignUp(driver);
            accountCreationSignUp.SignOut();
        }
        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(10000);
            driver.Quit();
        }
    }
}
