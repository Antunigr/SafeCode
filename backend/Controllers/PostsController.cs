using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SafeCode.Models;
using SafeCode.Repositories;

namespace backend.Controllers;

[Route("Posts")]
public class PostsController : Controller
{

    private readonly ContextQuest _context;
    private readonly IPostsCrud _postsCrud;

    private readonly ILogger<HomeController> _logger;

    public PostsController(ILogger<HomeController> logger, IPostsCrud postsCrud, ContextQuest context)
    {
        _logger = logger;
        _postsCrud = postsCrud;
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Posts()
    {
        var quest = await GetQuestion();
        _logger.LogInformation($"Numero de Posts: {quest.Count()}");
        return View(quest);
    }

    [HttpGet("{CategoriesId}")]
    [Route("/{CategoriesId}")]
    public async Task<IActionResult> PostsId(int CategoriesId)
    {
        var questionsList = await GetQuestionId(CategoriesId);
        List<Question> questions = new List<Question>();



        foreach (var question in questionsList)
        {
            questions.Add(question);
        }


        return View(questions);
    }


    public async Task<IEnumerable<Question>> GetQuestion()
    {
        // return await _postsCrud.Get();
        return await _context.QuestionModel.Include(q => q.Categories).ToListAsync();

    }

    public async Task<IEnumerable<Question>> GetQuestionId(int CategoriesId)
    {
        // return await _postsCrud.GetPostsById(CategoriesId);
        return await _context.QuestionModel.Include(q => q.Categories).Where(q => q.CategoriesId == CategoriesId).ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Question>> CreatePost([FromForm] Question questionInput)
    {

        var newQuestion = await _postsCrud.Create(questionInput);
        CreatedAtAction(nameof(GetQuestion), new { id = newQuestion.QuestionId }, newQuestion);

        return RedirectToAction("Posts", "Posts");

    }

    // [Route("/test")]
    // public IActionResult test()
    // {
    //     var List = _context.QuestionModel.Include(p => p.Categories).Where(p => p.Categories.CategoriesId.Equals(2)).ToList();
    //     List.ForEach(p =>
    //     {
    //         Console.WriteLine(p.ToString());
    //     });

    //     return Content("ore");

    // }


}
