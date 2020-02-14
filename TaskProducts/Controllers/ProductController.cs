using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskProducts.Common;
using TaskProducts.Models;
using TaskProducts.Models.Service;

namespace TaskProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;

        }

        [HttpGet]
        public async Task<IEnumerable<ProductViewModel>> GetProduct()
        {
            return await _service.GetProduct();
        }

        [HttpGet("{id}")]
        public async Task<ApiResult<ProductViewModel>> GetProduct(int id)
        {
            var product = await _service.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                return product;
            }
        }

        [HttpPut("{id}")]
        public async Task<ApiResult<Product>> PutProduct(int id, Product product)
        {
            if (product.ProductId != id)
            {
                return BadRequest();
            }

            return await _service.UpdataProduct(id, product);
        }

        [HttpPost]
        public async Task<ApiResult<Product>> PostProduct(Product product)

        {
            return await _service.AddProduct(product);
        }

        [HttpDelete("{id}")]
        public async Task<ApiResult> DeleteProduct(int id)
        {
          
            if (await _service.Delete(id))
            {
                return Ok();
            }
            return NotFound();
        }

        [HttpPost]
        [Route("addall")]
        public ApiResult AddAll(Product[] products)
        {
            _service.AddAll(products);
            return Ok();
        }
    }
}