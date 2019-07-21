using System.Configuration;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using LiteStore.Application.Interfaces.AccountService;
using LiteStore.Application.Services.AccountService;
using LiteStore.Domain.SettingsProvider.Interfaces;
using LiteStore.Domain.SettingsProvider.Providers;
using LiteStore.Web.Security.Services;
using AuthenticationService = LiteStore.Web.Security.Services.AuthenticationService;

namespace LiteStore.Web.IoC
{
    public class AutofacResolver
    {
        public static void ConfigureContainer()
        {            
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            
            //Register new services
            builder.RegisterType<PathSettingsProvider>().As<IPathSettingsProvider>().WithParameter("settingsEnv", ConfigurationManager.AppSettings["SettingsEnv"]);
            builder.RegisterType<DbSettingsProvider>().As<IDbSettingsProvider>().SingleInstance();
            builder.RegisterType<AccountService>().As<IAccountService>();
            builder.RegisterType<AuthenticationService>().As<IAuthenticationService>();
            

            var container = builder.Build();            
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}