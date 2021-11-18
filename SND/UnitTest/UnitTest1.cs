using Microsoft.VisualStudio.TestTools.UnitTesting;
using SND.Helpers;
using QAssistant.Extensions;
using QAssistant.WaitHelpers;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Atlassian;
using Atlassian.Jira;
using System.Linq;
using System.Threading;
using System.Text.Json;
using Google;
using Google.Apis.Sheets.v4;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using System;
using System.IO;
using Google.Apis.Services;
using Google.Apis.Auth;
using Google.Apis.Sheets.v4.Data;
using System.Collections.Generic;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using Data = Google.Apis.Sheets.v4.Data;

namespace SND
{


    [TestClass]
    public class UnitTest1 : Methods
    {

        static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static string ApplicationName = "AIzaSyDrk9Kc1wNPIRjPCb5XYhKGb - Fa1Zh6K50";

        [TestMethod]
        public void TestMethod1()
        {


            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            GoToUrl(driver, "https://space-next-door.atlassian.net/issues/?jql=project%20%3D%20SND%20AND%20issuetype%20%3D%20Bug%20AND%20text%20~%20%22HOTFIX%22%20order%20by%20created%20DESC");
            driver.Wait();
            driver.Click(By.XPath("//*[@aria-label='Sign in']"));
            driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='username']")).SendKeys("luka@spacenextdoor.io");
            driver.Click(By.XPath("//*[@id='login-submit']"));
            driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='password']")).SendKeys("sndluka24");
            driver.Click(By.XPath("//*[@id='login-submit']"));
            driver.Click(By.XPath("//*[@id='jira-export-trigger']"));
            //driver.Click(By.XPath("//*[@id='com.atlassian.jira.spreadsheets__open-in-gsheets']"));
            //driver.Click(By.XPath("(//*[contains(text(),'Allow')])[2]"));
            Sleep(2222);
            driver.Click(By.XPath("//*[@id='currentCsvFields']"));

            //SwitchToTab(driver);
            //*[@id='jira-export-trigger']

            //GoToUrl(driver,"ssaadsa");
        }

        [TestMethod]
        public void TestMethod2()
        {
            SheetsGenerator.HotfixBugs();

        }


    } 
}

