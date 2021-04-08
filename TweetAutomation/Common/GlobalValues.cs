using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace twitterAutomationBalaji
{
    public class GlobalValues
    {
        //Driver Info
        public static IWebDriver driver;
        public static WebDriverWait waitForElement;

        //Browser Info
        public static string browserFirefox = "Firefox";
        public static string browserChrome = "Chrome";
        public static string browserIE = "IE";


        //URL Info
        public static string TwitterURL = "https://twitter.com/LOGIN";

        //Signup Values   

        public static string accName = "ClearUser001" + DateTime.Now.Millisecond;
        public static string accEmail = "ClearUser001" + DateTime.Now.Millisecond + "@gmail.com";
        public static string accMonth = "January";
        public static string accDay = "4";
        public static string accYear = "1982";

        //Login Values
        public static string accUserName = "Cleartest001";
        public static string accPassword = "Test@123";

        //Values to Verify
        public static string LoginLbl = "Log in to Twitter";
        public static string CreateAccountLabel = "Create your account";
        public static string WeHaveSentCodeLbl = "We sent you a code";

        //Other Input Values
        public static string TweetInputValue = "Sample Tweet" + DateTime.Now.Millisecond;


    }
}
