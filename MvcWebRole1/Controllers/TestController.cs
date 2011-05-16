using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebRole1.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome()
        {
            ViewData.Model = "Welcome welcome";
            return View();
        }

        public ActionResult NewIntro()
        {
            ViewData["Message"] = "Welcome Gurmeet Kaur Saluja ";
            return View();
        }

    }
}
