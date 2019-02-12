using geopost.Domain.Models.Comments;
using System.Collections.Generic;

namespace geopost.Services.Interfaces
{
    public interface ICommentsService
    {
        int AddComment(NewCommentViewModel newComment);
        List<CommentViewModel> GetPageComments(int pageId);
    }
}
