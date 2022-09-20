using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Look4MeAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuração e serviços de API Web
            config.Formatters.JsonFormatter.SupportedMediaTypes
        .Add(new MediaTypeHeaderValue("text/html"));

            // Rotas de API Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "WithActionApi",
                routeTemplate: "api/{controller}/{Action}/{pais}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{pais}",
                defaults: new
                {
                    champion = RouteParameter.Optional
                }
            );

        }
    }
}
