using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.PublishedContentModels;

namespace geopost.Helpers
{
    public static class SettingsHelper
    {
        public static DataSiteSettings GetSiteSettings()
        {
            var umbHelper = new UmbracoHelper(UmbracoContext.Current);
            var rootItems = umbHelper.TypedContentAtRoot().ToContentSet();
            return rootItems.FirstOrDefault(x => x.DocumentTypeAlias == DataSiteSettings.ModelTypeAlias) as DataSiteSettings;
        }
    }
}