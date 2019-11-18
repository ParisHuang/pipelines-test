using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoTestExtras.Core;
using TechTalk.SpecFlow;
using PipelinesTest.PageObjects;

namespace PipelinesTest.TestCases.SmokeTesting
{
    [Binding]
    [Scope(Feature = "Login")]
    public sealed class Login
    {
        private static LoginPage LoginPage;

        [BeforeFeature]
        public static void BeforeFeature()
        {
            BrowserDriverHelper.CreateBrowserInstance();
            LoginPage = BrowserDriverHelper.InstancePageObject<LoginPage>();
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            BrowserDriverHelper.CloseBrowserInstance();
        }

        [When(@"Login as school staff")]
        public void WhenLoginAsSchoolStaff()
        {
            BrowserDriverHelper.NavigateToUrl(AppsettingsHelper.SuperAdminWebUrl);
            LoginPage.TextboxUserName.SendKeys("admin");
            LoginPage.TextboxPassword.SendKeys("123456");
            LoginPage.ButtonSignIn.Click();
        }

        [Then(@"Login successfully")]
        public void ThenLoginSuccessfully()
        {
            BrowserDriverHelper.WaitTime(5);
        }

    }
}
