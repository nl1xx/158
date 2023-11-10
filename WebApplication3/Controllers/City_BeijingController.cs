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
    public class City_BeijingController : Controller
    {
        private CommentsForBeijingContext db = new CommentsForBeijingContext();

        // GET: City_Beijing
        public ActionResult Index()
        {
            /*MyDbContext db = new MyDbContext();
            var data = db.YourEntities.ToList();
            return View(data);*/
            return View(db.City_Beijing.ToList());
        }

        // GET: City_Beijing/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            City_Beijing city_Beijing = db.City_Beijing.Find(id);
            if (city_Beijing == null)
            {
                return HttpNotFound();
            }
            return View(city_Beijing);
        }

        // GET: City_Beijing/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: City_Beijing/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,mainContent")] City_Beijing city_Beijing)
        {
            if (ModelState.IsValid)
            {
                db.City_Beijing.Add(city_Beijing);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(city_Beijing);
        }

        // GET: City_Beijing/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            City_Beijing city_Beijing = db.City_Beijing.Find(id);
            if (city_Beijing == null)
            {
                return HttpNotFound();
            }
            return View(city_Beijing);
        }

        // POST: City_Beijing/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,mainContent")] City_Beijing city_Beijing)
        {
            if (ModelState.IsValid)
            {
                db.Entry(city_Beijing).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(city_Beijing);
        }

        // GET: City_Beijing/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            City_Beijing city_Beijing = db.City_Beijing.Find(id);
            if (city_Beijing == null)
            {
                return HttpNotFound();
            }
            return View(city_Beijing);
        }

        // POST: City_Beijing/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            City_Beijing city_Beijing = db.City_Beijing.Find(id);
            db.City_Beijing.Remove(city_Beijing);
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
