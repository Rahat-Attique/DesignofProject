using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hostel_project.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Complains()
        {
            return View();
        }
        public ActionResult BillCalculation()
        {
            return View();
        }
    }
}