using OrderStore.Domain.Interfaces;
using OrderStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStore.Repository
{
   public class OrderRepository: GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext context): base(context)
        {

        }
        public IEnumerable<Order> GetOrdersByGenre(string orderName)
        {
            return _context.Orders.Where(x => x.OrderDetails == orderName);
        }
    }
}
