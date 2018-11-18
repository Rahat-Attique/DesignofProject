using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hostel_project.Controllers
{
    public class RTController : Controller
    {
        // GET: RT
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Menu()
        {
            return View();
        }

        public ActionResult OneDayMenu()
        {
            return View();
        }

        public ActionResult Requests()
        {
            return View();
        }
    }
}