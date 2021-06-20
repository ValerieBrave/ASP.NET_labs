using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab5b.Filters;

namespace Lab5b.Controllers
{
    public class AResearchController : Controller
    {
        // GET: AResearch
        public ActionResult Index()
        {
            return View();
        }

        [AA]
        public ActionResult AA()
        {
            return Content("<p> Basic AA() response </p>");
        }

        [AR]
        public ActionResult AR()
        {
            return Content("<p> Basic AR() response </p>");
        }

        [AE]
        public ActionResult AE()
        {
            throw new Exception("AE method exception!");
            //return Content("<p> Basic AE() response </p>");
        }

        public class AAAttribute : FilterAttribute, IActionFilter
        {
            public void OnActionExecuted(ActionExecutedContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<p>AA() response modified by OnActionExecuted </p>");
            }

            public void OnActionExecuting(ActionExecutingContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<p>AA() response modified by OnActionExecuting </p>");
            }
        }

        public class ARAttribute : FilterAttribute, IResultFilter
        {
            public void OnResultExecuted(ResultExecutedContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<p>AR() response modified by OnResultExecuted </p>");
            }

            public void OnResultExecuting(ResultExecutingContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<p>AR() response modified by OnResultExecuting </p>");
            }
        }
    }
}