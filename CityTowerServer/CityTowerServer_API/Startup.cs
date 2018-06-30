using System.Data.Entity;
using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using CityTowerServer_API;
using CityTowerServer_DAL.Models;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repositories;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace CityTowerServer_API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration configugation = new HttpConfiguration();
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterWebApiFilterProvider(configugation);
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerDependency();

            builder.RegisterType<CityTowerDataBase>().As(typeof(DbContext)).SingleInstance();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).SingleInstance();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).SingleInstance();

            builder.RegisterWebApiFilterProvider(configugation);

            var container = builder.Build();

            configugation.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            app.UseAutofacMiddleware(container);
            app.UseAutofacWebApi(configugation);

            WebApiConfig.Register(configugation);
            app.UseWebApi(configugation);
        }
    }
}