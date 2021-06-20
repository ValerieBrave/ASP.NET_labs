using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_dll
{
    public class NoteDictionary : INoteDictionary
    {
        private NotesContext notesContext = new NotesContext();
        public Note Add(Note newNote)
        {
            notesContext.Notes.Add(newNote);
            notesContext.SaveChanges();
            return newNote;
        }

        public Note GetByID(long NoteID)
        {
            return notesContext.Notes.Where(x => x.NoteId == NoteID).FirstOrDefault();
        }

        public long Delete(long NoteID)
        {
            Note note = GetByID(NoteID);
            notesContext.Notes.Remove(note);
            notesContext.Entry(note).State = System.Data.Entity.EntityState.Deleted;
            notesContext.SaveChanges();
            return NoteID;
        }

        public List<Note> GetAll()
        {
            return notesContext.Notes.ToList();
        }

        public Note Update(Note newNote)
        {
            Note note = GetByID(newNote.NoteId);
            note.Fullname = newNote.Fullname;
            note.Telephone = newNote.Telephone;
            notesContext.Entry(note).State = System.Data.Entity.EntityState.Modified;
            notesContext.SaveChanges();
            return newNote;
        }
    }
}
