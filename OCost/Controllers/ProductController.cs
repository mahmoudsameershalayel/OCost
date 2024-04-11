using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OCost.Core.APIDtos;
using OCost.Data.DBEntities;
using OCost.Service.Contracts;

namespace OCost.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IServiceManager _service;
        public ProductController(IServiceManager service) => _service = service;
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _service.ProductService.GetAllProducts();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _service.ProductService.GetProductById(id);
            return Ok(product);
        }
        [HttpPost]
        public IActionResult AddProduct(CreateUpdateProductDto dto)
        {
            _service.ProductService.AddProduct(dto);
            return Ok("Product added successfully");
        }
        [HttpPut("{id}")]
        public IActionResult EditProduct(int id, CreateUpdateProductDto dto)
        {
            _service.ProductService.EditProduct(id, dto);
            return Ok(dto);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id) {
            _service.ProductService.DeleteProduct(id);
            return NoContent();
        }


    }
}
