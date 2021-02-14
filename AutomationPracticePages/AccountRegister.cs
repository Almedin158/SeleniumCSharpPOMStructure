using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationPractice.AutomationPracticeUtilityFunctions;
using OpenQA.Selenium.Support.UI;

namespace AutomationPractice.AutomationPracticePages
{
    class AccountRegister
    {
        IWebDriver driver;
        By FirstName = By.Name("customer_firstname");
        By LastName = By.Name("customer_lastname");
        By Title;
        By Password = By.Name("passwd");
        By Day = By.Name("days");
        By Month = By.Name("months");
        By Year = By.Name("years");
        By Newsletter = By.Name("newsletter");
        By Address = By.Name("address1");
        By City = By.Name("city");
        By State = By.Name("id_state");
        By Country = By.Name("id_country");
        By PhoneNumber = By.Name("phone_mobile");
        By AddressAlias = By.Name("alias");
        By SubmitAccount = By.Name("submitAccount");
        By PostalCode = By.Name("postcode");
        #region RegistrationData
        string firstName;
        string lastName;
        string email;
        string password;
        string day;
        string month;
        string year;
        string state;
        string phoneNumber;
        #endregion

        public AccountRegister(IWebDriver driver)
        {
            UtilityFunctions utilityFunctions = new UtilityFunctions();
            this.driver = driver;
            firstName = utilityFunctions.GenerateFirstName();
            lastName = utilityFunctions.GenerateLastName();
            email = firstName + lastName + utilityFunctions.GenerateEmailAddress();
            password = utilityFunctions.GeneratePassword();
            Title = By.Id(utilityFunctions.GenerateTitle());
            day = utilityFunctions.GenerateDateOfBirth(1, 31).ToString();
            month = utilityFunctions.GenerateDateOfBirth(1, 12).ToString();
            year = utilityFunctions.GenerateDateOfBirth(1950, 2003).ToString();
            state = utilityFunctions.GenerateDateOfBirth(1, 50).ToString();
            phoneNumber = utilityFunctions.GeneratePhoneNumber();
        }
        public void Register()
        {
            driver.FindElement(Title).Click();
            driver.FindElement(FirstName).SendKeys(firstName);
            driver.FindElement(LastName).SendKeys(lastName);
            driver.FindElement(Password).SendKeys(password);
            SelectDayOfBirth();
            SelectMonthOfBirth();
            SelectYearOfBirth();
            driver.FindElement(Newsletter).Click();
            driver.FindElement(Address).SendKeys("Adema Buce 13");
            driver.FindElement(City).SendKeys("Sarajevo");
            SelectState();
            driver.FindElement(PostalCode).SendKeys("71000");
            SelectCountry();
            driver.FindElement(PhoneNumber).SendKeys(phoneNumber);
            InsertAddressAlias();
            driver.FindElement(SubmitAccount).Click();
        }
        public void SelectDayOfBirth()
        {
            SelectElement selectElement = new SelectElement(driver.FindElement(Day));
            selectElement.SelectByValue(day);
        }
        public void SelectMonthOfBirth()
        {
            SelectElement selectElement = new SelectElement(driver.FindElement(Month));
            selectElement.SelectByValue(month);
        }
        public void SelectYearOfBirth()
        {
            SelectElement selectElement = new SelectElement(driver.FindElement(Year));
            selectElement.SelectByValue(year);
        }
        public void SelectState()
        {
            SelectElement selectElement = new SelectElement(driver.FindElement(State));
            selectElement.SelectByValue(state);
        }
        public void SelectCountry()
        {
            SelectElement selectElement = new SelectElement(driver.FindElement(Country));
            selectElement.SelectByIndex(1);
        }
        public void InsertAddressAlias()
        {
            driver.FindElement(AddressAlias).Clear();
            driver.FindElement(AddressAlias).SendKeys("Adema Buce 13, 71000 Sarajevo");
        }
        public string getEmail()
        {
            return email;
        }
    }
}
