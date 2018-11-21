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
using System.IO;

namespace paymerang.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {   
            var payData = paymerang.JsonToFile<PayInfo>.ReadJson();
            return View(payData);
        }
    }
}