namespace BridgePattern.Reports
{
    public class Report
    {
        private IReportFormat ReportFormat { get; }

        protected Report(IReportFormat reportFormat)
        {
            ReportFormat = reportFormat;
        }

        public virtual void Display()
        {
            ReportFormat.Generate();
        }
    }
}