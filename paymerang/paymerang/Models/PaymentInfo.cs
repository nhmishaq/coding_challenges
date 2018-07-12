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
        List<Remittance> remittanceLines;
        public PaymentAddress Address;
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