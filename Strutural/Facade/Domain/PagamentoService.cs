using Fundamentos.DesignPatterns.Strutural.Facade.Domain;

namespace Fundamentos.DesignPatterns.Strutural.Facade.CrossCutting
{
  public class PagamentoService
  {
    private readonly IPagamentoFacade _pagamentoFacade;

    public PagamentoService(
      IPagamentoFacade pagamentoFacade)
    {
      _pagamentoFacade = pagamentoFacade;
    }

    public Pedido AutorizarPagamento(Pedido pedido, CartaoCredito cartao)
    {
      // Consultar Saldo Serasa
      // Autorizar Banco
      // Demais requisições a serviços externos

      Console.WriteLine("Iniciando Autorização de Pagamento - Valor " + pedido.Valor.ToString("c2"));

      if (_pagamentoFacade.AutorizarPagamento(pedido, cartao))
        pedido.StatusAutorizacao = StatusAutorizacao.Aprovado;
      else
        pedido.StatusAutorizacao = StatusAutorizacao.Rejeitado;

      return pedido;
    }
  }
}