using System;
using System.Collections.Generic;
using System.Text;
using AutoTestExtras.Core;
using AutoTestExtras.PageObjects.Web;

namespace PipelinesTest.PageObjects
{
    public class LoginPage : BasePage
    {
        /// <summary>
        /// user name
        /// </summary>
        [FindsBy(How.Id, "username")]
        public IBrowserElement TextboxUserName { get; set; }

        /// <summary>
        /// password
        /// </summary>
        [FindsBy(How.Id, "password")]
        public IBrowserElement TextboxPassword { get; set; }

        /// <summary>
        /// Sign In
        /// </summary>
        [FindsBy(How.XPath, ".//input[@value='Sign In']")]
        public IBrowserElement ButtonSignIn { get; set; }

        /// <summary>
        /// sign out
        /// </summary>
        [FindsBy(How.XPath, ".//span[contains(.,'SIGN OUT')]")]
        public IBrowserElement ButtonLogout { get; set; }

        /// <summary>
        /// the button of re-login
        /// </summary>
        [FindsBy(How.LinkText, "RE-LOGIN")]
        public IBrowserElement ButtonReLogin { get; set; }
    }
}
