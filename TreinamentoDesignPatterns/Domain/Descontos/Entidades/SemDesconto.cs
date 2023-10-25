using TreinamentoDesignPatterns.Domain.Descontos.Interfaces;
using TreinamentoDesignPatterns.Domain.Comum.Entidades;

namespace TreinamentoDesignPatterns.Domain.Compras.Entidades
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public SemDesconto()
        {
            Proximo = new SemDesconto();
        }

        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}
