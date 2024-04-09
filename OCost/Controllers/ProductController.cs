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
        [HttpPost]
        public IActionResult AddProduct(CreateUpdateProductDto dto)
        {
            _service.ProductService.AddProduct(dto);
            return Ok("Product added successfully");
        }
    }
}
