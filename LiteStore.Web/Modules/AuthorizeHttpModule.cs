using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiteStore.Web.Security.Services;

namespace LiteStore.Web.Modules
{
    public class AuthorizeHttpModule : IHttpModule
    {
        private void Authenticate(object sender, EventArgs args)
        {
            var application = (HttpApplication)sender;
            var authenticationService = DependencyResolver
                .Current.GetService<IAuthenticationService>();
            authenticationService.Init(application.Context);
        }       

        public void Init(HttpApplication context)
        {
            context.AuthenticateRequest += Authenticate;            
        }

        public void Dispose()
        {
        }
    }
}