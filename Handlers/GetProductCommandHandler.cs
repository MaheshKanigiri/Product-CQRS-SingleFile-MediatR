using MediatR;
using Product_CQRS_SingleFile_MediatR.Interface;
using Product_CQRS_SingleFile_MediatR.Models;
using Product_CQRS_SingleFile_MediatR.Query;

namespace Product_CQRS_SingleFile_MediatR.Handlers
{
    public class GetProductCommandHandler : IRequestHandler<GetProductQuery, List<Product>>
    {
        private readonly IProduct _repo;

        public GetProductCommandHandler(IProduct repo)
        {
            _repo = repo;
        }

        public async Task<List<Product>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult( _repo.GetProducts());
        }
    }
}
