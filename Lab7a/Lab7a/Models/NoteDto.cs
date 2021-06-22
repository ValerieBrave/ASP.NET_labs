using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab7a.Models
{
    public class NoteDto
    {
        
            public long NoteId { get; set; }
            public string Fullname { get; set; }
            public string Telephone { get; set; }

            public NoteDto(string name, string num)
            {
                this.NoteId = DateTime.Now.ToFileTime();
                this.Fullname = name;
                this.Telephone = num;
            }
            public NoteDto(long id, string name, string num)
            {
                this.NoteId = id;
                this.Fullname = name;
                this.Telephone = num;
            }

            public NoteDto() { }

            public override string ToString() =>
                NoteId.ToString() + " " + Fullname + " " + Telephone;
        
    }
}