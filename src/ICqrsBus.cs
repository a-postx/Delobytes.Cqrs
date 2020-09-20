using System.Threading.Tasks;

namespace Delobytes.Cqrs
{
    public interface ICqrsBus
    {
        Task<T> Execute<T>(ICommand<T> command);
        Task<T> Execute<T>(IQuery<T> query);
    }
}
