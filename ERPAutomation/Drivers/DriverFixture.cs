using ERPAutomation.Drivers.Interface;
using ERPAutomation.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace ERPAutomation.Drivers
{
    public class DriverFixture : IDisposable, IDriverFixture
    {
        private readonly IWebDriver _driver;
        public DriverFixture(Settings settings)
        {
            _driver = GetWebDriver();
            _driver.Navigate().GoToUrl(settings.ApplicationUrl);
        }
        public IWebDriver Driver => _driver;
        private IWebDriver? GetWebDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            return new ChromeDriver();
        }
        public void Dispose()
        {
            _driver.Quit();
        }
    }
}
