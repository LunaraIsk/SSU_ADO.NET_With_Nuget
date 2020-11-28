using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1b.IskalievaLE.WebPl.ViewModels.AppRequest
{
    public class RequestVM
    {
        public int IdRequest { get; set; }

        public DateTime DateOfCreation { get; set; }

        public int Id_Inventory { get; set; }

        public int Amount { get; set; }

        public string Comment { get; set; }
    }
}