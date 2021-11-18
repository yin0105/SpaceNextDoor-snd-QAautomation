using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SND.Helpers
{
   public  class PerformanceData
    {

        private int _id { get; set; }
        public static double asr = 1.32;
        public static decimal dc = 124;
        
        

        public PerformanceData()
        {
            
        }

        [BsonElement("_id")]
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        [BsonElement("GoogleResults")]
        public LigthouseResults GoogleResults { get; set; }

        [BsonElement("Date")]
        public DateTime Date { get; set; }

       
    }
}
