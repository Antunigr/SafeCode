using SafeCode.Models;

namespace SafeCode.Repositories
{
    public interface IPostsCrud
    {
        Task<IEnumerable<Question>> Get();
        Task<IEnumerable<Question>> GetPostsById(int CategoriesId);
        Task<Question> Create(Question question);
        Task Update(Question question);
        Task Delete(int Id);
    }
}