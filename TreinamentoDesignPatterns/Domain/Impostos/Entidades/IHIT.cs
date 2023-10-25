using TreinamentoDesignPatterns.Domain.Comum.Entidades;
using TreinamentoDesignPatterns.Domain.Impostos.Interfaces;

namespace TreinamentoDesignPatterns.Domain.Impostos.Entidades
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public IHIT(Imposto outroImposto) : base(outroImposto)
        {
        }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.itens.GroupBy(item => item.Nome).Where(group => group.Count() >= 2).Any();
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.itens.Count);
        }

        private bool TemItemMaiorqueCemReais(Orcamento orcamento)
        {
            return orcamento.itens.Any(i => i.Valor > 100);
        }
    }
}
