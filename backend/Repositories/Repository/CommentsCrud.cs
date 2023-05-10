using Microsoft.AspNetCore.Identity;
using SafeCode.Models;

namespace SafeCode.Repositories
{
    public class CommentsCrud : ICommentsCrud
    {

        private readonly ApplicationDbContext _context;

        public CommentsCrud(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Comment> CreateComment(Comment comment)
        {
            string parentId = comment.ParentCommentId;

            var parentComment = _context.CommentsModel.FirstOrDefault(c => c.Id == parentId);
            if (parentComment != null)
            {
                var newComment = new Comment
                {
                    Text = comment.Text,
                    CreationDate = DateTime.Now,
                    QuestionId = parentComment.QuestionId,
                    ApplicationUserId = comment.ApplicationUserId,
                    ApplicationUser = comment.ApplicationUser,
                    ParentCommentId = parentComment.Id,
                    ParentComment = parentComment,
                    ChildrenComments = new List<Comment>()
                };
                parentComment.ChildrenComments.Add(newComment);
                _context.CommentsModel.Add(newComment);
                _context.SaveChanges();

                return Task.FromResult(newComment);
            }

            return Task.FromResult<Comment>(null);
        }
    }
}