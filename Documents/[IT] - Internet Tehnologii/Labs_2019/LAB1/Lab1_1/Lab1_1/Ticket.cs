using System;

namespace Lab1_1
{
    class Ticket
    {
        private string nameClient;
        private string surnameClient;
        private int age;

        public Ticket(string nameClient, string surnameClient, int age, Destination destination)
        {
            this.nameClient = nameClient;
            this.surnameClient = surnameClient;
            this.age = age;
            this.Dest = destination;
            this.Time = DateTime.Now;
            this.Price = Dest.Price;
        }

        public DateTime Time
        {
            get; set;
        }

        public int Price
        {
            get; set;
        }
        public Destination Dest
        {
            get; set;
        }
        public override string ToString()
        {
            return $"{nameClient} {surnameClient} {age} {Dest} {Time} {Price}";
        }
    }
}
