using AutoMapper;
using OCost.API.Infrastructure.Errors;
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
        public ProductService(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
            _mapper = mapper;
        }

        public IList<ProductDto> GetAllProducts()
        {
            try
            {
                var products = _repositoryManager.ProductRepository.GetAllProducts();
                return _mapper.Map<IList<ProductDto>>(products);
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Something went wrong in the {nameof(GetAllProducts)} service method {ex}");
                throw;
            }
        }
        public ProductDto GetProductById(int id)
        {
            var product = _repositoryManager.ProductRepository.GetProductById(id);
            if (product == null)
            {
                throw new ProductNotFoundException(id);
            }
            return _mapper.Map<ProductDto>(product);
        }
        public void AddProduct(CreateUpdateProductDto dto)
        {
            try
            {
                var product = _mapper.Map<Product>(dto);
                _repositoryManager.ProductRepository.AddProduct(product);
                _repositoryManager.Save();
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Something went wrong in the {nameof(AddProduct)} service method {ex}");
                throw;
            }
        }
        public void EditProduct(int id, CreateUpdateProductDto dto)
        {
            try
            {
                var product = _repositoryManager.ProductRepository.GetProductById(id);
                if (product == null)
                {
                    throw new ProductNotFoundException(id);
                }
                _mapper.Map(dto, product);
                _repositoryManager.Save();
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Something went wrong in the {nameof(EditProduct)} service method {ex}");
                throw;
            }
        }

        public void DeleteProduct(int id)
        {
            try
            {
                var product = _repositoryManager.ProductRepository.GetProductById(id);
                if (product == null)
                {
                    throw new ProductNotFoundException(id);
                }
                _repositoryManager.ProductRepository.DeleteProduct(product);
                _repositoryManager.Save();
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Something went wrong in the {nameof(EditProduct)} service method {ex}");
                throw;
            }
        }
    }
}
