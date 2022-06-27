using Fundamentos.DesignPatterns.Behavioral.Strategy.CrossCutting;
using Fundamentos.DesignPatterns.Behavioral.Strategy.Domain;

namespace Fundamentos.DesignPatterns.Behavioral.Strategy
{
  public class ExecutarStrategy
  {
    public static void Executar()
    {
      Console.WriteLine("Escolha a forma de pagamento:");
      Console.WriteLine("1 - Cartão Crédito");
      Console.WriteLine("2 - Boleto");
      Console.WriteLine("");
      Console.WriteLine("");

      IPagamento pagamento;

      switch (Console.ReadKey().KeyChar)
      {
        case '1':
          CartaoCredito cartao = new CartaoCredito("1111222233334444", "199");
          Pedido pedidoCartao = new Pedido()
          {
            Valor = 300.20M
          };

          pagamento = new PagamentoCartaoCreditoService(new PagamentoCartaoFacade(new PaypalGateway(), new SerasaIntegration()));
          pagamento.AutorizarPagamento(pedidoCartao, cartao);
          break;


        case '2':
          Boleto boleto = new Boleto("111111 2222222 33333333 4 555555555555", DateTime.Now.AddDays(7));
          Pedido pedidoBoleto = new Pedido()
          {
            Valor = 5999.99M
          };

          pagamento = new PagamentoBoletoService(new PagamentoBoletoFacade());
          pagamento.AutorizarPagamento(pedidoBoleto, boleto);
          break;
      }
    }
  }
}