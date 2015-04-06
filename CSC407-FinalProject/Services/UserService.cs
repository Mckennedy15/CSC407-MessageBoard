using CSC407_FinalProject.Data;
using CSC407_FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSC407_FinalProject.Services
{
    public class UserService : IUserService
    {

        private MessageBoardDbContext context;
        private IEncryptor encryptor;

        public UserService(IEncryptor encryptor)
        {
            this.encryptor = encryptor;
            this.context = new MessageBoardDbContext();
        }


        public bool Authenticate(string username, string password)
        {
            // if username (case insensitive search) and password match
            // return true
            // otherwise return false

            string encryptedPassword = this.encryptor.Encrypt(password);

            User user = this.context.Users.Where(x => x.Username.ToLower() == username.ToLower()
                && x.Password == encryptedPassword).SingleOrDefault();

            if (user == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        public void Register(User user)
        {
            user.Password = this.encryptor.Encrypt(user.Password);

            this.context.Users.Add(user);
            this.context.SaveChanges();
        }

        public bool Exists(string username)
        {
            User user = this.context.Users.Where(x => x.Username.ToLower() == username.ToLower()).SingleOrDefault();

            if (user == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}