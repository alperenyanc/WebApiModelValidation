using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApiModelValidation.Filters;

namespace WebApiModelValidation
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            // bütün bir projeyi artk attribute çalışıyor olacak!!!
            config.Filters.Add(new MyModelValidationAttribute());//bu projeyi kapsayacak

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
