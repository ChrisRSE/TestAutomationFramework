# Test Automation Framework

The completed Technical test framework created by Chris Rafferty.

The project utilises the swag lab login functionality (https://www.saucedemo.com/) 

### 1.1 Dependencies

All dependencies are packaged up as part of the .csproj file provided in the repository. The project is best ran with a version of Visual Studios. It contains the following:

- ExtentReports (5.0.1)
- FluentAssertions (6.12.0)
- Microsoft.NET.Test.Sdk (17.8.0)
- NUnit (3.14.0)
- NUit3TestAdapter (4.5.0)
- Selenium.Support (4.15.0)
- Selenium.WebDriver (4.15.0)
- Selenium.WebDriver.ChromeDriver (119.0.6045.10500)
- SpecFlow (3.9.74)
- SpecFlow.NUnit (3.9.74)
- SpeFlow.Plus.LivingDocPlugin (3.9.57)

## 1.2 Git Clone

```bash
  git clone https://github.com/ChrisRSE/TestAutomationFramework.git
```


## 1.3 Running Tests

Tests can be ran in different ways depending on preference

- Directly via Visual Studio Test Explorer.
- Alternatively, navigate to the project directory and run the command **RunTests.sh**.

## 1.4 Test Report

Regardless of which way you run the tests, an html report will be saved to the reports folder upon test completion showcasing the results of the test suite.

## 1.5 Design Choices

C# Pick: I chose C# because of its incredible tools like Selenium and SpecFlow, as well as my history and familiarity with the language.
Automation Tests: Due to testing a website I chose to focus on features and step definitions as my testing of choice, this allowed me to emphasise on the functionality testing and the typical behaviors a user might have. 
Test Model Patterns: I put a lot of emphasis on having a solid page model in place with supporting hooks. Keeping the features and step definitions clean and concise without duplicate code is really important to me. Additionally it allows me to build on the foundations in future if new page features or complete new pages are required.

Improvements Given More Time:
Enhanced Reports and Logs: I started off with some basic reporting and logging using extensions, but it's far from perfect. I really want to dive deeper into this—improving the reports so that whenever a test fails, it's crystal clear why and where it went wrong. This would probably be one of my priorities going forward.
Installation Setup: I would want to implement a script or executable to install all the dependencies for a new user.

## 1.6 Author

Thank you so much for reading this far. 

If there's any questions or thoughts please feel to get in touch

- [@Chris Rafferty](https://www.github.com/ChrisRSE)
- ChrisRaffertySE@gmail.com
