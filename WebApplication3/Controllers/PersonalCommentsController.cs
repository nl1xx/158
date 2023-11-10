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
    public class PersonalCommentsController : Controller
    {
        private PersonalCommentsContext db = new PersonalCommentsContext();

        // GET: PersonalComments
        public ActionResult Index()
        {
            return View(db.PersonalComments.OrderBy(c => c.personalComment).ToList());
        }

        // GET: PersonalComments/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalComments personalComments = db.PersonalComments.Find(id);
            if (personalComments == null)
            {
                return HttpNotFound();
            }
            return View(personalComments);
        }

        // GET: PersonalComments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonalComments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "personalComment")] PersonalComments personalComments)
        {
            if (ModelState.IsValid)
            {
                db.PersonalComments.Add(personalComments);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personalComments);
        }

        // GET: PersonalComments/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalComments personalComments = db.PersonalComments.Find(id);
            if (personalComments == null)
            {
                return HttpNotFound();
            }
            return View(personalComments);
        }

        // POST: PersonalComments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "personalComment")] PersonalComments personalComments)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personalComments).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personalComments);
        }

        // GET: PersonalComments/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalComments personalComments = db.PersonalComments.Find(id);
            if (personalComments == null)
            {
                return HttpNotFound();
            }
            return View(personalComments);
        }

        // POST: PersonalComments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PersonalComments personalComments = db.PersonalComments.Find(id);
            db.PersonalComments.Remove(personalComments);
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
