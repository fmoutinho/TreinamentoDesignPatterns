using TreinamentoDesignPatterns.Domain.Notas.Entidades;
using TreinamentoDesignPatterns.Domain.Notas.Interfaces;

namespace TreinamentoDesignPatterns.Domain.Notas.Services;

public class Multiplicador : IAcaoAposGerarNota
{
    private double fator;

    public Multiplicador(double fator)
    {
        this.fator = fator;
    }

    public void Executa(NotaFiscal notaFiscal)
    {
        Console.WriteLine(notaFiscal.ValorTotal * fator);
    }
}