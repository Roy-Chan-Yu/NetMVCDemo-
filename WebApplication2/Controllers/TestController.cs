using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            var data = new List<Person>()
            {
                new Person() { Id = 1, Name = "Will ", Age = 18},
                new Person() { Id = 2, Name = "Will2 ", Age = 28},
                new Person() { Id = 3, Name = "Will3 ", Age = 38},
                new Person() { Id = 4, Name = "Will4 ", Age = 48},
            };

            return View(data);
        }
    }
}