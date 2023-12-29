using OpenQA.Selenium;
using ValueBlueUI.WebPageAction;

namespace ValueBlueUI.Pages
{
    //Page Class for RFC 2606 and RFC 6761 links

    public class MoreInformation
    {
        private IWebDriver driver;
        public MoreInformation(IWebDriver driver)
        {
            this.driver = driver;
        }
        By link1 = By.LinkText("RFC 2606");
        By link2 = By.LinkText("RFC 6761");
        By domainNameLink = By.XPath("//td[@class='section']/a[@href='/domains']");

        public void GetLinkText()
        {
            WebAction.VerifyLinkText(driver, link1, link2);
        }
        public void GetDomainNameLink()
        {
            WebAction.ClickOnDomainNameLink(driver, domainNameLink);
        }
    }
}
