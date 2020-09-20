using MediatR;

namespace Delobytes.Cqrs
{
    public interface IQuery<TResponse> : IRequest<TResponse>
    {

    }
}
