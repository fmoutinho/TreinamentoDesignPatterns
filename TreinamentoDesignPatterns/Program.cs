using TreinamentoDesignPatterns.Domain.Comum.Entidades;
using TreinamentoDesignPatterns.Domain.Investimentos.Entidades;
using TreinamentoDesignPatterns.Domain.Investimentos.Interfaces;
using TreinamentoDesignPatterns.Domain.Investimentos.Services;

static class Program
{
    public static void Main(string[] args)
    {
        //IImposto icms = new ICMS();
        //IImposto iss = new ISS();
        //IImposto iccc = new ICCC();
        //Orcamento orcamento = new Orcamento(500);
        //CalculadorDeImposto calculador = new CalculadorDeImposto();

        ////calculador.RealizaCalculo(orcamento, icms);
        ////calculador.RealizaCalculo(orcamento, iss);
        //calculador.RealizaCalculo(orcamento, iccc);

        IPerfil arrojado = new Arrojado();
        IPerfil moderado = new Moderado();
        IPerfil conservador = new Conservador();

        ContaBancaria conta = new ContaBancaria("XPTO", 1000);
        Console.WriteLine(conta.Saldo);
        conta.Deposita(500);
        Console.WriteLine(conta.Saldo);
        conta.Saca(1000);
        Console.WriteLine(conta.Saldo);
        conta.Saca(3000);
        Console.WriteLine(conta.Saldo);
        conta.Saca(1);
        //RealizadorDeInvestimentos realizadorDeInvestimentos = new RealizadorDeInvestimentos();
        //realizadorDeInvestimentos.RealizaInvestimento(conta, arrojado);
        Console.ReadKey();
    }
}