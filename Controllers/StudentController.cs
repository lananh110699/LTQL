using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LTQL.Models;

namespace LTQL.Controllers
{
    public class StudentController : Controller
    {
        LTQLDBContext db = new LTQLDBContext();
        // GET: Student
        public ActionResult Index()
        {
            var model = db.Students.ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student std)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(std);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}