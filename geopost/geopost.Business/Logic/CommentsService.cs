using AutoMapper;
using geopost.Domain;
using geopost.Domain.Models.Comments;
using geopost.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace geopost.Services.Logic
{
    public class CommentsService : ICommentsService
    {
        public int AddComment(NewCommentViewModel commentModel)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    CommentViewModel model = (CommentViewModel)commentModel;

                    model.DateCreated = DateTime.Now;

                    Comment comment = Mapper.Map<Comment>(model);
                    db.Comments.Add(comment);
                    db.SaveChanges();
                    return comment.Id;
                }
                catch(Exception ex)
                {
                    return 0;
                }
            }
        }

        public List<CommentViewModel> GetPageComments(int pageId)
        {
            using (DataContext db = new DataContext())
            {
                return Mapper.Map<List<CommentViewModel>>(db.Comments.Where(c => c.PageId == pageId));
            }
        }


    }
}
