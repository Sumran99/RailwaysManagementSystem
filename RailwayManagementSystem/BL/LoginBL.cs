using RailwayManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayManagementSystem.BL
{
    class LoginBL
    {
        public LoginBL()
        {

        }
        public bool verifyUser(LoginDTO loginDTO)
        {
            if (loginDTO.Username.Equals("Admin") && loginDTO.Password.Equals("Admin"))
                return true;
            return false;
            
        }
    }
}
