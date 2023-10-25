using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDesignPatterns.Domain.Comum.Entidades;
using TreinamentoDesignPatterns.Domain.Estados.Interfaces;

namespace TreinamentoDesignPatterns.Domain.Estados.Entidades
{
    public class Aprovado : EstadoDeUmOrcamento
    {
        public override void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor -= (orcamento.Valor * 0.02);
                descontoAplicado = true;
            }
        }

        public override void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está aprovado");
        }

        public override void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public override void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está aprovado");
        }
    }
}
