﻿using Microsoft.AspNetCore.Mvc;

namespace Anyar.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}