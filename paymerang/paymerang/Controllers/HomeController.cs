using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
//
using System.Linq;
using JsonData.Models;
using paymerang;
using Newtonsoft.Json;

namespace paymerang.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            string json =  @"{
                'PayeeName': 'PayInfo.PayeeName',
                'PayeeFax: 'PayInfo.PayeeFax',
                'PayeePhone': 'PayInfo.PayeePhone' ,
                'PaymentPAN': 'PayInfo.PaymentPAN',
                'PaymentCVV': 'PayInfo.PaymentCVV',
                'PaymentExp': 'PayInfo.PaymentExp',
                'PayInfo.remittanceLines': [
                    'RemittancePayorName': 'Remittance.RemittancePayorName',
                    'RemittancePayorId': 'Remittance.RemittancePayorId',
                    'RemittanceInvoiceNo': 'Remittance.RemittanceInvoiceNo',
                    'RemittanceDescription': 'Remittance.RemittanceDescription',
                    'RemittanceAmount': 'Remittance.RemittanceAmount',
                ],
                'PaymentAddress': [
                    'Address1': 'PaymentAddress.Address1',
                    'Address2': 'PaymentAddress.Address2',
                    'city': 'PaymentAddress.city',
                    'StateOrProvince': 'PaymentAddress.StateOrProvince',
                    'Zip': 'PaymentAddress.Zip'
                ]
                }";
            var result = JsonConvert.DeserializeObject<PayInfo>(json);
            return View(result);
        }
    }
}


 // List<PayInfo> payee = JsonToFile<PayInfo>.ReadJson();
            // List<PaymentAddress> payment = JsonToFile<PaymentAddress>.ReadJson();
            // List<Remittance> remittance = JsonToFile<Remittance>.ReadJson();
        //going to scrap ViewBag approach
            // ViewBag.payees = from vendor in payee select new {
            //     vendor.PayeeName, vendor.PayeeFax, vendor.PayeePhone, vendor.PayeeAddress
            // };

            // ViewBag.payments = from payData in payment select new {
            //     payData.PaymentPAN, payData.PaymentCVV, payData.PaymentExp
            // };

            // ViewBag.remittance = from remitData in remittance select new {
            //     remitData.RemittancePayorName, remitData.RemittancePayorId, remitData.RemittanceInvoiceNo, remitData.RemittanceDescription, remitData.RemittanceAmount
            // };

            // var result = paymerang.JsonToFile<PaymentAddress>.ReadJson();