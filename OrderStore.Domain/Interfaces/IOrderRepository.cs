using OrderStore.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderStore.Domain.Interfaces
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
       Task<IEnumerable<Order>> GetOrdersByOrderName(string orderName);
    }
}
