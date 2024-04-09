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
        public void AddProduct(Product product) => Create(product);
     
    }

}
