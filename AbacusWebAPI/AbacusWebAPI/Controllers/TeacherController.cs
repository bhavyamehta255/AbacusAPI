﻿using Microsoft.AspNetCore.Mvc;

namespace AbacusWebAPI.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
