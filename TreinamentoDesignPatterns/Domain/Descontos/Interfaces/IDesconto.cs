using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDesignPatterns.Domain.Comum.Entidades;

namespace TreinamentoDesignPatterns.Domain.Descontos.Interfaces
{
    public interface IDesconto
    {
        public double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}
