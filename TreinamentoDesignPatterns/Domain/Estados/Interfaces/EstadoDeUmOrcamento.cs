using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDesignPatterns.Domain.Comum.Entidades;

namespace TreinamentoDesignPatterns.Domain.Estados.Interfaces
{
    public abstract class EstadoDeUmOrcamento
    {
        protected bool descontoAplicado = false;
        public abstract void AplicaDescontoExtra(Orcamento orcamento);
        public abstract void Aprova(Orcamento orcamento);
        public abstract void Reprova(Orcamento orcamento);
        public abstract void Finaliza(Orcamento orcamento);
    }
}
