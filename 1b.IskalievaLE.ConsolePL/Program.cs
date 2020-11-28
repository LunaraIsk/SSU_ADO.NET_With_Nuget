using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1b.IskalievaLE.ConsolePL
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A = true;
            while (A)
            {
                Console.WriteLine("1 - вывести список стандартного инвентаря");
                Console.WriteLine("2 - создать заявку");
                Console.WriteLine("3 - просмотреть заявку");
                Console.WriteLine("4 - вывести список созданных заявок");
                Console.WriteLine();
                Console.WriteLine("Введите действие:");
                var action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        LogicPl.GetAllInventory();
                        break;
                    case "2":
                        LogicPl.AddRequest();
                        break;
                    case "3":
                        LogicPl.GetRequest();
                        break;
                    case "4":
                        LogicPl.GetAllRequests();
                        break;
                    default:
                        A = false;
                        break;
                }
            }
        }
    }
}
