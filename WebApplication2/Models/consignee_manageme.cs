//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class consignee_manageme
    {
        public int Id { get; set; }
        public string consignee_name { get; set; }
        public string consignee_address { get; set; }
        public string consignee_code { get; set; }
        public string cinsignee_phone { get; set; }
        [DataType(DataType.Date)]
        /*[DisplayFormat(DataFormatString = "{yyyy-MM-dd}", ApplyFormatInEditMode = true*/)]
        public int user_info_user_id { get; set; }

        public virtual user_info user_info { get; set; }
    }
}
