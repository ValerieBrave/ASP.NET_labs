using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab5a.Controllers
{
    public class CResearchController : Controller
    {
        public string C01()
        {
            string body;
            string method = Request.HttpMethod;
            string header = Request.Headers.ToString();
            string uri = Request.Url.AbsoluteUri;
            string param = Request.QueryString["param"];

            using (StreamReader reader = new StreamReader(Request.InputStream))
            {
                body = reader.ReadToEnd();
            }
            return $"body: {body}; \n" +
                $"header: {header}; \n" +
                $"method: {method};\n " +
                $"uri: {uri};\n " +
                $"params: {param}; \n";
        }
        public string C02()
        {
            string body;
            string status = HttpContext.Response.StatusCode.ToString();
            string header = Request.Headers.ToString();

            using (StreamReader reader = new StreamReader(Request.InputStream))
            {
                body = reader.ReadToEnd();
            }
            return $"body: {body};\n" +
                $"header: {header}\n;" +
                $"status: {status}\n";
        }
    }
}