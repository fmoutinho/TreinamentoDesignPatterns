using TreinamentoDesignPatterns.Domain.Notas.Entidades;

namespace TreinamentoDesignPatterns.Domain.Notas.Builders;

public class ItemDaNotaBuilder
{
    private string Nome;
    private double Valor;

    public ItemDaNotaBuilder ComNome(string nome)
    {
        Nome = nome;
        return this;
    }

    public ItemDaNotaBuilder ComValor(double valor)
    {
        Valor = valor;
        return this;
    }

    public ItemDaNota Build()
    {
        return new ItemDaNota(Nome, Valor);
    }
}