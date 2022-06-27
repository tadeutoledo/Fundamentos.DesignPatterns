using Fundamentos.DesignPatterns.Behavioral.Strategy.Domain;
using Fundamentos.DesignPatterns.Behavioral.Strategy.Interfaces;

namespace Fundamentos.DesignPatterns.Behavioral.Strategy
{
  public class PagamentoBoletoService : IPagamento
  {
    private readonly IPagamentoFacade _pagamentoFacade;

    public PagamentoBoletoService(
      IPagamentoFacade pagamentoFacade)
    {
      _pagamentoFacade = pagamentoFacade;
    }

    public Pedido AutorizarPagamento(Pedido pedido, InstrumentoPagamento instrumentoPagamento)
    {
      var cartao = (Boleto)instrumentoPagamento;

      Console.WriteLine("Iniciando Autorização de Pagamento por Boleto - Valor " + pedido.Valor.ToString("c2"));

      if (_pagamentoFacade.AutorizarPagamento(pedido, cartao))
        pedido.StatusAutorizacao = StatusAutorizacao.Aprovado;
      else
        pedido.StatusAutorizacao = StatusAutorizacao.Rejeitado;

      return pedido;
    }
  }
}