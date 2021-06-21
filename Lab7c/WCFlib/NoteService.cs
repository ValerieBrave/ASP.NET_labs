using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFlib.Repository;

namespace WCFlib
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class NoteService : IService
    {
        private NoteDictionary noteDictionary = new NoteDictionary();

        public Note Add(Note newNote)
        {
            return this.noteDictionary.Add(newNote);
        }

        public long Delete(long NoteID)
        {
            return this.noteDictionary.Delete(NoteID);
        }

        public List<Note> GetAll()
        {
            return this.noteDictionary.GetAll();
        }

        public Note Update(Note newNote)
        {
            return this.noteDictionary.Update(newNote);
        }
    }
}
