using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayManagementSystem.DTO
{
    class ReservationDTO
    {
        private int _pID;
        private int _travCode;
        private string _name;
        private string _travdate;
        private string _travSrc;
        private string _travDest;
        private int _travCost;

        public ReservationDTO()
        {

        }

        public int PID { get => _pID; set => _pID = value; }
        public int TravCode { get => _travCode; set => _travCode = value; }
        public string Name { get => _name; set => _name = value; }
        public string Travdate { get => _travdate; set => _travdate = value; }
        public string TravSrc { get => _travSrc; set => _travSrc = value; }
        public string TravDest { get => _travDest; set => _travDest = value; }
        public int TravCost { get => _travCost; set => _travCost = value; }
    }
}
