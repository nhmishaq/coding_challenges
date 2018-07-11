using System.Collections.Generic;
using paymerang;

namespace JsonData {
    public class PayInfo {
     
        // List<PayInfo> payment = JsonToFile<PayInfo>.ReadJson();
        // // Dictionary<string, string> payment;
        // Dictionary<string, string> remittance;

        public List<string> Payee;
        public List<string> Payment;
        public List<string> Remittance;

    }
}