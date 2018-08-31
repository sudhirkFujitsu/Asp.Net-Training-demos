using System;
using System.Web.Mvc;

namespace IExceptionFilterExample.Filters
{
    public class SampleExceptionFilterAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            filterContext.Controller.ViewBag.Message = filterContext.Exception.Message;
            filterContext.Result = new ViewResult()
            { ViewName = "Error", ViewData = filterContext.Controller.ViewData };
        }
    }
}


