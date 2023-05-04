using SafeCode.Models;

namespace SafeCode.Repositories
{
    public interface IPostsCrud
    {
        Task<IEnumerable<Question>> GetAllPosts();
        Task<IEnumerable<Question>> GetPostsById(int CategoriesId);
        Task<Question> CreatePost(Question question);
        Task UpdatePost(Question question);
        Task DeletePost(int Id);
    }
}