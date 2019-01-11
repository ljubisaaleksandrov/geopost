using System.Web.Optimization;
using System.Web.Routing;
using Umbraco.Core;

namespace geopost.App_Start
{
    public class GeopostEventHandler : ApplicationEventHandler
    {
        protected override void ApplicationStarting(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //ContentFinderResolver.Current.InsertTypeBefore<ContentFinderByNotFoundHandlers, VortoContentFinder>();
            //UrlProviderResolver.Current.InsertTypeBefore<DefaultUrlProvider, UrlProviderExtended>();
            //ContentFinderResolver.Current.InsertTypeBefore<ContentFinderByNotFoundHandlers, PostContentFinder>();
            //base.ApplicationStarting(umbracoApplication, applicationContext);

            /*
            //With the url providers we can change node urls.
            UrlProviderResolver.Current.InsertTypeBefore<DefaultUrlProvider, UrlProviderExtended>();

            //With the content finder we can match nodes to urls.
            ContentFinderResolver.Current.InsertTypeBefore<ContentFinderByNotFoundHandlers, PostContentFinder>();
            ContentService.Published += ContentServicePublished;
            */
        }

        //private void ContentServicePublished(IPublishingStrategy sender, PublishEventArgs<IContent> args)
        //{
        //    HttpContext.Current.Cache.Remove("CachedPostNodes");
        //}
    }

}