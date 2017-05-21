using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using xtrade.Models;

namespace xtrade.Controllers
{
    public class BargainRecordsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BargainRecords
        public ActionResult Index()
        {
            var bargainRecords = db.BargainRecords.Include(b => b.Image).Include(b => b.Item);
            return View(bargainRecords.ToList());
        }

        // GET: BargainRecords/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BargainRecord bargainRecord = db.BargainRecords.Find(id);
            if (bargainRecord == null)
            {
                return HttpNotFound();
            }
            return View(bargainRecord);
        }

        // GET: BargainRecords/Create
        public ActionResult Create()
        {
            ViewBag.ImageId = new SelectList(db.Images, "ImageId", "ImageName");
            ViewBag.ItemId = new SelectList(db.Items, "Id", "Seller");
            return View();
        }

        // POST: BargainRecords/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BargainRecordId,PrivateIndicator,ParentBargainRecordId,RootBargainRecordIndicator,BargainerEmail,Amount,BargainMessage,ImageId,ItemId,AcceptanceIndicator")] BargainRecord bargainRecord)
        {
            if (ModelState.IsValid)
            {
                db.BargainRecords.Add(bargainRecord);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ImageId = new SelectList(db.Images, "ImageId", "ImageName", bargainRecord.ImageId);
            ViewBag.ItemId = new SelectList(db.Items, "Id", "Seller", bargainRecord.ItemId);
            return View(bargainRecord);
        }

        // GET: BargainRecords/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BargainRecord bargainRecord = db.BargainRecords.Find(id);
            if (bargainRecord == null)
            {
                return HttpNotFound();
            }
            ViewBag.ImageId = new SelectList(db.Images, "ImageId", "ImageName", bargainRecord.ImageId);
            ViewBag.ItemId = new SelectList(db.Items, "Id", "Seller", bargainRecord.ItemId);
            return View(bargainRecord);
        }

        // POST: BargainRecords/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BargainRecordId,PrivateIndicator,ParentBargainRecordId,RootBargainRecordIndicator,BargainerEmail,Amount,BargainMessage,ImageId,ItemId,AcceptanceIndicator")] BargainRecord bargainRecord)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bargainRecord).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ImageId = new SelectList(db.Images, "ImageId", "ImageName", bargainRecord.ImageId);
            ViewBag.ItemId = new SelectList(db.Items, "Id", "Seller", bargainRecord.ItemId);
            return View(bargainRecord);
        }

        // GET: BargainRecords/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BargainRecord bargainRecord = db.BargainRecords.Find(id);
            if (bargainRecord == null)
            {
                return HttpNotFound();
            }
            return View(bargainRecord);
        }

        // POST: BargainRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BargainRecord bargainRecord = db.BargainRecords.Find(id);
            db.BargainRecords.Remove(bargainRecord);
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
