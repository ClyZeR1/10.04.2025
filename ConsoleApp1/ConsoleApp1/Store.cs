using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Store
    {
        public List<WashingMachine> WashingMachines { get; set; } = new List<WashingMachine>();
        public List<Refrigerator> Refrigerators { get; set; } = new List<Refrigerator>();
        public List<Oven> Ovens { get; set; } = new List<Oven>();

        public void AddWashingMachine(int price, int power, int year, int maxLoad)
        {
            WashingMachines.Add(new WashingMachine(price, power, year, maxLoad));
        }
        public void AddRefrigerator(int price, int power, int year, int volume)
        {
            Refrigerators.Add(new Refrigerator(price, power, year, volume));
        }
        public void AddOven(int price, int power, int year, string heatingType)
        {
            Ovens.Add(new Oven(price, power, year, heatingType));
        }
        public void ShowAllWashingMachines()
        {
            foreach (var wm in WashingMachines)
            {
                wm.ShowDetails();
            }
        }

        public void ShowAllRefrigerators()
        {
            foreach (var fridge in Refrigerators)
            {
                fridge.ShowDetails();
            }
        }
        public void ShowAllOvens()
        {
            foreach (var oven in Ovens)
            {
                oven.ShowDetails();
            }
        }
    }
}