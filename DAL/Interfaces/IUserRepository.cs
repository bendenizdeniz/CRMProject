using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();

        User GetUserById(int id);
        User GetUserByEmail(string email);

        User CreateUser(User user);

        User UpdateUser(User user);

        void DeleteUser(int id);

        User GetUserByName(string userName);

        User UserLogin(User user);
        User UserRegister(User user);
    }
}
