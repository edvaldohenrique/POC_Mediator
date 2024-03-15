using Poc.Mediator.Infra;

namespace Poc.Mediator.Api.Config
{
    public static class DependencyInjectionConfig
    {
        public static void AddInfraestrutura(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            Setup.AddInfraestrutura(services);
        }
    }
}
