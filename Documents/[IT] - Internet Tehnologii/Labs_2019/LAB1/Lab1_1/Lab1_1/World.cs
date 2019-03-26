using System;
using static System.Console;
using System.Collections.Generic;

namespace Lab1_1
{
    public class World
    {
        private int numCounters;
        private List<Counter> counters;
        private List<Destination> destinations;
        private int totalClients;
        private int servedClients;
        private long totalProfitOfAgency;

        public World(int numCounters)
        {
            this.numCounters = numCounters;

            this.counters = new List<Counter>();

            for (int i = 0; i < numCounters; ++i){ this.counters.Add(new Counter(i + 1));}

            totalClients = 0;
            servedClients = 0;

            destinations = new List<Destination>();
            destinations.Add(new Destination("Rim"));
            destinations.Add(new Destination("London"));
            destinations.Add(new Destination("Tokio"));
            destinations.Add(new Destination("Sofija"));
            destinations.Add(new Destination("Istanbul"));
            destinations.Add(new Destination("Toronto"));
            destinations.Add(new Destination("Majami"));
            destinations.Add(new Destination("Zagreb"));
            destinations.Add(new Destination("Belgrad"));
            destinations.Add(new Destination("Moskva"));
        }

        public void AddDestination(string destination)
        {
            destinations.Add(new Destination(destination));
        }

        public void AddCounter(string counter)
        {
            counters.Add(new Counter(numCounters));
            numCounters++;
        }

        public void PrintDestinations()
        {
            foreach(Destination d in destinations)
            {
                WriteLine(d.Name);
            }
        }

        public bool DestinationExists(string destination)
        {
            return destinations.Contains(new Destination(destination));
        }
        
        public void ServeTheClient()
        {
            totalClients++;
            //WriteLine("Serving a client...");
            //WriteLine("Name: ");
            string name = ReadLine();
            //WriteLine("Surname: ");
            string surname = ReadLine();
            //WriteLine("Age: ");
            int age = int.Parse(ReadLine());

            //WriteLine("Destination: ");
            string dest = ReadLine();
            int counter = int.Parse(ReadLine());
            if (!DestinationExists(dest))
            {
                WriteLine($"Destination {dest} not included!");
                return;
            }
            Destination d = new Destination(dest);
            counters[counter - 1].OrderTicket(new Ticket(name, surname, age, d));
            totalProfitOfAgency += d.Price;
            WriteLine("####### TICKET ORDERED. ########");
            servedClients++;
        }

        public void OrderedTickets(int counter, DateTime start, DateTime end){
            counters[counter - 1].OrderedTicketsInInterval(start, end);
        }

        public void TotalProfitOfCounter(int counter, DateTime start, DateTime end){
            counters[counter - 1].TotalProfitPerCounter(start, end);
        }

        public void OrderedTicketsPerCounterInInterval(DateTime start, DateTime end)
        {
            foreach (Counter counter in counters)
            {
                WriteLine($"Counter {counter.Number}:");
                foreach(Ticket ticket in counter.GetTicketsInInterval(start, end))
                {
                    WriteLine($"\t{ticket}");
                }
            }
        }
        public void TotalProfitOfAgency()
        {
            WriteLine($"Total profit of Agency is: {totalProfitOfAgency}");
        }
        public void AgencySuccess()
        {
            double success = servedClients * 1.0 / totalClients;
            WriteLine($"Success of Agency: {Math.Round(success, 2)}");
        }
    }
}
