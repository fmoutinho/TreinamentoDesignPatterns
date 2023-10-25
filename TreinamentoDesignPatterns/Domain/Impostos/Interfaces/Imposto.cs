using TreinamentoDesignPatterns.Domain.Comum.Entidades;

namespace TreinamentoDesignPatterns.Domain.Impostos.Interfaces
{
    public abstract class Imposto
    {
        public Imposto? OutroImposto { get; set; }

        public Imposto()
        {
            OutroImposto = null;
        }
        public Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public abstract double CalculaImposto(Orcamento orcamento);

        protected double CalculoOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null)
            {
                return 0;
            }
            return OutroImposto.CalculaImposto(orcamento);
        }
    }
}
