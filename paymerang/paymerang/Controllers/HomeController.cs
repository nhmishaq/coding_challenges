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
                vendor.Name, vendor.Fax, vendor.Phone, vendor.Address
            };

            ViewBag.payments = from data in payment select new {
                payData.PAN, payData.CVV, payData.Exp
            };

            ViewBag.remittance = from remitData in remittance select new {
                remitData.PayorName, remitData.PayorId, remitData.InvoiceNo, remitData.Description, remitData.Amount
            };
            return View("Index");
        }
    }
}
