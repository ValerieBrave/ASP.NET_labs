using Lab7b.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Lab7b
{
    /// <summary>
    /// Сводное описание для WebService
    /// </summary>
    [WebService(Namespace = "http://svv.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        NoteDictionary noteDictionary = new NoteDictionary();

        [WebMethod(Description = "Get all notes", EnableSession = true)]
        public List<Note> GetDict()
        {
            return noteDictionary.GetAll();
        }

        [WebMethod(Description = "Add new note", EnableSession = true)]
        public Note AddDict(Note newNote)
        {
            return noteDictionary.Add(newNote);
        }

        [WebMethod(Description = "Edit note", EnableSession = true)]
        public Note UpdDict(Note newNote)
        {
            return noteDictionary.Update(newNote);
        }

        [WebMethod(Description = "Delete note", EnableSession = true)]
        public long DelDict(long id)
        {
            return noteDictionary.Delete(id);
        }
    }
}
