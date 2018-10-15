using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebSMonitor.Models;

namespace WebSMonitor.Controllers
{
    public class ImmediateResultsController : Controller
    {
        private ImmediateResultDBContext db = new ImmediateResultDBContext();

        // GET: ImmediateResults
        public ActionResult Index()
        {
            return View(db.ImmediateResults.ToList());
        }

        // GET: ImmediateResults/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ImmediateResult immediateResult = db.ImmediateResults.Find(id);
            if (immediateResult == null)
            {
                return HttpNotFound();
            }
            return View(immediateResult);
        }

        // GET: ImmediateResults/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ImmediateResults/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ControlPoints,Dpc,ErrorValue,Timestamp")] ImmediateResult immediateResult)
        {
            if (ModelState.IsValid)
            {
                db.ImmediateResults.Add(immediateResult);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(immediateResult);
        }

        // GET: ImmediateResults/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ImmediateResult immediateResult = db.ImmediateResults.Find(id);
            if (immediateResult == null)
            {
                return HttpNotFound();
            }
            return View(immediateResult);
        }

        // POST: ImmediateResults/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ControlPoints,Dpc,ErrorValue,Timestamp")] ImmediateResult immediateResult)
        {
            if (ModelState.IsValid)
            {
                db.Entry(immediateResult).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(immediateResult);
        }

        // GET: ImmediateResults/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ImmediateResult immediateResult = db.ImmediateResults.Find(id);
            if (immediateResult == null)
            {
                return HttpNotFound();
            }
            return View(immediateResult);
        }

        // POST: ImmediateResults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ImmediateResult immediateResult = db.ImmediateResults.Find(id);
            db.ImmediateResults.Remove(immediateResult);
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
