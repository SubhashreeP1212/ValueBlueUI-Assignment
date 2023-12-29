using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ValueBlueUI.Utils
{
    //Initialize chrome browser
    public class BrowserUtil
    {
        public static IWebDriver getDriver()
        {          
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            return driver;                
            
        }       
        
    }
}
