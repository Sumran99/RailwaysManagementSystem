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
    class ReservationBL
    {
        private ReservationDL reservationDL;
        public ReservationBL()
        {
            reservationDL = new ReservationDL();
        }
        public DataTable GetAllPassengerCode()
        {
            return reservationDL.GetPassengerCode();
        }
        public DataTable GetAllTravelCode()
        {
            return reservationDL.GetTravelCode();
        }
        public DataTable GetPassengerNames(ReservationDTO reservationDTO)
        {
            return reservationDL.GetPassengerNamesFromDB(reservationDTO);
        }
        public DataTable GetTravelDetails(ReservationDTO reservationDTO)
        {
            return reservationDL.GetTravelDetailsFromDB(reservationDTO);
        }
        public string InsertData(ReservationDTO reservationDTO)
        {
            return reservationDL.InsertIntoDB(reservationDTO);
        }
        public  DataSet GetReservation()
        {
            return reservationDL.GetCurrentReservations();
        }
    }
}
