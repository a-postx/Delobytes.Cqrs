using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Delobytes.Cqrs
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Добавляет внетрипроцессную шину данных.
        /// </summary>
        public static IServiceCollection AddCommandAndQueryBus(this IServiceCollection services, params Assembly[] assemblies)
        {
            services.AddMediatR(assemblies);
            services.AddScoped<IBus, InMemoryBus>();

            return services;
        }
    }
}
