using TreinamentoDesignPatterns.Domain.Notas.Entidades;
using TreinamentoDesignPatterns.Domain.Notas.Interfaces;

namespace TreinamentoDesignPatterns.Domain.Notas.Services;

public class EnviadorDeSms : IAcaoAposGerarNota
{
    public void Executa(NotaFiscal notaFiscal)
    {
        Console.WriteLine("Enviado por Sms");
    }
}
