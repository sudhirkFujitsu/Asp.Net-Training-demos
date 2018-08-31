using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FiltersExample.CustomFilters
{
    public class SampleActionFilterAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.Message += " IActionFilter.OnActionExecuting";
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.Controller.ViewBag.Message += " IActionFilter.OnActionExecuted";
        }
    }
}

