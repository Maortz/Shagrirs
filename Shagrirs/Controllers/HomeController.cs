using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BE;
using BLFrontend;

namespace Shagrirs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Frontend front = new Frontend();
            var sh = front.GetShagrirs();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}