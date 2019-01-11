using System.Web.Mvc;
using System.Web.Mvc.Html;
using Umbraco.Core.Models;

namespace geopost.Extensions
{
    public static class GridExtensions
    {
        public static MvcHtmlString GetVortoGridHtml(this HtmlHelper html, object gridValue, string framework = "bootstrap3")
        {
            if (gridValue == null)
                return new MvcHtmlString(string.Empty);

            var partialViewName = "Grid/" + framework;

            return html.Partial(partialViewName, gridValue);
        }

        public static MvcHtmlString GetGridHtml<T>(this HtmlHelper html, IPublishedProperty property, string framework = "bootstrap3")
        {
            if (property == null || property.Value == null || string.IsNullOrWhiteSpace(property.Value.ToString()))
                return new MvcHtmlString(string.Empty);

            var str = property.Value.ToJson();
            var grid = str.FromJson<T>();
            var partialViewName = "Grid/" + framework;
            return html.Partial(partialViewName, grid);
        }

        public static MvcHtmlString GetGridHtml<T>(this HtmlHelper html, IPublishedContent content, string propertyAlias, string framework = "bootstrap3")
        {
            IPublishedProperty property = content.GetProperty(propertyAlias);
            if (property == null || property.Value == null || string.IsNullOrWhiteSpace(property.Value.ToString()))
                return new MvcHtmlString(string.Empty);

            var str = property.Value.ToJson();
            var grid = str.FromJson<T>();   
            var partialViewName = "Grid/" + framework;
            return html.Partial(partialViewName, grid);
        }
    }
}
