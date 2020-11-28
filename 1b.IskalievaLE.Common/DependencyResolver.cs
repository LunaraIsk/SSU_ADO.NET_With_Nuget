using _1b.IskalievaLE.BLL;
using _1b.IskalievaLE.BLL.Interface;
using _1b.IskalievaLE.DAL;
using _1b.IskalievaLE.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1b.IskalievaLE.Common
{
    public static class DependencyResolver
    {
        private static IInventoryDao _inventoryDao;

        public static IInventoryDao InventoryDao => _inventoryDao ?? (_inventoryDao = new
            InventoryDao());

        private static IInventoryLogic _inventoryLogic;

        public static IInventoryLogic InventoryLogic => _inventoryLogic ?? (_inventoryLogic = 
            new InventoryLogic(InventoryDao));


        private static IRequestDao _requestDao;

        public static IRequestDao RequestDao => _requestDao ?? (_requestDao = new
            RequestDao());

        private static IRequestLogic _requestLogic;

        public static IRequestLogic RequestLogic => _requestLogic ?? (_requestLogic =
            new RequestLogic(RequestDao));

    }
}
