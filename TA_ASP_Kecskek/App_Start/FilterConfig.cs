﻿using System.Web;
using System.Web.Mvc;

namespace TA_ASP_Kecskek
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
