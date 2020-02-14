using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskProducts.Models
{
    public class ProductViewModel
    {    
            public int ProductId { get; set; }
            public string DriverId { get; set; }
            public string ProductName { get; set; }
            public string Version { get; set; }
            public string Size { get; set; }
            public string CompanyName { get; set; }
            public string ProductCategory { get; set; }
            public string URL { get; set; }
            public string VendorContact { get; set; }
            public virtual ProductsReleaseDate productsReleaseDate { get; set; }
       
    }
}
