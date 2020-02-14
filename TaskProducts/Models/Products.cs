using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskProducts.Models
{

    public class Product
    {
        [Key]
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
    public class ProductsReleaseDate
    {
        [Key]
        public int ProductsReleaseDateId { get; set; }
        public string ReleasedOn { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}

