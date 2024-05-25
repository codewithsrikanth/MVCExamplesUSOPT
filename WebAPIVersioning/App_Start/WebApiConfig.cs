﻿using System.Web.Http;
using System.Web.Http.Dispatcher;
using WebAPIVersioning.Custom;

namespace WebAPIVersioning
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            config.Services.Replace(typeof(IHttpControllerSelector), new CustomControllerSelector(config));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultRoute",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );

            //config.Routes.MapHttpRoute(
            //    name: "Version1",
            //    routeTemplate: "api/v1/employees/{id}",
            //    defaults: new { id = RouteParameter.Optional,controller="EmployeeV1" }
            //);

            //config.Routes.MapHttpRoute(
            //    name: "Version2",
            //    routeTemplate: "api/v2/employees/{id}",
            //    defaults: new { id = RouteParameter.Optional, controller = "EmployeeV2" }
            //);
        }
    }
}
