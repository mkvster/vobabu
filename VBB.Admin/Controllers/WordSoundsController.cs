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
    public class WordSoundsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: WordSounds
        public ActionResult Index()
        {
            var wordSounds = db.WordSounds.Include(w => w.Word);
            return View(wordSounds.ToList());
        }

        // GET: WordSounds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WordSound wordSound = db.WordSounds.Find(id);
            if (wordSound == null)
            {
                return HttpNotFound();
            }
            return View(wordSound);
        }

        // GET: WordSounds/Create
        public ActionResult Create()
        {
            ViewBag.WordId = new SelectList(db.Words, "Id", "Text");
            return View();
        }

        // POST: WordSounds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IsReadOnly,IsBlocked,WordId,SoundUrl")] WordSound wordSound)
        {
            if (ModelState.IsValid)
            {
                db.WordSounds.Add(wordSound);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.WordId = new SelectList(db.Words, "Id", "Text", wordSound.WordId);
            return View(wordSound);
        }

        // GET: WordSounds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WordSound wordSound = db.WordSounds.Find(id);
            if (wordSound == null)
            {
                return HttpNotFound();
            }
            ViewBag.WordId = new SelectList(db.Words, "Id", "Text", wordSound.WordId);
            return View(wordSound);
        }

        // POST: WordSounds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IsReadOnly,IsBlocked,WordId,SoundUrl")] WordSound wordSound)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wordSound).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.WordId = new SelectList(db.Words, "Id", "Text", wordSound.WordId);
            return View(wordSound);
        }

        // GET: WordSounds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WordSound wordSound = db.WordSounds.Find(id);
            if (wordSound == null)
            {
                return HttpNotFound();
            }
            return View(wordSound);
        }

        // POST: WordSounds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WordSound wordSound = db.WordSounds.Find(id);
            db.WordSounds.Remove(wordSound);
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
