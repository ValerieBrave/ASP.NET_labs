﻿using Lab7a.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Lab7a.Repository
{
    public class NoteDictionary : INoteDictionary
    {
        private readonly string FILE_PATH = @"D:\ASP.NET\Lab7a\notes.json";
        private List<Note> notes;
        public void UploadNotes()     //загрузить из файла
        {
            using (StreamReader sr = new StreamReader(FILE_PATH))
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
            using (StreamWriter stringWriter = new StreamWriter(FILE_PATH, false))
            {
                foreach (Note n in notes)
                {
                    stringWriter.WriteLine(JsonConvert.SerializeObject(n));
                }
            }
            UploadNotes();
        }
        //---------------------------------------------------------

        public NoteDictionary()
        {
            this.notes = new List<Note>();
            this.UploadNotes();
        }





        public Note Add(Note newNote)
        {
            using (StreamWriter stringWriter = new StreamWriter(FILE_PATH, true))
            {
                stringWriter.WriteLine("{\"NoteId\":\"" + newNote.NoteId.ToString() + "\",\"Fullname\":\"" + newNote.Fullname + "\",\"Telephone\":\"" + newNote.Telephone + "\"}");
            }
            this.UploadNotes();
            return newNote;
        }

        public long Delete(long NoteID)
        {
            bool found = false;
            Note ttd = new Note();
            using (StreamReader sr = new StreamReader(FILE_PATH))
            {
                string line = sr.ReadLine();
                while (!found && line != null)
                {
                    ttd = JsonConvert.DeserializeObject<Note>(line);
                    if (ttd.NoteId == NoteID) found = true;
                    line = sr.ReadLine();
                }
                if (found)
                {
                    int index = notes.IndexOf(notes.Single(n => n.NoteId == ttd.NoteId));
                    notes.RemoveAt(index);
                }
            }
            if (found)
            {
                DownloadNotes();
                return NoteID;
            }
            return 0;
        }

        public List<Note> GetAll()
        {
            return this.notes;
        }

        public Note GetByID(long NoteID)
        {
            bool found = false;
            Note ttd = new Note();
            using (StreamReader sr = new StreamReader(FILE_PATH))
            {
                string line = sr.ReadLine();
                while (!found && line != null)
                {
                    ttd = JsonConvert.DeserializeObject<Note>(line);
                    if (ttd.NoteId == NoteID) found = true;
                    line = sr.ReadLine();
                }
            }
            if (found) return ttd;
            else return null;
        }

        public Note Update(Note newNote)
        {
            bool found = false;
            Note ttd = new Note();
            using (StreamReader sr = new StreamReader(FILE_PATH))
            {
                string line = sr.ReadLine();
                while (!found && line != null)
                {
                    ttd = JsonConvert.DeserializeObject<Note>(line);
                    if (ttd.NoteId == newNote.NoteId) found = true;
                    line = sr.ReadLine();
                }
                if (found)
                {
                    int index = notes.IndexOf(notes.Single(n => n.NoteId == ttd.NoteId));
                    notes.RemoveAt(index);
                    ttd.Telephone = newNote.Telephone;
                    ttd.Fullname = newNote.Fullname;
                    notes.Insert(index, ttd);

                }
            }
            if (found)
            {
                DownloadNotes();
                return newNote;
            }
            return null;
        }
    }
}