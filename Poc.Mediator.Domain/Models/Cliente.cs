namespace Poc.Mediator.Domain.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public float Saldo { get; set; }
    }
}
