using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DbConnection;

namespace cbhs.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            string viewAllPortals = $"Select * from u_portal order by portal.nm";
            // DbConnector.Query(viewAllPortals);
            return View();
        }

        // GET: /Home/
        [HttpGet]
        [Route("register")]
        public IActionResult Register()
        {
            // string executeRegistration = "Select p.portal_id, p.portal_nm from u_portal p order by p.portal_nm";
            // DbConnector.Execute(executeRegistration);
            return View();
        }
    }
}
