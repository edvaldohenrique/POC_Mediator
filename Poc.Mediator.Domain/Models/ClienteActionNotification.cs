using MediatR;
using Poc.Mediator.Domain.Enums;

namespace Poc.Mediator.Domain.Models
{
    public class ClienteActionNotification : INotification
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public float Saldo { get; set; }
        public AcaoNotificacao Acao { get; set; }
    }
}
