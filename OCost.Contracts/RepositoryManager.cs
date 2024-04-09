using OCoast.Data;
using OCost.API.Infrastructure.Repositories.ProductRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.API.Infrastructure.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly ApplicationDbContext _context;
        private readonly Lazy<IProductRepository> _productRepository;
        public RepositoryManager(ApplicationDbContext context)
        {
            _context = context;
            _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(_context));
        }
        public IProductRepository ProductRepository => _productRepository.Value;

        public void Save() => _context.SaveChanges();
    }
}
