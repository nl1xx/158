using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class City_NewZealandController : Controller
    {
        private CommentsForNZContext db = new CommentsForNZContext();

        // GET: City_NewZealand
        public ActionResult Index()
        {
            return View(db.City_NewZealand.ToList());
        }

        // GET: City_NewZealand/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            City_NewZealand city_NewZealand = db.City_NewZealand.Find(id);
            if (city_NewZealand == null)
            {
                return HttpNotFound();
            }
            return View(city_NewZealand);
        }

        // GET: City_NewZealand/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: City_NewZealand/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,mainContent")] City_NewZealand city_NewZealand)
        {
            if (ModelState.IsValid)
            {
                db.City_NewZealand.Add(city_NewZealand);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(city_NewZealand);
        }

        // GET: City_NewZealand/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            City_NewZealand city_NewZealand = db.City_NewZealand.Find(id);
            if (city_NewZealand == null)
            {
                return HttpNotFound();
            }
            return View(city_NewZealand);
        }

        // POST: City_NewZealand/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,mainContent")] City_NewZealand city_NewZealand)
        {
            if (ModelState.IsValid)
            {
                db.Entry(city_NewZealand).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(city_NewZealand);
        }

        // GET: City_NewZealand/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            City_NewZealand city_NewZealand = db.City_NewZealand.Find(id);
            if (city_NewZealand == null)
            {
                return HttpNotFound();
            }
            return View(city_NewZealand);
        }

        // POST: City_NewZealand/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            City_NewZealand city_NewZealand = db.City_NewZealand.Find(id);
            db.City_NewZealand.Remove(city_NewZealand);
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
