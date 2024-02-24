using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace Desafio_S4E
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);

            routes.MapPageRoute("HomePageIndexRoute", "", "~/Views/Home/Index.aspx");
            //routes.MapPageRoute("TarefaUserIndexRoute", "Tarefas/{Id}", "~/Views/Tarefa/Index.aspx");
            routes.MapPageRoute("TarefaUserCreateRoute", "Tarefas/create", "~/Views/Tarefa/Create.aspx");
            routes.MapPageRoute("EtapasCreateRoute", "Etapas/create", "~/Views/Etapa/Create.aspx");

            routes.MapPageRoute("UserIndexRoute", "User/", "~/Views/User/Index.aspx");
            routes.MapPageRoute("UserCreateRoute", "User/create", "~/Views/User/Create.aspx");

        }
    }
}
