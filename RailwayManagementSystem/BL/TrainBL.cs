using RailwayManagementSystem.DL;
using RailwayManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayManagementSystem.BL
{
    class TrainBL
    {
        private TrainDL trainDL;
        public TrainBL()
        {
            trainDL = new TrainDL();
        }
        public string InsertData(TrainDTO trainDTO)
        {
             return  trainDL.InsertIntoDB(trainDTO);
        }
        public string RemoveTrain(int trainKey)
        {
            return trainDL.RemoveTrainFromDB(trainKey);
        }
        public DataSet GetAllTrains()
        {
            return trainDL.GetCurrentTrains();
        }
        public string UpdateTrainDetails(TrainDTO trainDTO, int key)
        {
            return trainDL.UpdateTrainInDB(trainDTO, key);
        }


    }
}
