using MediatR;
using Poc.Mediator.Domain.Commands;
using Poc.Mediator.Domain.Enums;
using Poc.Mediator.Domain.Interfaces;
using Poc.Mediator.Domain.Models;

namespace Poc.Mediator.Api.Handlers
{
    public class ClienteHandler :
        IRequestHandler<ClienteInsertCommand, string>
    
    {
        private readonly IMediator _mediator;
        private readonly IClienteRepository _clienteRepository;

        public ClienteHandler(IMediator mediator, IClienteRepository clienteRepository)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _clienteRepository = clienteRepository ?? throw new ArgumentNullException(nameof(clienteRepository));
        }

        public async Task<string> Handle(ClienteInsertCommand request, CancellationToken cancellationToken)
        {
            var cliente = new Cliente() { Id = request.Id, Cpf = request.Cpf, Nome = request.Nome, Saldo = request.Saldo};
            await _clienteRepository.Inserir(cliente);

            await _mediator.Publish(new ClienteActionNotification
            {
                Nome = request.Nome,
                Id = request.Id,
                Cpf = request.Cpf,
                Saldo = request.Saldo,
                Acao = AcaoNotificacao.Criado
            }, cancellationToken);

            return await Task.FromResult("Cliente registrado com sucesso");
        }

        public async Task<Cliente> Handle(Guid clienteId, CancellationToken cancellationToken)
        {
            var cliente = await _clienteRepository.ObterPorId(clienteId);
            return cliente;
        }

    }
}
