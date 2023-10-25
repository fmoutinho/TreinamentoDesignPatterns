using TreinamentoDesignPatterns.Domain.Comum.Entidades;
using TreinamentoDesignPatterns.Domain.Impostos.Interfaces;

namespace TreinamentoDesignPatterns.Domain.Impostos.Entidades
{
    public class ISS : Imposto
    {
        public ISS(Imposto outroImposto) : base(outroImposto)
        {
        }

        public override double CalculaImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoOutroImposto(orcamento);
        }
    }
}
