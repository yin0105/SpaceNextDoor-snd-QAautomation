# snd-QAautomation
This is solution for test automation. 

Target Framework: .NET 5.0

NUget Packages:
SpecFlow 3.9.22
SpecFlow.MSTest 3.9.22
SpecFlow.Tools.MSBuild.Generation 3.9.22
SpecFlow.LivingDoc.Plugin 3.9.50
SpecFlow.Assist.Dynamic 1.4.2
Selenium.WebDriver.Chrome 93.0.4577.1500
Atlassian.SDK  12.4.0
CloudinaryDotNet 1.15.2
coverlet.collector 3.1.0
ExtentReports 4.1.0
FluentAssertions 6.1.0
Google.Apis.Auth 1.54.0
Google.Apis.Sheets.v4 1.54.0.2371
Google.Apis.Vision.v1 1.54.0.2412
Microsoft.NET.Test.Sdk 16.11.0
MSTest.TestAdapter 2.2.6
MSTest.TestFramework 2.2.6
QAssistant 1.1.0 ( not latest ) 
Selenium.Support 3.141.0
Selenium.WebDriver 3.141.0
Selenium.WebDriver.ChromeDriver 93.0.4577.1500


RUN this test via cmd. example is showing that we are running all the test or by specific caterogy

All Test: dotnet test C:\Users\l.gogritchiani\source\repos\Space-Next-Door\snd-QAautomation 
OnlyRegression category: dotnet test C:\Users\l.gogritchiani\source\repos\Space-Next-Door\snd-QAautomation --filter Category=regression
(we can trigger this via batch file run)
