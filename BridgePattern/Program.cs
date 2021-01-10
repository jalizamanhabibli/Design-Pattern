using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgePattern.Formats;
using BridgePattern.Reports;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Report employeePerformanceReport = new EmployeePerformanceReport(new DesktopFormat());
            employeePerformanceReport.Display();

            Console.WriteLine();

            Report salesReport = new SalesReport(new WebFormat());
            salesReport.Display();

            Console.ReadKey();
        }
    }
}
