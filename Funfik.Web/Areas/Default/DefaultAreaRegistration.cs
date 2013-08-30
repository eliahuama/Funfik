﻿using System.Web.Mvc;

namespace Funfik.Web.Areas.Default
{
    public class DefaultAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Default";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Default",
                "Default/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
