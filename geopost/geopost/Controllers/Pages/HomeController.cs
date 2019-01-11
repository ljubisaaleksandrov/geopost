using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using Umbraco.Web.PublishedContentModels;

namespace geopost.Controllers.Pages
{
    public class PageHomeController : RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            return View("~/Views/Pages/Home.cshtml", (PageHome)model.Content);
        }
    }
}