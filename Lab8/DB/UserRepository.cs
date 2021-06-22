using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class UserRepository : IUserRepository
    {
        UserContext userContext = new UserContext();
        public user AddUser(user user)
        {
            userContext.user.Add(user);
            userContext.SaveChanges();
            return user;
        }

        public user GetUserById(int id)
        {
            return userContext.user.Where(u => u.id == id).FirstOrDefault();
        }

        public user DeleteUser(int id)
        {
            user user = GetUserById(id);
            userContext.user.Remove(user);
            userContext.Entry(user).State = System.Data.Entity.EntityState.Deleted;
            userContext.SaveChanges();
            return user;
        }

        public user EditUser(user user)
        {
            user to_edit = GetUserById(user.id);
            to_edit.firstName = user.firstName;
            to_edit.lastName = user.lastName;
            to_edit.email = user.email;
            to_edit.password = user.password;
            to_edit.status = user.status;
            to_edit.role = user.role;
            userContext.Entry(to_edit).State = System.Data.Entity.EntityState.Modified;
            userContext.SaveChanges();
            return to_edit;
        }

        public List<user> GetAllUsers()
        {
            return userContext.user.ToList();
        }

        
    }
}
