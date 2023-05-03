using Microsoft.EntityFrameworkCore;
using SafeCode.Models;

namespace SafeCode.Repositories
{
    public class PostsCrud : IPostsCrud
    {
        public readonly ApplicationDbContext _context;

        public PostsCrud(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Question> CreatePost(Question question)
        {
            await _context.QuestionModel.AddAsync(question);
            await _context.SaveChangesAsync();
            return question;
        }

        public async Task DeletePost(int Id)
        {
            var questionDelete = await _context.QuestionModel.FindAsync(Id);
            _context.QuestionModel.Remove(questionDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Question>> GetAllPosts()
        {
            return await _context.QuestionModel.Include(post => post.Categories).ToListAsync();
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