using _1b.IskalievaLE.Entities;
using _1b.IskalievaLE.WebPl.ViewModels.AppInventory;
using _1b.IskalievaLE.WebPl.ViewModels.AppRequest;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1b.IskalievaLE.WebPl.App_Start
{
    public class AutoMapperWebConfiguration : Profile
    {
        public AutoMapperWebConfiguration()
        {
            CreateMap<Inventory, InventoryVM>()
                .ForMember(emp => emp.NameVm, map => map.MapFrom(p => p.Name));
            CreateMap<Request, RequestVM>();
        }
    }
}