using ERPAutomation.Drivers.Interface;
using ERPAutomation.Pages;
using ERPAutomation.Pages.Interface;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace ERPAutomation.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly IDriverFixture _driverFixture;
        private readonly ILoginPage _loginPage;

        public LoginStepDefinitions(IDriverFixture driverFixture, ILoginPage loginPage)
        {
            _driverFixture = driverFixture;
            _loginPage = loginPage;
        }

        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            _driverFixture.Driver.Navigate().GoToUrl("https://localhost:44339/Account/Login");
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _loginPage.EnterUserNameAndPassword(data.UserName, Convert.ToString(data.Password));
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            _loginPage.ClickLogin();
        }

        [Then(@"I should see user logged in to the application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            
        }

    }
}
