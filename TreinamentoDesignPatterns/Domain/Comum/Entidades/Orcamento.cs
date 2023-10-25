using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDesignPatterns.Domain.Compras.Entidades;
using TreinamentoDesignPatterns.Domain.Estados.Entidades;
using TreinamentoDesignPatterns.Domain.Estados.Interfaces;

namespace TreinamentoDesignPatterns.Domain.Comum.Entidades

{
    public class Orcamento
    {
        public double Valor { get; set; }
        public IList<Item> itens { get; private set; }
        public EstadoDeUmOrcamento EstadoAtual { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            itens = new List<Item>();
            EstadoAtual = new EmAprovacao();
        }
        public void AdicionaItem(Item item)
        {
            itens.Add(item);
        }
        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }
        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }
        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }
        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}
