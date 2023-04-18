using Microsoft.EntityFrameworkCore;
using SafeCode.Models;

namespace SafeCode.Repositories
{
    public class PostsCrud : IPostsCrud
    {
        public readonly AppDbContext _context;

        public PostsCrud(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Question> CreatePost(Question question)
        {
            _context.QuestionModel.AddAsync(question);
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
            var results = await _context.QuestionModel.Include(post => post.Categories).Where(post => post.CategoriesId == categoriesId).ToListAsync();
            return results;
        }

        public async Task UpdatePost(Question question)
        {
            _context.Entry(question).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}