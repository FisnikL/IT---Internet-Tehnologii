using System;

namespace Lab1_1
{
    class Destination : IEquatable<Destination>
    {
        public Destination(string name)
        {
            this.Name = name.ToUpper();
            this.Price = this.Name.Length * 2000;
        }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool Equals(Destination other)
        {
            if (other == null) return false;
            return (this.Name.Equals(other.Name));
        }
        public override string ToString()
        {
            return $"{Name} {Price}";
        }
    }
}
