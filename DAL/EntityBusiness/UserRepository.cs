using DAL.Interfaces;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.EntityBusiness
{
    public class UserRepository : IUserRepository
    {
        CrmsystemContext context = new CrmsystemContext();


        public UserRepository(CrmsystemContext _context)
        {
            context = _context;
        }

        public User CreateUser(User user)
        {
            context.User.Add(user);
            context.SaveChanges();
            return new User { Username = user.Username, Password = user.Password };
        }

        public void DeleteUser(int id)
        {
            User user = GetUserById(id);
            context.User.Remove(user);
            context.SaveChanges();
        }

        public List<User> GetAllUsers()
        {
            return context.User.ToList();
        }

        public User GetUserById(int id)
        {
            return context.User.Find(id);
        }

        public User GetUserByName(string userName)
        {
            return context.User.FirstOrDefault(x => x.Username == userName);
        }

        public User GetUserByEmail(string email)
        {
            User _email = context.User.FirstOrDefault(x => x.Email == email);
            if (_email != null)
            {
                return _email;
            }
            return null;
        }

        public User UpdateUser(User user)
        {
            context.User.Update(user);
            context.SaveChanges();
            return user;
        }

        public User UserLogin(User user)
        {
            User _user = context.User.FirstOrDefault(x => x.Username == user.Username && x.Password == user.Password);
            if (_user != null)
            {
                return user;
            }
            return null;

        }

        public User UserRegister(User user)
        {
            User _user = context.User.FirstOrDefault(x => x.Username == user.Username || x.Email == user.Email);
            if (_user == null)
            {
                context.User.Add(user);
                context.SaveChanges();
                return new User { Username = user.Username, Password = user.Password, Email = user.Email };
            }
            return null;
        }

    }
}
