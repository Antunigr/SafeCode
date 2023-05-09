using System.Net;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SafeCode.Models;

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
