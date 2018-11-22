using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hostel_project.Models;

namespace hostel_project.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student

    // [HttpPost]
         public ActionResult Index()
            {
            Database1Entities db = new  Database1Entities();
            var result = (from c in db.Tables
                          select new Table 
                          {
                            Id=c.Id,
                              Name=c.Name,
                              Password = c.Password,
                             EmailAdress = c.EmailAdress,
                              PhoneNo = c.PhoneNo,
                              CNIC = c.CNIC,
                              Adress = c.Adress,
                              Degree = c.Degree,
                              DepartmentName = c.DepartmentName,
                              RegistrationNo = c.RegistrationNo,
                              HostelName = c.HostelName,
                              RoomNo = c.RoomNo
                             

                          }).ToList();
            return View(result);


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