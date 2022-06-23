using Fundamentos.DesignPatterns.Strutural.Facade.Domain;

namespace Fundamentos.DesignPatterns.Strutural.Facade
{
  public interface IPagamentoFacade
  {
    public bool AutorizarPagamento(Pedido pedido, CartaoCredito cartao);
  }
}