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
    public class AccountTest
    {
        public Person person;
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
        public void AccountCreation()
        {
            person = new Person();
            HomePage homePage = new HomePage(driver);
            homePage.AccountCreationSignIn();
            AccountCreationSignUp accountCreationSignUp = new AccountCreationSignUp(driver);
            accountCreationSignUp.CreateAccount(person);
        }
        [Test]
        public void SignInSignOut()
        {
            LogInLogOutTest logInLogOutTest = new LogInLogOutTest(driver);
            logInLogOutTest.SignIn(driver,person);
            logInLogOutTest.SignOut(driver,person);
        }
        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(10000);
            driver.Quit();
        }
    }
}
