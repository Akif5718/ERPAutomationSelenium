using OpenQA.Selenium;

namespace ERPAutomation.Drivers.Interface
{
    public interface IDriverFixture
    {
        IWebDriver Driver { get; }
        void Dispose();
    }
}