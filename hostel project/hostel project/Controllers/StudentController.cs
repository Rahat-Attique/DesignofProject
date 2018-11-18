using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hostel_project.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddComplains()
        {
            return View();
        }

        public ActionResult ViewDetails()
        {
            return View();
        }

        public ActionResult Calender()
        {
            return View();
        }
    }
}