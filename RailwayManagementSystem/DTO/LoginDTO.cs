using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayManagementSystem.DTO
{
    class LoginDTO
    {
        private string _username;
        private string _password;
        public LoginDTO()
        {

        }

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
