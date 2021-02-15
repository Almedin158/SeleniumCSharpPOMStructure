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
    public class RegisterTest
    {
        public Person person;
        public IWebDriver driver;
        [SetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000);
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
        public void SignIn()
        {
            HomePage homePage = new HomePage(driver);
            homePage.AccountCreationSignIn();
            AccountCreationSignUp accountCreationSignUp = new AccountCreationSignUp(driver);
            accountCreationSignUp.SignIn(person);
        }
        [Test]
        public void SignOut()
        {
            AccountCreationSignUp accountCreationSignUp = new AccountCreationSignUp(driver);
            accountCreationSignUp.SignOut();
        }
        [Test]
        public void SignInSignOut()
        {
            SignIn();
            SignOut();
        }
        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(10000);
            driver.Quit();
        }
    }
}
