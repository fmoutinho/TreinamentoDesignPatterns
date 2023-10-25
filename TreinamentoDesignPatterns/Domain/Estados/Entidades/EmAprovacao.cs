using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDesignPatterns.Domain.Comum.Entidades;
using TreinamentoDesignPatterns.Domain.Estados.Interfaces;

namespace TreinamentoDesignPatterns.Domain.Estados.Entidades
{
    public  class EmAprovacao : EstadoDeUmOrcamento
    {
        public override void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor -= (orcamento.Valor * 0.05);
                descontoAplicado = true;
            }
        }

        public override void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public override void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento em aprovação não pode ser diretamente finalizado");
        }

        public override void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }
    }
}
