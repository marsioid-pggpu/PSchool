using System;
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
    public class ChildController : Controller
    {
        private MvcApplication8Context db = new MvcApplication8Context();

        //
        // GET: /Child/Add

        //[Authorize (Roles="admins,users")]
        public ActionResult Add()
        {


            SelectList nationalities = new SelectList(db.Nationalities, "Id", "Name");
            ViewBag.Nationalities = nationalities;
            
            
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


            return View(child);
        }

        //
        // GET: /Child/SearchChild

        public ActionResult SearchChild()
        {
            return View();
        }

        //
        // POST: /Child/SearchChild

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SearchChild(Child child)
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

        //
        // GET: /Child/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Child/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Child child)
        {
            if (ModelState.IsValid)
            {
                db.Children.Add(child);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(child);
        }

        //
        // GET: /Child/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Child child = db.Children.Find(id);
            if (child == null)
            {
                return HttpNotFound();
            }
            return View(child);
        }

        //
        // POST: /Child/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Child child)
        {
            if (ModelState.IsValid)
            {
                db.Entry(child).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(child);
        }

        //
        // GET: /Child/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Child child = db.Children.Find(id);
            if (child == null)
            {
                return HttpNotFound();
            }
            return View(child);
        }

        //
        // POST: /Child/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Child child = db.Children.Find(id);
            db.Children.Remove(child);
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