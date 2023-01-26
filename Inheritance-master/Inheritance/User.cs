using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class User
    {
        //Attributes
        private string realname;
        private string username;
        private string password;

        //Getters & Setters
        public string Realname
            { get { return realname; } set { realname = value; } }
        public string Username
            { get { return username; } set { username = value; } }
        public string passwordHash
        {
            get { return password; } set { password = value; } 
        }
        
        // Check Password
        public virtual bool CheckPassword (string pass)
        {
            if (pass.ToLower().Equals(password.ToLower()))
            {
                return true;
            }
            return false;
        }
    }
}
