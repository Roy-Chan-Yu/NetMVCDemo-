using Omu.ValueInjecter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ConsigneeController : BaseController
    {
        ContosoUniversityEntities2 db = new ContosoUniversityEntities2();



        // GET: Consignee
        public ActionResult Index()
        {
            return View(db.consignee_manageme.ToList());
        }

        public ActionResult Create()
        {
            ViewBag.user_info_user_id = new SelectList(db.user_info, "user_id", "user_name");

            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, consignee_name, consignee_address, consignee_code,consignee_phone,user_info_user_id,Memo")]consignee_manageme cons)
        {
            if (ModelState.IsValid)
            {
                db.consignee_manageme.Add(cons);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.user_info_user_id = new SelectList(db.user_info, "user_id", "user_name");
            return View(cons);
        }

        public ActionResult Edit(int? id)
        {
            if (!id.HasValue)
            {
                return HttpNotFound();
            }

            var item = db.consignee_manageme.Find(id);

            ViewBag.user_info_user_id = new SelectList(db.user_info, "user_id", "user_name", item.user_info_user_id);

            return View(item);
        }

        [HttpPost]
        public ActionResult Edit(int id, consignee_manageme_edit cons)
        {
            if (ModelState.IsValid)
            {
                var item = db.consignee_manageme.Find(id);

                item.InjectFrom(cons);
                //item.consignee_name = cons.consignee_name;
                //item.consignee_address = cons.consignee_address;
                //item.consignee_code = cons.consignee_code;
                //item.cinsignee_phone = cons.cinsignee_phone;
                //item.user_info_user_id = cons.user_info_user_id;

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(db.consignee_manageme.Find(id));
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            consignee_manageme cons = db.consignee_manageme.Find(id);
            if (cons == null)
            {
                return HttpNotFound();
            }

            return View(cons);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var item = db.consignee_manageme.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }

            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(int id)
        {

            consignee_manageme payload = db.consignee_manageme.Find(id);
            db.consignee_manageme.Remove(payload);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}