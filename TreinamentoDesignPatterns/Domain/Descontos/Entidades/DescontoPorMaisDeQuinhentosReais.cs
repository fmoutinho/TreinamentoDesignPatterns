using TreinamentoDesignPatterns.Domain.Descontos.Interfaces;
using TreinamentoDesignPatterns.Domain.Comum.Entidades;

namespace TreinamentoDesignPatterns.Domain.Compras.Entidades
{
    public class DescontoPorMaisDeQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public DescontoPorMaisDeQuinhentosReais(IDesconto proximo)
        {
            Proximo = proximo;
        }

        public DescontoPorMaisDeQuinhentosReais()
        {
            Proximo = new SemDesconto();
        }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }

            return Proximo.Desconta(orcamento);
        }
    }
}
