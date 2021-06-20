using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Web.Common;

//using JSON_dll;
using SQL_dll;

namespace Lab6.Util
{
    public class NinjectRegistration : NinjectModule
    {
        public override void Load()
        {
            Bind<INoteDictionary>().To<NoteDictionary>(); //inTransientScope - новый объект на каждое обращение
            //Bind<INoteDictionary>().To<NoteDictionary>().InThreadScope();   // новый объект на каждый поток
            //Bind<INoteDictionary>().To<NoteDictionary>().InRequestScope();  // новый объект на каждый запрос
        }
    }
}