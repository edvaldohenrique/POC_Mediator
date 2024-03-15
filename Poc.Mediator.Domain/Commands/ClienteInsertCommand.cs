using MediatR;

namespace Poc.Mediator.Domain.Commands
{
    public class ClienteInsertCommand : IRequest<string>
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public float Saldo { get; set; }
    }
}
