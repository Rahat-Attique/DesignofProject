using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hostel_project.Models;

namespace hostel_project.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

      
      

        // POST: User/Register
        [HttpPost]
        public ActionResult Index(User user)
        {
            HostelProjectEntities  usersEntities= new HostelProjectEntities();
            usersEntities.Users.Add(user);
            usersEntities.SaveChanges();
            string message = string.Empty;
            switch (user.UserId)
            {
                case -1:
                    message = "Username already exists.\\nPlease choose a different username.";
                    break;
                case -2:
                    message = "Supplied email address has already been used.";
                    break;
                default:
                    message = "Registration successful.\\nUser Id: " + user.UserId.ToString();
                    break;
            }
            ViewBag.Message = message;

            return View(user);
        }

        // GET: User/Login
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [Authorize]
        public ActionResult Profile()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(User user)
        {
            HostelProjectEntities usersEntities = new HostelProjectEntities();
            int? userId = usersEntities.ValidateUser(user.Username, user.Password).FirstOrDefault();

            string message = string.Empty;
            switch (userId.Value)
            {
                case -1:
                    message = "Username and/or password is incorrect.";
                    break;
                case -2:
                    message = "Account has not been activated.";
                    break;
                default:
                    //FormsAuthentication.SetAuthCookie(user.Username, user.RememberMe);
                    if (!string.IsNullOrEmpty(Request.Form["ReturnUrl"]))
                    {
                        return RedirectToAction(Request.Form["ReturnUrl"].Split('/')[2]);
                    }
                    else
                    {
                        return RedirectToAction("Profile");
                    }
            }

            ViewBag.Message = message;
            return View(user);
        }


    }
}
