using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SafeCode.Models;
using SafeCode.Repositories;

namespace backend.Controllers;

[Route("Posts")]
public class PostsController : Controller
{
    private readonly IPostsCrud _postsCrud;

    private readonly ILogger<HomeController> _logger;

    public PostsController(ILogger<HomeController> logger, IPostsCrud postsCrud)
    {
        _logger = logger;
        _postsCrud = postsCrud;
    }

    [HttpGet]
    public async Task<IActionResult> Posts()
    {
        var quest = await GetQuestion();
        _logger.LogInformation($"Numero de Posts: {quest.Count()}");
        return View(quest);
    }


    public async Task<IEnumerable<Question>> GetQuestion()
    {
        return await _postsCrud.Get();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Question>> GetQuestion(int id)
    {
        return await _postsCrud.Get(id);
    }

    [HttpPost]
    public async Task<ActionResult<Question>> CreatePost([FromForm] Question questionInput)
    {

        var newQuestion = await _postsCrud.Create(questionInput);
        CreatedAtAction(nameof(GetQuestion), new { id = newQuestion.Id }, newQuestion);

        return RedirectToAction("Posts", "Posts");

    }



}
