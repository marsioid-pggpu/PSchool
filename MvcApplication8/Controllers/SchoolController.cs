﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication8.Models;
using SchoolDomains;

namespace MvcApplication8.Controllers
{
    public class SchoolController : Controller
    {
        private MvcApplication8Context db = new MvcApplication8Context();

        //
        // GET: /School/

        public ActionResult Index()
        {
            return View(db.Schools.ToList());
        }

        //
        // GET: /School/Details/5

        public ActionResult Details(int id = 0)
        {
            School school = db.Schools.Find(id);
            if (school == null)
            {
                return HttpNotFound();
            }
            return View(school);
        }

        //
        // GET: /School/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /School/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(School school)
        {
            if (ModelState.IsValid)
            {
                db.Schools.Add(school);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(school);
        }





        //
        // GET: /School/AddChild

        public ActionResult AddChild()
        {
            return View();
        }

        //
        // POST: /School/AddChild

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddChild(Child child)
        {
            if (ModelState.IsValid)
            {
                db.Children.Add(child);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(child);
        }






        //
        // GET: /School/SearchEditChild

        public ActionResult SearchEditChild()
        {
            return View();
        }

        //
        // POST: /School/SearchEditChild

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SearchEditChild(Child child)
        {
            if (ModelState.IsValid)
            {
                //db.Children.Add(child);
                //db.SaveChanges();
                //return RedirectToAction("Index");

            }

            return View(child);
        }















        //
        // GET: /School/Edit/5

        public ActionResult Edit(int id = 0)
        {
            School school = db.Schools.Find(id);
            if (school == null)
            {
                return HttpNotFound();
            }
            return View(school);
        }

        //
        // POST: /School/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(School school)
        {
            if (ModelState.IsValid)
            {
                db.Entry(school).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(school);
        }

        //
        // GET: /School/Delete/5

        public ActionResult Delete(int id = 0)
        {
            School school = db.Schools.Find(id);
            if (school == null)
            {
                return HttpNotFound();
            }
            return View(school);
        }

        //
        // POST: /School/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            School school = db.Schools.Find(id);
            db.Schools.Remove(school);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}