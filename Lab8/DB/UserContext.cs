using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class UserContext : DbContext
    {
        public UserContext() :base("Data Source=.\\SQLEXPRESS;Initial Catalog=aspnetcore;Integrated Security=True") { }

        public DbSet<user> user;
    }
}
