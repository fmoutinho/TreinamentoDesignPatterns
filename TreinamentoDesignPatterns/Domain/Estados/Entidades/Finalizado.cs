using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDesignPatterns.Domain.Comum.Entidades;
using TreinamentoDesignPatterns.Domain.Estados.Interfaces;

namespace TreinamentoDesignPatterns.Domain.Estados.Entidades
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        public override void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto extra");
        }

        public override void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado");
        }

        public override void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado");
        }

        public override void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado");
        }
    }
}
