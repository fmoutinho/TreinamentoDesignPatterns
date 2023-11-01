using TreinamentoDesignPatterns.Domain.Notas.Entidades;
using TreinamentoDesignPatterns.Domain.Notas.Interfaces;

namespace TreinamentoDesignPatterns.Domain.Notas.Builders
{
    public class NotaFiscalBuilder
    {
        private string Cnpj { get;  set; }
        private string RazaoSocial { get;  set; }
        private string Observacoes { get;  set; }
        private DateTime Data { get;  set; }
        private double ValorTotal;
        private double Impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();
        private IList<IAcaoAposGerarNota> acoesAposGerarNota;

        public NotaFiscalBuilder()
        {
            Data = DateTime.Now;
            acoesAposGerarNota = new List<IAcaoAposGerarNota>();
        }
        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string obs)
        {
            Observacoes = obs;
            return this;
        }

        public NotaFiscalBuilder NaData(DateTime data)
        {
            Data = data;
            return this;
        }

        public NotaFiscal Build()
        {
            NotaFiscal notaFiscal = new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Impostos, todosItens, Observacoes);

            foreach (IAcaoAposGerarNota acao in acoesAposGerarNota)
            {
                acao.Executa(notaFiscal);
            }

            return notaFiscal;
        }

        public NotaFiscalBuilder Com(ItemDaNota itemNovo)
        {
            todosItens.Add(itemNovo);
            ValorTotal += itemNovo.Valor;
            Impostos += itemNovo.Valor * 0.05;

            return this;
        }

        public NotaFiscalBuilder AdicionaAcao(IAcaoAposGerarNota novaAcao)
        {
            acoesAposGerarNota.Add(novaAcao);
            return this;
        }
    }
}
