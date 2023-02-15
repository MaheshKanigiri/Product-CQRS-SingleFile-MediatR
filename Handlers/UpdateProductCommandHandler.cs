using MediatR;
using Product_CQRS_SingleFile_MediatR.Command;
using Product_CQRS_SingleFile_MediatR.Interface;
using Product_CQRS_SingleFile_MediatR.Models;

namespace Product_CQRS_SingleFile_MediatR.Handlers
{
    internal class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, List<Product>>

    {
        private readonly IProduct _product;

        public UpdateProductCommandHandler(IProduct product)
        {
            _product = product;
        }

        public async Task<List<Product>> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            return  await Task.FromResult( _product.updateProduct(request.product));
        }
    }
}
