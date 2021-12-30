using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ReportsController : BaseController
    {
        ContosoUniversityEntities1 db = new ContosoUniversityEntities1();
        StringBuilder builder = new StringBuilder();


        public ReportsController()
        {
            Debug.WriteLine("Entry Constructor");
            db.Database.Log = (msg) =>
              {
                  builder.AppendLine("====================");
                  builder.AppendLine(msg);

              };

            Debug.WriteLine("Exit Constrictor");
        }




        // GET: Reports
        public ActionResult Index()
        {
            return View(db.BoughtFlower.ToList());
        }

        public ActionResult BuyReports()
        {
            var data = (from p in db.BoughtFlower
                        group p by p.BuyID into BoughtFlowerGroup
                        select new BoughtReportVM()
                        {
                            BuyID = BoughtFlowerGroup.Key,
                            FlowerCount = BoughtFlowerGroup.Sum(x => x.Number),
                            TotalCost = BoughtFlowerGroup.Sum(x => x.Price),
                            AvgCost = BoughtFlowerGroup.Average(x => x.Price)
                        }).ToList();

            ViewBag.SQL = builder.ToString();

            return View(data);
        }

        public ActionResult BuyReports02()
        {
            var data = db.Database.SqlQuery<BoughtReportVM>(
             @"select bf.BuyID,
                SUM(bf.Number) as FlowerCount,
                SUM(bf.Price) as TotalCost,
                AVG(CAST(bf.Price as Float)) as AvgCost
               from BoughtFlower bf
                group by bf.BuyID"
           ).ToList();

            ViewBag.SQL = builder.ToString();

            return View("BuyReports02", data);
        }

        public ActionResult BuyReports03(int id)
        {
            var data = db.Database.SqlQuery<BoughtReportVM>(
                @"select bf.BuyID,
                    SUM(bf.Number) as FlowerCount,
                    SUM(bf.Price) as TotalCost,
                    AVG(CAST(bf.Price as Float)) as AvgCost
                  from BoughtFlower bf
                  where bf.BuyID = @p0
                  group by bf.BuyID", id
               ).ToList();

            ViewBag.SQL = builder.ToString();

            return View("BuyReports03", data);
        }

        public ActionResult BuyReports04(int id)
        {
            var data = db.GetBuyReport(id);

            ViewBag.SQL = builder.ToString();

            return View("BuyReports04", data);
        }

        public ActionResult BuyReports05(int id)
        {
            var data = db.Database.SqlQuery<GetBuyReport_Result>("EXEC GetBuyReport @p0", id).ToList();

            ViewBag.SQL = builder.ToString();

            return View("BuyReports05", data);
        }

    }
}