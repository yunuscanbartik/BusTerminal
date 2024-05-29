using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTerminal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Terminal terminal = new Terminal();

            terminal.newCompany();
            terminal.newCompany();

            terminal.newBus(6);
            terminal.newBus(6);

            terminal.getPassengers();
            terminal.getBuses();
            Console.ReadLine();

        }

    }
}
