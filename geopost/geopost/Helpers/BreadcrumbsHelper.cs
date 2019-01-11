using System.Collections.Generic;
using umbraco.NodeFactory;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.PublishedContentModels;

namespace geopost.Helpers
{
    public static class BreadcrumbsHelper
    {
        public static List<IGeneralNavigation> InitBreadcrumb()
        {
            var umbracoHelper = new UmbracoHelper(UmbracoContext.Current);
            IPublishedContent currentItem = umbracoHelper.TypedContent(Node.getCurrentNodeId());

            var breadcrumbs = BuldBreadcrumb(currentItem, null);
            breadcrumbs.Reverse();

            return breadcrumbs;
        }

        private static List<IGeneralNavigation> BuldBreadcrumb(IPublishedContent item, List<IGeneralNavigation> breadcrupbList)
        {
            if (breadcrupbList == null)
                breadcrupbList = new List<IGeneralNavigation>();

            if (item != null)
            {
                if (item.IsComposedOf(GeneralNavigation.ModelTypeAlias) && 
                    ((IGeneralNavigation)item).NavigationTitle != null && 
                    !string.IsNullOrEmpty(((IGeneralNavigation)item).NavigationTitle.GetValue()) && 
                    ((IGeneralNavigation)item).ShowInBreadcrumbs)
                        breadcrupbList.Add((IGeneralNavigation)item);
                if (item.Parent != null)
                    BuldBreadcrumb(item.Parent, breadcrupbList);
            }

            return breadcrupbList;
        }
    }
}