using DNet_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace DNet_MVC.Controllers
{
    public class HomeController : Controller
    {
        protected override void OnAuthentication(AuthenticationContext filterContext)
        {

        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {

        }

        // GET: Home
        public ActionResult Index()
        {  
            Customer c = new Customer();
            c.ID= 1;
            c.Name = "Sagar";

            return View("Index", c);
        }
    }
}