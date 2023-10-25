using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDesignPatterns.Domain.Comum.Entidades;
using TreinamentoDesignPatterns.Domain.Investimentos.Interfaces;

namespace TreinamentoDesignPatterns.Domain.Investimentos.Entidades
{
    public class Conservador : IPerfil
    {
        public double Investe(ContaBancaria conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
