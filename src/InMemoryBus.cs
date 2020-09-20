using MediatR;
using System.Threading.Tasks;

namespace Delobytes.Cqrs
{
    public sealed class InMemoryBus : ICqrsBus
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task<T> Execute<T>(ICommand<T> command)
        {
            return _mediator.Send(command);
        }

        public Task<T> Execute<T>(IQuery<T> query)
        {
            return _mediator.Send(query);
        }
    }
}
