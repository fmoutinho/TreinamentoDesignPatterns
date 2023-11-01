using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDesignPatterns.Domain.Notas.Entidades;
using TreinamentoDesignPatterns.Domain.Notas.Interfaces;

namespace TreinamentoDesignPatterns.Domain.Notas.Services
{
    public class EnviadorDeEmail :IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Enviado por Email");
        }
    }
}
