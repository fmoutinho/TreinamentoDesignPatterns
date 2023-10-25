using TreinamentoDesignPatterns.Domain.Comum.Entidades;
using TreinamentoDesignPatterns.Domain.Filtros.Interfaces;

namespace TreinamentoDesignPatterns.Domain.Filtros.Entidades
{
    public class SemFiltro : Filtro
    {
        public override IList<ContaBancaria> Filtra(IList<ContaBancaria> contas)
        {
            return contas;
        }
    }
}