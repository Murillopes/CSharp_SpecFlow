﻿using SauceDemo.Testing_SpecFlow.Resources.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SauceDemo.Testing_SpecFlow.Pages_POM
{
    [Binding]
    public class LoginSteps : LoginPage
    {
        [Given(@"I navigate to the Login page")]
        public void GivenINavigateToTheLoginPage()
        {
            CongfigBrowser();
            NavigateToUrl();
        }

        [Given(@"Type my (.*) and my (.*)")]
        public void GivenTypeMyStandard_UserAndMySecret_Sauce(string username, string password)
        {
            EnterCredentials(username, password);
        }


        [When(@"I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            ClickLoginButton();
        }

        [Then(@"I should navigate to the Home page")]
        public void ThenIShouldNavigateToTheHomePage()
        {
            Thread.Sleep(4000);
            HomePage homePage = new HomePage(getDriver());
            homePage.CheckTitle();
            getDriver().Close();
            getDriver().Quit();
        }

    }
}