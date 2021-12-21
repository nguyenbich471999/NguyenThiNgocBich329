using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NguyenThiNgocBich329.Models;

namespace NguyenThiNgocBich329.Controllers
{
    public class NhaCungCap329Controller : Controller
    {
        private LTQLDBContext db = new LTQLDBContext();

        // GET: NhaCungCap329
        public ActionResult Index()
        {
            return View(db.NhaCungCap329s.ToList());
        }

        // GET: NhaCungCap329/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap329 nhaCungCap329 = db.NhaCungCap329s.Find(id);
            if (nhaCungCap329 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap329);
        }

        // GET: NhaCungCap329/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhaCungCap329/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNhaCungCap,TenNhaCungCap")] NhaCungCap329 nhaCungCap329)
        {
            if (ModelState.IsValid)
            {
                db.NhaCungCap329s.Add(nhaCungCap329);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhaCungCap329);
        }

        // GET: NhaCungCap329/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap329 nhaCungCap329 = db.NhaCungCap329s.Find(id);
            if (nhaCungCap329 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap329);
        }

        // POST: NhaCungCap329/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNhaCungCap,TenNhaCungCap")] NhaCungCap329 nhaCungCap329)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhaCungCap329).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhaCungCap329);
        }

        // GET: NhaCungCap329/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap329 nhaCungCap329 = db.NhaCungCap329s.Find(id);
            if (nhaCungCap329 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap329);
        }

        // POST: NhaCungCap329/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NhaCungCap329 nhaCungCap329 = db.NhaCungCap329s.Find(id);
            db.NhaCungCap329s.Remove(nhaCungCap329);
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
