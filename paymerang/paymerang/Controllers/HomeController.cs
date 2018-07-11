using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
//
using System.Linq;
using JsonData;
using paymerang;

namespace paymerang.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            List<PayInfo> payee = JsonToFile<PayInfo>.ReadJson();
            List<PayInfo> payment = JsonToFile<PayInfo>.ReadJson();
            List<PayInfo> remittance = JsonToFile<PayInfo>.ReadJson();
        
            ViewBag.payees = from vendor in payee select new {
                vendor.PayeeName, vendor.PayeeFax, vendor.PayeePhone, vendor.PayeeAddress
            };

            ViewBag.payments = from payData in payment select new {
                payData.PaymentPAN, payData.PaymentCVV, payData.PaymentExp
            };

            ViewBag.remittance = from remitData in remittance select new {
                remitData.RemittancePayorName, remitData.RemittancePayorId, remitData.RemittanceInvoiceNo, remitData.RemittanceDescription, remitData.RemittanceAmount
            };
            return View("Index");
        }
    }
}
