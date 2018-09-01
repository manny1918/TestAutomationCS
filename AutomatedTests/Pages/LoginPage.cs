using AutomatedTests.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Xunit.Abstractions;
using AutomatedTests.Utils;

namespace AutomatedTests.Pages
{
    class LoginPage: UserActions
    {
        public LoginPage()//  //
        {
        }
        
        public void openApp()
        {
            OpenTheApplication(BrowserName.GoogleChrome, Parameters.ApplicationURL);
        }

        public void TypeEmail(string Email)
        {
            Type("identifierId", Email);
        }

        public void ClickNext()
        {
            Click("//*[@id='identifierNext']/content/span", LocatorName.xpath);
        }
    }
}
