using TreinamentoDesignPatterns.Domain.Comum.Entidades;
using TreinamentoDesignPatterns.Domain.Impostos.Interfaces;

namespace TreinamentoDesignPatterns.Domain.Impostos.Entidades
{
    public class ICMS : Imposto
    {
        public ICMS(Imposto outroImposto) : base(outroImposto)
        {
        }

        public override double CalculaImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculoOutroImposto(orcamento);
        }
    }
}







