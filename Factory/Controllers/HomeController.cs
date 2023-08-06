﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
    public class HomeController : Controller
    {
        private readonly FactoryContext _db;
        public HomeController(FactoryContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            List<Engineer> engineers = _db.Engineers.ToList();
            List<Machine> machines = _db.Machines.ToList();
            ViewBag.Engineers = engineers;
            ViewBag.Machines = machines;
            return View();
        }
    }
}