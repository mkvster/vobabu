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
    public class TermTopicsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TermTopics
        public ActionResult Index()
        {
            return View(db.TermTopics.ToList());
        }

        // GET: TermTopics/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TermTopic termTopic = db.TermTopics.Find(id);
            if (termTopic == null)
            {
                return HttpNotFound();
            }
            return View(termTopic);
        }

        // GET: TermTopics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TermTopics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IsReadOnly,IsBlocked,Name")] TermTopic termTopic)
        {
            if (ModelState.IsValid)
            {
                db.TermTopics.Add(termTopic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(termTopic);
        }

        // GET: TermTopics/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TermTopic termTopic = db.TermTopics.Find(id);
            if (termTopic == null)
            {
                return HttpNotFound();
            }
            return View(termTopic);
        }

        // POST: TermTopics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IsReadOnly,IsBlocked,Name")] TermTopic termTopic)
        {
            if (ModelState.IsValid)
            {
                db.Entry(termTopic).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(termTopic);
        }

        // GET: TermTopics/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TermTopic termTopic = db.TermTopics.Find(id);
            if (termTopic == null)
            {
                return HttpNotFound();
            }
            return View(termTopic);
        }

        // POST: TermTopics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TermTopic termTopic = db.TermTopics.Find(id);
            db.TermTopics.Remove(termTopic);
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
