using _1b.IskalievaLE.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DependencyResolver = _1b.IskalievaLE.Common.DependencyResolver;

namespace _1b.IskalievaLE.Web.Controllers
{
    public class InventoryController : Controller
    {
        private readonly IInventoryLogic _inventoryLogic;

        // GET: Inventory

        public InventoryController()
        {
            _inventoryLogic = DependencyResolver.InventoryLogic;
        }
        public ActionResult Index()
        {
            var inventary = _inventoryLogic.GetAllInventory();
            return View(inventary);
        }
    }
}