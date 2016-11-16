using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolPortal.Models;
using SchoolDomains;

namespace SchoolPortal.Controllers
{

    public class AdminController : Controller
    {
        private SchoolContext db = new SchoolContext();


        //
        // GET: /Admin/Index

        [Authorize(Roles = "admins")]
        public ActionResult Index()
        {
            return View();
        }
        

        //
        // GET: /Admin/AddStudyType

        [Authorize(Roles = "admins")]
        public ActionResult AddStudyType()
        {
            return View();
        }

        //
        // POST: /Admin/AddStudyType

        [HttpPost]
        [Authorize(Roles = "admins")]
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


        //
        // GET: /Admin/AddStudyForm

        [Authorize(Roles = "admins")]
        public ActionResult AddStudyForm()
        {
            return View();
        }

        //
        // POST: /Admin/AddStudyForm

        [HttpPost]
        [Authorize(Roles = "admins")]
        [ValidateAntiForgeryToken]
        public ActionResult AddStudyForm(StudyForm studyform)
        {
            if (ModelState.IsValid)
            {
                db.StudyForms.Add(studyform);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View("Index", "Home");
        }


        //
        // GET: /Admin/AddSchoolType

        [Authorize(Roles = "admins")]
        public ActionResult AddSchoolType()
        {
            return View();
        }

        //
        // POST: /Admin/AddSchoolType

        [HttpPost]
        [Authorize(Roles = "admins")]
        [ValidateAntiForgeryToken]
        public ActionResult AddSchoolType(SchoolType schooltype)
        {
            if (ModelState.IsValid)
            {
                db.SchoolTypes.Add(schooltype);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View("Index", "Home");
        }


        //
        // GET: /Admin/AddClassType

        [Authorize(Roles = "admins")]
        public ActionResult AddClassType()
        {
            return View();
        }

        //
        // POST: /Admin/AddClassType

        [HttpPost]
        [Authorize(Roles = "admins")]
        [ValidateAntiForgeryToken]
        public ActionResult AddClassType(ClassType classtype)
        {
            if (ModelState.IsValid)
            {
                db.ClassTypes.Add(classtype);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View("Index", "Home");
        }


        //
        // GET: /Admin/AddNationality

        [Authorize(Roles = "admins")]
        public ActionResult AddNationality()
        {
            return View();
        }

        //
        // POST: /Admin/AddNationality

        [HttpPost]
        [Authorize(Roles = "admins")]
        [ValidateAntiForgeryToken]
        public ActionResult AddNationality(Nationality nationality)
        {
            if (ModelState.IsValid)
            {
                db.Nationalities.Add(nationality);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View("Index", "Home");
        }


        //
        // GET: /Admin/AddLocality

        [Authorize(Roles = "admins")]
        public ActionResult AddLocality()
        {
            return View();
        }

        //
        // POST: /Admin/AddLocality

        [HttpPost]
        [Authorize(Roles = "admins")]
        [ValidateAntiForgeryToken]
        public ActionResult AddLocality(Locality locality)
        {
            if (ModelState.IsValid)
            {
                db.Localities.Add(locality);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View("Index", "Home");
        }


        ////
        //// GET: /Admin/AddSchool

        //public ActionResult AddSchool()
        //{
        //    SelectList locality = new SelectList(db.Localities, "Id", "Name");
        //    ViewBag.Locality = locality;
        //    SelectList schooltype = new SelectList(db.SchoolTypes, "Id", "Name");
        //    ViewBag.SchoolType = schooltype;
        //    SelectList user = new SelectList(db.Users, "Id", "Name");
        //    ViewBag.User = user;
            
        //    return View();
        //}

        ////
        //// POST: /Admin/AddSchool

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult AddSchool(SchoolView school)
        //{
        //    if (ModelState.IsValid)
        //    {
                
        //        //db.Schools.Add(school);
        //        //db.SaveChanges();
        //        return RedirectToAction("Index", "Home");
        //    }

        //    SelectList locality = new SelectList(db.Localities, "Id", "Name");
        //    ViewBag.Locality = locality;
        //    SelectList schooltype = new SelectList(db.SchoolTypes, "Id", "Name");
        //    ViewBag.SchoolType = schooltype;
        //    SelectList user = new SelectList(db.Users, "Id", "Name");
        //    ViewBag.User = user;

        //    return View(school);
        //}



        //
        // GET: /Admin/AddSchool

        public ActionResult AddSchool()
        {
            SelectList locality = new SelectList(db.Localities, "Id", "Name");
            ViewBag.Locality = locality;
            SelectList schooltype = new SelectList(db.SchoolTypes, "Id", "Name");
            ViewBag.SchoolType = schooltype;
            SelectList user = new SelectList(db.Users, "Id", "Name");
            ViewBag.User = user;

            return View();
        }

        //
        // POST: /Admin/AddSchool

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddSchool(School school)
        {
            if (ModelState.IsValid)
            {

                //db.Schools.Add(school);
                //db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            SelectList locality = new SelectList(db.Localities, "Id", "Name");
            ViewBag.Locality = locality;
            SelectList schooltype = new SelectList(db.SchoolTypes, "Id", "Name");
            ViewBag.SchoolType = schooltype;
            SelectList user = new SelectList(db.Users, "Id", "Name");
            ViewBag.User = user;

            return View(school);
        }










        ////
        //// GET: /Admin/FindSchool

        //public ActionResult FindSchool()
        //{
        //    return View();
        //}

        ////
        //// POST: /Admin/FindSchool

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult FindSchool(School school)
        //{
        //     if (ModelState.IsValid==false)
        //    {
        //        var schools = db.Schools.Where(s=> s.Name == "Школа 1");





        //        return RedirectToAction("Index", "Home");
        //    }


        //    return View(school);
        //}





    }
}
