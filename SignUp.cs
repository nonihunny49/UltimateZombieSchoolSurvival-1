using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateZombieSchoolSurvival_1
{
    internal class SignUp
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public SignUp(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }

        //Method to validate the user's sign up detail (all field are filled out)
        public bool ValidateDetails()
        {
            //Not null for username, email and password (return false)
            //Use if.. statement for email and username if already registed (return false)
            //Print "Details validated successfully (return true)
        }

        public bool Register()
        {
            //Use if..else statement
            /*New user to database
             * success return true
             * else return false 
             */
        }

    }
}
