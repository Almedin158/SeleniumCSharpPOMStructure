using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;

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
        public void SelectBestSeller()//I can't seem to find a way to select "Printed Chiffon Dress" and hover over it to be able to select adding it to the cart.//Solved
        {
            driver.FindElement(bestSeller).Click();
            Actions actions = new Actions(driver);
            IWebElement webElement = driver.FindElement(By.XPath("(//img[@alt='Printed Chiffon Dress'])[2]")); 
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;//Scrolls down to element, so it is in the view.
            js.ExecuteScript("arguments[0].scrollIntoView();", webElement);//Scrolls down to element, so it is in the view.
            actions.MoveToElement(webElement).Perform();
            driver.FindElement(By.XPath("//ul[@id='blockbestsellers']/li/div/div[2]/div[2]/a/span")).Click();
        }
    }
}
