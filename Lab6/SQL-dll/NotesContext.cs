using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_dll
{
    public class NotesContext : DbContext
    {
        public NotesContext() : base("NotesContext") { }

        public DbSet<Note> Notes { get; set; }
    }
}
