using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NineBarc.Core.Models;

namespace NineBarc.Core.Controllers
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

        public ActionResult SecureSharing()
        {
            ViewBag.Message = "Secure Sharing";

            return View();
        }
        public ActionResult LegalResources()
        {
            ViewBag.Message = "Legal Resources";

            return View();
        }
    }
}
