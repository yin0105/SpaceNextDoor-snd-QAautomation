using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SND.Helpers
{
    public class LigthouseResults
    {

        public LigthouseResults(decimal[] results)
        {
            Accessibility = results[0];
            BenchmarkIndex = results[1];
            BestPractices = results[2];
            Performance = results[3];
            Pwa = results[4];
            Seo = results[5];
            TotalDuration = results[6];
        }



        [BsonElement("Accessibility")]
        public decimal Accessibility { get; set; }

        [BsonElement("BenchmarkIndex")]
        public decimal BenchmarkIndex { get; set; }

        [BsonElement("BestPractices")]
        public decimal BestPractices { get; set; }

        [BsonElement("Performance")]
        public decimal Performance { get; set; }

        [BsonElement("Pwa")]
        public decimal Pwa { get; set; }

        [BsonElement("Seo")]
        public decimal Seo { get; set; }

        [BsonElement("TotalDuration")]
        public decimal TotalDuration { get; set; }
    }
}
