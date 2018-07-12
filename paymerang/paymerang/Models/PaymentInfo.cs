using System.Collections.Generic;
using paymerang;

namespace JsonData.Models {
    //Seperated PayInfo, PaymentAddress, and Remittance into their own classes.
    public class PayInfo {
        public string PayeeName;
        public string PayeeFax;
        public string PayeePhone;
        public string PaymentPAN;
        public string PaymentCVV;
        public string PaymentExp;
    }
    public class PaymentAddress {
        
        public string Address1;
        public string Address2;
        public string city;
        public string StateOrProvince;
        public string Zip;

    }
    public class Remittance {
        public string RemittancePayorName;
        public string RemittancePayorId;
        public string RemittanceInvoiceNo;
        public string RemittanceDescription;
        public string RemittanceAmount;
    }
}

        // List<PayInfo> payment = JsonToFile<PayInfo>.ReadJson();
        // // Dictionary<string, string> payment;
        // Dictionary<string, string> remittance;

        // public List<string> PayeeAddress;

        // public List<string> Payee;
        // public List<string> Payment;
        // public List<string> Remittance;