using System.Collections.Generic;
using paymerang;

namespace JsonData {
    public class PayInfo {
     
        // List<PayInfo> payment = JsonToFile<PayInfo>.ReadJson();
        // // Dictionary<string, string> payment;
        // Dictionary<string, string> remittance;

        public string PayeeName;
        public string PayeeFax;

        public string PayeePhone;

        public List<string> PayeeAddress;
//
        public string PaymentPAN;
        public string PaymentCVV;
        public string PaymentExp;
//
        public string RemittancePayorName;
        public string RemittancePayorId;
        public string RemittanceInvoiceNo;
        public string RemittanceDescription;
        public string RemittanceAmount;
        
        // public List<string> Payee;
        // public List<string> Payment;
        // public List<string> Remittance;

    }
}