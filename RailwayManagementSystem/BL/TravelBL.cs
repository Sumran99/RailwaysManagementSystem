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
    class TravelBL
    {
        private TravelDL travelDL;
        public TravelBL()
        {
            travelDL = new TravelDL();
        }
        public DataSet GetSchedule()
        {
            return travelDL.GetCurrentSchedule();
        }
        public string InsertData(TravelDTO travelTO)
        {
            return travelDL.InsertIntoDB(travelTO);
        }

        public DataTable GetTrainCodes()
        {
            return travelDL.GetTrainCode();
        }
        public string UpdatSchedule(TravelDTO travelDTO, int key)
        {
            return travelDL.UpdateScheduleInDB(travelDTO, key);
        }
        public string changeTrainStatus(int key)
        {
            return travelDL.changeTrainStatusInDB(key);
        }
    }
}
