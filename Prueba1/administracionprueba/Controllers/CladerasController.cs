using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using administracionprueba.Models;

namespace administracionprueba.Controllers
{
    public class CladerasController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Claderas
        [Authorize]
        public ActionResult Index()
        {
            return View(db.Claderas.ToList());
        }

        // GET: Claderas/Details/5
        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cladera cladera = db.Claderas.Find(id);
            if (cladera == null)
            {
                return HttpNotFound();
            }
            return View(cladera);
        }

        // GET: Claderas/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Claderas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CladeraID,FriendofCladera,Place,Email,Birthdate")] Cladera cladera)
        {
            if (ModelState.IsValid)
            {
                db.Claderas.Add(cladera);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cladera);
        }

        // GET: Claderas/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cladera cladera = db.Claderas.Find(id);
            if (cladera == null)
            {
                return HttpNotFound();
            }
            return View(cladera);
        }

        // POST: Claderas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CladeraID,FriendofCladera,Place,Email,Birthdate")] Cladera cladera)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cladera).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cladera);
        }

        // GET: Claderas/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cladera cladera = db.Claderas.Find(id);
            if (cladera == null)
            {
                return HttpNotFound();
            }
            return View(cladera);
        }

        // POST: Claderas/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cladera cladera = db.Claderas.Find(id);
            db.Claderas.Remove(cladera);
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
