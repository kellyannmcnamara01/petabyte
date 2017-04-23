﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetaByte_KellysFeatures2.Models;

//  Project: Temiskaming Hospital Website
//  Team Name: PetaByte
//  Class: Mobile Development
//  Professor: Lee Situ
//  Author: Kelly Ann McNamara
//  File Description: This file sets the view for the home page and the partial view for the alerts to display. Please see other comments below for specific details.

namespace PetaByte_KellysFeatures2.Controllers
{
    public class HomeController : Controller
    {
        private PetaByteContext db = new PetaByteContext();
        // GET: Home
        public ActionResult Index()
        {
            List<HospitalEvent> events = db.HospitalEvents.Take(3).ToList();
            return View(events);
        }

        public ActionResult EventDetails(int? id)
        {
            HospitalEvent events = db.HospitalEvents.Single(evnt => evnt.eventsId == id);

            return View(events);
        }

        public ActionResult Allevents()
        {
            return View(db.HospitalEvents.ToList());
        }

        public PartialViewResult Alerts()
        {
            //NOTE (Kelly Ann McNamara): grab all of the alerts that are published
            List<Alert> alerts = db.Alerts.Where(a => a.status == "Published").ToList();
            //NOTE (Kelly Ann McNamara): call the partial view name and list
            return PartialView("_AlertsPartial", alerts);
        }
    }
}