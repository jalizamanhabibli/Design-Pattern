using System;

namespace BridgePattern.Reports
{
    public class EmployeePerformanceReport:Report
    {
        public EmployeePerformanceReport(IReportFormat reportFormat) : base(reportFormat)
        {
        }

        public override void Display()
        {
            Console.WriteLine(" ---------Employee Performance Report--------- ");
            base.Display();
        }
    }
}