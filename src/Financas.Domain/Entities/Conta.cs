using Financas.Domain.Enums;

namespace Financas.Domain.Entities;

public class Conta
{
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public TipoConta Tipo { get; private set; }
    public decimal SaldoInicial { get; private set; }
    public bool Ativa { get; private set; }

    public Conta(string nome, TipoConta tipo, decimal saldoInicial)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException(
                    "O nome da conta não pode ser vazio.",
                    nameof(nome)
            );
        }

        if (!Enum.IsDefined(tipo))
        {
            throw new ArgumentOutOfRangeException(
                    nameof(tipo),
                    "O tipo da conta informado é inválido."
            );
        }

        Id = Guid.NewGuid();
        Nome = nome.Trim();
        Tipo = tipo;
        SaldoInicial = saldoInicial;
        Ativa = true;
    }
}