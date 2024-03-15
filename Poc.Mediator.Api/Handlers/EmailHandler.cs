using MediatR;
using Poc.Mediator.Domain.Models;

namespace Poc.Mediator.Api.Handlers
{
    public class EmailHandler : INotificationHandler<ClienteActionNotification>
    {
        public Task Handle(ClienteActionNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine("O cliente {0} foi {1} com sucesso", notification.Nome, notification.Acao.ToString().ToLower());
            });
        }
    }
}
