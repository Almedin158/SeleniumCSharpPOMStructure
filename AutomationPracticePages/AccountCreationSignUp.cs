﻿using AutomationPractice.DataSaveClasses;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationPractice.AutomationPracticePages
{
    class AccountCreationSignUp
    {
        AccountRegister accountRegister;
        By signOut = By.ClassName("logout");
        By email = By.Name("email");
        By password = By.Name("passwd");
        By submitLogin = By.Name("SubmitLogin");
        By emailAddress = By.Name("email_create");
        By createAnAccount = By.Name("SubmitCreate");
        By logo = By.Id("header_logo");
        By cart = By.CssSelector("[href*='http://automationpractice.com/index.php?controller=order']");
        IWebDriver driver;

        public AccountCreationSignUp(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void CreateAccount(Person person)
        {
            accountRegister = new AccountRegister(driver);
            driver.FindElement(emailAddress).SendKeys(person.getEmail());
            driver.FindElement(createAnAccount).Click();
            accountRegister.CreateAccount(person);
        }
        public void SignIn(Person person)
        {
            driver.FindElement(email).SendKeys(person.getEmail());
            driver.FindElement(password).SendKeys(person.getPassword());
            driver.FindElement(submitLogin).Click();
        }
        public void SignOut()
        {
            driver.FindElement(signOut).Click();
        }
        public void ReturnToHomePage()
        {
            driver.FindElement(logo).Click();
        }
        public void OpenCart()
        {
            driver.FindElement(cart).Click();
        }
    }
}
