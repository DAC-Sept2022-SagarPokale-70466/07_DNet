using DNet_MVC.Filter;
using DNet_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.Mvc;
            
namespace DNet_MVC.Controllers
{
    [Authorize]
    public class TableController : Controller
    {
        ClassworkEntities DBData = new ClassworkEntities();

        // GET: Table
        [SBFilter]
        public ActionResult Index()
        {
            List<Table> allData = DBData.Tables.ToList();

            ViewBag.UserName = "Welcome "+ User.Identity.Name;
            // User.Identity.Name will give the current Authorized User

            return View("Index", allData);
        }

        public ActionResult Edit(int id)
        {
            Table data = DBData.Tables.Find(id);
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(Table data)
        {
            Table dataToBeEdited = DBData.Tables.Find(data.Id);
            dataToBeEdited.Name = data.Name;
            dataToBeEdited.Address = data.Address;
            DBData.SaveChanges();
            return Redirect("/Table/Index");
        }

        public ActionResult Delete(int id)
        {
            Table dataToRemove = DBData.Tables.Find(id);
            DBData.Tables.Remove(dataToRemove);
            DBData.SaveChanges();
            return Redirect("/Table/Index");
            
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult AfterCreate(Table dataToBeAdded)
        {
            DBData.Tables.Add(dataToBeAdded);
            DBData.SaveChanges();

            return Redirect("/Table/Index");
        }
    }
}