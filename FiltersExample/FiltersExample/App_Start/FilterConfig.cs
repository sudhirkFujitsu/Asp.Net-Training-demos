using System;
using System.Web.Mvc;
using FiltersExample.CustomFilters;

namespace FiltersExample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new SampleAuthorizationFilterAttribute());
            filters.Add(new SampleActionFilterAttribute());
            filters.Add(new SampleResultFilterAttribute());
            filters.Add(new SampleExceptionFilterAttribute());
        }
    }
}


