using System.Collections.Generic;

namespace geopost.Domain.Models.Comments
{
    public class CommentViewModel : NewCommentViewModel
    {
        public int Id { get; set; }
        public bool IsBlocked { get; set; }
        public List<CommentViewModel> Replies { get; set; }
        public System.DateTime DateCreated { get; set; }
    }
}
