using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class ARController : Controller
    {
        // GET: AR
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewTest2()
        {
            return View("Index");
        }

        public ActionResult ViewTest3()
        {
            return View("TEMP");
        }

        public ActionResult ViewTest4()
        {
            return PartialView("Index");
        }

        public ActionResult ContentTest()
        {
            return Content("<root>123</root>", "text/xml", Encoding.GetEncoding("big5"));
        }

        public ActionResult FileTest(bool download = false)
        {
            if (download)
            {
                return View("FileTest");
                //return File(Server.MapPath("~/Content/800px-耿鬼_SS002.png"), "image/png", "Gengar.png");
            }
            else
            {
                return File(Server.MapPath("~/Content/800px-耿鬼_SS002.png"), "image/png");
            }
        }
    }
}