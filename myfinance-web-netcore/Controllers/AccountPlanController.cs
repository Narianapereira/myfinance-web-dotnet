﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myfinance_web_netcore.Models;
using myfinance_web_netcore.Services;

namespace myfinance_web_netcore.Controllers;

// [ApiController]
[Route("[controller]")]
public class AccountPlanController : Controller
{
    private readonly ILogger<AccountPlanController> _logger;

    private readonly IAccountPlanService _accountPlanService;

    public AccountPlanController(ILogger<AccountPlanController> logger,
                                IAccountPlanService accountPlanService)
    {
        _logger = logger;
        _accountPlanService = accountPlanService;
    }

    [HttpGet]
    [Route("Index")]
    public IActionResult Index()
    {
        var lista = _accountPlanService.Listar();
        ViewBag.ListItems = lista;
        return View();
    }

    [HttpGet]
    [Route("Cadastro")]
    [Route("Cadastro/{id}")]
    public IActionResult Cadastro(int? id)
    {
        if (id != null)
        {
            var registro = _accountPlanService.RetornarRegistro((int)id);
            return View(registro);
        }
        return View();
    }

    [HttpPost]
    [Route("Cadastro")]
    [Route("Cadastro/{id}")]
    public IActionResult Cadastro(AccountPlanModel model)
    {
        _accountPlanService.Salvar(model);
        return RedirectToAction("Index");
    }

    [HttpGet]
    [Route("Excluir/{id}")]
    public IActionResult Excluir(int id)
    {
        _accountPlanService.Excluir(id);
        return RedirectToAction("Index");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}