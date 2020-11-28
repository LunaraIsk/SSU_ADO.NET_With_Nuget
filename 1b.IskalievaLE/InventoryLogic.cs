using _1b.IskalievaLE.BLL.Interface;
using _1b.IskalievaLE.DAL;
using _1b.IskalievaLE.DAL.Interface;
using _1b.IskalievaLE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1b.IskalievaLE.BLL
{
    public class InventoryLogic: IInventoryLogic
    {
        private readonly IInventoryDao _inventoryDao;
        public InventoryLogic(IInventoryDao inventoryDao)
        {
            this._inventoryDao = new InventoryDao();
        }

        public IEnumerable<Inventory> GetAllInventory()
        {
            return this._inventoryDao.GetAllInventory();
        }
    }
}
