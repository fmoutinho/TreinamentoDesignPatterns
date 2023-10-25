using TreinamentoDesignPatterns.Domain.Comum.Entidades;
using TreinamentoDesignPatterns.Domain.Filtros.Interfaces;

namespace TreinamentoDesignPatterns.Domain.Filtros.Entidades
{
    public class FiltraSaldoMenorQueCemReais : Filtro
    {
        public override IList<ContaBancaria> Filtra(IList<ContaBancaria> contas)
        {
            return OutroFiltro.Filtra(contas.Where(c => c.Saldo< 100).ToList());
        }
    }
}
