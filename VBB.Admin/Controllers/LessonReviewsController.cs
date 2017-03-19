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
    public class LessonReviewsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: LessonReviews
        public ActionResult Index()
        {
            var lessonReviews = db.LessonReviews.Include(l => l.CreatedBy).Include(l => l.Lesson);
            return View(lessonReviews.ToList());
        }

        // GET: LessonReviews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LessonReview lessonReview = db.LessonReviews.Find(id);
            if (lessonReview == null)
            {
                return HttpNotFound();
            }
            return View(lessonReview);
        }

        // GET: LessonReviews/Create
        public ActionResult Create()
        {
            ViewBag.CreatedById = new SelectList(db.People, "Id", "UserName");
            ViewBag.LessonId = new SelectList(db.Lessons, "Id", "Name");
            return View();
        }

        // POST: LessonReviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IsBlocked,StartCount,Description,LessonId,CreatedById")] LessonReview lessonReview)
        {
            if (ModelState.IsValid)
            {
                db.LessonReviews.Add(lessonReview);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CreatedById = new SelectList(db.People, "Id", "UserName", lessonReview.CreatedById);
            ViewBag.LessonId = new SelectList(db.Lessons, "Id", "Name", lessonReview.LessonId);
            return View(lessonReview);
        }

        // GET: LessonReviews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LessonReview lessonReview = db.LessonReviews.Find(id);
            if (lessonReview == null)
            {
                return HttpNotFound();
            }
            ViewBag.CreatedById = new SelectList(db.People, "Id", "UserName", lessonReview.CreatedById);
            ViewBag.LessonId = new SelectList(db.Lessons, "Id", "Name", lessonReview.LessonId);
            return View(lessonReview);
        }

        // POST: LessonReviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IsBlocked,StartCount,Description,LessonId,CreatedById")] LessonReview lessonReview)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lessonReview).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CreatedById = new SelectList(db.People, "Id", "UserName", lessonReview.CreatedById);
            ViewBag.LessonId = new SelectList(db.Lessons, "Id", "Name", lessonReview.LessonId);
            return View(lessonReview);
        }

        // GET: LessonReviews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LessonReview lessonReview = db.LessonReviews.Find(id);
            if (lessonReview == null)
            {
                return HttpNotFound();
            }
            return View(lessonReview);
        }

        // POST: LessonReviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LessonReview lessonReview = db.LessonReviews.Find(id);
            db.LessonReviews.Remove(lessonReview);
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
