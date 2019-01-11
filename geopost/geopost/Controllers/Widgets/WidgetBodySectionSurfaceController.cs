using Our.Umbraco.DocTypeGridEditor.Web.Controllers;
using System.Web.Mvc;
using Umbraco.Web.PublishedContentModels;

namespace geopost.Controllers.Widgets
{
    public class WidgetBodySectionSurfaceController : DocTypeGridEditorSurfaceController
    {
        public ActionResult WidgetBodySection()
        {
            return CurrentPartialView((WidgetBodySection)Model);
        }
    }
}