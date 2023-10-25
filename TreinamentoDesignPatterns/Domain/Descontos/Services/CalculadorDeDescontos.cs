using TreinamentoDesignPatterns.Domain.Compras.Entidades;
using TreinamentoDesignPatterns.Domain.Descontos.Interfaces;
using TreinamentoDesignPatterns.Domain.Comum.Entidades;

namespace TreinamentoDesignPatterns.Domain.Descontos.Services
{
    internal class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto d3 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;

            return d1.Desconta(orcamento);
        }
    }
}
