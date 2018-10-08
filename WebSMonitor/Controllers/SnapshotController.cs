using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSMonitor.Models;

namespace WebSMonitor.Controllers
{
    public class SnapshotController : Controller
    {
        // GET: Snapshot
        public ActionResult Index()
        {
            var snapshots = from s in GetRandomSnapshots()
                            orderby s.ID
                            select s;
            return View(snapshots);
        }

        // GET: Snapshot/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Snapshot/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Snapshot/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Snapshot/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Snapshot/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Snapshot/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Snapshot/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [NonAction]
        public List<Snapshot> GetRandomSnapshots()
        {
            return new List<Snapshot>
            {
                new Snapshot
                {
                    ID = 1,
                    ExperimentID = "10xdc",
                    Taken = DateTime.Parse(DateTime.Today.ToString())
                },
                new Snapshot
                {
                    ID = 2,
                    ExperimentID = "10xdc",
                    Taken = DateTime.Parse(DateTime.Today.ToString())
                },
                new Snapshot
                {
                    ID = 3,
                    ExperimentID = "11xdc",
                    Taken = DateTime.Parse(DateTime.Today.ToString())
                }
            };
        }
    }
}
