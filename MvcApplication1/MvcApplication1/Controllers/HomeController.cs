﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var nevar = 0;
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            ViewBag.Test = 6700;


            // New Line
            // Comment for Mr. Madhab
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






        public ActionResult NEwMethodActionResult()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }







    }
}
