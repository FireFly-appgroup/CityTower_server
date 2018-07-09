using System.Data.Entity;
using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using CityTowerServer_API;
using CityTowerServer_BLL.Services;
using CityTowerServer_DAL.Entities;
using CityTowerServer_DAL.Models;
using CityTowerServer_DAL.Repository;
using CityTowerServer_DAL.UnitOfWork;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace CityTowerServer_API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext<ApplicationContext>(ApplicationContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });

            HttpConfiguration configugation = new HttpConfiguration();
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterWebApiFilterProvider(configugation);
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<CityTowerDataBase>().As(typeof(DbContext)).SingleInstance();
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).SingleInstance();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).SingleInstance();
            builder.RegisterType(typeof(CountryListService)).As(typeof(ICountryListService)).SingleInstance();
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