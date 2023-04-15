using Microsoft.EntityFrameworkCore;
using SafeCode.Models;

namespace SafeCode.Repositories
{
    public class PostsCrud : IPostsCrud
    {
        public readonly ContextQuest _context;

        public PostsCrud(ContextQuest context)
        {
            _context = context;
        }

        public async Task<Question> Create(Question question)
        {
            _context.QuestionModel.AddAsync(question);
            await _context.SaveChangesAsync();
            return question;
        }

        public async Task Delete(int Id)
        {
            var questionDelete = await _context.QuestionModel.FindAsync(Id);
            _context.QuestionModel.Remove(questionDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Question>> Get()
        {
            return await _context.QuestionModel.ToListAsync();
        }

        public async Task<Question> Get(int Id)
        {
            return await _context.QuestionModel.FindAsync(Id);
        }

        public async Task Update(Question question)
        {
            _context.Entry(question).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}