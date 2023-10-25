using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDesignPatterns.Domain.Comum.Entidades;
using TreinamentoDesignPatterns.Domain.Filtros.Entidades;

namespace TreinamentoDesignPatterns.Domain.Filtros.Interfaces
{
    public abstract class Filtro
    {
        protected Filtro OutroFiltro { get; private set; }

        protected Filtro(Filtro outroFiltro)
        {
            OutroFiltro = outroFiltro;
        }
        protected Filtro()
        {
            OutroFiltro = new SemFiltro();
        }
        public abstract IList<ContaBancaria> Filtra(IList<ContaBancaria> contas);
    }
}
