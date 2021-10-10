using Entity;
using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface IUserService
    {
        User CreateUser(User user);

        List<User> GetAllUser();

        User GetUserById(int id);

        User GetUserByEmail(string email);

        User UpdateUser(User user);

        void DeleteUser(int id);

        User GetUserByName(string userName);

        User UserLogin(User user);
        User UserRegister(User user);
    }
}
