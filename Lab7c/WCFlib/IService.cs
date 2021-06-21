using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFlib.Repository;

namespace WCFlib
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        List<Note> GetAll();
        [OperationContract]
        Note Add(Note newNote);
        [OperationContract]
        Note Update(Note newNote);
        [OperationContract]
        long Delete(long NoteID);
    }
}
