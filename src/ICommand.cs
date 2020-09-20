using MediatR;

namespace Delobytes.Cqrs
{
    public interface ICommand<TResponse> : IRequest<TResponse>
    {

    }
}
