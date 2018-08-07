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
            ViewBag.viewAllPortals = viewAllPortals;
            return View();
        }

        // Selecting a client should call to get list of courses for the selected client. Still needs a correct query for viewCourses
        [HttpGet]
        [Route("clientCourseList")]
        public IActionResult clientCourseList()
        {
            // string viewCourses =  $"Select * from u_portal order by portal.nm";
            // // DbConnector.Query(viewCourses);
            // ViewBag.viewCourses = viewCourses;

            string viewCourses = $"select registration_id, user_id, course_portal_id, registration_dttm from u_registration  where course_portal_id = course_portal_id_coming_in order by registration_dttm";
            // DbConnector.Query(executeRegistration);
            ViewBag.viewCourses = viewCourses;
            return View();
        }

        // Selecting a course should bring up list of users registered to the course.

        [HttpGet]
        [Route("registeredUsersOfCourse")]
        public IActionResult registeredUsersOfCourse(string course_portal_id_coming_in)
        {
            string registration_list = $"select registration_id, user_id, course_portal_id, registration_dttm from u_registration  where course_portal_id = course_portal_id_coming_in order by registration_dttm";
            // DbConnector.Query(executeRegistration);
            ViewBag.registration_list = registration_list;
            return View();
        }

        

    }
}
