﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SFHCars.Controllers
{
    public class SalesPersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}