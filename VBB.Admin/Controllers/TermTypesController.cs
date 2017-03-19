using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VBB.DataAccessLayer;
using VBB.Model;

namespace VBB.Admin.Controllers
{
    public class TermTypesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TermTypes
        public ActionResult Index()
        {
            return View(db.TermTypes.ToList());
        }

        // GET: TermTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TermType termType = db.TermTypes.Find(id);
            if (termType == null)
            {
                return HttpNotFound();
            }
            return View(termType);
        }

        // GET: TermTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TermTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IsReadOnly,IsBlocked,Name")] TermType termType)
        {
            if (ModelState.IsValid)
            {
                db.TermTypes.Add(termType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(termType);
        }

        // GET: TermTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TermType termType = db.TermTypes.Find(id);
            if (termType == null)
            {
                return HttpNotFound();
            }
            return View(termType);
        }

        // POST: TermTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IsReadOnly,IsBlocked,Name")] TermType termType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(termType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(termType);
        }

        // GET: TermTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TermType termType = db.TermTypes.Find(id);
            if (termType == null)
            {
                return HttpNotFound();
            }
            return View(termType);
        }

        // POST: TermTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TermType termType = db.TermTypes.Find(id);
            db.TermTypes.Remove(termType);
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
