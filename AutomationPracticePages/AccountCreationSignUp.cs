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
        AccountRegister automationPracticeAccountRegister;
        By emailAddress = By.Name("email_create");
        By createAnAccount = By.Name("SubmitCreate");
        IWebDriver driver;

        public AccountCreationSignUp(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void CreateAccount()
        {
            automationPracticeAccountRegister = new AccountRegister(driver);
            driver.FindElement(emailAddress).SendKeys(automationPracticeAccountRegister.getEmail());
            driver.FindElement(createAnAccount).Click();
            Thread.Sleep(10000);
            automationPracticeAccountRegister.Register();
        }
    }
}
