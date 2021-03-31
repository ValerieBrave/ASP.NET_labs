using System;
using System.Web;

namespace Lab1a
{
    public class http_handler1 : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            string ParmA = context.Request.QueryString["ParmA"];
            string ParmB = context.Request.QueryString["ParmB"];

            HttpResponse response = context.Response;
            response.Write($"GET-Http-XYZ:ParmA = {ParmA},ParmB = {ParmB}");
        }
    }
}
