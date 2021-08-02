using Microsoft.AspNetCore.Mvc;
using OrderStore.Domain.Interfaces;
using OrderStore.Domain.Models;

namespace OrderStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost(nameof(CreateProduct))]
        public IActionResult CreateProduct(Product product)
        {
            var result = _unitOfWork.Products.Add(product);
            _unitOfWork.Complete();
            if (result is not null) return Ok("Product Created");
            else return BadRequest("Error in Creating the Product");
        }

        [HttpPut(nameof(UpdateProduct))]
        public IActionResult UpdateProduct(Product product)
        {
            _unitOfWork.Products.Update(product);
            _unitOfWork.Complete();
            return Ok("Product Updated");
        }
    }
}
