using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;

namespace twitterAutomationBalaji.Features
{
    [Binding]
    public class TwitterScenariosSteps
    {
        //Triggers before every scenario/testcase
        [BeforeScenario]
        public void TestStarup()
        {
            GlobalValues.driver = Functions.Browser(GlobalValues.browserChrome);
        }

        //Triggers after every scenario/testcase
        [AfterScenario]
        public void TestCleanup()
        {
            GlobalValues.driver.Quit();
        }

        //Testcase method starts
        [Given(@"Navigate to application using the URL")]
        public void GivenNavigateToApplicationUsingTheURL()
        {
            var accEmail = "ClearUser001" + DateTime.Now.Millisecond + "@gmail.com";
            Functions.NavigateToURL();
        }

        [Then(@"application login screen should be displayed\.")]
        public void ThenApplicationLoginScreenShouldBeDisplayed_()
        {
            Functions.WaitForTheElement(TweetLogin.objLoginLbl);
            //Thread.Sleep(5000);
            var LoginLabel = GlobalValues.driver.FindElement(By.CssSelector(TweetLogin.objLoginLbl)).Text;
            if (LoginLabel == GlobalValues.LoginLbl)
            {
                Console.Write("Application Login Displayed: " + LoginLabel);
                Assert.AreEqual(LoginLabel, GlobalValues.LoginLbl);
            }
        }

        [Then(@"Click Sign up for Twitter")]
        public void ThenClickSignUpForTwitter()
        {
            //SignUp for Twitter only till code sent to user and verifications done for sighup pages
            Actions actions = new Actions(GlobalValues.driver);

            GlobalValues.driver.FindElement(By.CssSelector(TweetLogin.objSignUpLnk)).Click();
            Functions.WaitForTheElement(TweetLogin.objUseEmailLnk);
            GlobalValues.driver.FindElement(By.CssSelector(TweetLogin.objUseEmailLnk)).Click();

            //Page 2 Values
            Functions.WaitForTheElement(TweetLogin.objCreateAccLbl);
            var LblCreateAcc = GlobalValues.driver.FindElement(By.CssSelector(TweetLogin.objCreateAccLbl)).Text;
            
            //Verify if create account page is displayed
            Assert.AreEqual(GlobalValues.CreateAccountLabel, LblCreateAcc);

            //Filling the user values and navigating to next pages till "We Have Sent your Code"
            GlobalValues.driver.FindElement(By.CssSelector(TweetLogin.objAccNameTxt)).SendKeys(GlobalValues.accName);
            actions.SendKeys(Keys.Tab);
            GlobalValues.driver.FindElement(By.CssSelector(TweetLogin.objAccEmailTxt)).SendKeys(GlobalValues.accEmail);
            actions.SendKeys(Keys.Tab);
            GlobalValues.driver.FindElement(By.CssSelector(TweetLogin.objAccMonthTxt)).SendKeys(GlobalValues.accMonth);
            actions.SendKeys(Keys.Tab);
            GlobalValues.driver.FindElement(By.CssSelector(TweetLogin.objAccDayTxt)).SendKeys(GlobalValues.accDay);
            actions.SendKeys(Keys.Tab);
            GlobalValues.driver.FindElement(By.CssSelector(TweetLogin.objAccYearTxt)).SendKeys(GlobalValues.accYear);
            Functions.ImplicitWait();
            GlobalValues.driver.FindElement(By.CssSelector(TweetLogin.objNextBtn)).Click();

            //Page 2 Next
            Functions.WaitForTheElement(TweetLogin.objCustomizeYourExpNextBtn);
            GlobalValues.driver.FindElement(By.CssSelector(TweetLogin.objCustomizeYourExpNextBtn)).Click();

            //Page 3           
            Functions.ImplicitWait();            
            GlobalValues.driver.FindElement(By.CssSelector(TweetLogin.objSignUpBtn)).Click();

            //Code Page
            var LblWeHaveSentCode = GlobalValues.driver.FindElement(By.CssSelector(TweetLogin.objWeHaveSentCodeLbl)).Text;

            //Verifying "We have sent code" page is displayed
            Assert.AreEqual(GlobalValues.WeHaveSentCodeLbl, LblWeHaveSentCode);
        }


        [Then(@"Log into the application")]
        public void ThenLogIntoTheApplication()
        {
            //Logging into the application and verifying Success
            GlobalValues.driver.FindElement(By.CssSelector(TweetLogin.objUserNameTxt)).SendKeys(GlobalValues.accUserName);
            GlobalValues.driver.FindElement(By.CssSelector(TweetLogin.objPasswordTxt)).SendKeys(GlobalValues.accPassword);
            GlobalValues.driver.FindElement(By.CssSelector(TweetLogin.objLoginBtn)).Click();
            Thread.Sleep(5000);
            GlobalValues.driver.FindElement(By.CssSelector(TweetLogin.ObjProfileLnk)).Click();
            Thread.Sleep(5000);
            var accUserNameAfterLogin = GlobalValues.driver.FindElement(By.CssSelector(TweetLogin.ObjAccUserAfterLogin)).Text;

            //Verifying login success by fetching the user name after logging in
            Assert.AreEqual(GlobalValues.accUserName, accUserNameAfterLogin);
        }

        [Then(@"Post a Tweet")]
        public void ThenPostATweet()
        {
            //Posting a tweet
            GlobalValues.driver.FindElement(By.CssSelector(TweetLogin.ObjNewTweetLnk)).Click();            
            GlobalValues.driver.FindElement(By.CssSelector(TweetLogin.ObjTweetInputBlock)).SendKeys(GlobalValues.TweetInputValue);
            GlobalValues.driver.FindElement(By.CssSelector(TweetLogin.ObjPostTweetBtn)).Click();
        }

        [Then(@"Verify posted Tweet in Profile\.")]
        public void ThenVerifyPostedTweetInProfile_()
        {
            //Verifying the Posted Tweet in Profile page a Success
            GlobalValues.driver.FindElement(By.CssSelector(TweetLogin.ObjProfileLnk)).Click();

            var NewTweetedValueRawText = GlobalValues.driver.FindElement(By.CssSelector(TweetLogin.ObjTweetsInProfile)).Text;
            var stringseparators = new string[] { "\r\n" };
            var NewTweetedValueRawTextSplited = NewTweetedValueRawText.Split(stringseparators, StringSplitOptions.None);

            for (int i = 0; i < NewTweetedValueRawTextSplited.Count(); i++)
            {
                if (NewTweetedValueRawTextSplited[i] == GlobalValues.TweetInputValue)
                {
                    var NewTweetedValue = NewTweetedValueRawTextSplited[i];
                    Assert.AreEqual(GlobalValues.TweetInputValue, NewTweetedValue);
                }
            }
        }



    }
}
