﻿using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers;

public class CategoriesController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}