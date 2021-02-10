using System;
using System.Web;

namespace Lab1a
{
    public class http_handler5 : IHttpHandler
    {
        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpResponse response = context.Response;
            HttpRequest request = context.Request;
            if (request.HttpMethod == "GET")
            {
                response.ContentType = "text/html";
                response.WriteFile("./static/index.html");
            }
            else if (request.HttpMethod == "POST")
            {
                var x = context.Request["x"];
                var y = context.Request["y"];
                int ix = int.Parse(x);
                int iy = int.Parse(y);
                context.Response.ContentType = "text/plain";
                context.Response.Write(ix * iy);
            }
        }

    }
}
