using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class user
    {
        public int id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string status { get; set; }
        public string role { get; set; }

        public user(string lastName, string firstname, string email, string password, string status, string role)
        {
            this.lastName = lastName;
            this.firstName = firstname;
            this.email = email;
            this.password = password;
            this.status = status;
            this.role = role;
        }
    }
}
