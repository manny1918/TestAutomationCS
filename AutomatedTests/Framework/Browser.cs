using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatedTests.Utils;
using OpenQA.Selenium.Chrome;

namespace AutomatedTests.Framework
{
    class Browser
    {

        public static IWebDriver driver;

        public static void OpenGoogleChromeBrowser(String URL)
        {
            driver = new ChromeDriver("C:\\Users\\Yomara\\source\\repos\\AutomatedTests\\AutomatedTests\\Drivers\\");
            driver.Navigate().GoToUrl(URL);
        }

        public static void OpenMozillaFirefoxBrowser()
        {

        }

        public static void OpenInternetExplorerBrowser()
        {

        }


        public static void CloseBrowse()
        {
            driver.Close();
        }
    }
}
