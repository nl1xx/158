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
    public class City_TianjinController : Controller
    {
        private CommentsForTianjinContext db = new CommentsForTianjinContext();

        // GET: City_Tianjin
        public ActionResult Index()
        {
            return View(db.City_Tianjin.ToList());
        }

        // GET: City_Tianjin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            City_Tianjin city_Tianjin = db.City_Tianjin.Find(id);
            if (city_Tianjin == null)
            {
                return HttpNotFound();
            }
            return View(city_Tianjin);
        }

        // GET: City_Tianjin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: City_Tianjin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,mainContent")] City_Tianjin city_Tianjin)
        {
            if (ModelState.IsValid)
            {
                db.City_Tianjin.Add(city_Tianjin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(city_Tianjin);
        }

        // GET: City_Tianjin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            City_Tianjin city_Tianjin = db.City_Tianjin.Find(id);
            if (city_Tianjin == null)
            {
                return HttpNotFound();
            }
            return View(city_Tianjin);
        }

        // POST: City_Tianjin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,mainContent")] City_Tianjin city_Tianjin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(city_Tianjin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(city_Tianjin);
        }

        // GET: City_Tianjin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            City_Tianjin city_Tianjin = db.City_Tianjin.Find(id);
            if (city_Tianjin == null)
            {
                return HttpNotFound();
            }
            return View(city_Tianjin);
        }

        // POST: City_Tianjin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            City_Tianjin city_Tianjin = db.City_Tianjin.Find(id);
            db.City_Tianjin.Remove(city_Tianjin);
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
