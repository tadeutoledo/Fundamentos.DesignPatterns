using Fundamentos.DesignPatterns.Behavioral.Strategy.Domain;

namespace Fundamentos.DesignPatterns.Behavioral.Strategy.Interfaces
{
  public interface IPagamentoFacade
  {
    public bool AutorizarPagamento(Pedido pedido, InstrumentoPagamento instrumentoPagamento);
  }
}