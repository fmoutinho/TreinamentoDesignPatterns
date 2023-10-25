using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDesignPatterns.Domain.Comum.Entidades;
using TreinamentoDesignPatterns.Domain.Relatorios.Interfaces;

namespace TreinamentoDesignPatterns.Domain.Relatorios.Entidades
{
    internal class RelatorioSimples : Relatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco XPTO");
        }

        protected override void Corpo(IList<ContaBancaria> contas)
        {
            foreach (ContaBancaria contaBancaria in contas)
            {
                Console.WriteLine($"Nome: {contaBancaria.Nome} , saldo: {contaBancaria.Saldo}");
            }
        }

        protected override void Rodape()
        {
            Console.WriteLine("Rio de Janeiro");
        }
    }
}
