using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WashingMachine : Appliance
    {
        public int MaxLoad { get; set; } // Максимальная загрузка

        public WashingMachine(int price, int power, int year, int maxLoad)
            : base(price, power, year)
        {
            MaxLoad = maxLoad;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"Стиральная машина: Цена: {Price} руб, Мощность: {Power} Вт, Год: {Year}, Максимальная загрузка: {MaxLoad} кг");
        }
    }
}