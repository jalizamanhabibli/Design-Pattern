using System;

namespace BridgePattern.Formats
{
    public class DesktopFormat:IReportFormat
    {
        public void Generate()
        {
            Console.WriteLine("Desktop Format Report");
        }
    }
}