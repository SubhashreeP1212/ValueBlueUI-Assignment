using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using ValueBlueUI.WebPageAction;
using ValueBlueUI.Pages;
using ValueBlueUI.Utils;

namespace ValueBlueUI.StepDefinitions
{
    [Binding]
    public class ExampleStepDefinitions
    {
        private IWebDriver driver;
        HomePage? homePage;
        MoreInformation? moreInformation;
        DomainName? domainName;

        [When(@"I start the browser")]
        public void WhenIStartTheBrowser()
        {            
            driver = BrowserUtil.getDriver();
        }

        [When(@"I navigate to '(.*)'")]
        public void WhenINavigateTo(string p0)
        {
            WebAction.ClickOnUrl(driver, "http://example.com");       
        }

        [When(@"I click on the '(.*)' link")]
        public void WhenIClickOnTheLink(string p0)
        {
            homePage = new HomePage(driver);
            homePage.MoreInfoLocator();
            
        }

        [Then(@"a link with text '(.*)' must be present")]
        public void ThenALinkWithTextMustBePresent(string p0)
        {           
            moreInformation = new MoreInformation(driver);
            moreInformation.GetLinkText();
        }

        [Then(@"I click on the '(.*)' link")]
        public void ThenIClickOnTheLink(string p0)
        {            
            moreInformation = new MoreInformation(driver);
            moreInformation.GetDomainNameLink();
        }

        [Then(@"the '(.*)' box must contain '(.*)' at index '(.*)'")]
        public void ThenTheBoxMustContainAtIndex(string p0, string p1, string p2)
        {            
            domainName = new DomainName(driver);
            domainName.GetDomainNameList();
            WebAction.CloseBrowser(driver);            
        }
    }
}
