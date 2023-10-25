using TreinamentoDesignPatterns.Domain.Comum.Entidades;

namespace TreinamentoDesignPatterns.Domain.Investimentos.Interfaces
{
    public interface IPerfil
    {
        double Investe(ContaBancaria saldo);
    }
}