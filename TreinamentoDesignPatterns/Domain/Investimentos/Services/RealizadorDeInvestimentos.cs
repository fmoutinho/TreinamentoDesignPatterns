using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDesignPatterns.Domain.Comum.Entidades;
using TreinamentoDesignPatterns.Domain.Investimentos.Interfaces;

namespace TreinamentoDesignPatterns.Domain.Investimentos.Services
{
    public class RealizadorDeInvestimentos
    {
        public void RealizaInvestimento(ContaBancaria conta, IPerfil perfil)
        {
            double investimento = perfil.Investe(conta);
            Console.WriteLine(investimento);
        }
    }
}
