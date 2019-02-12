using System.Web.Mvc;
using Umbraco.Core.Logging;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using Umbraco.Web.PublishedContentModels;

namespace geopost.Controllers.Pages
{
    public class PageLoginController : RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            var login = (PageLogin)model.Content;

            return View("~/Views/Pages/Login.cshtml", login);
        }
    }
}