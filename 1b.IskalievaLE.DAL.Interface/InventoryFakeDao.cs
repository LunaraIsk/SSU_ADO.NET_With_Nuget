using _1b.IskalievaLE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1b.IskalievaLE.DAL.Interface
{
    public class InventoryFakeDao: IInventoryDao
    {
        private static Dictionary<int, Inventory> _repoInventory;

        public InventoryFakeDao()
        {
            _repoInventory = new Dictionary<int, Inventory>();
        }
        public IEnumerable<Inventory> GetAllInventory()
        {
            return _repoInventory.Values;
        }
    }
}
