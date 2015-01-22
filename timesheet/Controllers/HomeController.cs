﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using timesheet.Models;

namespace timesheet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Fake timesheets for now...
            var timesheets = new TimeSheetCollection();

            var todayWork = new TimeSheet();
            todayWork.Date = DateTime.Today;
            todayWork.HoursWorked = 8.25;
            timesheets.Add(todayWork);


            return View(timesheets);
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