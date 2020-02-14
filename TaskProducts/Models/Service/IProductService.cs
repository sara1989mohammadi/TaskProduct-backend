using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskProducts.Models.Service
{
    public interface IProductService
    {
        Task<ProductViewModel> GetProduct(int id);

        Task<IEnumerable<ProductViewModel>> GetProduct();

        Task<Product> AddProduct(Product product);

        Task<Product> UpdataProduct(int id, Product product);

        Task<bool> Delete(int id);

        bool AddAll(params Product[] products);
    }
}
