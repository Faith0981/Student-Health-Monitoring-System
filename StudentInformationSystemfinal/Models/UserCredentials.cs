using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystemfinal.Models
{
    public class UserCredentials
    {
        private string _username = "1";
        private string _password = "1";
        public string Username { get { return _username; } private set { _username = value; } }
        public string Password { get { return _password; } private set { _password = value; } }
    }
}
