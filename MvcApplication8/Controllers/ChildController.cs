using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolPortal.Models;
using SchoolDomains;

namespace SchoolPortal.Controllers
{
    public class ChildController : Controller
    {
        private SchoolContext db = new SchoolContext();

        //
        // GET: /Child/Add

        //[Authorize (Roles="admins,users")]
        public ActionResult Add()
        {


            SelectList nationalities = new SelectList(db.Nationalities, "Id", "Name");
            ViewBag.Nationalities = nationalities;
            SelectList var_class = new SelectList(db.Classes, "Id", "Parallel");
            ViewBag.Classes = var_class;
            SelectList studyform = new SelectList(db.StudyForms, "Id", "Name");
            ViewBag.StudyFroms = studyform;
            SelectList studytype = new SelectList(db.StudyTypes, "Id", "Name");
            ViewBag.StudyTypes = studytype;
            

            //var nationalities = db.Nationalities.ToList();
            //ViewBag.Nationalities = nationalities.Select(x => new SelectListItem
            //{
            //    Value = x.Id.ToString(),
            //    Text = x.Name
            //});
            
            
            return View();
        }

        //
        // POST: /Child/Add

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Child child)
        {
            if (ModelState.IsValid)
            {
                db.Children.Add(child);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            SelectList nationalities = new SelectList(db.Nationalities, "Id", "Name");
            ViewBag.Nationalities = nationalities;
            SelectList var_class = new SelectList(db.Classes, "Id", "Parallel");
            ViewBag.Classes = var_class;
            SelectList studyform = new SelectList(db.StudyForms, "Id", "Name");
            ViewBag.StudyFroms = studyform;
            SelectList studytype = new SelectList(db.StudyTypes, "Id", "Name");
            ViewBag.StudyTypes = studytype;
            

            //var nationalities = db.Nationalities.ToList();
            //ViewBag.Nationalities = nationalities.Select(x => new SelectListItem
            //{
            //    Value = x.Id.ToString(),
            //    Text = x.Name
            //});

            return View(child);
        }

        //
        // GET: /Child/Search

        //[Authorize (Roles="admins,users")]
        public ActionResult Search()
        {
            return View();
        }

        //
        // POST: /Child/Search

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Search(Child child)
        {
            if (ModelState.IsValid)
            {

            
                


                return RedirectToAction("Edit", "Child");
            }            

            return View();
        }










        //
        // GET: /Child/

        public ActionResult Index()
        {
            return View(db.Children.ToList());
        }

        //
        // GET: /Child/Details/5

        public ActionResult Details(int id = 0)
        {
            Child child = db.Children.Find(id);
            if (child == null)
            {
                return HttpNotFound();
            }
            return View(child);
        }

        ////
        //// GET: /Child/Create

        //public ActionResult Create()
        //{
        //    return View();
        //}

        ////
        //// POST: /Child/Create

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(Child child)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Children.Add(child);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(child);
        //}

        ////
        //// GET: /Child/Edit/5

        //public ActionResult Edit(int id = 0)
        //{
        //    Child child = db.Children.Find(id);
        //    if (child == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(child);
        //}

        ////
        //// POST: /Child/Edit/5

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(Child child)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(child).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(child);
        //}

        ////
        //// GET: /Child/Delete/5

        //public ActionResult Delete(int id = 0)
        //{
        //    Child child = db.Children.Find(id);
        //    if (child == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(child);
        //}

        ////
        //// POST: /Child/Delete/5

        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Child child = db.Children.Find(id);
        //    db.Children.Remove(child);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    db.Dispose();
        //    base.Dispose(disposing);
        //}
    }
}