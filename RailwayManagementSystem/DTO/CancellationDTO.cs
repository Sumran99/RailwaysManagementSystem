using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayManagementSystem.DTO
{
    class CancellationDTO
    {
        private int _ticketId;
        public CancellationDTO()
        {

        }

        public int TicketId { get => _ticketId; set => _ticketId = value; }
    }
}
