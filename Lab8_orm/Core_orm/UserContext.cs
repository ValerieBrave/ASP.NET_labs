using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_orm
{
    public class UserContext : DbContext
    {
        public DbSet<user> user { get; set; }
        public UserContext() 
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-BCBSGG7\SQLEXPRESS;Database=aspnetcore;Trusted_Connection=True;");
        }

        
    }
}
