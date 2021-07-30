using OrderStore.Domain.Interfaces;
using System;

namespace OrderStore.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IOrderRepository Orders { get; }
        public IProductRepository Products { get; }

        public UnitOfWork(ApplicationDbContext bookStoreDbContext,
            IOrderRepository booksRepository,
            IProductRepository catalogueRepository)
        {
            this._context = bookStoreDbContext;

            this.Orders = booksRepository;
            this.Products = catalogueRepository;
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
