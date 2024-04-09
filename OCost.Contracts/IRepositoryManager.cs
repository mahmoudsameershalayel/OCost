using OCost.API.Infrastructure.Repositories.ProductRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.API.Infrastructure.Repositories
{
    public interface IRepositoryManager
    {
        IProductRepository ProductRepository { get; }
        void Save();
    }
}
