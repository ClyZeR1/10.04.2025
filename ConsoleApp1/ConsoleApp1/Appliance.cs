using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Appliance
    {
        public int Price { get; set; }
        public int Power { get; set; }
        public int Year { get; set; }

        public Appliance(int price, int power, int year)
        {
            Price = price;
            Power = power;
            Year = year;
        }

        public abstract void ShowDetails();
    }
}