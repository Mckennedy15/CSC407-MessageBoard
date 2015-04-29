using CSC407_FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC407_FinalProject.Services
{
    public interface IUserService
    {
        List<User> GetUsers();
        bool Authenticate(string username, string password);

        void Register(User user);

        bool Exists(string username);

        void DeleteUser(int id);

        void SaveUser(User user);
        User GetUser(string userName);

    }
}
