using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationPractice.AutomationPracticePages
{
    class HomePage
    {
        IWebDriver driver;
        SelectElement selectElement;
        By signOut = By.ClassName("logout");
        By accountCreationSignUp = By.ClassName("login");
        By cart = By.CssSelector("[href*='http://automationpractice.com/index.php?controller=order']");
        By popular = By.ClassName("homefeatured");
        By bestSeller = By.ClassName("blockbestsellers");
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void AccountCreationSignIn()
        {
            driver.FindElement(accountCreationSignUp).Click();
        }
        public void SignOut()
        {
            driver.FindElement(signOut).Click();
        }
        public void OpenCart()
        {
            driver.FindElement(cart).Click();
        }
        public void SelectPopular()
        {
            driver.FindElement(popular).Click();
        }
        public void SelectBestSeller()//I can't seem to find a way to select "Faded Short Sleeve T-shirts" and hover over it to be able to select adding it to the cart.
        {
            driver.FindElement(bestSeller).Click();
            Actions actions = new Actions(driver);
            IWebElement webElement = driver.FindElement(By.CssSelector("[href*='http://automationpractice.com/index.php?id_product=1&controller=product']"));
            actions.MoveToElement(webElement).Perform();
        }
    }
}
