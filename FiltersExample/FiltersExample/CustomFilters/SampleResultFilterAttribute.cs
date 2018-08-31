using System;
using System.Web.Mvc;

namespace FiltersExample.CustomFilters
{
    public class SampleResultFilterAttribute : FilterAttribute, IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.Message += " IResultFilter.OnResultExecuting";
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.Controller.ViewBag.Message += " IResultFilter.OnResultExecuted";
        }
    }
}


