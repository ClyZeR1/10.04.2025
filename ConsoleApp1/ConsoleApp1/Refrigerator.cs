using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Refrigerator : Appliance
    {
        public int Volume { get; set; } // Объем

        public Refrigerator(int price, int power, int year, int volume)
            : base(price, power, year)
        {
            Volume = volume;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"Холодильник: Цена: {Price} руб, Мощность: {Power} Вт, Год: {Year}, Объем: {Volume} литров");
        }
    }
}