using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_dll
{
    public interface INoteDictionary
    {
        List<Note> GetAll();
        Note GetByID(long NoteID);
        Note Add(Note newNote);
        Note Update(Note newNote);
        long Delete(long NoteID);
    }
}
