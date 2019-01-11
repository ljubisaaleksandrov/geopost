using System.Web.Mvc;
using Umbraco.Core.Logging;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using Umbraco.Web.PublishedContentModels;

namespace geopost.Controllers.Pages
{
    public class PagePostController : RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            var post = (PagePost)model.Content;
            //var urlName = post.UrlName;‚‚
            //var urlAlias = post.UmbracoUrlAlias.GetValue();

            //post.UrlName.Replace(urlName, urlAlias);

            return View("~/Views/Pages/Post.cshtml", post);
        }
    }
}