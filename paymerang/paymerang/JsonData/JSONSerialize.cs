using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
//
using JsonData.Models;

namespace paymerang
{
    public class JsonToFile<T> {
        public object PayInfo { get; internal set; }


        public static List<PayInfo> ReadJson()
        {
        // read file into a string and deserialize JSON to a type
        var payInfoData1 = JsonConvert.DeserializeObject<List<PayInfo>>(File.ReadAllText(@"JsonData/sample.json"));
        // deserialize JSON directly from a file
        using (StreamReader file = File.OpenText(@"JsonData/sample.json"))
        {
            JsonSerializer serializer = new JsonSerializer();
            // PayInfo[] payInfoData = (PayInfo[])serializer.Deserialize(file, typeof(PayInfo[]));
            payInfoData1 = (List<PayInfo>)serializer.Deserialize(file, typeof(List<PayInfo>));
            return payInfoData1;
        }
        }

        // public static PayInfo[] ReadJson() {
        //     // read file into a string and deserialize JSON to a type
        //     PayInfo[] payInfoData1 = JsonConvert.DeserializeObject<PayInfo[]>(File.ReadAllText(@"JsonData/sample.json"));
        //     // deserialize JSON directly from a file
        //     using (StreamReader file = File.OpenText(@"JsonData/sample.json"))
        //     {
        //         JsonSerializer serializer = new JsonSerializer();
        //         // PayInfo[] payInfoData = (PayInfo[])serializer.Deserialize(file, typeof(PayInfo[]));
        //         payInfoData1 = (PayInfo[])serializer.Deserialize(file, typeof(PayInfo[]));
        //         return payInfoData1;   
        //     }      
        // }
    }
}
//Notes:
//1. Verified that the file path is correct (JsonData/sample.json)
//2. went from creating new instance of PayInfo in using method to original 
//payInfoData1 variable created in the JsonConvert step
//3. Debugger confirmed that the 15 objects are being caught in the Deserialize step;
//however the values are all null
