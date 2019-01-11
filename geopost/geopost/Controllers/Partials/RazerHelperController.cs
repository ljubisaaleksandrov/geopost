using geopost.Helpers;
using geopost.Models;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace geopost.Controllers.Partials
{
    public class RazerHelperController : SurfaceController
    {
        public ActionResult Header()
        {
            var model = new HeaderViewModel()
            {
                SiteSettings = SettingsHelper.GetSiteSettings(),
                Breadcrumbs = BreadcrumbsHelper.InitBreadcrumb()
            };

            return PartialView("~/Views/Shared/_Header.cshtml", model);
        }

        public ActionResult SocialSharing()
        {
            var model = "";
            return PartialView("~/Views/Shared/_SocialSharing.cshtml", model);
        }
    }
}