using geopost.Domain.Models.Comments;
using geopost.Services.Interfaces;
using Microsoft.AspNet.Identity;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace geopost.Controllers.Partials
{
    public class CommentsController : SurfaceController
    {
        private readonly ICommentsService _commentsService;

        public CommentsController(ICommentsService commentsService)
        {
            _commentsService = commentsService;
        }

        public ActionResult Index(int pageId)
        {
            var model = _commentsService.GetPageComments(pageId);

            return PartialView("~/Views/Partials/Comments/Index.cshtml", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateNew(NewCommentViewModel model)
        {

            if (User.Identity.IsAuthenticated)
            {
                model.UserId = User.Identity.GetUserId();
                model.UserName = User.Identity.Name;
            }

            _commentsService.AddComment(model);

            return Json(new { }, JsonRequestBehavior.AllowGet);
        }
    }
}