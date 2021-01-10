using System;

namespace BridgePattern.Formats
{
    public class WebFormat:IReportFormat
    {
        public void Generate()
        {
            Console.WriteLine("Web Format Report");
        }
    }
}