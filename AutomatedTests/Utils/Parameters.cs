using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTests.Utils
{
    class Parameters
    {
        //Time to determine the test execution speed 
        public static int DelayTypeExecutionSpeed_VeryQuick = 0;
        public static int DelayTypeExecutionSpeed_Quick = 0;
        public static int DelayTypeExecutionSpeed_Slow = 0;


        //Time to wait try to locate an element before timeout. Time in seconds utiltized in impicit waits
        public static int timeToWaitTryingToLocateElementUntilTimeout = 20;


        public static string ApplicationURL = "https://mail.google.com/mail/u/0/#";


        //
        public static string Email = "yhomara1817";
        public static string Password = "Manny-ramirez";
    }
}
