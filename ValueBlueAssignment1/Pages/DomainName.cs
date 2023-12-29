using OpenQA.Selenium;
using ValueBlueUI.WebPageAction;

namespace ValueBlueUI.Pages
{
    //Page Class for DomainNames
    public class DomainName
    {
        private IWebDriver driver;
        public DomainName(IWebDriver driver)
        {
            this.driver = driver;
        }
        By domainNameLists = By.XPath("//div[@class='navigation_box']/ul/li/a");

        public void GetDomainNameList() 
        {
            WebAction.VerifyDomainNameList(driver, domainNameLists);
        }
    }
}
