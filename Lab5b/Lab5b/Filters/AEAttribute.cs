using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab5b.Filters
{
    public class AEAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<p> Exception handled by ExceptionFilter </p>");
            ViewResult vr = new ViewResult();
            vr.ViewName = "Error";
            filterContext.Result = vr;
            filterContext.ExceptionHandled = true;
        }
    }
}