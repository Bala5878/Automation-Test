using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace twitterAutomationBalaji
{
    public class TweetLogin
    {
        public static string objLoginLbl = "h1[role='heading']";
        public static string objCreateAccLbl = "div[class='css-901oao r-18jsvk2 r-1qd0xha r-1blvdjr r-b88u0q r-vrz42v r-1r5su4o r-bcqeeo r-qvutc0']";

        public static string objSignUpLnk = "a[href = '/i/flow/signup']";
        public static string objUseEmailLnk = "div[class='css-18t94o4 css-901oao r-k200y r-1n1174f r-1qd0xha r-a023e6 r-16dba41 r-rjixqe r-1wzrnnt r-bcqeeo r-qvutc0']";

        public static string objAccNameTxt = "input[name = 'name']";
        public static string objAccEmailTxt = "input[name = 'email']";
        public static string objAccMonthTxt = "select[id = 'Month']";
        public static string objAccDayTxt = "select[id = 'Day']";
        public static string objAccYearTxt = "select[id = 'Year']";

        public static string objNextBtn = "div>div>div>div>div>div>span>span[class='css-901oao css-16my406 r-poiln3 r-bcqeeo r-qvutc0']";
        public static string objCustomizeYourExpNextBtn = "div>div>span>span[class='css-901oao css-16my406 r-poiln3 r-bcqeeo r-qvutc0']";
        public static string objSignUpBtn = "div>div>span>span[class='css-901oao css-16my406 r-poiln3 r-bcqeeo r-qvutc0']";
        public static string objWeHaveSentCodeLbl = "div[class='css-901oao r-18jsvk2 r-1qd0xha r-1blvdjr r-b88u0q r-vrz42v r-1r5su4o r-bcqeeo r-qvutc0']";


        //Login Page
        public static string objUserNameTxt = "input[type='text']";
        public static string objPasswordTxt = "input[type='password']";
        public static string objLoginBtn = "div[class='css-18t94o4 css-1dbjc4n r-urgr8i r-42olwf r-sdzlij r-1phboty r-rs99b7 r-1w2pmg r-1fz3rvf r-usiww2 r-1pl7oy7 r-snto4y r-1ny4l3l r-1dye5f7 r-o7ynqc r-6416eg r-lrvibr']";

        //Home Page
        public static string ObjProfileLnk = "a[aria-label='Profile']";
        public static string ObjAccUserAfterLogin = "div[class='css-901oao r-18jsvk2 r-1qd0xha r-adyw6z r-1vr29t4 r-135wba7 r-bcqeeo r-1udh08x r-qvutc0']";
        public static string ObjNewTweetLnk = "a[data-testid = 'SideNav_NewTweet_Button']";
        public static string ObjTweetInputBlock = "div[data-testid='tweetTextarea_0']";
        public static string ObjPostTweetBtn = "div[data-testid='tweetButton']";

        //Profile Page
        public static string ObjTweetsInProfile = "div[class='css-1dbjc4n r-16y2uox r-1wbh5a2 r-1ny4l3l']";

    }
}
