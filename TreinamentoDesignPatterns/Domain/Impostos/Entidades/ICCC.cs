using TreinamentoDesignPatterns.Domain.Impostos.Interfaces;
using TreinamentoDesignPatterns.Domain.Comum.Entidades;

namespace TreinamentoDesignPatterns.Domain.Impostos.Entidades
{
    internal class ICCC : Imposto
    {
        public override double CalculaImposto(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000)
            {
                return orcamento.Valor * 0.05;
            }
            else if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
            {
                return orcamento.Valor * 0.07;
            }
            else
            {
                return orcamento.Valor * 0.08 + 30;
            }
        }
    }
}
