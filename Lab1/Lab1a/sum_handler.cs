using System;
using System.Web;

namespace Lab1a
{
    public class sum_handler : IHttpHandler
    {
        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            var x = context.Request["x"];
            var y = context.Request["y"];
            int ix = int.Parse(x);
            int iy = int.Parse(y);
            context.Response.ContentType = "text/plain";
            context.Response.Write(ix + iy);
        }
    }
}
