using AvisaSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvisaSolution.Service
{
    public interface IUserService
    {
        List<User> GetUsers();
        User GetUser(int id);
        void AddUser(User item);
        void UpdateUser(User item);
        void DeleteUser(int id);
        bool UserExists(int id);
    }
}
