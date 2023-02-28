using ERPAutomation.Drivers;
using ERPAutomation.Drivers.Interface;
using ERPAutomation.Pages;
using ERPAutomation.Pages.Interface;
using ERPAutomation.Support;
using Microsoft.Extensions.DependencyInjection;
using SolidToken.SpecFlow.DependencyInjection;

namespace ERPAutomation
{
    public class Startup
    {
        [ScenarioDependencies]
        public static IServiceCollection CreateService()
        {
            var services = new ServiceCollection();
            services.AddSingleton(new Settings
            {
                ApplicationUrl = new Uri("https://localhost:44339/")
            });
            services.AddScoped<IDriverFixture, DriverFixture>();
            services.AddScoped<ILoginPage, LoginPage>();

            return services;
        }
    }
}
