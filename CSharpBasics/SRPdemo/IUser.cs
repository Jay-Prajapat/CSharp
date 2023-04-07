using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPdemo
{
    interface IUser
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);
    }
    interface ILogError
    {
        void LogError(string error);
    }
    interface IEmail
    {
        void SendEmail(string emailContent);
    }
}
