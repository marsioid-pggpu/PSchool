using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolPortal.Models;
using SchoolDomains;
using System.Data;
using System.Data.Entity;

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
            return RedirectToAction("AdminIndex", "Home");
        }


        ///////////////////////////////////////////////////////////////////////////////////SchoolTypeBegin
        //
        // GET: /Admin/ViewSchoolType

        [Authorize(Roles = "admins")]
        public ActionResult ViewSchoolType()
        {
            return View(db.SchoolTypes.ToList());
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
                return RedirectToAction("ViewSchoolType");
            }

            return View(schooltype);
        }


        //
        // GET: /Admin/EditSchoolType

        [Authorize(Roles = "admins")]
        public ActionResult EditSchoolType(int id = 0)
        {
            SchoolType schooltype = db.SchoolTypes.Find(id);
            if (schooltype == null)
            {
                return HttpNotFound();
            }
            return View(schooltype);
        }

        //
        // POST: /Admin/EditSchoolType

        [HttpPost]
        [Authorize(Roles = "admins")]
        [ValidateAntiForgeryToken]
        public ActionResult EditSchoolType(SchoolType schooltype)
        {
            if (ModelState.IsValid)
            {
                db.Entry(schooltype).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ViewSchoolType");
            }
            return View(schooltype);
        }

        //
        // GET: /Admin/DeleteSchoolType

        [Authorize(Roles = "admins")]
        public ActionResult DeleteSchoolType(int id = 0)
        {
            SchoolType schooltype = db.SchoolTypes.Find(id);
            if (schooltype == null)
            {
                return HttpNotFound();
            }
            return View(schooltype);
        }

        //
        // POST: /Admin/DeleteSchoolType

        [HttpPost, ActionName("DeleteSchoolType")]
        [Authorize(Roles = "admins")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmedSchoolType(int id)
        {
            SchoolType schooltype = db.SchoolTypes.Find(id);
            db.SchoolTypes.Remove(schooltype);
            db.SaveChanges();
            return RedirectToAction("ViewSchoolType");
        }
        ///////////////////////////////////////////////////////////////////////////////////SchoolTypeEnd


        ///////////////////////////////////////////////////////////////////////////////////ClassTypeBegin
        //
        // GET: /Admin/ViewClassType

        [Authorize(Roles = "admins")]
        public ActionResult ViewClassType()
        {
            return View(db.ClassTypes.ToList());
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
                return RedirectToAction("ViewClassType");
            }

            return View(classtype);
        }


        //
        // GET: /Admin/EditClassType

        [Authorize(Roles = "admins")]
        public ActionResult EditClassType(int id = 0)
        {
            ClassType classtype = db.ClassTypes.Find(id);
            if (classtype == null)
            {
                return HttpNotFound();
            }
            return View(classtype);
        }

        //
        // POST: /Admin/EditClassType

        [HttpPost]
        [Authorize(Roles = "admins")]
        [ValidateAntiForgeryToken]
        public ActionResult EditClassType(ClassType classtype)
        {
            if (ModelState.IsValid)
            {
                db.Entry(classtype).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ViewClassType");
            }
            return View(classtype);
        }

        //
        // GET: /Admin/DeleteClassType

        [Authorize(Roles = "admins")]
        public ActionResult DeleteClassType(int id = 0)
        {
            ClassType classtype = db.ClassTypes.Find(id);
            if (classtype == null)
            {
                return HttpNotFound();
            }
            return View(classtype);
        }

        //
        // POST: /Admin/DeleteClassType

        [HttpPost, ActionName("DeleteClassType")]
        [Authorize(Roles = "admins")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmedClassType(int id)
        {
            ClassType classtype = db.ClassTypes.Find(id);
            db.ClassTypes.Remove(classtype);
            db.SaveChanges();
            return RedirectToAction("ViewClassType");
        }
        ///////////////////////////////////////////////////////////////////////////////////ClassTypeEnd


        ///////////////////////////////////////////////////////////////////////////////////StudyFormBegin
        //
        // GET: /Admin/ViewStudyForm

        [Authorize(Roles = "admins")]
        public ActionResult ViewStudyForm()
        {
            return View(db.StudyForms.ToList());
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
                return RedirectToAction("ViewStudyForm");
            }

            return View(studyform);
        }


        //
        // GET: /Admin/EditStudyForm

        [Authorize(Roles = "admins")]
        public ActionResult EditStudyForm(int id = 0)
        {
            StudyForm studyform = db.StudyForms.Find(id);
            if (studyform == null)
            {
                return HttpNotFound();
            }
            return View(studyform);
        }

        //
        // POST: /Admin/EditStudyForm

        [HttpPost]
        [Authorize(Roles = "admins")]
        [ValidateAntiForgeryToken]
        public ActionResult EditStudyForm(StudyForm studyform)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studyform).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ViewStudyForm");
            }
            return View(studyform);
        }

        //
        // GET: /Admin/DeleteStudyForm

        [Authorize(Roles = "admins")]
        public ActionResult DeleteStudyForm(int id = 0)
        {
            StudyForm studyform = db.StudyForms.Find(id);
            if (studyform == null)
            {
                return HttpNotFound();
            }
            return View(studyform);
        }

        //
        // POST: /Admin/DeleteStudyForm

        [HttpPost, ActionName("DeleteStudyForm")]
        [Authorize(Roles = "admins")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmedStudyForm(int id)
        {
            StudyForm studyform = db.StudyForms.Find(id);
            db.StudyForms.Remove(studyform);
            db.SaveChanges();
            return RedirectToAction("ViewStudyForm");
        }
        ///////////////////////////////////////////////////////////////////////////////////StudyFormEnd


        ///////////////////////////////////////////////////////////////////////////////////StudyTypeBegin
        //
        // GET: /Admin/ViewStudyType

        [Authorize(Roles = "admins")]
        public ActionResult ViewStudyType()
        {
            return View(db.StudyTypes.ToList());
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
                return RedirectToAction("ViewStudyType");
            }

            return View(studytype);
        }


        //
        // GET: /Admin/EditStudyType

        [Authorize(Roles = "admins")]
        public ActionResult EditStudyType(int id = 0)
        {
            StudyType studytype = db.StudyTypes.Find(id);
            if (studytype == null)
            {
                return HttpNotFound();
            }
            return View(studytype);
        }

        //
        // POST: /Admin/EditStudyType

        [HttpPost]
        [Authorize(Roles = "admins")]
        [ValidateAntiForgeryToken]
        public ActionResult EditStudyType(StudyType studytype)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studytype).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ViewStudyType");
            }
            return View(studytype);
        }

        //
        // GET: /Admin/DeleteStudyType

        [Authorize(Roles = "admins")]
        public ActionResult DeleteStudyType(int id = 0)
        {
            StudyType studytype = db.StudyTypes.Find(id);
            if (studytype == null)
            {
                return HttpNotFound();
            }
            return View(studytype);
        }

        //
        // POST: /Admin/DeleteStudyType

        [HttpPost, ActionName("DeleteStudyType")]
        [Authorize(Roles = "admins")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmedStudyType(int id)
        {
            StudyType studytype = db.StudyTypes.Find(id);
            db.StudyTypes.Remove(studytype);
            db.SaveChanges();
            return RedirectToAction("ViewStudyType");
        }
        ///////////////////////////////////////////////////////////////////////////////////StudyTypeEnd


        ///////////////////////////////////////////////////////////////////////////////////NationalityBegin
        //
        // GET: /Admin/ViewNationality

        [Authorize(Roles = "admins")]
        public ActionResult ViewNationality()
        {
            return View(db.Nationalities.ToList());
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
                return RedirectToAction("ViewNationality");
            }

            return View(nationality);
        }


        //
        // GET: /Admin/EditNationality

        [Authorize(Roles = "admins")]
        public ActionResult EditNationality(int id = 0)
        {
            Nationality nationality = db.Nationalities.Find(id);
            if (nationality == null)
            {
                return HttpNotFound();
            }
            return View(nationality);
        }

        //
        // POST: /Admin/EditNationality

        [HttpPost]
        [Authorize(Roles = "admins")]
        [ValidateAntiForgeryToken]
        public ActionResult EditNationality(Nationality nationality)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nationality).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ViewNationality");
            }
            return View(nationality);
        }

        //
        // GET: /Admin/DeleteNationality

        [Authorize(Roles = "admins")]
        public ActionResult DeleteNationality(int id = 0)
        {
            Nationality nationality = db.Nationalities.Find(id);
            if (nationality == null)
            {
                return HttpNotFound();
            }
            return View(nationality);
        }

        //
        // POST: /Admin/DeleteNationality

        [HttpPost, ActionName("DeleteNationality")]
        [Authorize(Roles = "admins")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmedNationality(int id)
        {
            Nationality nationality = db.Nationalities.Find(id);
            db.Nationalities.Remove(nationality);
            db.SaveChanges();
            return RedirectToAction("ViewNationality");
        }
        ///////////////////////////////////////////////////////////////////////////////////NationalityEnd


        ///////////////////////////////////////////////////////////////////////////////////LocalityBegin
        //
        // GET: /Admin/ViewLocality

        [Authorize(Roles = "admins")]
        public ActionResult ViewLocality()
        {
            return View(db.Localities.ToList());
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
                return RedirectToAction("ViewLocality");
            }

            return View(locality);
        }


        //
        // GET: /Admin/EditLocality

        [Authorize(Roles = "admins")]
        public ActionResult EditLocality(int id = 0)
        {
            Locality locality = db.Localities.Find(id);
            if (locality == null)
            {
                return HttpNotFound();
            }
            return View(locality);
        }

        //
        // POST: /Admin/EditLocality

        [HttpPost]
        [Authorize(Roles = "admins")]
        [ValidateAntiForgeryToken]
        public ActionResult EditLocality(Locality locality)
        {
            if (ModelState.IsValid)
            {
                db.Entry(locality).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ViewLocality");
            }
            return View(locality);
        }

        //
        // GET: /Admin/DeleteLocality

        [Authorize(Roles = "admins")]
        public ActionResult DeleteLocality(int id = 0)
        {
            Locality locality = db.Localities.Find(id);
            if (locality == null)
            {
                return HttpNotFound();
            }
            return View(locality);
        }

        //
        // POST: /Admin/DeleteLocality

        [HttpPost, ActionName("DeleteLocality")]
        [Authorize(Roles = "admins")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmedLocality(int id)
        {
            Locality locality = db.Localities.Find(id);
            db.Localities.Remove(locality);
            db.SaveChanges();
            return RedirectToAction("ViewLocality");
        }
        ///////////////////////////////////////////////////////////////////////////////////LocalityEnd


        ///////////////////////////////////////////////////////////////////////////////////SchoolBegin
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
        public ActionResult AddSchool(SchoolView model)
        {
            if (ModelState.IsValid)
            {
                School school = new School();
                school.Name = model.Name;
                school.Index = model.Index;
                school.Street = model.Street;
                school.House = model.House;
                school.House2 = model.House2;
                school.Phone = model.Phone;
                school.Boss = model.Boss;
                
                //school = model.Locality_id;
                //school. = model.SchoolType_id;
                //school. = model.User_id;
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

            return View(model);
        }
        ///////////////////////////////////////////////////////////////////////////////////SchoolEnd


        ///////////////////////////////////////////////////////////////////////////////////UserBegin
        //
        // GET: /Admin/ViewUser

        [Authorize(Roles = "admins")]
        public ActionResult ViewUser()
        {
            return View(db.Users.ToList());
        }
        ///////////////////////////////////////////////////////////////////////////////////UserEnd


















































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
