using AutomationPractice.DataSaveClasses;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationPractice.AutomationPracticePages
{
    class AccountRegister
    {
        IWebDriver driver;
        SelectElement selectElement;
        By firstName = By.Name("customer_firstname");
        By lastName = By.Name("customer_lastname");
        By title=By.Id("id_gender1");
        By password = By.Name("passwd");
        By day = By.Name("days");
        By month = By.Name("months");
        By year = By.Name("years");
        By newsletter = By.Name("newsletter");
        By address = By.Name("address1");
        By city = By.Name("city");
        By state = By.Name("id_state");
        By Country = By.Name("id_country");
        By phoneNumber = By.Name("phone_mobile");
        By addressAlias = By.Name("alias");
        By submitAccount = By.Name("submitAccount");
        By postalCode = By.Name("postcode");
        By logo = By.Id("header_logo");
        By cart = By.CssSelector("[href*='http://automationpractice.com/index.php?controller=order']");
        public AccountRegister(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void CreateAccount(Person person)
        {
            driver.FindElement(title).Click();
            driver.FindElement(firstName).SendKeys(person.getFirstName());
            driver.FindElement(lastName).SendKeys(person.getLastName());
            driver.FindElement(password).SendKeys(person.getPassword());
            selectElement = new SelectElement(driver.FindElement(day));
            selectElement.SelectByIndex(person.getDayOfBirth());
            selectElement = new SelectElement(driver.FindElement(month));
            selectElement.SelectByIndex(person.getMonthOfBirth());
            selectElement = new SelectElement(driver.FindElement(year));
            selectElement.SelectByValue(person.getYearOfBirth().ToString());
            driver.FindElement(newsletter).Click();
            driver.FindElement(address).SendKeys(person.getAddress());
            driver.FindElement(city).SendKeys(person.getCity());
            selectElement = new SelectElement(driver.FindElement(state));
            selectElement.SelectByIndex(person.getState());
            driver.FindElement(postalCode).SendKeys(person.getPostalCode());
            selectElement = new SelectElement(driver.FindElement(Country));
            selectElement.SelectByIndex(person.getCountry());
            driver.FindElement(phoneNumber).SendKeys(person.getMobilePhone());
            driver.FindElement(addressAlias).Clear();
            driver.FindElement(addressAlias).SendKeys(person.getAddressAlias());
            driver.FindElement(submitAccount).Click();
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
