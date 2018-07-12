using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
//
using System.Linq;
using JsonData.Models;
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
            List<PaymentAddress> payment = JsonToFile<PaymentAddress>.ReadJson();
            List<Remittance> remittance = JsonToFile<Remittance>.ReadJson();
        //going to scrap ViewBag approach
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
