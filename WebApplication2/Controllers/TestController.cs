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
        static List<Person> data = new List<Person>()
        {
                new Person() { Id = 1, Name = "Will ", Age = 18},
                new Person() { Id = 2, Name = "Will2 ", Age = 28},
                new Person() { Id = 3, Name = "Will3 ", Age = 38},
                new Person() { Id = 4, Name = "Will4 ", Age = 48},
        };

        public ActionResult Index()
        {

            return View(data);
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                // Todo
                data.Add(person);

                return RedirectToAction("Index");
            }

            return View(person);
        }

        public ActionResult Edit(int id)
        {
            return View(data.FirstOrDefault(p => p.Id == id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Person person)
        {
            if (ModelState.IsValid)
            {
                var payload = data.FirstOrDefault(p => p.Id == id);
                payload.Name = person.Name;
                payload.Age = person.Age;

                return RedirectToAction("Index");
            }

            return View(person);
        }


        public ActionResult Details(int id)
        {
            var payload = data.FirstOrDefault(p => p.Id == id);

            return View(payload);
        }

    }
}