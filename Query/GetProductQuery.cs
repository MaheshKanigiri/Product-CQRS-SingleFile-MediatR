using MediatR;
using Product_CQRS_SingleFile_MediatR.Models;

namespace Product_CQRS_SingleFile_MediatR.Query
{
    public class GetProductQuery : IRequest<List<Product>>
    {
    }
}
