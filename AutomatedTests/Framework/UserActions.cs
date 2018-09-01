using AutomatedTests.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace AutomatedTests.Framework
{
    public class UserActions
    {

        public UserActions()
        {
        }
        public void Click(string Locator, LocatorName locatorName=LocatorName.id)
        {
            String locType = locatorName.ToString();
            IWebElement e;
            if (locType == "xpath")
            {
                e= Browser.driver.FindElement(By.XPath(Locator));
            }
            else if (locType == "name")
            {
                e = Browser.driver.FindElement(By.Name(Locator));
            }
            else 
            {
                e = Browser.driver.FindElement(By.Id(Locator));
            }
            WebDriverWait wait = new WebDriverWait(Browser.driver, System.TimeSpan.FromSeconds(Parameters.timeToWaitTryingToLocateElementUntilTimeout));
            wait.Until(bb => e);
            e.Click();
        }

        public string GetText(string Locator, string Text, LocatorName locatorName = LocatorName.id)
        {
            String locType = locatorName.ToString();
            IWebElement e;
            if (locType == "xpath")
            {
                e = Browser.driver.FindElement(By.XPath(Locator));
            }
            else if (locType == "name")
            {
                e = Browser.driver.FindElement(By.Name(Locator));
            }
            else
            {
                e = Browser.driver.FindElement(By.Id(Locator));
            }
            WebDriverWait wait = new WebDriverWait(Browser.driver, System.TimeSpan.FromSeconds(Parameters.timeToWaitTryingToLocateElementUntilTimeout));
            wait.Until(foo=>e);
            return e.GetAttribute("value");
        }

        public void Type(string Locator, string TextToType,  LocatorName locatorName = LocatorName.id)
        {
            String locType = locatorName.ToString();
            IWebElement e;
            if (locType == "xpath")
            {
                e = Browser.driver.FindElement(By.XPath(Locator));
            }
            else if (locType == "name")
            {
                e = Browser.driver.FindElement(By.Name(Locator));
            }
            else
            {
                e = Browser.driver.FindElement(By.Id(Locator));
            }
            WebDriverWait wait = new WebDriverWait(Browser.driver, System.TimeSpan.FromSeconds(Parameters.timeToWaitTryingToLocateElementUntilTimeout));
            wait.Until(foo => e);
            e.SendKeys(TextToType);

        }

        public void OpenTheApplication(BrowserName browserName, string url)
        {
            string browser = browserName.ToString();
            if (browser==BrowserName.GoogleChrome.ToString())
            {
                Browser.OpenGoogleChromeBrowser(url);
            }
            else if(browser == "InternetExplorer")
            {

            }
            else if (browser == "MozilaFirefox")
            {

            }
        }


        public void CloseTheApplication()
        {
            Browser.driver.Quit();
        }

        public void Waiting(int TimeInSeconds)
        {
            Thread.Sleep(TimeInSeconds*1000);
        }

    }
}