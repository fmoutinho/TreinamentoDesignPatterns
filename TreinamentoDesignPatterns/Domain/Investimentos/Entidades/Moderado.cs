using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDesignPatterns.Domain.Comum.Entidades;
using TreinamentoDesignPatterns.Domain.Investimentos.Interfaces;

namespace TreinamentoDesignPatterns.Domain.Investimentos.Entidades
{
    public class Moderado : IPerfil
    {
        public double Investe(ContaBancaria conta)
        {
            int probabilidade = new Random().Next(0, 1);

            return probabilidade == 0 ? conta.Saldo * 0.025 : conta.Saldo * 0.007;
        }
    }
}

