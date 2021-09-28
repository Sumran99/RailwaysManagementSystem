using RailwayManagementSystem.DL;
using RailwayManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayManagementSystem.BL
{
    class PassengerBL
    {
        private PassengerDL passengerDL;
        
        public PassengerBL()
        {
            passengerDL = new PassengerDL();
            
        
        }
        public string  InsertData(PassengerDTO passengerDTO)
        {
            return passengerDL.InsertIntoDB(passengerDTO);
        }
        public string  UpdateData(PassengerDTO passengerDTO, int key)
        {
            return passengerDL.UpdatePassengerInDB(passengerDTO, key);
        }
        public DataSet GetAllPassengers()
        {
            return passengerDL.GetCurrentPassengers();
        }
        public string RemovePassenger(int passengerKey)
        {
            return passengerDL.RemovePassengerFromDB(passengerKey);
        }
    }
}
