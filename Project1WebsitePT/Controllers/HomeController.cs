﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1WebsitePT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us to schedule an appointment!";

            return View();
        }
        public ActionResult Exercise()
        {
            ViewBag.Message = "no view but will have one";

            return View();
        }
    }
}