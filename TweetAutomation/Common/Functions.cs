using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace twitterAutomationBalaji
{
    public class Functions
    {
        public static IWebDriver appdriver;
        public static WebDriverWait waitForElement;

        // Description: Select the required Browser
        public static IWebDriver Browser(string BrowserValue)
        {            
           switch (BrowserValue)
                {
                    case "Firefox":

                        appdriver = new FirefoxDriver();
                      //  appdriver.Navigate().GoToUrl(ConfigurationManager.AppSettings["TwitterURL"]);
                        break;

                    case "Chrome":

                        appdriver = new ChromeDriver();
                        //appdriver.Navigate().GoToUrl(ConfigurationManager.AppSettings["TwitterURL"]);
                        break;

                    case "IE":

                        appdriver = new InternetExplorerDriver();
                        //appdriver.Navigate().GoToUrl(ConfigurationManager.AppSettings["TwitterURL"]);                        
                        break;
                }

                return appdriver;
            }

        //Navigating to the application
        public static void NavigateToURL()
        {            
            GlobalValues.driver.Navigate().GoToUrl(GlobalValues.TwitterURL);            
            GlobalValues.driver.Manage().Window.Maximize();
        }

        //Explicit wait
        public static void WaitForTheElement(string ElementLocator)
        {
            waitForElement = new WebDriverWait(GlobalValues.driver, TimeSpan.FromSeconds(240));
            waitForElement.Until(ExpectedConditions.ElementExists(By.CssSelector(ElementLocator)));
        }

        //This is used where web driver wait sync was not working as expected.
        public static void ImplicitWait()
        {
            Thread.Sleep(5000);            
        }


    }
}
