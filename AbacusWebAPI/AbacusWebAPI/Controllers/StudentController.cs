﻿using Microsoft.AspNetCore.Mvc;

namespace AbacusWebAPI.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
