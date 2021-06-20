using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab5b.Controllers
{
    public class CHResearchController : Controller
    {
        // GET: CHResearch
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Duration = 5, Location = System.Web.UI.OutputCacheLocation.Client)]
        [HttpGet]
        public ActionResult AD()
        {
            DateTime t = DateTime.Now.ToLocalTime();
            return Content($"ЛЕРА ДУБЛИРУЙ ВКЛАДКИ GET:/AD:{t}");
        }

        [OutputCache(Duration = 7)]
        [Route("CHResearch/AP/{param1}/{param2}")]
        [HttpPost]
        public ActionResult AP(string param1, string param2)
        {
            DateTime t = DateTime.Now.ToLocalTime();
            return Content($"GET:/AP:{param1}:{param2}:{t}");
        }
    }
}