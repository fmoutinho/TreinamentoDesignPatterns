using TreinamentoDesignPatterns.Domain.Notas.Entidades;

namespace TreinamentoDesignPatterns.Domain.Notas.Interfaces;

public interface IAcaoAposGerarNota
{
    void Executa(NotaFiscal notaFiscal);

}