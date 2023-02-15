using MediatR;
using Product_CQRS_SingleFile_MediatR.Command;
using Product_CQRS_SingleFile_MediatR.Interface;
using Product_CQRS_SingleFile_MediatR.Models;

namespace Product_CQRS_SingleFile_MediatR.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, List<Product>>

    {
        private readonly IProduct _repo;

        public CreateProductCommandHandler(IProduct repo)
        {
            _repo = repo;
        }

        public async Task<List<Product>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            return   await Task.FromResult( _repo.CreateProducts(request.product));
        }
    }

}
