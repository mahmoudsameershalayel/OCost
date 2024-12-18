﻿using OCost.Core.APIDtos;
using OCost.Data.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Service.Contracts
{
    public interface IProductService
    {
        public IList<ProductDto> GetAllProducts();
        public ProductDto GetProductById(int id);
        public void AddProduct(CreateUpdateProductDto dto);
        public void EditProduct(int id ,CreateUpdateProductDto dto);
        public void DeleteProduct(int id);
    }
}
