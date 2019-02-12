using System;

namespace geopost.Domain.Models.Comments
{
    public class NewCommentViewModel
    {
        public string UserName { get; set; }
        public string UserId { get; set; }
        public int PageId { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public Nullable<int> ReplayTo { get; set; }

        public NewCommentViewModel()
        {

        }
    }
}
