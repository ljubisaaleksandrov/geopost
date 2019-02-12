using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using geopost.App_Start;
using geopost.Controllers.Pages;
using geopost.Controllers.Partials;
using geopost.Domain;
using geopost.Services.Interfaces;
using geopost.Services.Logic;
using System;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Umbraco.Core;
using Umbraco.Core.Events;
using Umbraco.Core.Logging;
using Umbraco.Core.Models;
using Umbraco.Core.Services;
using Umbraco.Web;
using Umbraco.Web.Trees;

namespace geopost
{
    //public class MvcApplication : UmbracoApplication //System.Web.HttpApplication
    //{
    //    protected override void OnApplicationStarting(object sender, EventArgs e)
    //    {
    //        //AreaRegistration.RegisterAllAreas();
    //        //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
    //        //RouteConfig.RegisterRoutes(RouteTable.Routes);
    //        //BundleConfig.RegisterBundles(BundleTable.Bundles);
    //    }
    //}

    public class Global : UmbracoApplication
    {
        protected override void OnApplicationStarting(object sender, EventArgs e)
        {
            ContentService.Saving += ContentService_Saving;
            ContentService.Saved += ContentService_Saved;
        }

        protected override void OnApplicationStarted(object sender, EventArgs e)
        {
            base.OnApplicationStarted(sender, e);
            //AreaRegistration.RegisterAllAreas();
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);

            base.OnApplicationStarted(sender, e);

            var builder = new ContainerBuilder();

            builder.Register(c => new UmbracoHelper(UmbracoContext.Current)).AsSelf();

            //register all controllers found in the Varkey.Business.dll
            //builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterControllers(typeof(CommentsController).Assembly);
            builder.RegisterControllers(typeof(Global).Assembly);

            //register umbraco webapi controllers
            builder.RegisterApiControllers(typeof(UmbracoApplication).Assembly);
            builder.RegisterApiControllers(typeof(ApplicationTreeController).Assembly);
            builder.RegisterApiControllers(typeof(PostImporterController).Assembly);
            //builder.RegisterApiControllers(typeof(UmbracoFormsController).Assembly);
            builder.RegisterApiControllers(typeof(CommentsController).Assembly);

            //Single Instance
            builder.RegisterType<CommentsService>().As<ICommentsService>().SingleInstance();
            builder.RegisterType<DataContext>().AsImplementedInterfaces().InstancePerLifetimeScope();

            AutoMapperWebConfigurationHelper.Configure();

            var container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            //Ditto.RegisterDefaultProcessorType<VortoPropertyAttribute>();
        }

        protected override void OnApplicationError(object sender, EventArgs e)
        {
            var error = Server.GetLastError();

            while (error.InnerException != null) error = error.InnerException;

            //handles the 500 error, illegal characters in path to redirect to /404
            if (error.GetType() == typeof(ArgumentException))
            {
                Server.TransferRequest(ConfigurationManager.AppSettings["notFoundPage"]);
            }

            // Log Error
            string message;
            try
            {
                message = "An unhandled exception occured at " + Request.Url + " - " + error.Message;
            }
            catch
            {
                message = "An unhandled exception occured " + error.Message;
            }

            LogHelper.Error<ArgumentException>(message, error);
        }

        private void ContentService_Saved(IContentService sender, Umbraco.Core.Events.SaveEventArgs<IContent> e)
        {
            //var contentUpdateService = new ContentUpdateService(sender);

            foreach (var entity in e.SavedEntities)
            {
                //docType defaults for new content only
                //will need for google translate api
                if (entity.IsNewEntity())
                {
                    if (entity.ContentType.Alias == "notFoundPage")
                    {
                        //404 page hide by default
                        entity.SetValue("hideFromNavigation", true);
                    }

                    sender.SaveAndPublishWithStatus(entity);
                }
            }

            //ApplicationContext.Current.ApplicationCache.RuntimeCache.ClearCacheByKeySearch("MultilingualContentFinder");
        }

        private void ContentService_Saving(IContentService sender, SaveEventArgs<IContent> saveEventArgs)
        {
            foreach (var entity in saveEventArgs.SavedEntities)
            {
                if (!entity.HasIdentity)
                {
                    var result = sender.SaveAndPublishWithStatus(entity);
                }
            }
        }
    }
}