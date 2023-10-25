using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDesignPatterns.Domain.Comum.Entidades;

namespace TreinamentoDesignPatterns.Domain.Relatorios.Interfaces
{
    abstract class Relatorio
    {
        protected abstract void Cabecalho();
        protected abstract void Corpo(IList<ContaBancaria> contas);
        protected abstract void Rodape();

        public void Imprime(IList<ContaBancaria> contas)
        {
            Cabecalho();
            Corpo(contas);
            Rodape();
        }
    }
}
