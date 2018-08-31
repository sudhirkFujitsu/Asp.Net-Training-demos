﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HandleErrorExample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute() { ExceptionType = typeof(Exception), View = "Error" } );
        }
    }
}


