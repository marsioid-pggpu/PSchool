using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolPortal.Models;

namespace SchoolPortal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                if (HttpContext.User.IsInRole("admins"))
                { return View("AdminIndex"); }
                else
                { return View("UserIndex"); }
            }
            else
            { return View("Index"); }
        }

        //public ActionResult AdminIndex()
        //{
        //    if (HttpContext.User.IsInRole("admins"))
        //        { return View(); }
        //}
        
        //public ActionResult UserIndex()
        //{
        //    if (HttpContext.User.Identity.IsAuthenticated)
        //        { return View(); }
        //}

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        //public ActionResult Query()
        //{
        //using(SchoolContext db = new SchoolContext()){
        //    ViewBag.fName = db.Children.Find(1).FirstName;
        //    ViewBag.lName = db.Children.Find(1).LastName;
        //    ViewBag.sName = db.Children.Find(1).PatranomicName;
        //}
        //    return View();
        //}
    }
}
