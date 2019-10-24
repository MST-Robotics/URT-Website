using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace URT_Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult History()
        {
            ViewBag.Message = "History page.";
            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Message = "Blog page.";
            return View();
        }

        public ActionResult Sponsors()
        {
            ViewBag.Message = "Sponsors page.";
            return View();
        }

        public ActionResult Resources()
        {
            ViewBag.Message = "Resources page.";
            return View();
        }
    }
}
