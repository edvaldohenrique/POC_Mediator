using Microsoft.Extensions.DependencyInjection;
using Poc.Mediator.Domain.Interfaces;
using Poc.Mediator.Infra.Repositories;

namespace Poc.Mediator.Infra
{
    public static class Setup
    {
        public static IServiceCollection AddInfraestrutura(this IServiceCollection services)
        {

            services.AddScoped<IClienteRepository, ClienteRepository>();

            return services;
        }
    }
}
