using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    [Serializable]
    public class Note
    {
        public string fullname;
        public string telephone;

        public Note(string name, string num)
        {
            this.fullname = name;
            this.telephone = num;
        }

        public Note()
        {
            this.fullname = "";
            this.telephone = "";
        }
    }
}