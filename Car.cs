using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Car : Vehicle
    {
        public Car(string model, int year) : base(model, year)
        {
            Console.WriteLine("Vehicle type: Car");
        }

        public Car(string model, int year, byte passenger) : this(model, year)
        {
            Passenger = passenger;
        }
        byte Passenger;
    }
}
