using Poc.Mediator.Domain.Models;

namespace Poc.Mediator.Domain.Interfaces
{
    public interface IClienteRepository
    {
        Task Inserir(Cliente cliente);
        Task<Cliente> ObterPorId(Guid id);
    }
}
