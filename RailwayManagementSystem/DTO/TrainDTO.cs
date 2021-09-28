using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayManagementSystem.DTO
{
    class TrainDTO
    {
        private string _trainName;
        private int _trainCapacity;
        private string _trainStatus;
        
        public TrainDTO()
        {

        }

        public string TrainName { get => _trainName; set => _trainName = value; }
        public int TrainCapacity { get => _trainCapacity; set => _trainCapacity = value; }
        public string TrainStatus { get => _trainStatus; set => _trainStatus = value; }
        
    }
}
