using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDesignPatterns.Domain.Comum.Entidades;
using TreinamentoDesignPatterns.Domain.Filtros.Interfaces;

namespace TreinamentoDesignPatterns.Domain.Filtros.Entidades
{
    internal class FiltraContasComDataAberturaNoMesCorrente : Filtro
    {
        public override IList<ContaBancaria> Filtra(IList<ContaBancaria> contas)
        {
            return OutroFiltro.Filtra(contas.Where(c => c.DataAbertura.Month == DateTime.Now.Month).ToList());
        }
    }
}
