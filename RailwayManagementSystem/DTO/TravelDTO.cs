using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayManagementSystem.DTO
{
    class TravelDTO
    {
        private DateTime _dateTime;
        private string _trainCode;
        private string _trainSource;
        private string _trainDestination;
        private string _trainCost;
        public TravelDTO()
        {

        }

        public DateTime DateTime { get => _dateTime; set => _dateTime = value; }
        public string TrainCode { get => _trainCode; set => _trainCode = value; }
        public string TrainSource { get => _trainSource; set => _trainSource = value; }
        public string TrainDestination { get => _trainDestination; set => _trainDestination = value; }
        public string TrainCost { get => _trainCost; set => _trainCost = value; }
    }
}
