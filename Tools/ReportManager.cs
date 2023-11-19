using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace TestAutomationFramework.Tools
{
    internal class ReportManager
    {
        public static ExtentReports Instance { get; set; }

        public static void InitializeReport()
        {
            var htmlReporter = new ExtentSparkReporter(@"..\..\Reports\TestReport.html");
            Instance = new ExtentReports();
            Instance.AttachReporter(htmlReporter);
        }
    }
}
