﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myfinance_web_netcore.Models;

namespace myfinance_web_netcore.Controllers;

public class AccountPlanController : Controller
{
    private readonly ILogger<AccountPlanController> _logger;

    public AccountPlanController(ILogger<AccountPlanController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}