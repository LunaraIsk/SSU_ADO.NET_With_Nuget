using _1b.IskalievaLE.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _1b.IskalievaLE.Common;
using DependencyResolver = _1b.IskalievaLE.Common.DependencyResolver;
using AutoMapper;
using _1b.IskalievaLE.WebPl.ViewModels.AppInventory;

namespace _1b.IskalievaLE.WebPl.Controllers
{
    public class InventoryController : Controller
    {
        private readonly IInventoryLogic _inventoryLogic;
        private readonly IMapper _mapper;
        // GET: Inventory

        public InventoryController(IMapper mapper)
        {
            _inventoryLogic = DependencyResolver.InventoryLogic;
            _mapper = mapper;
        }
        /*public InventoryController(IInventoryLogic inventoryLogic,
             IMapper mapper)
        {
            _inventoryLogic = inventoryLogic;
            _mapper = mapper;
        }*/
        public ActionResult Index()
        {
            var inventories = _inventoryLogic.GetAllInventory().ToList();


            var inventoryVM = _mapper.Map<IEnumerable<InventoryVM>>(inventories);



            return View(inventoryVM);
        }
        
    }
}