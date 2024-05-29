using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTerminal
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string  Tittle { get; set; }
        public List<Bus> busses = new List<Bus>();
        public Company(int id, string tittle) 
        {
            this.CompanyId = id;
            this.Tittle = tittle;
        }
    }
}
