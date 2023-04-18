using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SafeCode.Models;
using SafeCode.Repositories;

namespace backend.Controllers;

[Route("Posts")]
public class PostsController : Controller
{

    private readonly AppDbContext _context;
    private readonly IPostsCrud _postsCrud;

    private readonly ILogger<HomeController> _logger;

    public PostsController(ILogger<HomeController> logger, IPostsCrud postsCrud, AppDbContext context)
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
    public async Task<IActionResult> PostsByIdView(int categoriesId)
    {
        var questionsList = await GetQuestionById(categoriesId);
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

    public async Task<IEnumerable<Question>> GetQuestionById(int categoriesId)
    {
        return await _postsCrud.GetPostsById(categoriesId);
    }

    [HttpPost]
    public async Task<ActionResult<Question>> AddPost([FromForm] Question questionInput)
    {

        var newQuestion = await _postsCrud.CreatePost(questionInput);
        CreatedAtAction(nameof(GetQuestion), new { id = newQuestion.QuestionId }, newQuestion);

        return RedirectToAction("Posts", "Posts");
    }
}
