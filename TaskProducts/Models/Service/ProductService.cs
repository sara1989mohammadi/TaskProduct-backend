using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TaskProducts.Models.Service
{
    public class ProductService : IProductService
    {
        private ProductsContext _context;
        public ProductService(ProductsContext Context)
        {
            _context = Context;
        }


        public async Task<Product> AddProduct(Product product)
        {
            try
            {
                // ProductViewModel viewModel = new ProductViewModel()
                // {
                //     ProductName = product.ProductName,
                //     Version = product.Version,
                //     Size = product.Size,
                //     CompanyName = product.CompanyName,
                //     ProductCategory = product.ProductCategory,
                //     URL = product.URL,
                //     VendorContact = product.VendorContact,
                //     DriverId = product.DriverId
                // }; // اینم الکیه پروداکت اصلی رو گرفتی از روی ویو مدل یه شی ساختی که هیچ ستفاده ای نکردی و نداره
                await _context.AddAsync(product);
                //این جا چیزی ذخیره نمیشه توی دبتابیس
                await _context.SaveChangesAsync();
                return product;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                _context.Products.Remove(FindProduct(id));
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<ProductViewModel> GetProduct(int id)
        {
            try
            {
                var product = await _context.Products.FindAsync(id);
                ProductViewModel viewModel = new ProductViewModel()
                {
                    ProductName = product.ProductName,
                    Version = product.Version,
                    Size = product.Size,
                    CompanyName = product.CompanyName,
                    ProductCategory = product.ProductCategory,
                    URL = product.URL,
                    VendorContact = product.VendorContact,
                    DriverId = product.DriverId

                };
                return viewModel;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<ProductViewModel>> GetProduct()
        {
            try
            {
                return await _context.Products.Select(x => new ProductViewModel()
                {
                    ProductId = x.ProductId,
                    ProductName = x.ProductName,
                    Version = x.Version,
                    Size = x.Size,
                    CompanyName = x.CompanyName,
                    ProductCategory = x.ProductCategory,
                    URL = x.URL,
                    VendorContact = x.VendorContact,
                    DriverId = x.DriverId
                }).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Product> UpdataProduct(int id, Product product)
        {
            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return product;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Product FindProduct(int id)
        {
            try
            {
                return _context.Products.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddAll(params Product[] products)
        {
            foreach (var item in products)
            {
                _context.Add(item);
            }
            _context.SaveChanges();

            return true;
        }
    }
}
