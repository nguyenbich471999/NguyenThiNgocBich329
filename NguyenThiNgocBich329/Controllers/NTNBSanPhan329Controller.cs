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
    public class NTNBSanPhan329Controller : Controller
    {
        private LTQLDBContext db = new LTQLDBContext();

        // GET: NTNBSanPhan329
        public ActionResult Index()
        {
            var nTNBSanPhan329s = db.NTNBSanPhan329s.Include(n => n.nhaCungCap329);
            return View(nTNBSanPhan329s.ToList());
        }

        // GET: NTNBSanPhan329/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NTNBSanPhan329 nTNBSanPhan329 = db.NTNBSanPhan329s.Find(id);
            if (nTNBSanPhan329 == null)
            {
                return HttpNotFound();
            }
            return View(nTNBSanPhan329);
        }

        // GET: NTNBSanPhan329/Create
        public ActionResult Create()
        {
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap329s, "MaNhaCungCap", "TenNhaCungCap");
            return View();
        }

        // POST: NTNBSanPhan329/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSanPham,TenSanPham,MaNhaCungCap")] NTNBSanPhan329 nTNBSanPhan329)
        {
            if (ModelState.IsValid)
            {
                db.NTNBSanPhan329s.Add(nTNBSanPhan329);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap329s, "MaNhaCungCap", "TenNhaCungCap", nTNBSanPhan329.MaNhaCungCap);
            return View(nTNBSanPhan329);
        }

        // GET: NTNBSanPhan329/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NTNBSanPhan329 nTNBSanPhan329 = db.NTNBSanPhan329s.Find(id);
            if (nTNBSanPhan329 == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap329s, "MaNhaCungCap", "TenNhaCungCap", nTNBSanPhan329.MaNhaCungCap);
            return View(nTNBSanPhan329);
        }

        // POST: NTNBSanPhan329/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSanPham,TenSanPham,MaNhaCungCap")] NTNBSanPhan329 nTNBSanPhan329)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nTNBSanPhan329).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCap329s, "MaNhaCungCap", "TenNhaCungCap", nTNBSanPhan329.MaNhaCungCap);
            return View(nTNBSanPhan329);
        }

        // GET: NTNBSanPhan329/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NTNBSanPhan329 nTNBSanPhan329 = db.NTNBSanPhan329s.Find(id);
            if (nTNBSanPhan329 == null)
            {
                return HttpNotFound();
            }
            return View(nTNBSanPhan329);
        }

        // POST: NTNBSanPhan329/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NTNBSanPhan329 nTNBSanPhan329 = db.NTNBSanPhan329s.Find(id);
            db.NTNBSanPhan329s.Remove(nTNBSanPhan329);
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
