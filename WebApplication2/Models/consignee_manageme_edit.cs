using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class consignee_manageme_edit
    {

        //public string consignee_name { get; set; }                        
        public string consignee_address { get; set; }
        public string consignee_code { get; set; }
        public virtual user_info user_info { get; set; }

        public string Memo { get; set; }
    }
}