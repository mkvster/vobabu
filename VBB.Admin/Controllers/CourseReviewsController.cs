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
    public class CourseReviewsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CourseReviews
        public ActionResult Index()
        {
            var courseReviews = db.CourseReviews.Include(c => c.Course).Include(c => c.CreatedBy);
            return View(courseReviews.ToList());
        }

        // GET: CourseReviews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseReview courseReview = db.CourseReviews.Find(id);
            if (courseReview == null)
            {
                return HttpNotFound();
            }
            return View(courseReview);
        }

        // GET: CourseReviews/Create
        public ActionResult Create()
        {
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "Name");
            ViewBag.CreatedById = new SelectList(db.People, "Id", "UserName");
            return View();
        }

        // POST: CourseReviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IsBlocked,CourseId,StartCount,Description,CreatedById")] CourseReview courseReview)
        {
            if (ModelState.IsValid)
            {
                db.CourseReviews.Add(courseReview);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseId = new SelectList(db.Courses, "Id", "Name", courseReview.CourseId);
            ViewBag.CreatedById = new SelectList(db.People, "Id", "UserName", courseReview.CreatedById);
            return View(courseReview);
        }

        // GET: CourseReviews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseReview courseReview = db.CourseReviews.Find(id);
            if (courseReview == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "Name", courseReview.CourseId);
            ViewBag.CreatedById = new SelectList(db.People, "Id", "UserName", courseReview.CreatedById);
            return View(courseReview);
        }

        // POST: CourseReviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IsBlocked,CourseId,StartCount,Description,CreatedById")] CourseReview courseReview)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseReview).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "Name", courseReview.CourseId);
            ViewBag.CreatedById = new SelectList(db.People, "Id", "UserName", courseReview.CreatedById);
            return View(courseReview);
        }

        // GET: CourseReviews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseReview courseReview = db.CourseReviews.Find(id);
            if (courseReview == null)
            {
                return HttpNotFound();
            }
            return View(courseReview);
        }

        // POST: CourseReviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseReview courseReview = db.CourseReviews.Find(id);
            db.CourseReviews.Remove(courseReview);
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
