using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using IExceptionFilterExample.Filters;

namespace IExceptionFilterExample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new SampleExceptionFilterAttribute());
        }
    }
}


