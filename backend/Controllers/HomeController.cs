﻿using System.Net;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace backend.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        ViewData["success_message"] = "Cadastro realizado com sucesso!";

        return View();
    }

    [Route("Pergunta")]
    public IActionResult Pergunta()
    {
        return View();
    }

}
