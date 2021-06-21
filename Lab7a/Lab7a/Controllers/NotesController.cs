﻿using Lab7a.Models;
using Lab7a.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lab7a.Controllers
{
    public class NotesController : ApiController
    {
        private NoteDictionary notesDicionary;
        public NotesController()
        {
            this.notesDicionary = new NoteDictionary();
        }

        [HttpGet]
        public string Get()
        {
            return JsonConvert.SerializeObject(this.notesDicionary.GetAll());
        }

        [HttpPost]
        public void Post([FromBody]string json)
        {
            Note note = JsonConvert.DeserializeObject<Note>(json);
            this.notesDicionary.Add(new Note(note.Fullname, note.Telephone));
        }

        [HttpPut]
        public void Put(long id, [FromBody]string json)
        {
            Note note = JsonConvert.DeserializeObject<Note>(json);
            note.NoteId = id;
            this.notesDicionary.Update(note);
        }

        [HttpDelete]
        public void Delete(long id)
        {
            this.notesDicionary.Delete(id);
        }
    }
}