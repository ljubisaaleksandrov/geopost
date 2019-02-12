using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using AutoMapper;
using geopost.Domain;
using geopost.Domain.Models.Comments;
using geopost.Services.Interfaces;
using geopost.Services.Logic;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector.Integration.WebApi;
using System;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
//using Umbraco.Core.Models.Mapping;
using Umbraco.Core.Persistence;

namespace geopost.App_Start
{
    public static class AutoMapperWebConfigurationHelper
    {
        public static void Configure()
        {
            //ContainerBuilder builder = new ContainerBuilder();
            //builder.RegisterControllers(typeof(MvcApplication).Assembly);
            //if (AppDomain.CurrentDomain.GetAssemblies().Any(a => a.GetName().Name == "geopost.Services"))
            //{
            //    builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies().Single(a => a.GetName().Name == "geopost.Services")).AsImplementedInterfaces();
            //}
            //builder.RegisterType<DataContext>().AsImplementedInterfaces().InstancePerLifetimeScope();
            //builder.RegisterType<Hubs.UserGroupsHub>().AsImplementedInterfaces().InstancePerLifetimeScope();

            //builder.Register<>(c => new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<Comment, CommentViewModel>();
            //    cfg.CreateMap<CommentViewModel, Comment>();

            //    cfg.CreateMap<Comment, NewCommentViewModel>();
            //    cfg.CreateMap<NewCommentViewModel, Comment>();
            //}).CreateMapper());

            Mapper.CreateMap<Comment, CommentViewModel>();
            Mapper.CreateMap<CommentViewModel, Comment>();

            Mapper.CreateMap<Comment, NewCommentViewModel>();
            Mapper.CreateMap<NewCommentViewModel, Comment>();

            //Mapper.CreateMap<FormNominate, NominateFormViewModel>();
            //Mapper.CreateMap<FormApplication, ApplicationFormViewModel>()
            //      .ForMember(dest => dest.SchoolsList, opt => opt.MapFrom(src => !String.IsNullOrEmpty(src.SchoolsList) ? src.SchoolsList.Split(',').ToList() : new List<string>()))
            //      .ForMember(dest => dest.TeachingQualifications, opt => opt.MapFrom(src => !String.IsNullOrEmpty(src.TeachingQualifications) ? src.TeachingQualifications.Split(',').ToList() : new List<string>()));

            //var container = builder.Build();
            //var resolver = new AutofacWebApiDependencyResolver(container);
            //GlobalConfiguration.Configuration.DependencyResolver = resolver;
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            //var container1 = new Container();
            //container1.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            //// Register your types, for instance:
            //container1.Register<ICommentsService, CommentsService>(Lifestyle.Scoped);

            //// This is an extension method from the integration package.
            //container1.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            //container1.Verify();
            //DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container1));
            //GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container1);
        }
    }
}
