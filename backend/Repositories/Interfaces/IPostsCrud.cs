using SafeCode.Models;

namespace SafeCode.Repositories
{
    public interface IPostsCrud
    {
        Task<Question> CreatePost(Question question);
        Task<IEnumerable<Question>> GetAllPosts();
        Task<IEnumerable<Question>> GetPostsById(int CategoriesId);
        Task UpdatePost(Question question);
        Task DeletePost(string Id);
    }
}