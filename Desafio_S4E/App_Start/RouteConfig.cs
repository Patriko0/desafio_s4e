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
            routes.MapPageRoute("TarefaIndexRoute", "Tarefas/", "~/Views/Tarefa/Index.aspx");
            routes.MapPageRoute("TarefaUserIndexRoute", "Tarefas/{id}", "~/Views/Tarefa/TarefaUser.aspx");
            routes.MapPageRoute("UserIndexRoute", "User/", "~/Views/User/Index.aspx");

        }
    }
}
