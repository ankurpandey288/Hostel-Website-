﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GHL.Controllers
{
    public class GymController : Controller
    {
        // GET: Gym
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Amenities()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}