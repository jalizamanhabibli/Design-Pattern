using System;

namespace BridgePattern.Reports
{
    public class SalesReport:Report
    {
        public SalesReport(IReportFormat reportFormat) : base(reportFormat)
        {
        }

        public override void Display()
        {
            Console.WriteLine(" ---------Sales Report--------- ");
            base.Display();
        }
    }
}