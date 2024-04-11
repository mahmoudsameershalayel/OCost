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
        public Product GetProductById(int id);
        public void AddProduct(Product product);
        public void EditProduct(Product product);
        public void DeleteProduct(Product product);
    }
}
