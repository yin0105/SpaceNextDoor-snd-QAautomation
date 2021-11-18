using lighthouse.net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;
using OpenQA.Selenium;
using SND.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace SND.UnitTest
{
    [TestClass]
    public class LigthouseTest : Methods
    {
        private const string mongoAddress = "mongodb+srv://luka:4ee4ez5j8V9DPQAG@qa-automation.mqlmn.mongodb.net/test?retryWrites=true&w=majority";
        private static readonly IMongoClient client = new MongoClient(mongoAddress);
        private static readonly IMongoDatabase database = client.GetDatabase("Ligthouse");
        private static readonly IMongoCollection<PerformanceData> _collection = database.GetCollection<PerformanceData>("LigthouseResults");



        [TestMethod]
        public async Task ExampleComAudit()
        {

            var lh = new Lighthouse();
            var res = await lh.Run("https://stag.spacenextdoor.com/");
        //   Assert.IsNotNull(res);
        //   Assert.IsNotNull(res.Performance);
        //   Assert.IsTrue(res.Performance > 1000m);
        //   Assert.IsTrue(res.Accessibility > 1000m);
        //   Assert.IsNotNull(res.Accessibility);
        //   Assert.IsTrue(res.Accessibility > 1000m);
        //   Assert.IsNotNull(res.BestPractices);
        //   Assert.IsTrue(res.BestPractices > 1000m);
        //   Assert.IsNotNull(res.Pwa);
        //   Assert.IsTrue(res.Pwa > 1000m);
        //   Assert.IsNotNull(res.Seo);
        //   Assert.IsTrue(res.Seo > 1000m);

            var filePath = @"C:\Users\l.gogritchiani\Desktop\snd present\img.png";
            string data = res.FinalScreenshot.Base64Data;
            var base64Data = Regex.Match(data, @"data:image/(?<type>.+?),(?<data>.+)").Groups["data"].Value;
            byte[] imageBytes = Convert.FromBase64String(base64Data);
            File.WriteAllBytes(filePath, imageBytes);






            decimal[] array =
                {
            res.Accessibility.Value,
            res.BenchmarkIndex.Value,
            res.BestPractices.Value,
            res.Performance.Value,
            res.Pwa.Value,
            res.Seo.Value,
            res.TotalDuration.Value,
            };
                LigthouseResults results = new LigthouseResults(array);

                PerformanceData testData = new PerformanceData
                {

                    ID = GetLastID() + 1,
                    GoogleResults = results,
                    Date = DateTime.UtcNow,//AddHours(4),

                };

                _collection.InsertOne(testData);



                static int GetLastID()
                {
                    var filter = Builders<PerformanceData>.Filter.Exists("_id");
                    var sort = Builders<PerformanceData>.Sort.Descending("_id");
                    var document = _collection.Find(filter).Sort(sort).First();
                    return document.ID;
                    //return 0;
                }

            }

        }
    }

