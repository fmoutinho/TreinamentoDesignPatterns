using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDesignPatterns.Domain.Estados.Entidades;
using TreinamentoDesignPatterns.Domain.Estados.Interfaces;

namespace TreinamentoDesignPatterns.Domain.Comum.Entidades
{
    public class ContaBancaria
    {
        public double Saldo { get; private set; }
        public string Nome { get; internal set; }

        public DateTime DataAbertura { get; private set; }

        private IEstadoDaConta Estado { get; set; }

        public ContaBancaria(string nome, double valor)
        {
            Saldo = valor;
            Nome = nome;
            DataAbertura = DateTime.Now;
            Estado = new Positiva();
        }
        interface IEstadoDaConta
        {
            void Saca(ContaBancaria c, double valor);
            void Deposita(ContaBancaria c, double valor);
        }

        public void Saca(double valor)
        {
            Estado.Saca(this, valor);
        }

        public void Deposita(double valor)
        {
            Estado.Deposita(this, valor);
        }

        class Positiva : IEstadoDaConta
        {
            public void Saca(ContaBancaria c, double valor)
            {
                c.Saldo -= valor;
                if (c.Saldo < 0)
                {
                    c.Estado = new Negativa();
                }
            }
            public void Deposita(ContaBancaria c, double valor)
            {
                c.Saldo += valor * 0.98;
            }
        }

        class Negativa : IEstadoDaConta
        {
            public void Saca(ContaBancaria c, double valor)
            {
                throw new Exception("Não é possível realizar saques com a conta negativa");
            }
            public void Deposita(ContaBancaria c, double valor)
            {
                c.Saldo += valor * 0.95;
                if (c.Saldo >= 0)
                {
                    c.Estado = new Positiva();
                }
            }
        }
    }
}