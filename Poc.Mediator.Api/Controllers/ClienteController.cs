using MediatR;
using Microsoft.AspNetCore.Mvc;
using Poc.Mediator.Domain.Commands;
using Poc.Mediator.Domain.Interfaces;

namespace Poc.Mediator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IClienteRepository _clienteRepository;

        public ClienteController(IMediator mediator, IClienteRepository clienteRepository)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _clienteRepository = clienteRepository ?? throw new ArgumentNullException(nameof(clienteRepository));
        }

        [HttpPost]
        public async Task<IActionResult> Post(ClienteInsertCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

    }
}
