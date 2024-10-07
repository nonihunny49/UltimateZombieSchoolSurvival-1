using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateZombieSchoolSurvival_1
{
    internal class LogIn
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public LogIn(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public bool Authenticate()
        {

        }

        public void LogOut()
        {

        }

    }
}
