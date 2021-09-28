using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayManagementSystem.DTO
{
    class PassengerDTO
    {
        private string _pName;
        private string _pAddress;
        private string _pPhone;
        private string _pGender;
        public PassengerDTO()
        {

        }

        public string PName { get => _pName; set => _pName = value; }
        public string PAddress { get => _pAddress; set => _pAddress = value; }
        public string PPhone { get => _pPhone; set => _pPhone = value; }
        public string PGender { get => _pGender; set => _pGender = value; }
    }
}
