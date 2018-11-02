using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using majig.service;

namespace majig.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDooIt DooIt;

        public HomeController(IDooIt DooIt) {
            this.DooIt = DooIt;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page. " + this.DooIt.getIt(34).ToString();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}