using System;
using System.Web;

namespace Lab1a
{
    public class http_handler2 : IHttpHandler
    {
        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            var ParmA = context.Request["ParmA"];
            var ParmB = context.Request["ParmB"];

            context.Response.Write($"Post-Http-XYZ:ParmA = {ParmA},ParmB = {ParmB}");
        }
    }
}
