using OCost.Data.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.API.Infrastructure.Repositories.ProductRepositories
{
    public interface IProductRepository
    {
        public IList<Product> GetAllProducts();
        public void AddProduct(Product product);
    }
}
