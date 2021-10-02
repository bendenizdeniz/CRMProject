using Business.Interfaces;
using DAL.Interfaces;
using Entity;
using System.Collections.Generic;

namespace Business.EntityBusiness
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserManager(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }

        public User CreateUser(User user)
        {
            return userRepository.CreateUser(user);
        }
        public User GetUserByEmail(string email)
        {
            return userRepository.GetUserByEmail(email);
        }

        public void DeleteUser(int id)
        {
            userRepository.DeleteUser(id);
        }

        public List<User> GetAllUser()
        {
            return userRepository.GetAllUsers();
        }

        public User GetUserById(int id)
        {
            return userRepository.GetUserById(id);
        }

        public User GetUserByName(string userName)
        {
            return userRepository.GetUserByName(userName);
        }

        public User UpdateUser(User user)
        {
            return userRepository.UpdateUser(user);
        }

        public User UserLogin(User user)
        {
            return userRepository.UserLogin(user);
        }
    }
}
