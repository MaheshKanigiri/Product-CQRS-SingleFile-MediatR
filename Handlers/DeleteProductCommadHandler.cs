using MediatR;
using Product_CQRS_SingleFile_MediatR.Command;
using Product_CQRS_SingleFile_MediatR.Interface;

namespace Product_CQRS_SingleFile_MediatR.Handlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, string>
    {
        private readonly IProduct _repo;

        public DeleteProductCommandHandler(IProduct repo)
        {
            _repo = repo;
        }

        public async Task<string> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_repo.DeleteProduct(request.id));
        }
    }
}
