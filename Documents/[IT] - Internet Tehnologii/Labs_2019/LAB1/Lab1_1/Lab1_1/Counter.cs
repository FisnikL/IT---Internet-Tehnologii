using System;
using System.Collections.Generic;
using static System.Console;

namespace Lab1_1
{
    class Counter
    {
        private List<Ticket> orderedTickets;
        public Counter(int num)
        {
            orderedTickets = new List<Ticket>();
            Number = num;
        }
        public int Number
        {
            get; set;
        }
        public void OrderTicket(Ticket ticket)
        {
            orderedTickets.Add(ticket);
        }

        public void OrderedTicketsInInterval(DateTime start, DateTime end)
        {
            List<Ticket> ticketsInInterval = GetTicketsInInterval(start, end);
            WriteLine($"Total number of ordered tickets from Counter {Number}:\t {ticketsInInterval.Count}");
            foreach(Ticket ticket in ticketsInInterval)
            {
                WriteLine($"\t{ticket}");
            }
        }
        public void TotalProfitPerCounter(DateTime start, DateTime end)
        {
            long total = 0;
            List<Ticket> tickets = GetTicketsInInterval(start, end);
            foreach (Ticket ticket in tickets)
            {
                total += ticket.Price;
            }
            WriteLine($"Total Profit from Counter {Number} is:\t{total}");
        }

        public List<Ticket> GetTicketsInInterval(DateTime start, DateTime end)
        {
            List<Ticket> tickets = new List<Ticket>();
            foreach (Ticket ticket in orderedTickets)
            {
                if (ticket.Time.CompareTo(start) >= 0 && ticket.Time.CompareTo(end) <= 0)
                    tickets.Add(ticket);
            }
            return tickets;
        }

    }
}
