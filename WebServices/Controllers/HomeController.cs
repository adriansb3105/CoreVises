﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebServices.Controllers
{
    
    public class HomeController : Controller
    {

       
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

       
        public ActionResult Contact()
        {
            ViewBag.Title = "Product Page";

            return View();
        }
    }
}
