using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            while (true)
            {
                Console.WriteLine(@"Выберите действие:
            1. Добавить стиральную машину;
            2. Добавить холодильник;
            3. Добавить духовку;
            4. Показать все стиральные машины;
            5. Показать все холодильники;
            6. Показать все духовки;
            7. Выход.");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите цену стиральной машины:");
                            int price = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите мощность стиральной машины:");
                            int power = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите год выпуска стиральной машины:");
                            int year = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите максимальную загрузку стиральной машины:");
                            int maxLoad = Convert.ToInt32(Console.ReadLine());

                            store.AddWashingMachine(price, power, year, maxLoad);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите цену холодильника:");
                            int price = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите мощность холодильника:");
                            int power = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите год выпуска холодильника:");
                            int year = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите объем холодильника:");
                            int volume = Convert.ToInt32(Console.ReadLine());

                            store.AddRefrigerator(price, power, year, volume);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Введите цену духовки:");
                            int price = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите мощность духовки:");
                            int power = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите год выпуска духовки:");
                            int year = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите тип нагрева духовки:");
                            string heatingType = Console.ReadLine();

                            store.AddOven(price, power, year, heatingType);
                            break;
                        }
                    case 4:
                        Console.WriteLine("Все стиральные машины:");
                        store.ShowAllWashingMachines();
                        break;
                    case 5:
                        Console.WriteLine("Все холодильники:");
                        store.ShowAllRefrigerators();
                        break;
                    case 6:
                        Console.WriteLine("Все духовки:");
                        store.ShowAllOvens();
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Неверный выбор, попробуйте снова.");
                        break;
                }
            }
        }
    }
}