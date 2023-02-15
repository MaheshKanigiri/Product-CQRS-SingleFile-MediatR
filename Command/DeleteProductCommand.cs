using MediatR;

namespace Product_CQRS_SingleFile_MediatR.Command
{
    public record DeleteProductCommand(int id) : IRequest<string>;
}
