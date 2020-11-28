using _1b.IskalievaLE.BLL;
using _1b.IskalievaLE.BLL.Interface;
using _1b.IskalievaLE.Common;
using _1b.IskalievaLE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1b.IskalievaLE.ConsolePL
{
    public static class LogicPl
    {
        //private static IInventoryLogic inventoryLogic = new InventoryLogic();
        private static IInventoryLogic inventoryLogic = DependencyResolver.InventoryLogic;

        //private static IRequestLogic requestLogic = new RequestLogic();
        private static IRequestLogic requestLogic = DependencyResolver.RequestLogic;

        public static void AddRequest()
        {
            Console.WriteLine("Введите дату создания");
            var dateOfCreation = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Введите id стандартного инвентаря");
            var id_Inventory = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите количество");
            var amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите комментарий");
            var comment = Console.ReadLine();

            var currentRequest = new Request
            {
                DateOfCreation = dateOfCreation,
                Id_Inventory = id_Inventory,
                Amount = amount,
                Comment = comment,
            };

            requestLogic.AddRequest(currentRequest);
        }

        public static void GetAllInventory()
        {
            var collection = inventoryLogic.GetAllInventory();
            foreach (var item in inventoryLogic.GetAllInventory())
            {
                Console.WriteLine(item);
            }
        }
        public static void GetAllRequests()
        {
            var collection = requestLogic.GetAllRequests();
            foreach (var item in requestLogic.GetAllRequests())
            {
                Console.WriteLine(item);
            }
        }

        public static void GetRequest()
        {
            Console.WriteLine("Введите id заявки:");
            int id = int.Parse(Console.ReadLine());
            var collection = requestLogic.GetRequest(id);
            foreach (var item in requestLogic.GetRequest(id))
            {
                Console.WriteLine(item);
            }
        }

    }
}
