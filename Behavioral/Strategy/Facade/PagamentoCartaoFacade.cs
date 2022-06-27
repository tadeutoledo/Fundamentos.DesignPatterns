using Fundamentos.DesignPatterns.Behavioral.Strategy.CrossCutting;
using Fundamentos.DesignPatterns.Behavioral.Strategy.Domain;
using Fundamentos.DesignPatterns.Behavioral.Strategy.Interfaces;

namespace Fundamentos.DesignPatterns.Behavioral.Strategy
{
  public class PagamentoCartaoFacade : IPagamentoFacade
  {
    private readonly IPayPalGateway _payPalGateway;
    private readonly ISerasaIntegration _serasaIntegration;

    public PagamentoCartaoFacade(
      IPayPalGateway payPalGateway,
      ISerasaIntegration serasaIntegration)
    {
      _payPalGateway = payPalGateway;
      _serasaIntegration = serasaIntegration;
    }

    public bool AutorizarPagamento(Pedido pedido, InstrumentoPagamento instrumentoPagamento)
    {
      var cartao = (CartaoCredito)instrumentoPagamento;

      var score = _serasaIntegration.ConsultarScore(cartao);

      switch (score)
      {
        case NivelScore.Pessimo:
        case NivelScore.Ruim:
          Console.WriteLine("Score no Serasa abaixo do permitido.");
          return false;
        default:
          Console.WriteLine("Score no Serasa regular ou superior.");
          break;
      }

      if (!_payPalGateway.CommitTransaction(cartao.NumeroCartao, pedido.Valor))
      {
        Console.WriteLine($"O pedido não foi aprovado.");
        return false;
      }

      Console.WriteLine($"O pedido foi aprovado.");
      return true;
    }
  }
}