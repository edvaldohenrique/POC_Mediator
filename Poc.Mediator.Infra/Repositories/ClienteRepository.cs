using Dapper;
using Poc.Mediator.Domain.Interfaces;
using Poc.Mediator.Domain.Models;

namespace Poc.Mediator.Infra.Repositories
{
    public class ClienteRepository : IClienteRepository
    {

        private DbSession _connection { get; set; }

        public ClienteRepository()
        {
            _connection = new DbSession();
        }

        public async Task Inserir(Cliente cliente)
        {
            var sql = "INSERT INTO clientes (id, nome, cpf, saldo) VALUES (@id, @nome, @cpf, @saldo)";

            using (var conexao = _connection.Connection())
            {
                conexao.Open();

                conexao.ExecuteScalarAsync(sql, new
                {
                    id = cliente.Id,
                    nome = cliente.Nome,
                    cpf = cliente.Cpf,
                    saldo = cliente.Saldo
                });
            }
        }

        public async Task<Cliente> ObterPorId(Guid id)
        {
            var sql = "SELECT id, nome, cpf, saldo FROM clientes WHERE id=@id";

            using (var conexao = _connection.Connection())
            {
                conexao.Open();

                return conexao.QueryFirstOrDefault<Cliente>(sql, new { id });
            }
        }
    }
}
