using OCoast.Data;
using OCost.Data.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.API.Infrastructure.Repositories.ProductRepositories
{
    internal class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IList<Product> GetAllProducts() => FindAll().ToList();
        public Product GetProductById(int id) => FindByCondition(condition => condition.Id == id).SingleOrDefault();        public void AddProduct(Product product) => Create(product);
        public void EditProduct(Product product) => Update(product);
        public void DeleteProduct(Product product) => Delete(product);
     
    }

}
