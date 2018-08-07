using System.Collections.Generic;
using Newtonsoft.Json;
using paymerang;

namespace JsonData.Models {
    //Seperated PayInfo, PaymentAddress, and Remittance into their own classes.
    public class PayInfo {
        public string PayeeName { get; set; }
        public string PayeeFax { get; set; }
        public string PayeePhone { get; set; }
        public string PaymentPAN { get; set; }
        public string PaymentCVV { get; set; }
        public string PaymentExp { get; set; }
        public PaymentAddress Address { get; set; }
        public List<Remittance> RemittanceLines { get; set; }
    
    }
    public class PaymentAddress {
        
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public string Zip { get; set; }

    }
    public class Remittance {
        public string PayorName { get; set; }
        public string PayorId { get; set; }
        public string InvoiceNo { get; set; }
        public string Description { get; set; }
        public string Amount { get; set; }
    }
}