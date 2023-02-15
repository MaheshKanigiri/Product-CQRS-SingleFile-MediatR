
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Product_CQRS_SingleFile_MediatR.Command;
using Product_CQRS_SingleFile_MediatR.Models;
using Product_CQRS_SingleFile_MediatR.Query;

namespace Product_CQRS_SingleFile_MediatR.Controllers
{
        
        [Route("api/[controller]")]
        [ApiController]
        public class ProductController : Controller
        {
            private readonly IMediator _mediator;

            public ProductController(IMediator mediator)
            {
                _mediator = mediator;
            }
        [HttpGet]
        public async Task<IActionResult> getAllProducts()
        {
            var products = await _mediator.Send(new GetProductQuery());
            return Ok(products);
        }

        [HttpPost]

        public async Task<IActionResult> addNewProduct([FromBody] Product product)
        {
            await _mediator.Send(new CreateProductCommand(product));
            return StatusCode(201);
        }

        [HttpDelete]
        public async Task<IActionResult> deleteProduct(int id)
        {
            await _mediator.Send(new DeleteProductCommand(id));
            return StatusCode(200);
        }

        [HttpPut]
        public async Task<IActionResult> updateProduct([FromBody] Product product)
        {
            await _mediator.Send(new UpdateProductCommand(product));
            return StatusCode(200);
        }
    }
    
}
