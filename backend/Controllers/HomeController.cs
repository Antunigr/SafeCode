using System.Net;
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
        return View();
    }

    [Authorize]
    [Route("Pergunta")]
    public IActionResult Pergunta()
    {
        return View();
    }

    [Route("Blog")]
    public IActionResult Blog()
    {
        return View();
    }

    [Route("FeedBack")]
    public IActionResult FeedBack()
    {
        return View();
    }

}
