using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Truck : Vehicle
    {
        public Truck(string model, int year) : base(model, year)
        {
            Console.WriteLine("Vehicle type: Truck");
        }
        public Truck(string model, int year, double carryingCapacity) : this(model,year)
        {
            CarryingCapacity = carryingCapacity;
        }
        double CarryingCapacity;
    }
}
