using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTerminal
{
    public class Passenger
    {
        public int PassengerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Ticket ticket { get; set; }
        public void setTicket(Ticket ticket)
        {
            this.ticket = ticket;
        }
    }
}
