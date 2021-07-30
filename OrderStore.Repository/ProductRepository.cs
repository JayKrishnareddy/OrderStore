using OrderStore.Domain.Interfaces;
using OrderStore.Domain.Models;

namespace OrderStore.Repository
{
    class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
