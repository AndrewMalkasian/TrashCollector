using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollectorRemade.Models;

namespace TrashCollectorRemade.Controllers
{
    public class CustomerController : Controller

    {
        ApplicationDbContext db;
        public CustomerController()
        {
            db = new ApplicationDbContext();
        }
        // GET: Customer
        public ActionResult Index()
        {
            var CustomerId = User.Identity.GetUserId();
            var customer = db.Customers.Where(e => e.ApplicationId == CustomerId).ToList();

            return View(customer);
        }
        //TODO: createyourindex view 

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            Customer customerFromDb = db.Customers.Where(c => c.Id == id).SingleOrDefault();


            return View(customerFromDb);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            Customer customer = new Customer();
            return View(customer);

        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
        
            customer.ApplicationId = User.Identity.GetUserId();
            db.Customers.Add(customer);
            db.SaveChanges();

     
                // b4 adding customer to table and saving changes,
                // assign customer.ApplicationId
             //   customer.ApplicationId = Application;


            return RedirectToAction("Index");
           

        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            Customer customerFromDb = db.Customers.Where(c => c.Id == id).SingleOrDefault();


            return View(customerFromDb);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                var customerFromDb = db.Customers.Where(c => c.Id == id).SingleOrDefault();
                customerFromDb.FirstName = customer.FirstName;
                customerFromDb.LastName = customer.LastName;
                customerFromDb.StreetAddress = customer.StreetAddress;
                customerFromDb.ZipCode = customer.ZipCode;
                customerFromDb.State = customer.State;
                customerFromDb.PickupDay = customer.PickupDay;
                customerFromDb.SpecialOneTimePickUp = customer.SpecialOneTimePickUp;
                customerFromDb.PickUpStartDay = customer.PickUpStartDay;
                customerFromDb.PickUpEndDay = customer.PickUpEndDay;
                db.SaveChanges();

                return RedirectToAction("Index","Customer");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Customer/Delete/5
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
    }
}
