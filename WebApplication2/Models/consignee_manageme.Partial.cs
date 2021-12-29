using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    [MetadataType(typeof(consignee_managemeMetadata))]
    public partial class consignee_manageme
    {

        public class consignee_managemeMetadata
        {
            public int Id { get; set; }
            [Required]
            public string consignee_name { get; set; }
            public string consignee_address { get; set; }
            public string consignee_code { get; set; }
            public string cinsignee_phone { get; set; }
            public int user_info_user_id { get; set; }
            public string Memo { get; set; }

            public virtual user_info user_info { get; set; }

        }
    }
}