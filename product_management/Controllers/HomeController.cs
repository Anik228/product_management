﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace product_management.Controllers
{
    public class HomeController : Controller
    {
        /*public ActionResult Index()
        {
            return View();
        }*/

        public ActionResult Index()
        {
            //return RedirectToAction("Index", "Products");  
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