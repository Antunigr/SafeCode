using SafeCode.Models;

namespace SafeCode.Repositories
{
    public interface ICommentsCrud
    {
        Task<Comment> CreateComment(Comment comment);
    }
}