using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[Route("Posts")]
public class PostsController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public PostsController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Posts()
    {
        return View();
    }

}
