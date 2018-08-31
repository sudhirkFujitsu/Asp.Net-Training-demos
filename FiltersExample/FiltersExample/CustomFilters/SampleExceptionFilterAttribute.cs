using System;
using System.Web.Mvc;

namespace FiltersExample.CustomFilters
{
    public class SampleExceptionFilterAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.Controller.ViewBag.Message += " IExceptionFilter.OnException";
        }
    }
}


