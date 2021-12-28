﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessageResourceName = "Person_Name_Required", ErrorMessageResourceType = typeof(Resource1))]
        [DisplayName("姓名")]
        public string Name { get; set; }
        [Required]
        [Range(0, 200)]
        [DisplayName("年齡")]
        public int Age { get; set; }
    }
}