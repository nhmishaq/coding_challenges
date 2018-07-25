using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
//
using JsonData.Models;

namespace paymerang
{
    public class JsonToFile<T> {
        public object PayInfo { get; internal set; }

        public static PayInfo ReadJson() {
            // read file into a string and deserialize JSON to a type
            PayInfo payInfoData1 = JsonConvert.DeserializeObject<PayInfo>(File.ReadAllText(@"c:\sample.json"));

            // deserialize JSON directly from a file
            using (StreamReader file = File.OpenText(@"c:\sample.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                PayInfo payInfoData = (PayInfo)serializer.Deserialize(file, typeof(PayInfo));
                return payInfoData;   
            }      
        }
    }
}