using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication8.Models;
using SchoolDomains;

namespace MvcApplication8.Controllers
{
    public class AdminController : Controller
    {
        private MvcApplication8Context db = new MvcApplication8Context();

        //
        // GET: /Admin/AddStudyType

        public ActionResult AddStudyType()
        {
            return View();
        }

        //
        // POST: /Admin/AddStudyType

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddStudyType(StudyType studytype)
        {
            if (ModelState.IsValid)
            {
                db.StudyTypes.Add(studytype);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View("Index", "Home");
        }
    }
}
