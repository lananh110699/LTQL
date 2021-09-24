using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LTQL.Models;


namespace LTQL.Controllers
{
    
    public class StdNewController : Controller
    {
        LTQLDBContext db = new LTQLDBContext();
        StringProcess genKey = new StringProcess();
        // GET: StdNew
        public ActionResult Index()
        {

            return View(db.Students.ToList());
        }

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create (Student std)
        {
            var countStudent = db.Students.Count();
            if (countStudent==0)

            return RedirectToAction("Index");
        }
    }
}