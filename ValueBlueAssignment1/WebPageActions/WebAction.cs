using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueBlueUI.Utils;

namespace ValueBlueUI.WebPageAction
{
    public class WebAction
    {
        //Click on Example.com URL and navigates to the Homepage
        public static void ClickOnUrl(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        //Click on MoreInformation link and navigates to MoreInformation page
        public static void ClickOnMoreInfo(IWebDriver driver, By MoreInfoLocator)
        {
            driver.FindElement(MoreInfoLocator).Click();
        }

        //Validates RFC 2606 and RFC 6761 link
        public static void VerifyLinkText(IWebDriver driver, By link1Locator, By link2Locator)
        {
            IWebElement Verifylink1 = driver.FindElement(link1Locator);
            Assert.AreEqual("RFC 2606", Verifylink1.Text, "Actual is different than expected text 'RFC 2606'");

            IWebElement Verifylink2 = driver.FindElement(link2Locator);
            Assert.AreEqual("RFC 6761", Verifylink2.Text, "Actual is different than expected text 'RFC 6761'");
        }

        //Click on Domanin Names link and navigates to Domain Names Page
        public static void ClickOnDomainNameLink(IWebDriver driver, By domainNameLocator)
        {
            driver.FindElement(domainNameLocator).Click();
        }

        //Get the list of Domain Names links and validates the presence of Root Management Link at index 2
        public static void VerifyDomainNameList(IWebDriver driver, By domainNameListsLocator)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            IList<IWebElement> lists = driver.FindElements(domainNameListsLocator);            
            Console.WriteLine(lists.Count);
            int index = 1;

            for (var i = 0; i < lists.Count-1; i++)
            {
                index = index + i;
                if (index==2)
                {  
                    Console.WriteLine(lists[i].Text + " is at index " + index);
                    Assert.AreEqual("Root Zone Management", lists[i].Text);
                    break;
                }
            }                               

        }

        //Close the browser
        public static void CloseBrowser(IWebDriver driver)
        {
            driver.Close();
            driver.Quit();
        }
    }


    
}
