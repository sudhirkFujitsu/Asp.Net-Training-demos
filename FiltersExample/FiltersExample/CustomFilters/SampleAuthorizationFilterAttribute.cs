using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FiltersExample.CustomFilters
{
    public class SampleAuthorizationFilterAttribute : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            filterContext.Controller.ViewBag.Message = "IAuthorizationFilter.OnAuthorization";
        }
    }
}


