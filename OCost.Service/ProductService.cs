using AutoMapper;
using OCost.API.Infrastructure.Repositories;
using OCost.API.Infrastructure.Services.LoggerService;
using OCost.Core.APIDtos;
using OCost.Data.DBEntities;
using OCost.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Service
{
    public class ProductService : IProductService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;
        public ProductService(IRepositoryManager repositoryManager , ILoggerManager loggerManager , IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
            _mapper = mapper;
        }

        public IList<ProductDto> GetAllProducts()
        {
            try {
                var products = _repositoryManager.ProductRepository.GetAllProducts();
                return _mapper.Map<IList<ProductDto>>(products);   
            } catch (Exception ex) {
                _loggerManager.LogError($"Something went wrong in the {nameof(GetAllProducts)} service method {ex}");
                throw;
            }
        }
        public void AddProduct(CreateUpdateProductDto dto) {
            try
            {    var product = _mapper.Map<Product>(dto);   
                _repositoryManager.ProductRepository.AddProduct(product);
                _repositoryManager.Save();
            }
            catch (Exception ex) {
                _loggerManager.LogError($"Something went wrong in the {nameof(AddProduct)} service method {ex}");
                throw;
            }
        }
    }
}
