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
    public class TermPicturesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TermPictures
        public ActionResult Index()
        {
            var termPictures = db.TermPictures.Include(t => t.Term);
            return View(termPictures.ToList());
        }

        // GET: TermPictures/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TermPicture termPicture = db.TermPictures.Find(id);
            if (termPicture == null)
            {
                return HttpNotFound();
            }
            return View(termPicture);
        }

        // GET: TermPictures/Create
        public ActionResult Create()
        {
            ViewBag.TermId = new SelectList(db.Terms, "Id", "Name");
            return View();
        }

        // POST: TermPictures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IsReadOnly,IsBlocked,TermId,ImageUrl,IsTransparent")] TermPicture termPicture)
        {
            if (ModelState.IsValid)
            {
                db.TermPictures.Add(termPicture);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TermId = new SelectList(db.Terms, "Id", "Name", termPicture.TermId);
            return View(termPicture);
        }

        // GET: TermPictures/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TermPicture termPicture = db.TermPictures.Find(id);
            if (termPicture == null)
            {
                return HttpNotFound();
            }
            ViewBag.TermId = new SelectList(db.Terms, "Id", "Name", termPicture.TermId);
            return View(termPicture);
        }

        // POST: TermPictures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IsReadOnly,IsBlocked,TermId,ImageUrl,IsTransparent")] TermPicture termPicture)
        {
            if (ModelState.IsValid)
            {
                db.Entry(termPicture).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TermId = new SelectList(db.Terms, "Id", "Name", termPicture.TermId);
            return View(termPicture);
        }

        // GET: TermPictures/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TermPicture termPicture = db.TermPictures.Find(id);
            if (termPicture == null)
            {
                return HttpNotFound();
            }
            return View(termPicture);
        }

        // POST: TermPictures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TermPicture termPicture = db.TermPictures.Find(id);
            db.TermPictures.Remove(termPicture);
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
