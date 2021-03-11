using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShopTelerikBlazor.Data.Enums;

namespace OnlineShopTelerikBlazor.Data
{
    public class Product
    {
        public int? ProductId { get; set; }

        public string ProductName { get; set; }

        public int UnitInStock { get; set; }

        public decimal UnitPrice { get; set; }

        public Gender Gender { get; set; }

        public string ImageUrl { get; set; }

        public Product()
        {
        }
    }
}
