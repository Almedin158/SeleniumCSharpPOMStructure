using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.AutomationPracticePages
{
    class HomePage
    {
        IWebDriver driver;
        By accountCreationSignUp = By.ClassName("login");
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void AccountCreationSignIn()
        {
            driver.FindElement(accountCreationSignUp).Click();
        }
    }
}
