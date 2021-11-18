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
namespace SND.Helpers
{
    class SheetsGenerator
    {
        static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static string ApplicationName = "AIzaSyDrk9Kc1wNPIRjPCb5XYhKGb - Fa1Zh6K50";
        static string sheet = "HOTFIX";
        // static string spID = "1Yc4itwjB2N87g7Aj6kZcVn5akBMgUgRD9bzEFNu5euk";
        static string spID = "10YsD-6oyleQ-L0GrvOCymQ2EQKG14MNcW7rxrNPF1UI";
        static UserCredential credential;
        public static IList<IList<object>>  JiraConnector()
        {
            var jira = Jira.CreateRestClient("https://space-next-door.atlassian.net/", "luka@spacenextdoor.io", "1VS1wJJhvwh020N1CJC289AB");

            var issues2 = from i in jira.Issues.Queryable
                          where i.Project == $"Space Next Door" && i.Type == "Bug" && i.Labels == "HOTFIX" //questio here only bugs or?
                          orderby i.Key //possible to sort with created date
                          select i;
            //this method should be adjusted for different labels and types and projects to filter

            IList<IList<object>> clonedIList = new List<IList<object>>();
            foreach (var item in issues2)
            {
                //Regex.IsMatch(item.Summary.ToLower(), @"\bhotfix\b"Regex.IsMatch(item.Summary.ToLower(), @"\bhotfix\b"
                IList<object> newlist = new List<object>();
                newlist.Add(item.Type.Name);
                newlist.Add(item.Key.Value);
                newlist.Add(item.Summary.ToString());
                newlist.Add(item.AssigneeUser.DisplayName);
                newlist.Add(item.ReporterUser.DisplayName);
                newlist.Add(item.Priority.Name);
                newlist.Add(item.Status.Name);
                newlist.Add(item.Created.ToString());
                newlist.Add(item.Updated.ToString());

                //newlist.Add(item.Labels.);
                string strLine = "";
                foreach (string labelString in item.Labels)
                {
                    strLine = strLine + "," + labelString;
                }
                newlist.Add(strLine);
                clonedIList.Add(newlist);    
            }
            return clonedIList;
        }
        public static SheetsService SheetsConnector()
        {
            using (var stream =
             new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                //your clienrt id = 1070273132806-hsaiipoanabvakn5kirbh4g14dt6sv29.apps.googleusercontent.com
                // your client secret = l9J0vFyDaZFcACifmlfVPvqZ
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            return service;
        }

       public static void CreateEntry(SheetsService service, IList<IList<object>> issues)
        {

            var range = "A2:J";
            ValueRange valueRange = new ValueRange();
            valueRange.Values = issues;
            var appendRequest = service.Spreadsheets.Values.Append(valueRange, spID, range);
            appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
            var appendResponse = appendRequest.Execute();
        }

        static void ClearSheet(SheetsService service)
        {
            var range = "A2:J";
            ValueRange valueRange = new ValueRange();
            Data.ClearValuesRequest requestBody = new Data.ClearValuesRequest();
            SpreadsheetsResource.ValuesResource.ClearRequest request = service.Spreadsheets.Values.Clear(requestBody, spID, range);
            var appendRequest = service.Spreadsheets.Values.Append(valueRange, spID, range);
            Data.ClearValuesResponse response = request.Execute();
        }


        public static void HotfixBugs()
        {
            ClearSheet(SheetsConnector());
            CreateEntry(SheetsConnector(), JiraConnector());
        }

    }
}
