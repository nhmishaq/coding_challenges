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
            var result = new paymerang.JsonToFile<PayInfo>();
            // PayInfo payInfo = JsonConvert.DeserializeObject<PayInfo>(File.ReadAllText(@"c:\sample.json"));
            return View(result);
        }
    }
}