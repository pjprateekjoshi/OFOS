using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OFOS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var a = 2;
            var b = 3;
            var c = 4;
            var z = 100;
            return View();
        }
    }
}
