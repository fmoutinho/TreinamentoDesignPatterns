using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDesignPatterns.Domain.Comum.Entidades;
using TreinamentoDesignPatterns.Domain.Descontos.Interfaces;


namespace TreinamentoDesignPatterns.Domain.Compras.Entidades
{
    public class DescontoPorCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public DescontoPorCincoItens(IDesconto proximo)
        {
            Proximo = proximo;
        }

        public DescontoPorCincoItens()
        {
            Proximo = new SemDesconto();
        }
        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }
            return Proximo.Desconta(orcamento);
        }
    }
}
