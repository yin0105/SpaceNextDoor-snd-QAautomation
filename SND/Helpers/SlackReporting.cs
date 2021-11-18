using CloudinaryDotNet;
using lighthouse.net.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;

namespace SND.Helpers
{
    public class SlackReporting
    {
        private readonly Uri _uri;
        private readonly Encoding _encoding = new UTF8Encoding();
        private string urlWithAccessToken;
        protected const string QASlackChannel = "#automated-reporting";

        public SlackReporting(string urlWithAccessToken)
        {
            _uri = new Uri(urlWithAccessToken);
        }


        //html report uploader
        public static string UploadHTMLReport()
        {
            //var htmlPath = @"C:\Users\l.gogritchiani\Desktop\SpaceNextDoor\QAautoSND\snd-QAautomation\SND\bin\Debug\net5.0\TestResults\index.html";
            //var htmlPath2 = @"C:\Users\l.gogritchiani\Desktop\SpaceNextDoor\QAautoSND\snd-QAautomation\SND\bin\Debug\net5.0\TestResults\index.html";
            var htmlPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\TestResults\index.html"; 
            try
            {
                //cloudinary acc
                Account account = new Account(
                    "spacenextdoor",
                    "699362336961262",
                    "XsNMIZjtkkReu3048qGQnCmkV2g"
                    );
                Cloudinary cloudinary = new Cloudinary(account);

                var uploadResult = cloudinary.Upload("auto", null, new FileDescription(htmlPath));
                Uri uploadURL = uploadResult.Uri;
                if(uploadURL == null)
                {
                    return "Couldn't upload HTML Report";
                }
                return uploadResult.Uri.ToString();
            }
            catch (Exception ex)
            {
                
                return $"Couldn't Upload Html Report+{ex.Message}"; //need to be tested how this works in action.
            }
        }



        public static void SendReportInSlack()
        {
            string urlWithAccessToken = "https://hooks.slack.com/services/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";
            SlackReporting reporting = new SlackReporting(urlWithAccessToken);
            reporting.PostMessage(username: "SND Regression Results",
                                  text: $"If you want to check detailed report click this link {UploadHTMLReport()} :here:",
                                  channel: "automated-reporting"
                                //  url: "https://drive.google.com/file/d/1mroRmWLT2oTYv0qAICiFaFgqGwl7tQiz/view?usp=sharing"
                                  );
        }







        //public static void SendScreenShotInSlack()
        //{
            
        //    string urlWithAccessToken = "https://hooks.slack.com/services/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";
        //    SlackReporting reporting = new SlackReporting(urlWithAccessToken);
        //    reporting.PostMessage(username: "SND Regression Results",
        //                          text: $"If you want to check detailed report click this link xxx :here:",
        //                          channel: "automated-reporting",
        //                          url: "https://cdn.vox-cdn.com/thumbor/Ous3VQj1sn4tvb3H13rIu8eGoZs=/0x0:2012x1341/1400x788/filters:focal(0x0:2012x1341):format(jpeg)/cdn.vox-cdn.com/uploads/chorus_image/image/47070706/google2.0.0.jpg"
        //                          );

            
        //}

        // Post message using simple strings.
        public void PostMessage(string text, string username = null, string channel = null, string url = null)
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            Payload payload = new Payload()
            {
                Channel = channel,
                Username = username,
                Text = text,
                Attachments = new[] { new { image_url = url, title = "image" } }
            };
            PostMessage(payload);
        }

        public void PostMessage(Payload payload)
        {
            string payLoadJson = JsonConvert.SerializeObject(payload);
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            using(WebClient client = new WebClient())
            {
                NameValueCollection data = new NameValueCollection();
                data["payload"] = payLoadJson;
                var response = client.UploadValues(_uri, "POST", data);

                //The response text is usually "OK"
                string responseText = _encoding.GetString(response);
            }
        }

        public void PostMessageBrowser(string text, string username = null, string channel = null)
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            Payloadbrowser payloadbrowser = new Payloadbrowser()
            {
                Channel = channel,
                Username = username,
                Text = text
            };
            PostMessageBrowser(payloadbrowser);
        }

        public void PostMessageBrowser(Payloadbrowser payloadbrowser)
        {
            string payloadbrowserJson = JsonConvert.SerializeObject(payloadbrowser);
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            using (WebClient client = new WebClient())
            {
                NameValueCollection data = new NameValueCollection();
                data["payload"] = payloadbrowserJson;

                var response = client.UploadValues(_uri, "POST", data);

                string responseText = _encoding.GetString(response);
            }
        }
    }

    public class Payload
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("attachments")]
        public Array Attachments { get; set; }
    }


    public class Payloadbrowser
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
