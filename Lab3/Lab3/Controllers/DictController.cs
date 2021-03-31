using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3.Controllers
{
    public class DictController : Controller
    {
        Models.Dictionary dict;
        public DictController()
        {
            dict = new Models.Dictionary();
        }

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.getall = dict.notes;
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Update(string name)
        {
            ViewBag.name = name;
            return View();
        }
        [HttpGet]
        public ActionResult Delete(string name)
        {
            ViewBag.name = name;
            return View();
        }

        [HttpPost]
        public void AddSave(string fullname, string telephone)
        {
            dict.AddNote(fullname, telephone);
            //this.HttpContext.Response.Redirect(System.Web.HttpRuntime.AppDomainAppVirtualPath + "/Dict/Index");
            this.HttpContext.Response.Redirect("~/Dict/Index");
        }

        [HttpPost]
        public void UpdateSave(string fullname, string telephone)
        {
            dict.UpdateNote(fullname, telephone);
            this.HttpContext.Response.Redirect("~/Dict/Index");
        }

        [HttpPost]
        public void DeleteSave(string fullname)
        {
            dict.DeleteNote(fullname);
            this.HttpContext.Response.Redirect("~/Dict/Index");
        }

        public ActionResult Error()
        {
            Response.StatusCode = 404;
            return View();
        }
    }
}