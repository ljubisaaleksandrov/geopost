using geopost.Helpers;
using geopost.Models;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace geopost.Controllers.Partials
{
    public class CommentsController : SurfaceController
    {
        public ActionResult Index(int pageId)
        {
            //var model = new HeaderViewModel()
            //{
            //    SiteSettings = SettingsHelper.GetSiteSettings(),
            //    Breadcrumbs = BreadcrumbsHelper.InitBreadcrumb()
            //};

            return PartialView("~/Views/Partials/Comments/Index.cshtml", pageId);
        }
    }
}