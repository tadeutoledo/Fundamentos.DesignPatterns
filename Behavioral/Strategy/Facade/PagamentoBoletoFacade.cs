using Fundamentos.DesignPatterns.Behavioral.Strategy.CrossCutting;
using Fundamentos.DesignPatterns.Behavioral.Strategy.Domain;
using Fundamentos.DesignPatterns.Behavioral.Strategy.Interfaces;

namespace Fundamentos.DesignPatterns.Behavioral.Strategy
{
  public class PagamentoBoletoFacade : IPagamentoFacade
  {
    public PagamentoBoletoFacade()
    {
    }

    public bool AutorizarPagamento(Pedido pedido, InstrumentoPagamento instrumentoPagamento)
    {
      var cartao = (Boleto)instrumentoPagamento;

      // Consultar febraban
      // Registrar Boleto WS
      // Verificar Nosso Número

      return true;
    }
  }
}