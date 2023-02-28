using ERPAutomation.Drivers.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPAutomation.Pages
{
    public class DashboardPage
    {
        private readonly IDriverFixture _driverFixture;

        public DashboardPage(IDriverFixture driverFixture)
        {
            _driverFixture = driverFixture;
        }
    }
}
