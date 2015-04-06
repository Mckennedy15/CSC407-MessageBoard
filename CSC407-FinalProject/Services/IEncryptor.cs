using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSC407_FinalProject.Services
{
    public interface IEncryptor
    {
        string Encrypt(string input);
    }
}