using MediatR;
using Product_CQRS_SingleFile_MediatR.Models;

namespace Product_CQRS_SingleFile_MediatR.Command
{
        public record UpdateProductCommand(Product product) : IRequest<List<Product>>;
}
