using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports;
using TechTalk.SpecFlow;
using TestAutomationFramework.Tools;

namespace TestAutomationFramework.Hooks
{
    [Binding]
    public class LoggerHooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            ReportManager.InitializeReport();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            ReportManager.Instance.Flush();
        }

        [AfterScenario]
        public static void AfterScenario(ScenarioContext scenarioContext)
        {
            var scenario = ReportManager.Instance.CreateTest(scenarioContext.ScenarioInfo.Title);

            switch (scenarioContext.ScenarioExecutionStatus)
            {
                case ScenarioExecutionStatus.OK:
                    scenario.Pass("Scenario passed");
                    break;
                case ScenarioExecutionStatus.TestError:
                    scenario.Fail($"Scenario failed. Reason: {scenarioContext.TestError.Message}");
                    break;
                default:
                    scenario.Skip("Scenario skipped");
                    break;
            }
        }
    }
}
