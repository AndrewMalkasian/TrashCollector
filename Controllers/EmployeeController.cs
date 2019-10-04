using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollectorRemade.Models;

namespace TrashCollectorRemade.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext db;
        public EmployeeController()
        {
            db = new ApplicationDbContext();
        }
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create(Employee employee)
        {
            
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
          
                employee.ApplicationId = User.Identity.GetUserId();
                db.Employees.Add(employee);
                db.SaveChanges();

                return RedirectToAction("Index");
          
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
