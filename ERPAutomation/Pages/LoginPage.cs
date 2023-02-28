using ERPAutomation.Drivers.Interface;
using ERPAutomation.Pages.Interface;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPAutomation.Pages
{
    public class LoginPage : ILoginPage
    {
        private readonly IDriverFixture _driverFixture;

        public LoginPage(IDriverFixture driverFixture)
        {
            _driverFixture = driverFixture;
        }
        IWebElement txtUserName => _driverFixture.Driver.FindElement(By.Id("Username"));
        IWebElement txtPassword => _driverFixture.Driver.FindElement(By.Id("Password"));
        IWebElement btnLogin => _driverFixture.Driver.FindElement(By.XPath("//BUTTON[@type='submit'][text()='Log in']"));


        public void EnterUserNameAndPassword(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
        }
    }
}
