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
    public class PermissionGroupsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PermissionGroups
        public ActionResult Index()
        {
            return View(db.PermissionGroups.ToList());
        }

        // GET: PermissionGroups/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PermissionGroup permissionGroup = db.PermissionGroups.Find(id);
            if (permissionGroup == null)
            {
                return HttpNotFound();
            }
            return View(permissionGroup);
        }

        // GET: PermissionGroups/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PermissionGroups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description")] PermissionGroup permissionGroup)
        {
            if (ModelState.IsValid)
            {
                db.PermissionGroups.Add(permissionGroup);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(permissionGroup);
        }

        // GET: PermissionGroups/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PermissionGroup permissionGroup = db.PermissionGroups.Find(id);
            if (permissionGroup == null)
            {
                return HttpNotFound();
            }
            return View(permissionGroup);
        }

        // POST: PermissionGroups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description")] PermissionGroup permissionGroup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(permissionGroup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(permissionGroup);
        }

        // GET: PermissionGroups/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PermissionGroup permissionGroup = db.PermissionGroups.Find(id);
            if (permissionGroup == null)
            {
                return HttpNotFound();
            }
            return View(permissionGroup);
        }

        // POST: PermissionGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PermissionGroup permissionGroup = db.PermissionGroups.Find(id);
            db.PermissionGroups.Remove(permissionGroup);
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
