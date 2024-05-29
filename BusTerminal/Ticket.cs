using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTerminal
{
    public class Ticket
    {     
            public int TicketId { get; set; }
            public string TicketInfo { get; set; }
            public Ticket(int id, string destination)
            {
                this.TicketId = id;
                this.TicketInfo = destination;
            }
        
    }
}
