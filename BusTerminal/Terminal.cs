using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTerminal
{
    public class Terminal
    {
        List<Company> companies = new List<Company>();
        public string title { get; set; }



        public string getString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public int getInt(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        public void newCompany()
        {

            Company company = new Company(getInt("Enter the comapny ID:"), getString("Enter the comapny Title: "));

            this.companies.Add(company);
            Console.WriteLine("New company added with this " + company.CompanyId + " id");
        }

        public void newBus(int companyId)
        {

            Bus bus = new Bus();
            bus.busId = getInt("Enter the bus id: ");
            bus.model = getString("Enter the bus mode: ");

            foreach (Company company in companies)
            {
                if (company.CompanyId == companyId)
                {
                    companies.Add(company);
                }

            }
            Console.WriteLine("New buses added with this " + bus.busId + " " + bus.model + " information");


        }
        public void newPassenger(int busId)
        {
            Passenger passenger = new Passenger();
            passenger.Name = getString("Enter the passenger name: ");
            passenger.Surname = getString("Enter the passenger surname: ");
            passenger.PassengerId = getInt("Enter the passenger ıd: ");
            Ticket t = new Ticket(getInt("Enter the ticket ID: "), getString("Enter the ticket Info: "));
            passenger.setTicket(t);

            passenger.setTicket(new Ticket(getInt("Enter the ticket ıd: "), getString("Enter the ticket info: ")));


            foreach (Company company in companies)
            {
                foreach (Bus bus in company.busses)
                {
                    if (bus.busId == busId)
                    {
                        bus.addPassenger(passenger);
                    }
                }
            }




            Console.WriteLine("New passenger added with this " + passenger.PassengerId + " " + passenger.Name + " " + passenger.Surname);



        }


        public void getBuses()
        {
            foreach (Company company in companies)
            {
                Console.WriteLine(company.CompanyId + " " + company.Tittle);
                foreach (Bus bus in company.busses)
                {
                    Console.WriteLine(bus.busId + " " + bus.model);
                }
            }
            companies.ForEach(c => c.busses.ForEach(b => Console.WriteLine(b.busId + " " + b.busId + " " + c.Tittle)));


        }

        public void getBuses(int companyId)
        {
            foreach (Company company in companies)
            {
                if (company.CompanyId == companyId)
                {
                    Console.WriteLine(company.CompanyId + " " + company.Tittle);
                    foreach (Bus bus in company.busses)
                    {
                        Console.WriteLine(bus.busId + " " + bus.model);
                    }
                }
            }

        }
        public void getPassengers()
        {
            foreach (Company company in companies)
            {
                Console.WriteLine(company.CompanyId + " " + company.Tittle);
                foreach (Bus bus in company.busses)
                {
                    Console.WriteLine(bus.busId + "" + bus.model);
                    foreach (Passenger passenger in bus.passengers)
                    {
                        Console.WriteLine(passenger.PassengerId + " " + passenger.Name + " " + passenger.Surname);
                    }
                }
            }




        }
    }
}
