using OrderStore.Domain.Models;
using System.Collections.Generic;

namespace OrderStore.Domain.Interfaces
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        IEnumerable<Order> GetOrdersByGenre(string orderName);
    }
}
