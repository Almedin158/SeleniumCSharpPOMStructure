using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace AutomationPractice.AutomationPracticePages
{
    class HomePage
    {
        IWebDriver driver;
        By logo = By.Id("header_logo");
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
        public void ReturnToHomePage()
        {
            driver.FindElement(logo).Click();
        }
        public void SelectPopular()
        {
            Actions actions = new Actions(driver);
            driver.FindElement(popular).Click();
            IWebElement webElement = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[2]/div/div[1]/ul[1]/li[1]/div"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;//Scrolls down to element, so it is in the view.
            js.ExecuteScript("arguments[0].scrollIntoView();", webElement);//Scrolls down to element, so it is in the view.
            actions.MoveToElement(webElement).Perform();
            driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[2]/div/div[1]/ul[1]/li[1]/div/div[2]/div[2]/a[1]/span")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[3]/div/div/div[4]/div[1]/div[1]/span")).Click();
        }
        public void SelectBestSeller()//I can't seem to find a way to select "Printed Chiffon Dress" and hover over it to be able to select adding it to the cart.//Solved
        {
            Actions actions = new Actions(driver);
            driver.FindElement(bestSeller).Click();
            IWebElement webElement = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[2]/div/div[1]/ul[2]/li[1]/div")); 
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;//Scrolls down to element, so it is in the view.
            js.ExecuteScript("arguments[0].scrollIntoView();", webElement);//Scrolls down to element, so it is in the view.
            actions.MoveToElement(webElement).Perform();
            driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[2]/div/div[1]/ul[2]/li[1]/div/div[2]/div[2]/a[1]/span")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[3]/div/div/div[4]/div[1]/div[1]/span")).Click();
        }
    }
}
