﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View();
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GetTotal(int Id, string FirstName, string LastName, string EmailAddress, DateTime DateOfBirth, int CarYear, string CarMake, string CarModel, bool DUI, int SpeedingTickets, bool CoverageType)    
            
        {

            decimal Total = 50;
            var today = DateTime.Today;
            // Calculate the age.
            var age = today.Year - DateOfBirth.Year;


            if (age > 100)
            {
                Total += 25;
            }

            else if (age < 18)
            {
                Total += 100;
            }

            else if (age < 25)
            {
                Total += 25;
            }

            if (CarYear < 2000)
            {
                Total += 25;
            }

            if (CarYear > 2015)
            {
                Total += 25;
            }

            if (CarMake == "Porsche")
            {
                Total += 25;
            }
            
            if (CarMake == "Porsche" && CarModel == "911 Carrera")
            {
                Total += 25;
            }

            if (SpeedingTickets > 0)
            {
                Total += (SpeedingTickets * 10);
            }

            if (DUI == true)
            {
                Total *= 1.25m;
            }

            if (CoverageType == true)
            {
                Total *= 1.5m;
            }
            

            using (InsuranceEntities db = new InsuranceEntities())
            {
                Insuree insuree = new Insuree();
                Id = insuree.Id;
                FirstName = insuree.FirstName;
                LastName = insuree.LastName;
                EmailAddress = insuree.EmailAddress;
                DateOfBirth = insuree.DateOfBirth;
                CarYear = insuree.CarYear;
                CarModel = insuree.CarModel;
                CarMake = insuree.CarMake;
                DUI = insuree.DUI;
                SpeedingTickets = insuree.SpeedingTickets;
                CoverageType = insuree.CoverageType;

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
           
           // db.Insurees.Add(insuree);
 
            }

        // DateOfBirth (other variables declared above) = names of variables already established in existant DB
        //DateOfBirth = 

        //    return View(insuree);
        

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
