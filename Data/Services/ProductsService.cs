using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShopTelerikBlazor.Data.Enums;

namespace OnlineShopTelerikBlazor.Data
{
    public class ProductsService
    {
        public List<Product> ProductsList { get; set; } = new List<Product>()
        {
            new Product() { ProductId = 1, ProductName = "Adidas Ultraboost 21", UnitInStock = 18, UnitPrice = 10.5m, Gender = 0, ImageUrl = "https://assets.adidas.com/images/w_383,h_383,f_auto,q_auto:sensitive,fl_lossy/ea53db41a68b4a6c9022aca60112f059_9366/ultraboost-21-shoes.jpg"},
            new Product() { ProductId = 2, ProductName = "Adidas ZX 1K BOOST", UnitInStock = 0, UnitPrice = 13m, Gender = 0, ImageUrl = "https://assets.adidas.com/images/w_383,h_383,f_auto,q_auto:sensitive,fl_lossy/abdd5da4d510483b83c1ac0200926997_9366/zx-1k-boost-shoes.jpg"},
            new Product() { ProductId = 3, ProductName = "Adidas ULTRA4D", UnitInStock = 1, UnitPrice = 6m, Gender = 0, ImageUrl = "https://assets.adidas.com/images/h_840,f_auto,q_auto:sensitive,fl_lossy/5ebf76604dca4e6c8abfabe500ba8929_9366/Ultra4D_Shoes_Black_FW7089_02_standard.jpg"},
            new Product() { ProductId = 4, ProductName = "Adidas NMD_R1 V2", UnitInStock = 10, UnitPrice = 6m, Gender = 0, ImageUrl = "https://assets.adidas.com/images/w_383,h_383,f_auto,q_auto:sensitive,fl_lossy/b6810eb5ae454f1da53eac7501328191_9366/nmd_r1-v2-shoes.jpg"},
            new Product() { ProductId = 5, ProductName = "Adidas NMD_R1", UnitInStock = 0, UnitPrice = 33m, Gender = (Gender)1, ImageUrl = "https://assets.adidas.com/images/h_840,f_auto,q_auto:sensitive,fl_lossy/19beb21e57884b499897aa8e00f44c4e_9366/NMD_R1_Shoes_White_FV2475_02_standard.jpg"},
            new Product() { ProductId = 6, ProductName = "Adidas ULTRABOOST 5.0 DNA", UnitInStock = 5, UnitPrice = 22m, Gender = (Gender)1, ImageUrl = "https://assets.adidas.com/images/h_840,f_auto,q_auto:sensitive,fl_lossy/266bc3124a6544fc9edeac7900c4c002_9366/Ultraboost_5.0_DNA_Shoes_Beige_FZ1851_02_standard_hover.jpg"},
            new Product() { ProductId = 7, ProductName = "Adidas SWIFT RUN X", UnitInStock = 22, UnitPrice = 18.9m, Gender = (Gender)1, ImageUrl = "https://assets.adidas.com/images/h_840,f_auto,q_auto:sensitive,fl_lossy/d01dc7dd5694478ea862ac5c01623a04_9366/Swift_Run_X_Shoes_White_H01904_02_standard_hover.jpg"},
            new Product() { ProductId = 8, ProductName = "Adidas CLIMACOOL VENTO HEAT.RDY", UnitInStock = 3, UnitPrice = 15m, Gender = (Gender)1, ImageUrl = "https://assets.adidas.com/images/h_840,f_auto,q_auto:sensitive,fl_lossy/074b79b46f7a42babc26ac7900db407a_9366/Climacool_Vento_HEAT.RDY_Shoes_White_FZ1729_02_standard.jpg"},
            new Product() { ProductId = 9, ProductName = "Adidas EQ21 Run Ch14", UnitInStock = 0, UnitPrice = 21m, Gender = (Gender)2, ImageUrl = "https://images.sportsdirect.com/images/products/03306803_l_a3.jpg"},
            new Product() { ProductId = 10, ProductName = "Adidas Roguera Crt GrJn13", UnitInStock = 13, UnitPrice = 8m, Gender = (Gender)2, ImageUrl = "https://images.sportsdirect.com/images/products/06402601_l_a3.jpg"},
            new Product() { ProductId = 11, ProductName = "Adidas Hoops Mid Jn10", UnitInStock = 13, UnitPrice = 8m, Gender = (Gender)2, ImageUrl = "https://images.sportsdirect.com/images/products/09303603_l_a3.jpg"},
            new Product() { ProductId = 12, ProductName = "Adidas Runfalcon 2", UnitInStock = 13, UnitPrice = 8m, Gender = (Gender)2, ImageUrl = "https://images.sportsdirect.com/images/products/04300002_l_a3.jpg"}
        };
    }
}
