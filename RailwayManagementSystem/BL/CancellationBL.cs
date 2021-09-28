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
    class CancellationBL
    {
        private CancellationDL cancellationDL;
        public CancellationBL()
        {
            cancellationDL = new CancellationDL();
        }
        public DataSet GetTickets()
        {
            return cancellationDL.GetCurrentTickets();
        }
        public DataTable GetTicketsFromDL()
        {
            return cancellationDL.GetTicketsFromDB();
        }
        public string InsertData(CancellationDTO cancellationDTO)
        {
            return cancellationDL.InsertIntoDB(cancellationDTO);
        }
        public void RemoveTicketFromReservation(CancellationDTO cancellationDTO)
        {
            cancellationDL.deleteFromReservation(cancellationDTO);
        }
    }
}
