using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//using JSON_dll;
using SQL_dll;

namespace Lab6.Controllers
{
    public class NotesController : Controller
    {
        private INoteDictionary noteDictionary;
        public NotesController(INoteDictionary noteDictionary)
        {
            ViewBag.notes = noteDictionary.GetAll();
            this.noteDictionary = noteDictionary;
        }
        public ActionResult Index()
        {
            ViewBag.notes = noteDictionary.GetAll();
            return View();
        }
        public ActionResult Add()
        {
            ViewBag.notes = noteDictionary.GetAll();
            return View();
        }

        [HttpPost]
        public ActionResult AddSave(string Fullname, string Telephone)
        {
            noteDictionary.Add(new Note(Fullname, Telephone));
            return Redirect("/Notes/Index");
        }

        public ActionResult Update(long NoteId)
        {
            ViewBag.notes = noteDictionary.GetAll();
            ViewBag.SelectedNote = noteDictionary.GetByID(NoteId);
            return View();
        }

        [HttpPost]
        public ActionResult UpdateSave(long NoteId, string Fullname, string Telephone)
        {
            noteDictionary.Update(new Note(NoteId, Fullname, Telephone));
            return Redirect("/Notes/Index");
        }

        public ActionResult Delete(long NoteId)
        {
            ViewBag.SelectedNote = noteDictionary.GetByID(NoteId);
            return View();
        }

        [HttpPost]
        public ActionResult DeleteSave(long NoteId)
        {
            noteDictionary.Delete(NoteId);
            return Redirect("/Notes/Index");
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}