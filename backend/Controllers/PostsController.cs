using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SafeCode.Models;
using SafeCode.Repositories;

namespace backend.Controllers;

[Route("Posts")]
public class PostsController : Controller
{

    private readonly ApplicationDbContext _context;
    private readonly IPostsCrud _postsCrud;
    private readonly ILogger<HomeController> _logger;
    public PostsController(ILogger<HomeController> logger,
                           IPostsCrud postsCrud,
                           ApplicationDbContext context)
    {
        _logger = logger;
        _postsCrud = postsCrud;
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> PostsView()
    {

        var quest = await GetQuestion();
        _logger.LogInformation($"Numero de Posts: {quest.Count()}");
        return View(quest);
    }

    [HttpGet("{CategoriesId}")]
    [Route("/{CategoriesId}")]
    public async Task<IActionResult> PostsByIdView(int CategoriesId)
    {
        var questionsList = await GetQuestionById(CategoriesId);
        List<Question> questions = new List<Question>();

        foreach (var question in questionsList)
        {
            questions.Add(question);
        }
        return View(questions);
    }

    public async Task<IEnumerable<Question>> GetQuestion()
    {
        return await _postsCrud.GetAllPosts();
    }

    public async Task<IEnumerable<Question>> GetQuestionById(int categoriesName)
    {
        return await _postsCrud.GetPostsById(categoriesName);
    }

    [HttpGet]
    [Route("Pergunta")]
    [Authorize]
    public IActionResult Pergunta()
    {
        return View();
    }

    [HttpPost]
    [Route("Pergunta")]
    public async Task<ActionResult<Question>> Pergunta([FromForm] Question question)
    {

        if (ModelState.IsValid)
        {
            var newQuestion = await _postsCrud.CreatePost(question);
            CreatedAtAction(nameof(GetQuestion), new { id = newQuestion.Id }, newQuestion);
            return RedirectToAction("PostsView", "Posts");
        }
        ModelState.AddModelError("", "Por favor, preencha todos os campos obrigatórios.");

        return View(question);
    }


}
