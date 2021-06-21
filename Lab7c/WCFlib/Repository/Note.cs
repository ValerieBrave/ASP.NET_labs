using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFlib.Repository
{
    public class Note
    {
        public long NoteId { get; set; }
        public string Fullname { get; set; }
        public string Telephone { get; set; }

        public Note(string name, string num)
        {
            this.NoteId = DateTime.Now.ToFileTime();
            this.Fullname = name;
            this.Telephone = num;
        }
        public Note(long id, string name, string num)
        {
            this.NoteId = id;
            this.Fullname = name;
            this.Telephone = num;
        }

        public Note() { }

        public override string ToString() =>
            NoteId.ToString() + " " + Fullname + " " + Telephone;
    }
}
