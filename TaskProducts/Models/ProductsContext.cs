﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskProducts.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
        {

        }
     
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductsReleaseDate> ProductsReleaseDates { get; set; }
    }
}
