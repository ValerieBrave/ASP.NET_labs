using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    
    public class Dictionary
    {
        public List<Note> notes;
        public void UploadNotes()     //загрузить из файла
        {
            using (StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"\App_Data\notes.json"))
            {
                this.notes.Clear();
                string line = sr.ReadLine();
                while (line != null)
                {
                    Note ttd = JsonConvert.DeserializeObject<Note>(line);
                    this.notes.Add(ttd);
                    line = sr.ReadLine();
                }
            }

        }

        public void DownloadNotes() //записать в файл
        {
            using (StreamWriter stringWriter = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\App_Data\notes.json", false))
            {
                foreach(Note n in notes)
                {
                    stringWriter.WriteLine(JsonConvert.SerializeObject(n));
                }
            }
            UploadNotes();
        }

        public void AddNote(string fullname, string telephone)
        {
            using (StreamWriter stringWriter = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\App_Data\notes.json", true))
            {
                stringWriter.WriteLine("{\"fullname\":\""+fullname+"\",\"telephone\":\""+telephone+"\"}");
            }
            this.UploadNotes();
        }

        public bool UpdateNote(string fullname, string telephone)
        {
            bool found = false;
            
            using (StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"\App_Data\notes.json"))
            {
                Note ttd = new Note();
                string line = sr.ReadLine();
                while (!found && line != null)
                {
                    ttd = JsonConvert.DeserializeObject<Note>(line);
                    if (ttd.fullname.Equals(fullname)) found = true;
                    line = sr.ReadLine();
                }
                if(found)
                {
                    int index = notes.IndexOf(notes.Single(n => n.fullname == ttd.fullname));
                    notes.RemoveAt(index);
                    ttd.telephone = telephone;
                    notes.Insert(index, ttd);
                    
                }
            }
            if (found) DownloadNotes();
            return found;
        }

        public bool DeleteNote(string fullname)
        {
            bool found = false;
            using (StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"\App_Data\notes.json"))
            {
                Note ttd = new Note();
                string line = sr.ReadLine();
                while (!found && line != null)
                {
                    ttd = JsonConvert.DeserializeObject<Note>(line);
                    if (ttd.fullname.Equals(fullname)) found = true;
                    line = sr.ReadLine();
                }
                if (found)
                {
                    int index = notes.IndexOf(notes.Single(n => n.fullname == ttd.fullname));
                    notes.RemoveAt(index);
                }
            }
            if (found) DownloadNotes();
            return found;
        }
        public Dictionary()
        {
            this.notes = new List<Note>();
            this.UploadNotes();
        }
    }
}