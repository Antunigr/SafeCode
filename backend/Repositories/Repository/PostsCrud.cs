using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SafeCode.Models;

namespace SafeCode.Repositories
{
    public class PostsCrud : IPostsCrud
    {
        public readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PostsCrud(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<Question> CreatePost(Question question)
        {
            string userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await _userManager.FindByIdAsync(userId);
            question.ApplicationUserId = user.Id;

            var currentUser = await _context.Users.Include(d => d.Iquestions).FirstOrDefaultAsync(u => u.Id == userId);
            currentUser.Iquestions.Add(question);

            var usersWithQuestions = _context.Users.Include(u => u.Iquestions).ToList();

            await _context.QuestionModel.AddAsync(question);
            await _context.SaveChangesAsync();
            return question;
        }

        public async Task DeletePost(string Id)
        {
            var questionDelete = await _context.QuestionModel.FindAsync(Id);
            if (questionDelete != null)
            {
                _context.QuestionModel.Remove(questionDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Question>> GetAllPosts()
        {
            return await _context.QuestionModel.Include(user => user.ApplicationUser).Include(post => post.Categories).ToListAsync();
        }

        public async Task<IEnumerable<Question>> GetPostsById(int categoriesId)
        {
            return await _context.QuestionModel.Include(post => post.Categories).Where(post => post.Categories.Id == categoriesId).ToListAsync();
        }

        public async Task UpdatePost(Question question)
        {
            _context.Entry(question).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}