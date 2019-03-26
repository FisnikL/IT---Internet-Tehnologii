using System;
using static System.Console;

namespace Lab1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            World agency = new World(4);

            int service = -1;
            string menu = "Menu of Services:\n" +
                "1 - Serve The Client\n" +
                "2 - Ordered Tickets of Counter X\n" +
                "3 - Total Profit of Counter X\n" +
                "4 - Ordered Tickets Per Counter\n" +
                "5 - Total Profit of Agency\n" +
                "6 - Success of Agency\n" +
                "0 - Exit\n";
            WriteLine(menu);

            //agency.PrintDestinations();
            
            do
            {
                Write("Num of Service: ");
                service = int.Parse(ReadLine());
                if (!(service <= 6 && service >= 0))
                {
                    WriteLine("Valid numbers of services are from 0 to 6. Try AGAIN!");
                    continue;
                }
                else if (service == 0)
                {
                    break;
                }
                else if (service == 1)
                {
                    WriteLine("Insert Name, Surname, Age, Destination, Counter");
                    agency.ServeTheClient();
                }
                else if(service == 2)
                {
                    WriteLine("Insert Counter number");
                    int counter = int.Parse(ReadLine());
                    WriteLine("Im going to take default DateTime.");
                    DateTime start = DateTime.Today.Subtract(new TimeSpan(24,0,0));
                    DateTime end = DateTime.Today.Add(new TimeSpan(24, 0, 0));
                    agency.OrderedTickets(counter, start, end);
                }
                else if(service == 3)
                {
                    WriteLine("Insert Counter number");
                    int counter = int.Parse(ReadLine());
                    WriteLine("Im going to take default DateTime.");
                    DateTime start = DateTime.Today.Subtract(new TimeSpan(24, 0, 0));
                    DateTime end = DateTime.Today.Add(new TimeSpan(24, 0, 0));
                    agency.TotalProfitOfCounter(counter, start, end);
                }
                else if(service == 4)
                {
                    WriteLine("Im going to take default DateTime.");
                    DateTime start = DateTime.Today.Subtract(new TimeSpan(24, 0, 0));
                    DateTime end = DateTime.Today.Add(new TimeSpan(24, 0, 0));
                    agency.OrderedTicketsPerCounterInInterval(start, end);
                }
                else if(service == 5)
                {
                    agency.TotalProfitOfAgency();
                }
                else
                {
                    agency.AgencySuccess();
                }
                //WriteLine($"Result: {service}");
            } while (true);
            ReadKey();
        }
    }
}
