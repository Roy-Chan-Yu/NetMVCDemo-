using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class BoughtReportVM
    {
        public int BuyID { get; set; }
        public int FlowerCount { get; set; }
        public int? TotalCost { get; set; }
        public double? AvgCost { get; set; }

    }
}