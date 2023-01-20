using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
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
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // calls quote calculation method
                CalculateQuote(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

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
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // recalculate quote if user edits input
                CalculateQuote(insuree);
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

        //ASSIGNMENT
        //Calculate quote based on user input
        public ActionResult CalculateQuote(Insuree insuree)
        {
            // start with base quote of $50/month
            insuree.Quote = 50m;
            // calculate current age of user
            int currentAge = DateTime.Now.Year - insuree.DateOfBirth.Year;
            // if loops that calculate how much to add to quote dependent on age
            if (currentAge <= 18)
            {
                insuree.Quote += 100M;
            }
            else if (currentAge > 18 && currentAge <= 25)
            {
                insuree.Quote += 50M;
            }
            else
            {
                insuree.Quote += 25M;
            }
            // if loop for adding to quote value depending on car year
            if (insuree.CarYear < 2000)
            {
                insuree.Quote += 25M;
            }
            else if (insuree.CarYear > 2015)
            {
                insuree.Quote += 25M;
            }
            // if loop for adding to quote value depending on car make
            if (insuree.CarMake.ToLower() == "porsche")
            {
                insuree.Quote += 25M;
                // if loop for model if make matches value
                if (insuree.CarModel.ToLower() == "911 carrera")
                {
                    insuree.Quote += 25M;
                }
            }
            // add 10 for each speeding tickets
            insuree.Quote += insuree.SpeedingTickets * 10; // if it's 0, it will add 0
            // dui
            if (insuree.DUI == true)
            {
                insuree.Quote += insuree.Quote / 4M;
            }
            if (insuree.CoverageType)
            {
                insuree.Quote += insuree.Quote / 2M;
            }

            db.SaveChanges();
            return View(insuree);
        }
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }
    }
}
