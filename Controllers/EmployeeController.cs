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
            var employeeId = User.Identity.GetUserId();
            var employee = db.Employees.SingleOrDefault(e => e.ApplicationId == employeeId);
            var ListOfPickUps = db.Customers.Where(c => c.ZipCode == employee.ZipCode);
            //if (customer.PickupDay == customer.PickupDay && customer.ZipCode == employee.ZipCode)
            //{
            //    customer.PickUpStatus = true;
            //    customer.Balance += 30;
            //}
            return View(ListOfPickUps);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            var employeeFromDb = db.Employees.Where(e => e.Id == id).SingleOrDefault();
            return View(employeeFromDb);
        }

        // GET: Employee/Create
        public ActionResult Create()
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
            Employee employeeFromDb = db.Employees.Where(e => e.Id == id).SingleOrDefault();

            return View(employeeFromDb);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee employee)
        {
            var employeeFromDb = db.Employees.Where(e => e.Id == id).SingleOrDefault();
            employeeFromDb.FirstName = employee.FirstName;
            employeeFromDb.LastName = employee.LastName;
            employeeFromDb.ZipCode = employee.ZipCode;
            employeeFromDb.PickUpStatus = employee.PickUpStatus;

            db.SaveChanges();
           

            return View();
        }
        [HttpGet]
        public ActionResult PickUpStatus(Customer customer, Employee employee)
        {

           
            return View("Index");
            //come back to that later
        }
        [HttpGet]
        //employee/Filter
        public ActionResult Index(string pickupDay)
        {
            var employeeId = User.Identity.GetUserId();
            var employee = db.Employees.SingleOrDefault(e => e.ApplicationId == employeeId);
           
            var pickupFilter = db.Customers.Where(c => c.PickupDay == pickupDay);
            var ListOfPickUps = pickupFilter.Where(c => c.ZipCode == employee.ZipCode);

            return View(ListOfPickUps);
        }
    }
}

        // GET: Employee/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Employee/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
 