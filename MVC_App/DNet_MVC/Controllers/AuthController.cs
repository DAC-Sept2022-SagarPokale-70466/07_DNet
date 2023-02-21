using DNet_MVC.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DNet_MVC.Controllers  
{
    //[Authorize]
// Tjis will require Authenticatio and the it will read the web.config file
    public class AuthController : Controller
    {
        
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AfterSignIn(UserData data, string returnUrl)
        {
            if (ValidateUserData(data))
            {
                FormsAuthentication.SetAuthCookie(data.UserName, false);
                // false is for To store in the hard disk or not 
                if (returnUrl != null)
                {
                    return Redirect(returnUrl);
                }
                {
                    return Redirect("/Table/Index");
                }
            }
            else
            {
                ViewBag.Message = "UserName or Password is wrong";
                return View("SignIn");
            }
        }

        private bool ValidateUserData(UserData data)
        {
            ClassworkEntities dbData = new ClassworkEntities();
            List<Table> tablesData = dbData.Tables.ToList();

            foreach (Table table in tablesData)
            {
                if (table.Name.Equals(data.UserName))
                    return true;
            }

            return false;

        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("/Table/Index");
        }

    }
}