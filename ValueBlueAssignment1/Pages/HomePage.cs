using OpenQA.Selenium;
using ValueBlueUI.WebPageAction;

namespace ValueBlueUI.Pages
{
    //Page class for HomePage of Example.com
    public class HomePage
    {
        private IWebDriver driver;
        
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        By moreInfoLink = By.LinkText("More information...");

        public void MoreInfoLocator()
        {
            WebAction.ClickOnMoreInfo(driver, moreInfoLink);
        }
    }
}
