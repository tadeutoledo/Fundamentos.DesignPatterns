using Fundamentos.DesignPatterns.Behavioral.Strategy.Domain;
using Fundamentos.DesignPatterns.Behavioral.Strategy.Interfaces;

namespace Fundamentos.DesignPatterns.Behavioral.Strategy
{
  public class PagamentoCartaoCreditoService : IPagamento
  {
    private readonly IPagamentoFacade _pagamentoFacade;

    public PagamentoCartaoCreditoService(
      IPagamentoFacade pagamentoFacade)
    {
      _pagamentoFacade = pagamentoFacade;
    }

    public Pedido AutorizarPagamento(Pedido pedido, InstrumentoPagamento instrumentoPagamento)
    {
      var cartao = (CartaoCredito)instrumentoPagamento;

      Console.WriteLine("Iniciando Autorização de Pagamento por Cartão de Crédito - Valor " + pedido.Valor.ToString("c2"));

      if (_pagamentoFacade.AutorizarPagamento(pedido, cartao))
        pedido.StatusAutorizacao = StatusAutorizacao.Aprovado;
      else
        pedido.StatusAutorizacao = StatusAutorizacao.Rejeitado;

      return pedido;
    }
  }
}