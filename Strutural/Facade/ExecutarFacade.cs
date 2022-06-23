using Fundamentos.DesignPatterns.Strutural.Facade.CrossCutting;
using Fundamentos.DesignPatterns.Strutural.Facade.Domain;

namespace Fundamentos.DesignPatterns.Strutural.Facade
{
  public class ExecutarFacade
  {
    public static void Executar()
    {
      CartaoCredito cartao = new CartaoCredito("1111222233334444", "199");
      Pedido pedido = new Pedido()
      {
        Valor = 300.20M
      };

      PagamentoFacade facade = new PagamentoFacade(new PaypalGateway(), new SerasaIntegration());

      PagamentoService service = new PagamentoService(facade);

      service.AutorizarPagamento(pedido, cartao);
      Console.WriteLine($"O pedido '{pedido.Id}' foi {pedido.StatusAutorizacao}.");
    }
  }
}