using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class Mobile20160830Controller : Controller
    {
        private testDBEntities db = new testDBEntities();

        // GET: Mobile20160830
        public ActionResult Index()
        {
            return View(db.Mobile20160830.Take(10).ToList());
        }

        // GET: Mobile20160830/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mobile20160830 mobile20160830 = db.Mobile20160830.Find(id);
            if (mobile20160830 == null)
            {
                return HttpNotFound();
            }
            return View(mobile20160830);
        }

        // GET: Mobile20160830/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mobile20160830/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserDisplayName,DeviceOS,DeviceType,WhenChanged,id")] Mobile20160830 mobile20160830)
        {
            if (ModelState.IsValid)
            {
                db.Mobile20160830.Add(mobile20160830);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mobile20160830);
        }

        // GET: Mobile20160830/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mobile20160830 mobile20160830 = db.Mobile20160830.Find(id);
            if (mobile20160830 == null)
            {
                return HttpNotFound();
            }
            return View(mobile20160830);
        }

        // POST: Mobile20160830/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserDisplayName,DeviceOS,DeviceType,WhenChanged,id")] Mobile20160830 mobile20160830)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mobile20160830).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mobile20160830);
        }

        // GET: Mobile20160830/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mobile20160830 mobile20160830 = db.Mobile20160830.Find(id);
            if (mobile20160830 == null)
            {
                return HttpNotFound();
            }
            return View(mobile20160830);
        }

        // POST: Mobile20160830/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mobile20160830 mobile20160830 = db.Mobile20160830.Find(id);
            db.Mobile20160830.Remove(mobile20160830);
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
