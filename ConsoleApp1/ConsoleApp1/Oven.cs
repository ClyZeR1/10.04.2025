using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Oven : Appliance
    {
        public string HeatingType { get; set; } // Тип нагрева

        public Oven(int price, int power, int year, string heatingType)
            : base(price, power, year)
        {
            HeatingType = heatingType;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"Духовка: Цена: {Price} руб, Мощность: {Power} Вт, Год: {Year}, Тип нагрева: {HeatingType}");
        }
    }
}