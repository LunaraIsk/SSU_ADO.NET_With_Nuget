using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1b.IskalievaLE.Entities
{
    public class Request
    {
        public int IdRequest { get; set; }

        public DateTime DateOfCreation { get; set; }

        public int Id_Inventory { get; set; }

        public int Amount { get; set; }

        public string Comment { get; set; }

        public override string ToString()
        {
            return $"{IdRequest} {DateOfCreation} {Id_Inventory} {Amount} {Comment}";
        }

    }
}
