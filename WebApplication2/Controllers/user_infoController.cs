using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class user_infoController : BaseController
    {
        private ContosoUniversityEntities2 db = new ContosoUniversityEntities2();

        // GET: user_info
        public ActionResult Index()
        {
            return View(db.user_info.ToList());
        }

        // GET: user_info/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user_info user_info = db.user_info.Find(id);
            if (user_info == null)
            {
                return HttpNotFound();
            }
            return View(user_info);
        }

        // GET: user_info/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: user_info/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "user_id,user_name,user_sex,user_phone,user_pw,user_state")] user_info user_info)
        {
            if (ModelState.IsValid)
            {
                db.user_info.Add(user_info);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user_info);
        }

        // GET: user_info/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user_info user_info = db.user_info.Find(id);
            if (user_info == null)
            {
                return HttpNotFound();
            }
            return View(user_info);
        }

        // POST: user_info/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "user_id,user_name,user_sex,user_phone,user_pw,user_state")] user_info user_info)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user_info).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user_info);
        }

        // GET: user_info/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user_info user_info = db.user_info.Find(id);
            if (user_info == null)
            {
                return HttpNotFound();
            }
            return View(user_info);
        }

        // POST: user_info/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            user_info user_info = db.user_info.Find(id);
            db.user_info.Remove(user_info);
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
