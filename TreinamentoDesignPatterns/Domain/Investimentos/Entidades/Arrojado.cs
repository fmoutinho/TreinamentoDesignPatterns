using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDesignPatterns.Domain.Comum.Entidades;
using TreinamentoDesignPatterns.Domain.Investimentos.Interfaces;

namespace TreinamentoDesignPatterns.Domain.Investimentos.Entidades
{
    public class Arrojado : IPerfil
    {
        public double Investe(ContaBancaria conta)
        {
            int probabilidade = new Random().Next(0, 100);
            if (probabilidade <= 20)
            {
                return conta.Saldo * 0.05;

            }
            else if (probabilidade > 21 && probabilidade < 50)
            {
                return conta.Saldo * 0.03;

            }
            else
            {
                return conta.Saldo * 0.006;
            }
        }
    }
}
