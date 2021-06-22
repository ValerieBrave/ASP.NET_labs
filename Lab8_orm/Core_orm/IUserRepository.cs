using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_orm
{
    public interface IUserRepository
    {
        List<user> GetAllUsers();
        user GetUserById(int id);
        user AddUser(user user);
        user EditUser(user user);
        user DeleteUser(int id);

    }
}
