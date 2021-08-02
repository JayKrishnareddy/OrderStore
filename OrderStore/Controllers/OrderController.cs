using Microsoft.AspNetCore.Mvc;
using OrderStore.Domain.Interfaces;
using OrderStore.Domain.Models;
using System.Threading.Tasks;

namespace OrderStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/<Books>
        [HttpGet(nameof(GetOrders))]
        public async Task<IActionResult> GetOrders() => Ok(await _unitOfWork.Orders.GetAll());

        [HttpGet(nameof(GetOrderByName))]
        public async Task<IActionResult> GetOrderByName([FromQuery] string Genre) => Ok(await _unitOfWork.Orders.GetOrdersByOrderName(Genre));
       
    }
}
