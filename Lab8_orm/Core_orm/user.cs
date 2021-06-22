using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_orm
{
    [Serializable]
    public class user
    {
        public int id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string status { get; set; }
        public string role { get; set; }

        public user() { }
        public user(string lastName, string firstName, string email, string password, string status, string role)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.email = email;
            this.password = password;
            this.status = status;
            this.role = role;
        }

       
    }
}
