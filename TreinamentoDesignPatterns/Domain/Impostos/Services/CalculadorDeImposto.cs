using TreinamentoDesignPatterns.Domain.Comum.Entidades;
using TreinamentoDesignPatterns.Domain.Impostos.Interfaces;

namespace TreinamentoDesignPatterns.Domain.Impostos.Services
{
    public class CalculadorDeImposto
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double calculo = imposto.CalculaImposto(orcamento);
            Console.WriteLine(calculo);
        }
    }
}
