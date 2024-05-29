using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTerminal
{
    public class Bus
    {
        public int busId { get; set; }
        public string model { get; set; }
        public List<Passenger> passengers = new List<Passenger>();
        public Company company { get; set; }
        public void setCompany(Company company)
        {
            this.company = company;
        }
        public void addPassenger(Passenger passenger)
        {
            passengers.Add(passenger);
        }
    }
}
