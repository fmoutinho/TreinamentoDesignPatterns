using TreinamentoDesignPatterns.Domain.Comum.Entidades;
using TreinamentoDesignPatterns.Domain.Impostos.Interfaces;
using TreinamentoDesignPatterns.Domain.Investimentos.Entidades;
using TreinamentoDesignPatterns.Domain.Investimentos.Interfaces;
using TreinamentoDesignPatterns.Domain.Investimentos.Services;
using TreinamentoDesignPatterns.Domain.Notas.Builders;
using TreinamentoDesignPatterns.Domain.Notas.Daos;
using TreinamentoDesignPatterns.Domain.Notas.Entidades;
using TreinamentoDesignPatterns.Domain.Notas.Services;

static class Program
{
    public static void Main(string[] args)
    {
        #region TestesAnteriores

        //IImposto icms = new ICMS();
        //IImposto iss = new ISS();
        //IImposto iccc = new ICCC();
        //Orcamento orcamento = new Orcamento(500);
        //CalculadorDeImposto calculador = new CalculadorDeImposto();

        //calculador.RealizaCalculo(orcamento, icms);
        //calculador.RealizaCalculo(orcamento, iss);
        //calculador.RealizaCalculo(orcamento, iccc);

        //IPerfil arrojado = new Arrojado();
        //IPerfil moderado = new Moderado();
        //IPerfil conservador = new Conservador();

        //ContaBancaria conta = new ContaBancaria("XPTO", 1000);
        //Console.WriteLine(conta.Saldo);
        //conta.Deposita(500);
        //Console.WriteLine(conta.Saldo);
        //conta.Saca(1000);
        //Console.WriteLine(conta.Saldo);
        //conta.Saca(3000);
        //Console.WriteLine(conta.Saldo);
        //conta.Saca(1);
        //RealizadorDeInvestimentos realizadorDeInvestimentos = new RealizadorDeInvestimentos();
        //realizadorDeInvestimentos.RealizaInvestimento(conta, arrojado);
        //Console.ReadKey();

        #endregion


        #region TesteBuilder

        NotaFiscalBuilder criador = new NotaFiscalBuilder();

        criador.ParaEmpresa("XPTO")
            .ComCnpj("123456787")
            .ComObservacoes("obs qualquer")
            .Com(new ItemDaNota("item 1", 100))
            .Com(new ItemDaNota("item 2", 500))
            .AdicionaAcao(new EnviadorDeEmail())
            .AdicionaAcao(new EnviadorDeSms())
            .AdicionaAcao(new NotaFiscalDao())
            .AdicionaAcao(new Multiplicador(50));

        NotaFiscal notaFiscal = criador.Build();

        Console.WriteLine(notaFiscal.DataDeEmissao);

        Console.ReadKey();

        #endregion
    }
}