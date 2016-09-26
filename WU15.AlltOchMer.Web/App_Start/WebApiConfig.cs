using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace WU15.AlltOchMer.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
    //        GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling =
    //ReferenceLoopHandling.Ignore;
            //var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            //json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            //var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            //jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            //    ReferenceLoopHandling.Ignore;

            //Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/Category/SE/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "SubCategory",
                routeTemplate: "api/SubCategory/SE/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            config.Routes.MapHttpRoute(
               name: "Norge",
               routeTemplate: "api/Category/NO/{id}",
               defaults: new { id = RouteParameter.Optional }
           );

            config.Routes.MapHttpRoute(
                name: "ProductSweden",
                routeTemplate: "api/Product/SE/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
               name: "CartProductSweden",
               routeTemplate: "api/CartProduct/SE/{id}",
               defaults: new { id = RouteParameter.Optional }
           );
            config.Routes.MapHttpRoute(
              name: "CartSweden",
              routeTemplate: "api/Cart/SE/{id}",
              defaults: new { id = RouteParameter.Optional }
          );

            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            //var json = config.Formatters.JsonFormatter;
            //json.SerializerSettings.PreserveReferencesHandling =
            //    Newtonsoft.Json.PreserveReferencesHandling.None;
        }
    }
}
//api/CartProducts/SE/