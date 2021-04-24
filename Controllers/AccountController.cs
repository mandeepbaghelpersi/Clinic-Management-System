using Clinic_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Clinic_Management_System.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(user model)
        {
            using (var context = new ClinicDBEntities())
            {

                bool loginIsValid = context.users.Any(x => x.user_name == model.user_name && x.user_password == model.user_password);

                if (loginIsValid)
                {
                    FormsAuthentication.SetAuthCookie(model.user_name,false);
                    return RedirectToAction("Index", "Patients");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password");
                    return View();
                }
            }
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(user model)
        {
            using(var context = new ClinicDBEntities())
            {
                context.users.Add(model);
                context.SaveChanges();
                return RedirectToAction("Login");
            }
           
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

    }
}