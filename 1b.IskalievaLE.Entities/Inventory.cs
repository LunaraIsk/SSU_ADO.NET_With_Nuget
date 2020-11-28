using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1b.IskalievaLE.Entities
{
    public class Inventory
    {
        public int IdInventory { get; set; }

        public string Name { get; set; }
        public override string ToString()
        {
            return $"{IdInventory} {Name}";
        }

    }
}
