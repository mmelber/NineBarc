using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NineBarc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            ViewBag.Message = "Dashboard";

            return View();
        }

        public ActionResult MyVault()
        {
            ViewBag.Message = "My vault";

            return View();
        }
        public ActionResult MyReceivers()
        {
            ViewBag.Message = "My Receivers";

            return View();
        }
    }
}