using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Vehicle
    {
        string Model;
        int Year;
        public Vehicle()
        {
            Console.Write("Vehicle is created: ");
        }
        public Vehicle(string model) : this()
        {
            Model= model;
        }
        public Vehicle(string model, int year) : this(model) 
        {
            Year= year;
        }
    }
}
